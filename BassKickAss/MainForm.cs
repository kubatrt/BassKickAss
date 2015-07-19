using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Timers;
using System.Threading;


namespace BassKickAss
{
    public partial class MainKBOForm : Form
    {
        Metronome metronome;

        // update UI using separate thread, kernel fixed
        public delegate void delUIUpdate();
        ThreadStart threadStart;
        Thread updateThread;

        // audio resources
        SoundPlayer audioTickLow;
        SoundPlayer audioTickHigh;

        int outputDevice = -1;

        public MainKBOForm()
        {
            InitializeComponent();

            // resources
            audioTickLow = new SoundPlayer(Properties.Resources.LowTick);
            audioTickHigh = new SoundPlayer(Properties.Resources.HighTick);

            metronome = new Metronome();
            metronome.TickEvent += new Metronome.OnTickEventHandler(OnTick);

            numUpDownTempo.Minimum = Metronome.TEMPO_MIN;
            numUpDownTempo.Maximum = Metronome.TEMPO_MAX;
            //numUpDownTempo.Increment = Metronome.TEMPO_STEP;

            trackBarTempo.Minimum = Metronome.TEMPO_MIN;
            trackBarTempo.Maximum = Metronome.TEMPO_MAX;
            //numUpDownTempo.Increment = Metronome.TEMPO_STEP;
            trackBarTempo.Value = metronome.Tempo;
        }

        private void ClearNotes()
        {
            picBoxQuarterNote1.BackColor = Color.Black;
            picBoxQuarterNote2.BackColor = Color.Black;
            picBoxQuarterNote3.BackColor = Color.Black;
            picBoxQuarterNote4.BackColor = Color.Black;
        }

        private void HighlightNote()
        {
            if (metronome.Beat == 1) picBoxQuarterNote1.BackColor = Color.Red;
            if (metronome.Beat == 2) picBoxQuarterNote2.BackColor = Color.Red;
            if (metronome.Beat == 3) picBoxQuarterNote3.BackColor = Color.Red;
            if (metronome.Beat == 4) picBoxQuarterNote4.BackColor = Color.Red;
        }

        // Action every single beat
        public void OnTick()
        {
            delUIUpdate updateUI = new delUIUpdate(OnUpdateUIElement);
            this.labelCurrentBeat.BeginInvoke(updateUI);

            if (metronome.Beat == 4)
                audioTickHigh.Play();
            else
                audioTickLow.Play();

            ClearNotes();
            HighlightNote();
        }


        public void GetThreadStarted()
        {
            delUIUpdate updateUI = new delUIUpdate(OnUpdateUIElement);
            this.labelCurrentBeat.BeginInvoke(updateUI);
        }

        public void OnUpdateUIElement() 
        {
            labelCurrentBeat.Text = metronome.Beat.ToString();
            Console.WriteLine("OnUpdateUIElement: " + metronome.Beat.ToString());
        }

        private void UpdateTempo(int t)
        {
            metronome.Tempo = t;

            trackBarTempo.Value = metronome.Tempo;
            numUpDownTempo.Value = metronome.Tempo;
        }



        private void buttonMetronomePlay_Click(object sender, EventArgs e)
        {
            if(metronome.IsPlaying)
            {
                metronome.Stop();
                ClearNotes();
                buttonMetronomePlay.Text = "Play";
                labelCurrentBeat.Text = "0";
            }
            else
            {
                metronome.Play();
                buttonMetronomePlay.Text = "Stop";
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numUpDownTempo_ValueChanged(object sender, EventArgs e)
        {
            UpdateTempo((int)numUpDownTempo.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            threadStart = new ThreadStart(GetThreadStarted);
            updateThread = new Thread(threadStart);
            updateThread.Name = "Second thread";
            updateThread.Start();

            //RecordingDevices recDevices = new RecordingDevices();
            //for (int i = 0; i < recDevices.Count; i++)
                //listBoxRecDevices.Items.Add(recDevices[i]);
        }


        private NAudio.Wave.WaveIn sourceStream = null;
        private NAudio.Wave.DirectSoundOut waveOut = null;
        NAudio.Wave.WaveFileWriter waveWriter = null;
        NAudio.Wave.WaveFileReader waveReader = null;

        private void buttonRecStart_Click(object sender, EventArgs e)
        {
            if (listViewSources.SelectedItems.Count == 0)
            {
                Console.WriteLine("No device selected.");
                return;
            }
            

            int deviceNumber = listViewSources.SelectedItems[0].Index;
            labelRecDevice.Text = deviceNumber.ToString();

            sourceStream = new NAudio.Wave.WaveIn();
            sourceStream.DeviceNumber = deviceNumber;
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);
            sourceStream.DataAvailable += new EventHandler<NAudio.Wave.WaveInEventArgs>(waveIn_DataAvailable);
            sourceStream.StartRecording();

            

            if (checkBoxPlayback.Checked)
            {
                NAudio.Wave.WaveInProvider waveIn = new NAudio.Wave.WaveInProvider(sourceStream);
                waveOut = new NAudio.Wave.DirectSoundOut(NAudio.Wave.WaveOut.GetCapabilities(outputDevice).ProductGuid);
                waveOut.Init(waveIn);
                waveOut.Play();
            }
            else
            {
                NAudio.Wave.WaveIn waveIn = new NAudio.Wave.WaveIn();
            }
            
            pictureBoxRecording.BackColor = Color.Red;
        }

        private void buttonRecStop_Click(object sender, EventArgs e)
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
            if(sourceStream != null)
            {
                sourceStream.StopRecording();
                sourceStream.Dispose();
                sourceStream = null;
            }
            pictureBoxRecording.BackColor = Color.Black;
        }

        private void RefreshInputAudioSources()
        {
            List<NAudio.Wave.WaveInCapabilities> sources = new List<NAudio.Wave.WaveInCapabilities>();
            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            {
                sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i));
            }

            listViewSources.Items.Clear();

            int id = 0;
            foreach (var source in sources)
            {
                ListViewItem item = new ListViewItem(source.ProductName);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, source.Channels.ToString()));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, id.ToString()));
                listViewSources.Items.Add(item);
                id++;
            }
        }

        private void btnRefreshSources_Click(object sender, EventArgs e)
        {
            RefreshInputAudioSources();
        }

        private void waveIn_DataAvailable(object sender, NAudio.Wave.WaveInEventArgs e)
        {
            // data available
            if (waveWriter == null) return;

            //waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
            //waveWriter.Flush();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm();
            optionsForm.FormClosed += new FormClosedEventHandler( (o, a) =>
               {
                   outputDevice = optionsForm.OutputDevice;
                   Console.WriteLine("Output dev: " + outputDevice);
               });
            optionsForm.Show();
            outputDevice = optionsForm.OutputDevice;
            
        }

        private void tabControlMain_Selected(object sender, TabControlEventArgs e)
        {
            RefreshInputAudioSources();
        }

        private void trackBarTempo_ValueChanged(object sender, EventArgs e)
        {
            UpdateTempo(trackBarTempo.Value);
        }
    }
}
