using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4.Objects
{
    public class Level1Stick : Stick
    {
        public Stick stick;
        public Level1Stick(Stick stick)
        {
            this.stick = stick;
            chanceToCatch = 40;
            isAvailable = true;
        }
    }
}
