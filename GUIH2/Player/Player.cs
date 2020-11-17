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
        public void AddPlayerBombs(int i)
        {
            playeritems.SetNuclearBombs(playeritems.ReturnBombs() + i);
        }
        public void AddPlayerPlanes(int i)
        {
            playeritems.SetPlanes(playeritems.ReturnPlanes() + i);
        }
        public void AddPlayerSoldiers(int i)
        {
            playeritems.SetSoldiers(playeritems.ReturnSoldiers() + i);
        }
        public void AddPlayerTanks(int i)
        {
            playeritems.SetTanks(playeritems.ReturnTanks() + i);
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
        public void SellPlayerBomb(int i)
        {
            playeritems.SetNuclearBombs(playeritems.ReturnBombs() - i);
        }
        public void SellPlayerSoldier(int i)
        {
            playeritems.SetSoldiers(playeritems.ReturnSoldiers() - i);
        }
        public void SellPlayerPlanes(int i)
        {
            playeritems.SetPlanes(playeritems.ReturnPlanes() - i);
        }
        public void SellPlayerTanks(int i)
        {
            playeritems.SetTanks(playeritems.ReturnTanks() - i);
        }
    }
}
