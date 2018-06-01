using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using NAudio.Wave;


namespace SoundEditor
{
    /// <summary>  
    ///  Осуществляет обрезку и склеивание трека.
    /// </summary>        
    public class TrackEdit: IEdit
    {
        public string inputPath;
        public string outputPath;
        public string[] inputFiles;
        public Stream output;

        /// <summary>  
        /// Обрезает аудиотрек от заданного семпла до заданного семпла (begin, end).
        /// </summary>       
        public void Trim(TimeSpan? begin, TimeSpan? end)
        {
            if (begin.HasValue && end.HasValue && begin > end)
                throw new ArgumentOutOfRangeException("end", "end should be greater than begin");         

            using (var reader = new NAudio.Wave.Mp3FileReader(inputPath))
            using (var writer = System.IO.File.Create(outputPath))
            {
                NAudio.Wave.Mp3Frame frame;
                while ((frame = reader.ReadNextFrame()) != null)
                    if (reader.CurrentTime >= begin || !begin.HasValue)
                    {
                        if (reader.CurrentTime <= end || !end.HasValue)
                            writer.Write(frame.RawData, 0, frame.RawData.Length);
                        else break;
                    }
            }
        }

        /// <summary>  
        /// Возвращает время в секундах для обрезки.
        /// </summary>   
        public double TrimArgs(string min, string sec)
        {
            try
            {
                double min1 = double.Parse(min);
                double sec1 = double.Parse(sec);

                if (min1 < 0 || sec1 < 0 || sec1 >= 60)
                {
                    throw new ArgumentOutOfRangeException("Отрицательные данные");
                }
                double timer = 60 * min1 + sec1;
                return timer;
            }
            catch (FormatException)
            {
                return -1.00;

            }
            catch (ArgumentOutOfRangeException)
            {
                return -1.00;
            }
        }

        /// <summary>  
        /// Склеивает аудиотреки.
        /// </summary>   
        public void Combine()
        {
            foreach (string file in inputFiles)
            {
                Mp3FileReader reader = new Mp3FileReader(file);

                if ((output.Position == 0) && (reader.Id3v2Tag != null))
                {
                    output.Write(reader.Id3v2Tag.RawData, 0, reader.Id3v2Tag.RawData.Length);
                }

                Mp3Frame frame;

                while ((frame = reader.ReadNextFrame()) != null)
                {
                    output.Write(frame.RawData, 0, frame.RawData.Length);
                }
            }
        }

    }
}
