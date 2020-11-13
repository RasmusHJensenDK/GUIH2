using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace GUIH2
{
    class Character
    {
        private string Name { get; set; }
        private int life { get; set; }
        private Image image { get; set; }
        private string characterDescription { get; set; }

        public Character(string Name, string characterDescription, Image image, int Life = 3)
        {
            this.characterDescription = characterDescription;
            this.Name = Name;
            this.image = image;
            this.life = life;
        }
        public string getName()
        {
            return Name;
        }
        public string getDescription()
        {
            return characterDescription;
        }
        public int getLifes()
        {
            return life;
        }
        public void loseLife(int loser)
        {
            this.life = life - loser;
        }
        public void gainLife(int gain)
        {
            this.life = life + gain;
        }
        public Image returnImage()
        {
            return image;
        }

    }
}
