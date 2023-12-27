using NAudio.CoreAudioApi;
using NAudio.Wave;
using System.Diagnostics;

namespace RecordSystemAudio
{
    public partial class Form1 : Form
    {
        private string? _outputFilename;
        private WasapiLoopbackCapture _wasapiLoopbackCapture;
        private WaveFileWriter _waveFileWriter;

        public Form1()
        {
            InitializeComponent();
            LoadDevices();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Wave files | *.wav";

            if (saveDialog.ShowDialog() is not DialogResult.OK)
                return;

            _outputFilename = saveDialog.FileName;
            var selectedDevice = cbOutputDevice.SelectedItem as MMDevice;
            _wasapiLoopbackCapture = new WasapiLoopbackCapture(selectedDevice);
            _waveFileWriter = new WaveFileWriter(_outputFilename, _wasapiLoopbackCapture.WaveFormat);

            _wasapiLoopbackCapture.DataAvailable += (s, e) =>
            {
                _waveFileWriter.Write(e.Buffer, 0, e.BytesRecorded);
            };
            _wasapiLoopbackCapture.RecordingStopped += (s, e) =>
            {
                _waveFileWriter.Dispose();
                _wasapiLoopbackCapture.Dispose();
                btnStart.Enabled = true;
                btnStop.Enabled = false;

                var startInfo = new ProcessStartInfo
                {
                    FileName = Path.GetDirectoryName(_outputFilename),
                    UseShellExecute = true
                };

                Process.Start(startInfo);
            };

            _wasapiLoopbackCapture.StartRecording();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_wasapiLoopbackCapture != null)
                _wasapiLoopbackCapture.StopRecording();
        }

        private void LoadDevices()
        {
            var enumeratorDevices = new MMDeviceEnumerator();
            var devices = enumeratorDevices.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
            cbOutputDevice.Items.AddRange(devices.ToArray());
            cbOutputDevice.SelectedIndex = 0;
        }
    }
}
