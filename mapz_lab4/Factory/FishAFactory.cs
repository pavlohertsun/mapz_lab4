using mapz_lab4.Fishes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4.Factory
{
     class FishAFactory : AbstractFactory
     {
        public override Fish createFish() {
            return new FishA();
        }
     }
}
