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
        private Player _PLAYER { get; set; }
        private int _PLAYERBOMBS { get; set; }
        private int _PLAYERPLANES { get; set; }
        private int _PLAYERTANKS { get; set; }
        private int _PLAYERSOLDIERS { get; set; }
        public Game(Player player)
        {
            _PLAYERBOMBS = 0;
            _PLAYERSOLDIERS = 50;
            _PLAYERPLANES = 2;
            _PLAYERTANKS = 5;
            this._PLAYER = player;
            this.character = character;
            InitializeComponent();
            this.GAMEUSERNAME.Content = player.GetUsername();
            UpdateItems(_PLAYERBOMBS, _PLAYERSOLDIERS, _PLAYERPLANES, _PLAYERTANKS);
            UpdateCountryText();
            SPShop.Visibility = Visibility.Hidden;
            //GAMEUSERIMAGE = character.returnImage();

            LBLBRASIL.MouseEnter += MouseEnter;
            LBLCHINA.MouseEnter += MouseEnter;
            LBLEU.MouseEnter += MouseEnter;
            LBLNK.MouseEnter += MouseEnter;
            LBLRUSSIA.MouseEnter += MouseEnter;
            LBLUSA.MouseEnter += MouseEnter;

            LBLBRASIL.MouseLeave += MouseLeave;
            LBLCHINA.MouseLeave += MouseLeave;
            LBLEU.MouseLeave += MouseLeave;
            LBLNK.MouseLeave += MouseLeave;
            LBLRUSSIA.MouseLeave += MouseLeave;
            LBLUSA.MouseLeave += MouseLeave;

            LBLBRASIL.MouseDown += ShowShop;
            LBLCHINA.MouseDown += ShowShop;
            LBLEU.MouseDown += ShowShop;
            LBLNK.MouseDown += ShowShop;
            LBLRUSSIA.MouseDown += ShowShop;
            LBLUSA.MouseDown += ShowShop;

            BUYBOMB.MouseDown += BUYBOMB_MouseDown;
            BUYPLANE.MouseDown += BUYPLANE_MouseDown;
            BUYSOLDIER.MouseDown += BUYSOLDIER_MouseDown;
            BUYTANK.MouseDown += BUYTANK_MouseDown;

            CLOSESHOP.MouseDown += ExitShop;

        }

        private void BUYTANK_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(_PLAYER.ReturnPlayerCash() > 2000)
            {
                _PLAYER.SetPlayerCash(2000);
                UpdateItems(_PLAYERBOMBS, _PLAYERSOLDIERS, _PLAYERPLANES, _PLAYERTANKS + 1);
            }
            else
            {
                //Alert player not enough cash!
            }
        }

        private void BUYSOLDIER_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_PLAYER.ReturnPlayerCash() > 500)
            {
                _PLAYER.SetPlayerCash(500);
                UpdateItems(_PLAYERBOMBS, _PLAYERSOLDIERS + 1, _PLAYERPLANES, _PLAYERTANKS);
            }
            else
            {
                //Alert player not enough cash!
            }
        }

        private void BUYPLANE_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_PLAYER.ReturnPlayerCash() > 2500)
            {
                _PLAYER.SetPlayerCash(2500);
                UpdateItems(_PLAYERBOMBS, _PLAYERSOLDIERS, _PLAYERPLANES + 1, _PLAYERTANKS);
            }
            else
            {
                //Alert player not enough cash!
            }
        }

        private void BUYBOMB_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_PLAYER.ReturnPlayerCash() > 12000)
            {
                _PLAYER.SetPlayerCash(12000);
                UpdateItems(_PLAYERBOMBS + 1, _PLAYERSOLDIERS, _PLAYERPLANES, _PLAYERTANKS);
            } else
            {
                //Alert player not enough cash!
            }
        }

        private void ShowShop(object sender, MouseButtonEventArgs e)
        {
            Label lbldown = (Label)sender;
            SPShop.Visibility = Visibility.Visible;
            GameShop GS = new GameShop();
            SPShop.Children.Add(GS.DrawShop(lbldown.Name.ToString()));
        }

        private new void MouseLeave(object sender, MouseEventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.Foreground = Brushes.White;
            lbl.Cursor = Cursors.Hand;

            switch (lbl.Name)
            {
                case "LBLBRASIL":
                    RECBRA.Fill = Brushes.Red;
                    break;
                case "LBLCHINA":
                    RECCH.Fill = Brushes.Red;
                    break;
                case "LBLEU":
                    RECEU.Fill = Brushes.Red;
                    break;
                case "LBLNK":
                    RECHNK.Fill = Brushes.Red;
                    break;
                case "LBLRUSSIA":
                    RECRUS.Fill = Brushes.Red;
                    break;
                case "LBLUSA":
                    RECUSA.Fill = Brushes.Red;
                    break;
            }
        }

        private new void MouseEnter(object sender, MouseEventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.Foreground = Brushes.Black;
            lbl.Cursor = Cursors.Hand;
            
            switch(lbl.Name)
            {
                case "LBLBRASIL":
                    RECBRA.Fill = Brushes.White;
                    break;
                case "LBLCHINA":
                    RECCH.Fill = Brushes.White;
                    break;
                case "LBLEU":
                    RECEU.Fill = Brushes.White;
                    break;
                case "LBLNK":
                    RECHNK.Fill = Brushes.White;
                    break;
                case "LBLRUSSIA":
                    RECRUS.Fill = Brushes.White;
                    break;
                case "LBLUSA":
                    RECUSA.Fill = Brushes.White;
                    break;
            }
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
            this.GAMECASHLABEL.Content = _PLAYER.ReturnPlayerCash().ToString();
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

        private void ExitShop(object sender, MouseButtonEventArgs e)
        {
            SPShop.Visibility = Visibility.Hidden;
        }
    }
}
