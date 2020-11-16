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
        private PlayerItems playeritems;
        public Player(string playerName, int playercash, Character playerCharacter, PlayerItems PI)
        {
            this._PLAYERCASH = playercash;
            this.playerName = playerName;
            this.playerCharacter = playerCharacter;
            this.playeritems = PI;
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
        public void SetPlayerBombs(int i)
        {
            if (i < 0)
            {
                playeritems.SetNuclearBombs(playeritems.ReturnBombs() - i);
            }
            if (i > 0)
            {
                playeritems.SetNuclearBombs(playeritems.ReturnBombs() + i);
            }
        }
        public void SetPlayerPlanes(int i)
        {
            if(i < 0)
            {
                playeritems.SetPlanes(playeritems.ReturnPlanes() - i);
            } 
            if(i > 0)
            {
                playeritems.SetPlanes(playeritems.ReturnPlanes() + i);
            }
        }
        public void SetPlayerSoldiers(int i)
        {
            if (i < 0)
            {
                playeritems.SetSoldiers(playeritems.ReturnSoldiers() - i);
            }
            if (i > 0)
            {
                playeritems.SetSoldiers(playeritems.ReturnSoldiers() + i);
            }
        }
        public void SetPlayerTanks(int i)
        {
            if (i < 0)
            {
                playeritems.SetTanks(playeritems.ReturnTanks() - i);
            }
            if (i > 0)
            {
                playeritems.SetTanks(playeritems.ReturnTanks() + i);
            }
        }
        public int GetPlayerBombs()
        {
            return playeritems.ReturnBombs();
        }
        public int GetPlayerTanks()
        {
            return playeritems.ReturnTanks();
        }
        public int GetPlayerPlanes()
        {
            return playeritems.ReturnPlanes();
        }
        public int GetPlayerSoldiers()
        {
            return playeritems.ReturnSoldiers();
        }
        public Character ReturnPlayerCharacter()
        {
            return playerCharacter;
        }  
    }
}
