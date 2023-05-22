using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4
{
    public abstract class Game
    {
        public abstract void game(int size, Character hero, Stick stick, bool useBait);
    }
}
