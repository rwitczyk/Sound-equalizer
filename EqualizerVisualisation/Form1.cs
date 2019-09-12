using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;
using CSCore.Streams.Effects;

namespace EqualizerVisualisation
{
    public partial class Form1 : Form
    {
        public static bool isThreadRunning = false;
        ISoundOut soundOut;
        Equalizer equalizer;
        Thread playingThread;

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
                button1.Enabled = false;
                button2.Enabled = false;
                timer1.Start();
                playingThread = new Thread(Play);
                playingThread.Start();
                button1.Enabled = true; 
                button2.Enabled = true;
                isThreadRunning = true;
            }
            else {
                timer1.Start();
                soundOut.Play();
            }
        }

        private void Play()
        {
            const string filename = @"D:\bbb.mp3";
            EventWaitHandle waitHandle = new AutoResetEvent(false);

            try
            {
                //create a source which provides audio data
                using (ISampleSource source = CodecFactory.Instance.GetCodec(filename).ToSampleSource())
                {
                    //create the equalizer.
                    //You can create a custom eq with any bands you want, or you can just use the default 10 band eq.
                    equalizer = Equalizer.Create10BandEqualizer(source);

                    //create a soundout to play the source
                    if (WasapiOut.IsSupportedOnCurrentPlatform) {
                        soundOut = new WasapiOut();
                    }
                    else {
                        soundOut = new DirectSoundOut();
                    }

                    soundOut.Stopped += (s, x) => waitHandle.Set();

                    IWaveSource finalSource = equalizer.ToWaveSource(16); //since the equalizer is a samplesource, you have to convert it to a raw wavesource
                    soundOut.Initialize(finalSource); //initialize the soundOut with the previously created finalSource
                    soundOut.Play();

                    //(int)equalizer.SampleFilters[0].AverageGainDB; //eq set the gain of the first filter to 20dB (if needed, you can set the gain value for each channel of the source individually)
                    
                    waitHandle.WaitOne(); // wait until the playback finished

                    //remember to dispose and the soundout and the source
                    soundOut.Dispose();
                }
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine("Fileformat not supported: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected exception: " + ex.Message);
            }
        }
        
        private void Button2_Click(object sender, EventArgs e) // PAUSE
        {
            if (isThreadRunning == true)
            {
                timer1.Stop();
                soundOut.Pause();
            }
        }

        private void Button3_Click(object sender, EventArgs e) // STOP
        {
            timer1.Stop();
            i = 0;
            soundOut.Dispose();
            playingThread.Abort();
            isThreadRunning = false;
        }
        
        int i = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar hz = progressBar1;

            i++;
            textBox1.Text = i.ToString();
            
            hz.Value = i;

            IList<EqualizerFilter> listChannels = equalizer.SampleFilters;
            foreach (EqualizerFilter channel in listChannels)
            {
                Dictionary<Int32, EqualizerChannelFilter> oneChannel = channel.Filters;
                foreach(KeyValuePair<Int32, EqualizerChannelFilter> entry in oneChannel)
                {
                    Console.WriteLine(entry.Value.Frequency); // <== how get actual value from this frequency ?
                    //entry.Value.GainDB = 12;
                    // TODO: wyswietlamy czestotliowsci jakie mamy w equalizerze, dla kazdej z nich trzeba pobrac jakos aktualna wartosc
                    // i ja przypisac do progressBara
                }
            }
        }
    }
}
