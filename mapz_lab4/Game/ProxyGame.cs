using mapz_lab4.Factory;
using mapz_lab4.Fishes;
using mapz_lab4.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mapz_lab4.Objects
{
    public class ProxyGame : Game
    {
        public DefaultGame proxy;
        public ProxyGame(DefaultGame game)
        {
            proxy = game;
        }

        public override void game(int size, Gender hero, Stick stick, bool useBait)
        {
            int value = stick.chanceToCatch;
            hero.expirience++;
            stick.chanceToCatch = 100;
            proxy.game(size, hero, stick, useBait);
            hero.expirience--;
            stick.chanceToCatch = value;
        }
    }
}