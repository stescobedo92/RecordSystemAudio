namespace RecordSystemAudio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cbOutputDevice = new ComboBox();
            btnStart = new Button();
            btnStop = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Select Output Device:";
            // 
            // cbOutputDevice
            // 
            cbOutputDevice.FormattingEnabled = true;
            cbOutputDevice.Location = new Point(135, 16);
            cbOutputDevice.Name = "cbOutputDevice";
            cbOutputDevice.Size = new Size(290, 23);
            cbOutputDevice.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(315, 57);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(52, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(373, 57);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(52, 23);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 93);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(cbOutputDevice);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Record System Audio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbOutputDevice;
        private Button btnStart;
        private Button btnStop;
    }
}
