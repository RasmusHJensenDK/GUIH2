using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace GUIH2
{
    class CharacterSelection
    {
        private List<Character> characterList = new List<Character>();
        private int counterForCharacter = 0;
        private string[] names = { "Trump", "Biden", "Putin" };
        private string[] Descriptions = { "Wooohah! You might think twice\n before selecting this big baby.\n He consider himself to be the \n top and will never stop  fighting \n to get there!", "So you choose an elderly guy. You might die quick in serverall ways!", "Kzunej Zubaj Nik nik. Putin will get you there!" };
        private List<Image> imageList = new List<Image>();
        public CharacterSelection()
        {
            Image trump= new Image();
            trump.Source = new BitmapImage(new Uri(@"C:\wwwroot\GUIH2\GUIH2\Media\bg.jpg"));
            Image biden = new Image();
            biden.Source = new BitmapImage(new Uri(@"C:\wwwroot\GUIH2\GUIH2\Media\bg.jpg"));
            Image putin = new Image();
            putin.Source = new BitmapImage(new Uri(@"C:\wwwroot\GUIH2\GUIH2\Media\bg2.jpg"));
            imageList.Add(trump);
            imageList.Add(biden);
            imageList.Add(putin);
            foreach (string name in names)
            {
                Character character = new Character(name, Descriptions[counterForCharacter],  imageList[counterForCharacter]);
                characterList.Add(character);
                counterForCharacter++;
            }
        }
        public Character returnCharacter(int i)
        {
            return characterList[i];
        }
        public List<Character> returnCharacterlist()
        {
            return characterList;
        }
        public string returnCharacterImageUri(int i)
        {
            return characterList[i].returnImage().Source.ToString();
        }
        public string returnCharacterDescription(int i)
        {
            return Descriptions[i];
        }
    }
}
