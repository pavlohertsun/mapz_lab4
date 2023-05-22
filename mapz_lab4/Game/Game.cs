using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mapz_lab4.Hero;

namespace mapz_lab4.Objects
{
    public abstract class Game
    {
        public abstract void game(int size, Gender hero, Stick stick, bool useBait);
    }
}
