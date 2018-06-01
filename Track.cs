using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using NAudio.Wave;
using SoundEditor;

namespace SoundEditor
{
    class Track
    {

        public BlockAlignReductionStream stream = null;

        public CustomWaveViewer graphWave = null;

        public DirectSoundOut output = null;

        public string inputpath;

        public string trackDuration;

        public long audioLength;

        public void open()
        {
            DisposeWave();
            Graph(); 

            if (inputpath.EndsWith(".mp3"))
            {
                WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(new Mp3FileReader(inputpath));
                stream = new BlockAlignReductionStream(pcm);
            }            

            else throw new InvalidOperationException("Not a correct audio file type.");

            FileInfo fileInf = new FileInfo(inputpath);
            trackDuration = string.Format("Duration: {0:D2} hrs, {1:D2} mins, {2:D2} secs", TimeMP3(inputpath).Hours, TimeMP3(inputpath).Minutes, TimeMP3(inputpath).Seconds);          

            audioLength = (fileInf.Length) / (1024 * 1024);

            output = new DirectSoundOut();
            output.Init(stream);
            output.Play();

        }
       
        public void DisposeWave()
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Stop();
                output.Dispose();
                output = null;
            }
            if (stream != null)
            {
                stream.Dispose();
                stream = null;
            }
        }

        public void Graph()
        {
         if (inputpath.EndsWith(".mp3"))
            {
                WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(new Mp3FileReader(inputpath));
                stream = new BlockAlignReductionStream(pcm);
            }
            graphWave.WaveStream = stream;
            graphWave.FitToScreen();
        }
        public void pause(DirectSoundOut output)
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Pause();
                else if (output.PlaybackState == NAudio.Wave.PlaybackState.Paused) output.Play();
            }
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
    }

}
