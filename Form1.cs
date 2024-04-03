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



namespace ytdlp_gui_mp3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            // The grabbing of URL text
            var urlString = textBoxURL.Text;

            // Some URL checking probably

            // The Download
            Process process = new Process();
            process.StartInfo.FileName = "./yt-dlp.exe";
            process.StartInfo.Arguments = $"-x --audio-format mp3 {urlString}";
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
            Debug.WriteLine(standardOutputText);
            Debug.WriteLine(standardErrorText);

        }
    }
}
