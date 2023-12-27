using NAudio.CoreAudioApi;

namespace RecordSystemAudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDevices();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

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
