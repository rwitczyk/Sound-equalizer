using System;
using System.Threading;
using System.Windows.Forms;
using Un4seen.Bass;

namespace EqualizerVisualisation
{
    public partial class Form1 : Form // DO OGARNIECIA CZY DA SIE OBROCIC TE PROGRESSBARY, ABY TO SIE Z DOLU DO GORY WYSWIETLALO
    {
        public static bool isThreadRunning = false; 
        Thread playingThread;
        const string filename = @"D:\bbb.mp3";

        int handle;
        int timeCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void Button1_Click(object sender, EventArgs e) // START 
        {
            if (isThreadRunning == false)
            {
                timer1.Start();
                timerVisualization.Start();
                playingThread = new Thread(Play);
                playingThread.Start();

                isThreadRunning = true;
            }
            else {
                timer1.Start();
                timerVisualization.Start();
                Bass.BASS_Start();
            }
        }

        private void Play()
        {
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
            handle = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_SAMPLE_FLOAT);
            Bass.BASS_ChannelPlay(handle, false);
        }
        
        private void Button2_Click(object sender, EventArgs e) // PAUSE
        {
            if (isThreadRunning)
            {
                timer1.Stop();
                timerVisualization.Stop();
                Bass.BASS_Pause();
            }
        }
        // PO ZATRZYMANIU I URUCHOMIENIU OD NOWA NIE DZIALA
        private void Button3_Click(object sender, EventArgs e) // STOP
        { 
            if (isThreadRunning)
            {
                timer1.Stop();
                timerVisualization.Stop();
                timeCounter = 0;
                Bass.BASS_Stop();
                playingThread.Abort();
                isThreadRunning = false;
            }
        }
        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar musicTime = progressBarTime;
            musicTime.Maximum = 300; // Tu trzeba ustawic dlugosc piosenki

            timeCounter++;
            textBox1.Text = timeCounter.ToString() + "s";

            musicTime.Value = timeCounter;
        }

        private void TimerVisualization_Tick(object sender, EventArgs e)
        {
            ProgressBar progress1 = progressBar1;
            ProgressBar progress2 = progressBar2;
            ProgressBar progress3 = progressBar3;
            ProgressBar progress4 = progressBar4;
            ProgressBar progress5 = progressBar5;
            ProgressBar progress6 = progressBar6;
            ProgressBar progress7 = progressBar7;
            ProgressBar progress8 = progressBar8;
            ProgressBar progress9 = progressBar9;
            ProgressBar progress10 = progressBar10;

            float[] buffer = new float[256];
            Bass.BASS_ChannelGetData(handle, buffer, (int)BASSData.BASS_DATA_FFT256);
            
            progress1.Value = (int)Math.Round(buffer[10] * 800);
            progress2.Value = (int)Math.Round(buffer[20] * 2000);
            progress3.Value = (int)Math.Round(buffer[30] * 2000);
            progress4.Value = (int)Math.Round(buffer[40] * 2000);
            progress5.Value = (int)Math.Round(buffer[50] * 2000);
            progress6.Value = (int)Math.Round(buffer[55] * 2000);
            progress7.Value = (int)Math.Round(buffer[60] * 2000);
            progress8.Value = (int)Math.Round(buffer[70] * 2000);
            progress9.Value = (int)Math.Round(buffer[80] * 2000);
            progress10.Value = (int)Math.Round(buffer[90] * 2000); 

            // Do ogarniecia jak to pustawiac zeby dobrze wygladalo i na jakich wartosciach w bufferze
            // to ja popatrze moze
            
            printBuffer(buffer);
        }

        public void printBuffer(float[] buffer)
        {
            if (isThreadRunning)
            {
                Console.WriteLine(buffer[10] * 1000);
                Console.WriteLine(buffer[20] * 1000);
                Console.WriteLine(buffer[30] * 1000);
                Console.WriteLine(buffer[40] * 1000);
                Console.WriteLine(buffer[50] * 1000);
                Console.WriteLine(buffer[60] * 1000);
                Console.WriteLine(buffer[70] * 1000);
                Console.WriteLine(buffer[80] * 1000);
                Console.WriteLine(buffer[90] * 1000);
                Console.WriteLine(" ");
            }
        }
    }
}
