using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoundEditor
{
    /// <summary>  
    ///  Накладывает на аудиотрек эффект овердрайв.
    /// </summary>        
    public class TrackEffectOverride : IEffect
    {
        public int OverdriveLength { get; private set; }

        public float OverdriveFactor { get; private set; }

        private Queue<float> samples;

        public TrackEffectOverride(int length = 200, float factor = 0.1f)
        {
            this.OverdriveLength = length;
            this.OverdriveFactor = factor;
            this.samples = new Queue<float>();

            for (int i = 0; i < length; i++) samples.Enqueue(0f);
        }

        /// <summary>  
        ///  Накладывает эффект Овердрайв на отрезок трека в момент времени.
        /// </summary>       
        public float ApplyEffect(float sample)
        {
                samples.Enqueue(sample);
                return Math.Max(samples.Dequeue(), 3 * sample);
        }
    }
    
}
