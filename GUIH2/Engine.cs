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
            for(int k = 0; k < 2; k++)
            {
                for (int i = 0; i < 3; i++)
                {
                    CharacterSelection CS_ENEMY = new CharacterSelection();
                    Player enemy = new Player("Enemy", CS_ENEMY.returnCharacter(random.Next(0,3)));
                    enemies[i] = enemy;
                }
            }
        }
    }
}
