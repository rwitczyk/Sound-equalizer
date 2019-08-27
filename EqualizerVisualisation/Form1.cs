using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;
using CSCore.Streams;
using CSCore.Streams.Effects;

namespace EqualizerVisualisation
{
    public partial class Form1 : Form
    {

        ISoundOut soundOut;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            const string filename = @"D:\bbb.mp3";
            ProgressBar hz = progressBar1;
            EventWaitHandle waitHandle = new AutoResetEvent(false);

            try
            {
                //create a source which provides audio data
                using (ISampleSource source = CodecFactory.Instance.GetCodec(filename).ToSampleSource())
                {
                    //create the equalizer.
                    //You can create a custom eq with any bands you want, or you can just use the default 10 band eq.
                    Equalizer equalizer = Equalizer.Create10BandEqualizer(source);

                    //create a soundout to play the source
                    
                    if (WasapiOut.IsSupportedOnCurrentPlatform)
                    {
                        soundOut = new WasapiOut();
                    }
                    else
                    {
                        soundOut = new DirectSoundOut();
                    }

                    soundOut.Stopped += (s, x) => waitHandle.Set();

                    IWaveSource finalSource = equalizer.ToWaveSource(16); //since the equalizer is a samplesource, you have to convert it to a raw wavesource
                    soundOut.Initialize(finalSource); //initialize the soundOut with the previously created finalSource
                    soundOut.Play();

                    /*
                     * You can change the filter configuration of the equalizer at any time.
                     */
                    hz.Value = 6;
                    //(int)equalizer.SampleFilters[0].AverageGainDB; //eq set the gain of the first filter to 20dB (if needed, you can set the gain value for each channel of the source individually)

                    //wait until the playback finished
                    //of course that is optional
                    waitHandle.WaitOne(5000); // TODO: ten watek blokuje robienie innych rzeczy, ale potrzebny aby muzyka wciaz leciala
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

        private void Button2_Click(object sender, EventArgs e)
        {
                soundOut.Pause(); 
        }
    }
}
