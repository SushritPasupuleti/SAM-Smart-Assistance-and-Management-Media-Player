using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.IO;

namespace SAM_Media_Player
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine _RecEng = new SpeechRecognitionEngine();
        string Username = Environment.UserName;
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Pink;
            TransparencyKey = Color.Pink;
            ply.settings.volume = 100;
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Openfile_Click(object sender, EventArgs e)
        {
            Open.ShowDialog();
            ply.URL = Open.FileName;

        }

        private void SP_Click(object sender, EventArgs e)
        {
            if (bdumbchk.Checked == true)
            {
                bdumbchk.Checked = false;

            }

            else
            {
                bdumbchk.Checked = true;

            }
        }

        private void bdumbchk_CheckedChanged(object sender, EventArgs e)
        {
            if (bdumbchk.Checked == true)
            {
                _RecEng.RecognizeAsyncCancel();

                SP.BackgroundImage = global::SAM_Media_Player.Properties.Resources.Microphone_iconC;
            }

            else
            {
                _RecEng.RecognizeAsync(RecognizeMode.Multiple);

                SP.BackgroundImage = global::SAM_Media_Player.Properties.Resources.Microphone_iconActC;
            }
        }

        private void Player_Load(object sender, EventArgs e)
        {   ///Initialize Grammar File 1st
            _RecEng.SetInputToDefaultAudioDevice();
            _RecEng.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"C:\Users\" + Username + "\\AppData\\Roaming\\Sushrit Teknologies\\CommandsP.txt")))));
            _RecEng.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(_recognizer_SpeechRecognizedG);
            _RecEng.RecognizeAsyncCancel();
        }
        void _recognizer_SpeechRecognizedG(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;
            switch (speech)
            {
                case "Play":
                    ply.Ctlcontrols.play();
                    break;

                case "Pause":
                    ply.Ctlcontrols.pause();
                    break;

                case "Stop":
                    ply.Ctlcontrols.stop();
                    break;

                case "Open file":
                    Open.ShowDialog();
                    ply.URL = Open.FileName;
                    break;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void ply_Enter(object sender, EventArgs e)
        {

        }

        private void Tpmst_CheckedChanged(object sender, EventArgs e)
        {
            if (Tpmst.Checked == true)
            {
                this.TopMost = true;
            }

            else if (Tpmst.Checked == false)
            {
                this.TopMost = false;
            }
        }

        private void Closethis_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void ffwd_Click(object sender, EventArgs e)
        {
            ply.Ctlcontrols.fastForward();
        }

        private void ffb_Click(object sender, EventArgs e)
        {
            ply.Ctlcontrols.fastReverse();
        }

        private void Open_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void VolumeAdj_Scroll(object sender, EventArgs e)
        {
            if (VolumeAdj.Value == 0)
            {
                ply.settings.volume = 0;
            }
            if (VolumeAdj.Value == 1)
            {
                ply.settings.volume = 10;
            }
            if (VolumeAdj.Value == 2)
            {
                ply.settings.volume = 20;
            }
            if (VolumeAdj.Value == 3)
            {
                ply.settings.volume = 30;
            }
            if (VolumeAdj.Value == 4)
            {
                ply.settings.volume = 40;
            }
            if (VolumeAdj.Value == 5)
            {
                ply.settings.volume = 50;
            }
            if (VolumeAdj.Value == 6)
            {
                ply.settings.volume = 60;
            }
            if (VolumeAdj.Value == 7)
            {
                ply.settings.volume = 70;
            }
            if (VolumeAdj.Value == 8)
            {
                ply.settings.volume = 80;
            }
            if (VolumeAdj.Value == 9)
            {
                ply.settings.volume = 90;
            }
            if (VolumeAdj.Value == 10)
            {
                ply.settings.volume = 100;
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            ply.Ctlcontrols.play();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            ply.Ctlcontrols.pause();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            ply.Ctlcontrols.stop();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            ply.Ctlcontrols.previous();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            ply.Ctlcontrols.next();
        }

        private void Play_MouseEnter(object sender, EventArgs e)
        {
            Play.BackgroundImage = global::SAM_Media_Player.Properties.Resources.PlayN;
        }

        private void Play_MouseLeave(object sender, EventArgs e)
        {
            Play.BackgroundImage = global::SAM_Media_Player.Properties.Resources.PlayC;
        }

        private void Pause_MouseEnter(object sender, EventArgs e)
        {
            Pause.BackgroundImage = global::SAM_Media_Player.Properties.Resources.PauseN;
        }

        private void Pause_MouseLeave(object sender, EventArgs e)
        {
            Pause.BackgroundImage = global::SAM_Media_Player.Properties.Resources.PauseC;
        }

        private void Stop_MouseEnter(object sender, EventArgs e)
        {
            Stop.BackgroundImage = global::SAM_Media_Player.Properties.Resources.StopN;
        }

        private void Stop_MouseLeave(object sender, EventArgs e)
        {
            Stop.BackgroundImage = global::SAM_Media_Player.Properties.Resources.StopC;
        }

        private void Previous_MouseEnter(object sender, EventArgs e)
        {
            Previous.BackgroundImage = global::SAM_Media_Player.Properties.Resources.SLN;
        }

        private void Previous_MouseLeave(object sender, EventArgs e)
        {
            Previous.BackgroundImage = global::SAM_Media_Player.Properties.Resources.SLC;
        }

        private void Next_MouseEnter(object sender, EventArgs e)
        {
            Next.BackgroundImage = global::SAM_Media_Player.Properties.Resources.SRN;
        }

        private void Next_MouseLeave(object sender, EventArgs e)
        {
            Next.BackgroundImage = global::SAM_Media_Player.Properties.Resources.SRC;
        }

        private void Openfile_MouseEnter(object sender, EventArgs e)
        {
            Openfile.BackgroundImage = global::SAM_Media_Player.Properties.Resources.folderN;
        }

        private void Openfile_MouseLeave(object sender, EventArgs e)
        {
            Openfile.BackgroundImage = global::SAM_Media_Player.Properties.Resources.folderC;
        }

        private void SP_MouseEnter(object sender, EventArgs e)
        {
            if (bdumbchk.Checked == true)
            {
                SP.BackgroundImage = global::SAM_Media_Player.Properties.Resources.Microphone_iconN;
            }
            else
            {
                SP.BackgroundImage = global::SAM_Media_Player.Properties.Resources.Microphone_iconActN;
            }
        }

        private void SP_MouseLeave(object sender, EventArgs e)
        {
            if (bdumbchk.Checked == true)
            {
                SP.BackgroundImage = global::SAM_Media_Player.Properties.Resources.Microphone_iconC;
            }
            else
            {
                SP.BackgroundImage = global::SAM_Media_Player.Properties.Resources.Microphone_iconActC;
            }
        }
    }
}
