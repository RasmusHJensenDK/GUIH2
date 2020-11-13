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
    public partial class Lobby : Window
    {
        private string username { get; set; }
        Menu menu = new Menu();
        CharacterSelection CS = new CharacterSelection();

        public Lobby(string username)
        {
            this.username = username;
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\wwwroot\GUIH2\GUIH2\Media\sD8pkb.jpg")));
            InitializeComponent();
            //this.LoadMenu();
            LoadCharacterSelection();
        }
        private void DragAble(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) this.DragMove();
        }
        private void LoadMenu()
        {
            foreach(Label lbl in menu.returnLabels())
            {
                LobbyGrid.Children.Add(lbl);
            }
        }

        public void LoadCharacterSelection()
        {
            int i = 0;
            foreach(DrawCharacterBox DCB in menu.returnDCBList())
            {
                LobbyGrid.Children.Add(DCB.StackView(-550 + i, 0, 0, 0));
                i = i + 550;
            }
        }
    }
}