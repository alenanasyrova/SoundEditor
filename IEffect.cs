using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoundEditor
{
    public interface IEffect
    {
        float ApplyEffect(float sample);
    }
}
