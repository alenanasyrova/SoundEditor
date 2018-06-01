using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using NAudio.Wave;

namespace SoundEditor
{
    /// <summary>  
    ///  Представляет авторскую информацию о загруженном аудиотреке.
    /// </summary>         
    public class TrackTag : ITag
    {
        public string inputpath;
        public byte[] TAGID = new byte[3];     
        public byte[] Title = new byte[30];    
        public byte[] Artist = new byte[30];    
        public byte[] Album = new byte[30];     
        public byte[] Year = new byte[4];       

        public string Titles;
        public string Artists;
        public string Albums;
        public string Years;

        /// <summary>  
        /// Возвращает информацию о заданном аудиотреке.
        /// </summary>        
        public void GetTags()
        {
            using (FileStream fs = File.OpenRead(inputpath))
            {
                if (fs.Length >= 128)
                {                    
                    fs.Seek(-128, SeekOrigin.End);
                    fs.Read(TAGID, 0, TAGID.Length);
                    fs.Read(Title, 0, Title.Length);
                    fs.Read(Artist, 0, Artist.Length);
                    fs.Read(Album, 0, Album.Length);
                    fs.Read(Year, 0, Year.Length);
                    string theTAGID = Encoding.Default.GetString(TAGID);

                    if (theTAGID.Equals("TAG"))
                    {
                        Titles = Encoding.Default.GetString(Title);
                        Artists = Encoding.Default.GetString(Artist);
                        Albums = Encoding.Default.GetString(Album);
                        Years = Encoding.Default.GetString(Year);                    
                    }
                }
            }
        }
    }
}
