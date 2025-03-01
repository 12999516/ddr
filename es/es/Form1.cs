using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace es
{
    public partial class Form1 : Form
    {
       

        int conteggio = 0;
        int quale;
        Random random = new Random(Environment.TickCount);
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;


        public Form1()
        {
            InitializeComponent();
            updateUI();
            string filePath = @"C:\percorso\al\tuo\file\musica.mp3"; // Modifica con il percorso del tuo file
            PlayMusicInLoop(filePath);

        }

        private void PlayMusicInLoop(string filePath)
        {
            waveOutDevice = new WaveOutEvent(); // Crea il dispositivo di output audio
            audioFileReader = new AudioFileReader(filePath); // Crea il lettore audio per il file MP3

            waveOutDevice.Init(audioFileReader); // Inizializza il dispositivo di output con il lettore audio
            waveOutDevice.Play(); // Avvia la riproduzione

            // Imposta il loop
            audioFileReader.Volume = 1.0f; // Imposta il volume (opzionale)
            audioFileReader.EndOfStream += (sender, e) =>
            {
                audioFileReader.Position = 0; // Torna all'inizio del file per il loop
                waveOutDevice.Play(); // Riprende la riproduzione
            };
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            waveOutDevice.Dispose();
            audioFileReader.Dispose();
            base.OnFormClosed(e);
        }
        private void Error()
        {
            btn_center.Text = "error";
            btn_down.Text = "error";
            btn_up.Text = "error";
            btn_right.Text = "error";
            btn_center.Text = "error";
        }
        private void btn_upp()
        {
            btn_center.BackColor = Color.White;
            btn_right.BackColor = Color.White;
            btn_left.BackColor = Color.White;
            btn_down.BackColor = Color.White;
            btn_up.BackColor = Color.Aquamarine;
        }

        private void btn_downn()
        {
            btn_center.BackColor = Color.White;
            btn_right.BackColor = Color.White;
            btn_left.BackColor = Color.White;
            btn_up.BackColor = Color.White;
            btn_down.BackColor = Color.Yellow;
        }

        private void btn_rightt()
        {
            btn_center.BackColor = Color.White;
            btn_down.BackColor = Color.White;
            btn_up.BackColor = Color.White;
            btn_left.BackColor = Color.White;
            btn_right.BackColor = Color.Violet;
        }

        private void btn_leftt()
        {
            btn_center.BackColor = Color.White;
            btn_down.BackColor = Color.White;
            btn_up.BackColor = Color.White;
            btn_right.BackColor = Color.White;
            btn_left.BackColor = Color.Blue;
        }

        private void btn_centerr()
        {
            btn_right.BackColor = Color.White;
            btn_left.BackColor = Color.White;
            btn_down.BackColor = Color.White;
            btn_up.BackColor = Color.White;
            btn_center.BackColor = Color.Gold;
        }
        private void btn_up_Click(object sender, EventArgs e)
        {
            if(btn_up.BackColor != Color.White)
            {
                conteggio += 1;
                lbl_point.Text = $"i tui punti: \n {conteggio}";
            }
            else
            {
                conteggio -= 1;
                lbl_point.Text = $"i tui punti: \n {conteggio}";
            }
            updateUI();
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            if (btn_left.BackColor != Color.White)
            {
                conteggio += 1;
                lbl_point.Text = $"i tui punti: \n {conteggio}";
            }
            else
            {
                conteggio -= 1;
                lbl_point.Text = $"i tui punti: \n {conteggio}";
            }
            
            updateUI();
        }

        private void btn_center_Click(object sender, EventArgs e)
        {
            if (btn_center.BackColor != Color.White)
            {
                conteggio += 1;
                lbl_point.Text = $"i tui punti: \n {conteggio}";
            }
            else
            {
                conteggio -= 1;
                lbl_point.Text = $"i tui punti: \n {conteggio}";
            }
            
            updateUI();
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            if (btn_right.BackColor != Color.White)
            {
                conteggio += 1;
                lbl_point.Text = $"i tui punti: \n {conteggio}";
            }
            else
            {
                conteggio -= 1;
                lbl_point.Text = $"i tui punti: \n {conteggio}";
            }
            
            updateUI();
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (btn_down.BackColor != Color.White)
            {
                conteggio += 1;
                lbl_point.Text = $"i tui punti: \n {conteggio}";
            }
            else
            {
                conteggio -= 1;
                lbl_point.Text = $"i tui punti: \n {conteggio}";
            }
            updateUI();
        }

        private void updateUI()
        {
            quale = random.Next(1, 6);

            switch (quale)
            {
                case 1:
                    btn_upp();
                    break;

                case 2:
                    btn_downn();
                    break;

                case 3:
                    btn_rightt();
                    break;

                case 4:
                    btn_leftt();
                    break;
                case 5:
                    btn_centerr();
                    break;
                default:
                    Error();
                    break;

            }
        }
        private void lbl_point_Click(object sender, EventArgs e)
        {

        }

        /* int quale;
            Random random = new Random(Environment.TickCount);
            quale = random.Next(1, 6);

            switch (quale)
            {
                case 1:
                    btn_upp();
                    break;

                case 2:
                    btn_downn();
                    break;

                case 3:
                    btn_rightt();
                    break;

                case 4:
                    btn_leftt();
                    break;
                case 5:
                    btn_centerr();
                    break;
                default:
                    Error();
                    break;

            }*/
    }
}
