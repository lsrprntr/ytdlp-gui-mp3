using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using static System.Net.WebRequestMethods;
using System.Security.Policy;
using System.IO;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;



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

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            // URL
            var urlString = textBoxURL.Text;
            var pathString = labelFolderPath.Text;

            // Some URL checking probably
            if (urlString == null && pathString == null)
            {
                return;
            }

            // The Download
            Process process = new Process();
            process.StartInfo.FileName = "./yt-dlp.exe";
            process.StartInfo.Arguments = $"-P {pathString}";
            process.StartInfo.Arguments += $" -x --audio-format mp3 {urlString}";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();

            var standardOutputText = process.StandardOutput.ReadToEnd();
            var standardErrorText = process.StandardError.ReadToEnd();
            OutputToTextBoxConsole(standardOutputText, standardErrorText);

            process.WaitForExit();
        }

        private void OutputToTextBoxConsole(string standardOutputText, string standardErrorText)
        {
            textBoxConsoleOutput.AppendText(standardOutputText + Environment.NewLine);
            textBoxConsoleOutput.AppendText(standardErrorText + Environment.NewLine);
            Debug.WriteLine(standardOutputText);
            Debug.WriteLine(standardErrorText);
            

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
                else
                {
                    Debug.WriteLine("Valid Directory");
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
