using System;
using System.Collections.Generic;
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
        private List<Image> imageList = new List<Image>();
        public CharacterSelection()
        {
            Image trump= new Image();
            trump.Source = new BitmapImage(new Uri(@"C:\wwwroot\GUIH2\GUIH2\Media\tenor.gif"));
            Image biden = new Image();
            biden.Source = new BitmapImage(new Uri(@"C:\wwwroot\GUIH2\GUIH2\Media\tenor.gif"));
            Image putin = new Image();
            putin.Source = new BitmapImage(new Uri(@"C:\wwwroot\GUIH2\GUIH2\Media\tenor.gif"));
            imageList.Add(trump);
            imageList.Add(biden);
            imageList.Add(putin);
            foreach (string name in names)
            {
                Character character = new Character(name, imageList[counterForCharacter]);
                characterList.Add(character);
                counterForCharacter++;
            }
        }
    }
    public class CharacterImage 
    {

        private Image image { get; set; }
        private string filename { get; set; }
        public CharacterImage(string filename)
        {
            System.Windows.Controls.Image myImage = new System.Windows.Controls.Image();
            myImage.Source = new BitmapImage(new Uri(filename));
        }
    }
}
