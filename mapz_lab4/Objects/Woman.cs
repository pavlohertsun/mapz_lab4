using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4.Objects
{
    public class Woman : Man
    {
        Woman woman;
        public  Woman() : base()
        {
            woman = new Woman();
            stamina = 200;
            woman.backpack.equipment.stick.chanceToCatch = 20;
        }
    }
}
