using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using NAudio.Wave;
using SoundEditor;


namespace SoundEditor
{
    /// <summary>  
    /// Представляет описание и функциональность формы приложения.
    /// </summary>        
    public partial class FormSoundEditor : Form
    {
        public FormSoundEditor()
        {
            InitializeComponent();
        }

        OpenFileDialog open = new OpenFileDialog();
        Track openWavTrack = new Track();
        TrackTag tags = new TrackTag();
       
        private void openFileButton_Click(object sender, EventArgs e)
        {            
            open.Filter = "Audio File (*.mp3)|*.mp3;";
            if (open.ShowDialog() != DialogResult.OK) return;

            openWavTrack.inputpath = open.FileName;
            openWavTrack.graphWave = customWaveViewer1;

            openWavTrack.open();
            
            tags.inputpath = open.FileName;
            tags.GetTags();

            duration.Text = openWavTrack.trackDuration;
            length.Text = "Length: " + openWavTrack.audioLength.ToString() + "Mb"; 
            title.Text = "Title: " + tags.Titles;
            artist.Text = "Artist: " + tags.Artists;
            album.Text = "Album: " + tags.Albums;
            year.Text = "Year: " + tags.Years;    

            pauseButton.Enabled = true;
            buttonTrim.Enabled = true;
            echo.Enabled = true;
            overdrive.Enabled = true;            
        }

        public void pauseButton_Click(object sender, EventArgs e)
        {
            openWavTrack.pause(openWavTrack.output);
        }  

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            openWavTrack.DisposeWave();
        }

        public TimeSpan TimeMP3(string inputPath)
        {
            if (inputPath != null)
            {
                NAudio.Wave.Mp3FileReader reader = new NAudio.Wave.Mp3FileReader(inputPath);
                TimeSpan duration = reader.TotalTime;
                return duration;
            }
            else
                return new TimeSpan(0, 0, 0, 0, 0);
        }

        private void buttonTrim_Click(object sender, EventArgs e)
        {
            TrackEdit edit = new TrackEdit();
            
            SaveFileDialog save = new SaveFileDialog();
            string minAmount = Convert.ToString(TimeMP3(openWavTrack.inputpath).Minutes);
            string secAmount = Convert.ToString(TimeMP3(openWavTrack.inputpath).Seconds);
            save.Filter = "Audio File (*.mp3)|*.mp3;";
            if (save.ShowDialog() != DialogResult.OK) return;
            double start = edit.TrimArgs(textBox1.Text, textBox3.Text);
            double end = edit.TrimArgs(textBox2.Text, textBox4.Text);
            double endTime = edit.TrimArgs(minAmount, secAmount);

            try
            {
                if (start == end || start < 0 || end < 0 || start > end || end > endTime || start > endTime)
                { throw new Exception(); }
                edit.inputPath = openWavTrack.inputpath;
                edit.outputPath = save.FileName;
                edit.Trim(TimeSpan.FromSeconds(start), TimeSpan.FromSeconds(end));
            }
            catch (Exception)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void title_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void buttonCombine_Click(object sender, EventArgs e)
        {            
            OpenFileDialog opencompile = new OpenFileDialog();
            opencompile.Multiselect = true;

            opencompile.Filter = "Audio File (*.mp3)|*.mp3;";

            if (opencompile.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in opencompile.FileNames)
                {
                    MessageBox.Show(file);
                }
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Audio File (*.mp3)|*.mp3;";
            if (save.ShowDialog() != DialogResult.OK) return;
            FileStream compile = new System.IO.FileStream(save.FileName, FileMode.Create);
            TrackEdit editcompile = new TrackEdit();

            editcompile.inputFiles = opencompile.FileNames;
            editcompile.output = compile;
            editcompile.Combine();
        }

        private void echo_Click(object sender, EventArgs e)
        {
            BlockAlignReductionStream stream = null;
            WaveChannel32 wave = new WaveChannel32(openWavTrack.stream);
            EffectStream effect = new EffectStream(wave);
            stream = new BlockAlignReductionStream(effect);

            for (int i = 0; i < wave.WaveFormat.Channels; i++) effect.Effects.Add(new TrackEffectEcho());

            openWavTrack.pause(openWavTrack.output);
            openWavTrack.output = new DirectSoundOut(200);
            openWavTrack.output.Init(stream);
            openWavTrack.output.Play();
        }

        private void overdrive_Click(object sender, EventArgs e)
        {
            BlockAlignReductionStream stream = null;
            WaveChannel32 wave = new WaveChannel32(openWavTrack.stream);
            EffectStream effect = new EffectStream(wave);
            stream = new BlockAlignReductionStream(effect);

            for (int i = 0; i < wave.WaveFormat.Channels; i++) effect.Effects.Add(new TrackEffectOverride());

            openWavTrack.pause(openWavTrack.output);
            openWavTrack.output = new DirectSoundOut(200);
            openWavTrack.output.Init(stream);
            openWavTrack.output.Play();         
        }



        private void customWaveViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
