﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freaks_memes
{
    public static class Game
    {
        public static Keys KeyPressed;
        public static IFreak Freak = new Stas(100, 100);
    }
}
