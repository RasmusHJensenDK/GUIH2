using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace GUIH2
{
    class DrawCharacterBox
    {
        private Character _CHARACTER { get; set; }
        private string _SRC { get; set; }
        private Brush stackColor { get; set; }
        private Lobby myParent;
        private string _USERNAME { get; set; }
        public DrawCharacterBox(Character character, string src)
        {
            this._SRC = src;
            this._CHARACTER = character; 
        }
        public DrawCharacterBox(Character character, string src, Lobby parent)
        {
            this._SRC = src;
            this._CHARACTER = character;
            myParent = parent;
            _USERNAME = myParent.GetUsername();
        }
        public StackPanel StackView(double left, double top, double right, double bottom)
        {
            StackPanel stackpanel = new StackPanel()
            {
                Width = 250,
                Height = 350,
                Margin = new System.Windows.Thickness(left, top, right, bottom)
            };
            stackpanel.Orientation = Orientation.Vertical;
            stackpanel.Background = Brushes.White;
            stackpanel.Opacity = 0.65;
            stackpanel.MouseEnter += Stackpanel_MouseEnter;
            stackpanel.MouseLeave += Stackpanel_MouseLeave;
            stackpanel.Children.Add(DrawLabel());
            stackpanel.Children.Add(DrawPicture());
            stackpanel.Children.Add(DrawInformation());
            stackpanel.MouseDown += Stackpanel_MouseDown;
            return stackpanel;
        }

        public void Stackpanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PlayerItems pi = new PlayerItems(0, 50, 5, 2);
            Player player = new Player(_USERNAME, 500, _CHARACTER, pi);
            Game Game = new Game(player);
            Game.Show();
        }

        private void Stackpanel_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            StackPanel stkPanel = (StackPanel)sender;
            stkPanel.Cursor = Cursors.Arrow;
            stkPanel.Background = stackColor;
            stkPanel.Opacity = 0.65;
        }

        private void Stackpanel_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            StackPanel stkPanel = (StackPanel)sender;
            stackColor = stkPanel.Background;
            stkPanel.Cursor = Cursors.Hand;
            stkPanel.Background = Brushes.Red;
            stkPanel.Opacity = 0.8;
        }

        public Rectangle DrawSquare()
        {
            Rectangle square = new Rectangle()
            {
                Width = 100,
                Height = 350
            };
            return square;
        }

        public Image DrawPicture()
        {
            Image characterImg = new Image
            {
                Width = 200,
                Height = 400,
                Margin = new System.Windows.Thickness(0, -100, 0, 0)
            };
            characterImg.Source = new BitmapImage(new Uri(_SRC));
            return characterImg;
        }

        public Label DrawLabel()
        {
            Label lblCharacter = new Label();
            lblCharacter.Content = _CHARACTER.getName();
            lblCharacter.FontSize = 20;
            lblCharacter.Margin = new System.Windows.Thickness(70, 0, 0, 0);
            return lblCharacter;
        }
        public Label DrawInformation()
        {
            Label information = new Label();
            information.Content = _CHARACTER.getDescription();
            information.FontSize = 12;
            information.Margin = new System.Windows.Thickness(28, -100, 0, 0);
            return information;
        }
    }
}
