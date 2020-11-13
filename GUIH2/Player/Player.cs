using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace GUIH2
{
    class Player
    {
        private string playerName { get; set; }
        private Character playerCharacter { get; set; }
        private Image playerImage { get; set; }
        public Player(string playerName, Character playerCharacter)
        {
            this.playerName = playerName;
            this.playerCharacter = playerCharacter;
            this.playerImage = playerCharacter.returnImage();
        }
    }
}
