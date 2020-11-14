using System;
using System.Collections.Generic;
using System.Text;

namespace GUIH2
{
    class Engine
    {
        private Player player { get; set; }
        private Player[] enemies { get; set; }
        private Random random;
        public Engine(Player player)
        {
            this.player = player;
        }
        public void AddEnemies()
        {

        }
        public void Run(Player player, Player[] enemies)
        {

        }
    }
}
