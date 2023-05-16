using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mapz_lab4
{
    public class Game
    {
        private static Game INSTANCE;
        private Game() { }
        public static Game getInstance() {
            if (INSTANCE == null) INSTANCE = new Game();
            return INSTANCE;
        }
        public void game(int sizeOfLocation)
        {
            Map map = new Map(LakeBuilder.lake1());
            while (true)
            {
                Console.Clear();
                map.showLake();
                Thread.Sleep(500);
            }
        }
    }
}
