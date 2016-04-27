using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Shortcuts";
        }

        private void spotifyButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\sli0504\AppData\Roaming\Spotify\Spotify.exe");
        }

        private void steamButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Steam\Steam.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe");
        }

        private void calculatorButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\calc.exe");
            
        }

        private void wordButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Office 2010\Word.lnk");
        }

        private void mozillaButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe");
        }

        private void originButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Origin\Origin.exe");
        }

        private void visualStudioButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Visual Studio 14.0\Common7\IDE\devenv.exe");
        }

        private void battleNetButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Battle.net\Battle.net Launcher.exe");
        }

        private void githubButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\sli0504\AppData\Local\Apps\2.0\O0NN8J1M.PHQ\6L99T7E8.ER5\gith..tion_317444273a93ac29_0003.0000_c74cce3a838f9354\GitHub.exe");
        }

        private void photoshopButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Adobe\Adobe Photoshop CC 2015 (32 Bit)\Photoshop.exe");
        }

        private void skypeButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Skype\Phone\Skype.exe");
        }
    }
}
