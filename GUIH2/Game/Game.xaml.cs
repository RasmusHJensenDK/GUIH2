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
        private Player _PLAYER { get; set; }
        public Game(Player player)
        {
            InitializeComponent();

            UpdateCountryText();

            this._PLAYER = player;
            this.GAMEUSERNAME.Content = player.GetUsername().ToString();
            SPShop.Visibility = Visibility.Hidden;

            /// **** UPDATE BOTTOM BAR **** ///
            UpdateItems(
                _PLAYER.GetPlayerBombs(), 
                _PLAYER.GetPlayerSoldiers(), 
                _PLAYER.GetPlayerPlanes(),
                _PLAYER.GetPlayerTanks()
            );

            GAMEUSERIMAGE = _PLAYER.ReturnPlayerCharacter().returnImage();
            playername.Content = _PLAYER.ReturnPlayerCharacter().getName().ToString();
            _PLAYER.ReturnPlayerCharacter().returnImageSource().ToString();

            /// **** GAME MECHANICS **** ///
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

            bBUYBOMB.Click += BUYBOMB;
            buttonBUYSOLDIER.Click += bBUYSOLDIER;
            buttonBUYPLANE.Click += bBUYPLANE;
            buttonBUYTANK.Click += bBUYTANK;

            CLOSESHOP.MouseDown += Exitshop;

            buttonSELLPLANE.Click += ButtonSELLPLANE_Click;
            buttonSELLSOLDIER.Click += ButtonSELLSOLDIER_Click;
            buttonSELLTANK.Click += ButtonSELLTANK_Click;
            buttonSELLBOMB.Click += ButtonSELLBOMB_Click;
        }

        private void ButtonSELLBOMB_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonSELLTANK_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonSELLSOLDIER_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonSELLPLANE_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
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

        private void Exitshop(object sender, RoutedEventArgs e)
        {
            SPShop.Visibility = Visibility.Hidden;
        }

        private void BUYBOMB(object sender, RoutedEventArgs e)
        {
            if (_PLAYER.ReturnPlayerCash() > 29999)
            {
                _PLAYER.SetPlayerCash(30000);
                _PLAYER.SetPlayerBombs(_PLAYER.GetPlayerBombs() + 1);
                UpdateItems(_PLAYER.GetPlayerBombs(), _PLAYER.GetPlayerSoldiers(), _PLAYER.GetPlayerPlanes(), _PLAYER.GetPlayerTanks());
            }
            else
            {
                //Alert player not enough cash!
            }
        }

        private void bBUYSOLDIER(object sender, RoutedEventArgs e)
        {
            if (_PLAYER.ReturnPlayerCash() > 499)
            {
                _PLAYER.SetPlayerCash(500);
                _PLAYER.SetPlayerSoldiers(_PLAYER.GetPlayerSoldiers() + 1);
                UpdateItems(_PLAYER.GetPlayerBombs(), _PLAYER.GetPlayerSoldiers(), _PLAYER.GetPlayerPlanes(), _PLAYER.GetPlayerTanks());
            }
            else
            {
                //Alert player not enough cash!
            }
        }

        private void bBUYPLANE(object sender, RoutedEventArgs e)
        {
            if (_PLAYER.ReturnPlayerCash() > 2499)
            {
                _PLAYER.SetPlayerCash(2500);
                _PLAYER.SetPlayerPlanes(_PLAYER.GetPlayerPlanes() + 1);
                UpdateItems(_PLAYER.GetPlayerBombs(), _PLAYER.GetPlayerSoldiers(), _PLAYER.GetPlayerPlanes(), _PLAYER.GetPlayerTanks());
            }
            else
            {
                //Alert player not enough cash!
            }
        }

        private void bBUYTANK(object sender, RoutedEventArgs e)
        {
            if (_PLAYER.ReturnPlayerCash() > 2000)
            {
                _PLAYER.SetPlayerCash(2000);
                _PLAYER.SetPlayerTanks(_PLAYER.GetPlayerTanks() + 1);
                UpdateItems(_PLAYER.GetPlayerBombs(), _PLAYER.GetPlayerSoldiers(), _PLAYER.GetPlayerPlanes(), _PLAYER.GetPlayerTanks());
            }
            else
            {
                //Alert player not enough cash!
            }
        }
    }
}
