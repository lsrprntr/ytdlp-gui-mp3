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
        // Movable None Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void button1_Click(object sender, EventArgs e)
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
            Debug.WriteLine(process.StandardOutput.ReadToEnd());
            Debug.WriteLine(process.StandardError.ReadToEnd());
            process.WaitForExit();

        }
    }
}
