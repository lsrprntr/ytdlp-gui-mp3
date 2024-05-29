using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ytdlp_gui_mp3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string root = Application.StartupPath;
            labelFolderPath.Text = root;
        }

        private async void buttonDownload_Click(object sender, EventArgs e)
        {
            var urlString = textBoxURL.Text;
            var pathString = labelFolderPath.Text;

            if (urlString == null || urlString == "")
            {
                // Add some URL checking probably
                return;
            }

            // The Download
            await RunQuery(pathString, urlString);

        }

        private async Task RunQuery(string pathString, string urlString)
        {
            await Task.Run(() =>
                {
                    Process process = new Process();
                    process.StartInfo.FileName = "./yt-dlp.exe";
                    process.StartInfo.Arguments = $"-P {pathString}";
                    process.StartInfo.Arguments += $" -x --audio-format mp3 {urlString}";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.OutputDataReceived += process_DataReceived;
                    process.ErrorDataReceived += process_DataReceived;
                    process.Start();
                    process.BeginOutputReadLine(); //Asynchronous
                    process.BeginErrorReadLine(); //Asynchronous
                    process.WaitForExit();
                }
            );
        }

        private void process_DataReceived(object sender, DataReceivedEventArgs e)
        {
            BeginInvoke(
                new Action(
                    () =>
                    {
                        textBoxConsoleOutput.Text += e.Data + Environment.NewLine;
                        textBoxConsoleOutput.AppendText("> ");
                    }
                )
            );
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            SelectDownloadFolderLocation();
        }
        private void SelectDownloadFolderLocationEvent(object sender, MouseEventArgs e)
        {
            SelectDownloadFolderLocation();
        }

        private void SelectDownloadFolderLocation()
        {
            var previousDirectory = labelFolderPath.Text;
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = previousDirectory;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var directory = dialog.SelectedPath;
                labelFolderPath.Text = directory;
                if (!CheckDirectoryExists(directory))
                {
                    labelFolderPath.Text = previousDirectory;
                }
            }
        }

        private bool CheckDirectoryExists(string directory)
        {
            DirectoryInfo di = new DirectoryInfo(directory);
            if (di.Exists)
            {
                Debug.WriteLine("Valid Directory");
                return true;
            }
            else
            {
                Debug.WriteLine("Invalid Directory");
                return false;
            }
        }

    }
}
