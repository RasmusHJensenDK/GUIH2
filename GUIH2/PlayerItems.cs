using System;
using System.Collections.Generic;
using System.Text;

namespace GUIH2
{
    public class PlayerItems
    {
        private int _NUCLEARBOMBS { get; set; }
        private int _SOLDIERS { get; set; }
        private int _TANKS { get; set; }
        private int _PLANES { get; set; }

        public PlayerItems(int bombs, int soldiers, int tanks, int planes)
        {
            this._NUCLEARBOMBS = bombs;
            this._SOLDIERS = soldiers;
            this._TANKS = tanks;
            this._PLANES = planes;
        }

        public void SetNuclearBombs(int bombs)
        {
            this._NUCLEARBOMBS = bombs;
        }
        public void SetSoldiers(int soldiers)
        {
            this._SOLDIERS = soldiers;
        }
        public void SetTanks(int tanks)
        {
            this._TANKS = tanks;
        }
        public void SetPlanes(int planes)
        {
            this._PLANES = planes;
        }
        public int ReturnBombs()
        {
            return _NUCLEARBOMBS;
        }
        public int ReturnSoldiers()
        {
            return _SOLDIERS;
        }
        public int ReturnTanks()
        {
            return _TANKS;
        }
        public int ReturnPlanes()
        {
            return _PLANES;
        }
    }
}
