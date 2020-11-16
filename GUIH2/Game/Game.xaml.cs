using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GUIH2
{
    public partial class Game : Window
    {
        private List<GameCard> _GAMECARDLIST = new List<GameCard>();
        private List<StackPanel> _GAMEOBJECTS = new List<StackPanel>();
        private Character character { get; set; }
        public Game(string username, Character CH)
        {
            this.character = character;
            InitializeComponent();
            this.GAMEUSERNAME.Content = username.ToString();
            UpdateItems(0, 50, 2, 5);
            UpdateCountryText();
            //GAMEUSERIMAGE = character.returnImage();

            LBLBRASIL.MouseEnter += MouseEnter;
            LBLCHINA.MouseEnter += MouseEnter;
            LBLEU.MouseEnter += MouseEnter;
            LBLNK.MouseEnter += MouseEnter;
            LBLRUSSIA.MouseEnter += MouseEnter;
            LBLUSA.MouseEnter += MouseEnter;

        }
        private new void MouseEnter(object sender, MouseEventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.Cursor = Cursors.Hand;
        }

        private void MoveIt(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) this.DragMove();
        }
        public void UpdateItems(int bombs, int soldiers, int planes, int tanks)
        {
            PlayerItems _PLAYERITEMS = new PlayerItems(bombs, soldiers, planes, tanks);
            this.NBQuantity.Content = _PLAYERITEMS.ReturnBombs().ToString();
            this.GAMEUSERSOLDIERS.Content = _PLAYERITEMS.ReturnSoldiers().ToString();
            this.GAMEUSERPLANES.Content = _PLAYERITEMS.ReturnPlanes().ToString();
            this.GAMEUSERTANKS.Content = _PLAYERITEMS.ReturnTanks().ToString();
        }
        public void UpdateCountryText()
        {
            this.LBLUSA.Content = "A good place \n to buy a good \n piece of weapon \n equipment. Best buys \n of Atomic bombs and tanks.";
            this.LBLCHINA.Content = "If you want \n high tech, \n dont go here!\n But if you want \n many men \n go here!";
            this.LBLEU.Content = "Before doing \n anything, be sure to \n setup a meeting, and \n wait ages for \n the democratic \n process.";
            this.LBLNK.Content = "Rocket man eh? \n NK only buys \n bombs, and do \n not distripute \n but if you want a virus \n they can sure help!";
            this.LBLRUSSIA.Content = "NASTROVIA COMRADE! \n Atomic bombs, \n a million men, \n tanks, planes \n mother russia has it all.";
            this.LBLBRASIL.Content = "You know \n Eddie Guerro? \n FIST FIGHT \n YOUR WAY \n To Victory! \n or get the cartels.";
        }
    }
}
