using System;
using System.Windows.Forms;

namespace JpegRecompressor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkChangeResolution_CheckedChanged(object sender, EventArgs e)
        {
            gbChangeResolution.Enabled = chkChangeResolution.Checked;
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog { Description = "Select Source folder", ShowNewFolderButton = false };
            dialog.ShowDialog();
            txbSource.Text = dialog.SelectedPath;
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog { Description = "Select Destination folder", ShowNewFolderButton = true };
            dialog.ShowDialog();
            txbDestination.Text = dialog.SelectedPath;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(txbSource.Text) || string.IsNullOrEmpty(txbDestination.Text))
            {
                MessageBox.Show("You should select source and destination folder for start");
                return;
            }

            var parameter = new RecompressorParameter
            {
                Source = txbSource.Text,
                Destination = txbDestination.Text,
                Quality = tbQuality.Value * 10,
                ThreadCount = tbThread.Value
            };

            if (chkChangeResolution.Checked)
            {
                parameter.Width = float.Parse(txbWidth.Text);
                parameter.Height = float.Parse(txbHeight.Text);
            }


            Recompressor recompressor = new Recompressor();

            recompressor.progressEvent += (info, progress) =>
            {
                if (info == "Finish")
                {
                    MessageBox.Show("Finish");
                }

                BeginInvoke((Action) (() => { progressBar1.Value = progress; }), null);
            };

            recompressor.Start(parameter);
        }
    }
}
