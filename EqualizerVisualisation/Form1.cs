using System;
using System.Threading;
using System.Windows.Forms;
using Un4seen.Bass;

namespace EqualizerVisualisation
{
    public partial class Form1 : Form 
    {
        public static bool isThreadRunning = false; 
        Thread playingThread;
        string filename = @"D:\bbb.mp3";

        int handle;
        int timeCounter = 0;

        public Form1()
        {
            InitializeComponent();
            ModifyProgressBarColor.SetState(verticalProgressBar1, 2);
            ModifyProgressBarColor.SetState(verticalProgressBar2, 2);
            ModifyProgressBarColor.SetState(verticalProgressBar3, 2);
            ModifyProgressBarColor.SetState(verticalProgressBar4, 2);
            ModifyProgressBarColor.SetState(verticalProgressBar5, 3);
            ModifyProgressBarColor.SetState(verticalProgressBar6, 3);
            ModifyProgressBarColor.SetState(verticalProgressBar7, 3);
            ModifyProgressBarColor.SetState(verticalProgressBar8, 3);
            ModifyProgressBarColor.SetState(verticalProgressBar9, 4);
            ModifyProgressBarColor.SetState(verticalProgressBar10, 4);
            ModifyProgressBarColor.SetState(progressBarTime, 4);
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

            // Music length
            Bass.BASS_ChannelGetLength(handle);
            long len = Bass.BASS_ChannelGetLength(handle, BASSMode.BASS_POS_BYTE);
            musicTime.Maximum = (int)Bass.BASS_ChannelBytes2Seconds(handle, len);

            timeCounter++;
            textBox1.Text = timeCounter.ToString() + "s";

            musicTime.Value = timeCounter;
        }

        private void TimerVisualization_Tick(object sender, EventArgs e)
        {
            ProgressBar progress1 = verticalProgressBar1;
            ProgressBar progress2 = verticalProgressBar2;
            ProgressBar progress3 = verticalProgressBar3;
            ProgressBar progress4 = verticalProgressBar4;
            ProgressBar progress5 = verticalProgressBar5;
            ProgressBar progress6 = verticalProgressBar6;
            ProgressBar progress7 = verticalProgressBar7;
            ProgressBar progress8 = verticalProgressBar8;
            ProgressBar progress9 = verticalProgressBar9;
            ProgressBar progress10 = verticalProgressBar10;
            ProgressBar progress11 = verticalProgressBar11;
            ProgressBar progress12 = verticalProgressBar12;

            float[] buffer = new float[256];
            Bass.BASS_ChannelGetData(handle, buffer, (int)BASSData.BASS_DATA_FFT256);

            printOneValueInProgressBar(verticalProgressBar1, buffer[22]);
            printOneValueInProgressBar(verticalProgressBar2, buffer[28]);
            printOneValueInProgressBar(verticalProgressBar3, buffer[36]);
            printOneValueInProgressBar(verticalProgressBar4, buffer[44]);
            printOneValueInProgressBar(verticalProgressBar5, buffer[52]);
            printOneValueInProgressBar(verticalProgressBar6, buffer[60]);
            printOneValueInProgressBar(verticalProgressBar7, buffer[68]);
            printOneValueInProgressBar(verticalProgressBar8, buffer[72]);
            printOneValueInProgressBar(verticalProgressBar9, buffer[76]);
            printOneValueInProgressBar(verticalProgressBar10, buffer[80]);
            printOneValueInProgressBar(verticalProgressBar11, buffer[85]);
            printOneValueInProgressBar(verticalProgressBar12, buffer[90]);

            // Do ogarniecia jak to pustawiac zeby dobrze wygladalo i na jakich wartosciach w bufferze

            printBuffer(buffer);
        }

        public void printOneValueInProgressBar(ProgressBar progressBar, float value)
        {
            if ((int)Math.Round(value * 150000) < progressBar.Maximum)
            {
                progressBar.Value = (int)Math.Round(value * 150000);
            }
            else
            {
                progressBar.Value = progressBar.Maximum;
            }
        }
        public void printBuffer(float[] buffer)
        {
            if (isThreadRunning)
            {
                Console.WriteLine(buffer[10] * 150000);
                Console.WriteLine(buffer[20] * 150000);
                Console.WriteLine(buffer[30] * 150000);
                Console.WriteLine(buffer[40] * 150000);
                Console.WriteLine(buffer[50] * 150000);
                Console.WriteLine(buffer[60] * 150000);
                Console.WriteLine(buffer[70] * 150000);
                Console.WriteLine(buffer[80] * 150000);
                Console.WriteLine(buffer[90] * 150000);
                Console.WriteLine(" ");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = openFileDialog1;
            open.Filter = "MP3 files (.mp3)|*.mp3";
            open.Title = "Wybierz plik do otworzenia";
            open.ShowDialog();

            if (open.FileName.ToString().EndsWith(".mp3"))
            {
                filename = open.FileName.ToString();
            }
        }
    }
}
