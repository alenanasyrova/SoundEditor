using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SoundEditor
{
    interface IEdit
    {
        void Trim(TimeSpan? begin, TimeSpan? end);
        void Combine();
    }
}

