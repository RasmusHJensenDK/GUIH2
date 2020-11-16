using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace GUIH2
{
    public class Player
    {
        private string playerName { get; set; }
        private Character playerCharacter { get; set; }
        private Image playerImage { get; set; }
        private int _PLAYERCASH { get; set; }
        public Player(string playerName, int playercash, Character playerCharacter)
        {
            this._PLAYERCASH = playercash;
            this.playerName = playerName;
            this.playerCharacter = playerCharacter;
            this.playerImage = playerCharacter.returnImage();
        }

        public string GetUsername()
        {
            return playerName;
        }
        public int ReturnPlayerCash()
        {
            return _PLAYERCASH;
        }
        public void SetPlayerCash(int minuscash)
        {
            _PLAYERCASH = _PLAYERCASH - minuscash;
        }
        public void UpdatePlayerCash(int pluscash)
        {
            _PLAYERCASH = _PLAYERCASH + pluscash;
        }
    }
}
