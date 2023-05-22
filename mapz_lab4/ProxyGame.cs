using mapz_lab4.Factory;
using mapz_lab4.Fishes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mapz_lab4
{
    public class ProxyGame : Game
    {
        public DefaultGame proxy;
        public ProxyGame(DefaultGame game)
        {
            this.proxy = game;
        }

        public override void game(int size, Character hero, Stick stick, bool useBait)
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