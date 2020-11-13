using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace GUIH2
{
    class Menu
    {
        private string[] menuItems = { "New Game", "Resume Game", "Options", "Exit" };
        private Brush[] bruches = { Brushes.Black, Brushes.Black, Brushes.Black, Brushes.Black };
        private List<Label> menuLabels = new List<Label>();
        
        private Brush labelColor { get; set; }

        public Menu()
        {
            DrawMenu();
        }
        public void DrawMenu()
        {
            int i = 0;
            int k = 0;
            foreach(string menuItem in menuItems)
            {
                Label menuLabel = new Label()
                {
                    Width = 150,
                    Height = 50,
                    Margin = new System.Windows.Thickness(10,i,10,200)
                };
                menuLabel.Background = bruches[k];
                menuLabel.Foreground = Brushes.White;
                menuLabel.Content = menuItems[k];
                menuLabel.FontSize = 12;
                menuLabel.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
                menuLabel.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
                menuLabel.MouseEnter += MenuLabel_MouseEnter;
                menuLabel.MouseLeave += MenuLabel_MouseLeave;
                menuLabel.MouseDown += MenuLabel_MouseDown;
                menuLabels.Add(menuLabel);
                i = i + Convert.ToInt32(menuLabel.Width) - 50 ;
                k++;
            }
        }
        private void MenuLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label labelDown = (Label)sender;
            if((e.ChangedButton == MouseButton.Left))
            {
               foreach(Label label in menuLabels)
                {
                    menuLabels.Remove(label);
                }
               if(labelDown.Content.ToString() == "New Game")
                {
                    CharacterSelection CS = new CharacterSelection();
                   // CS.CreateCharacterList();
                }
            }
        }
        public Brush returnBrush()
        {
            return bruches[0];
        }
        private void MenuLabel_MouseLeave(object sender, MouseEventArgs e)
        {
            Label labelOver = (Label)sender;
            labelOver.Cursor = Cursors.Arrow;
            labelOver.Background = labelColor;
        }

        private void MenuLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            Label labelOver = (Label)sender;
            labelColor = labelOver.Background;
            labelOver.Cursor = Cursors.Hand;
            labelOver.Background = Brushes.Green;
        }
        public List<Label> returnLabels()
        {
            return menuLabels;
        }
    }
}