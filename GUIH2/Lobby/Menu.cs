using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace GUIH2
{
    class Menu
    {
        private string[] menuItems = { "New Game", "Resume Game", "Options", "Exit" };
        private Brush[] bruches = { Brushes.Red, Brushes.Black, Brushes.Black, Brushes.Black };
        private List<Label> menuLabels = new List<Label>();
        private List<DrawCharacterBox> characterBoxes = new List<DrawCharacterBox>();
        private Brush labelColor { get; set; }
        private Lobby myParent;

        public Menu()
        {
            LoadCharacters();
            DrawMenu();
        }
        public Menu(Lobby parent)
        {   
            DrawMenu();
            myParent = parent;
            LoadCharacters();
            foreach (Label lbl in returnLabels())
            {
                myParent.LobbyGrid.Children.Add(lbl);
            }
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
               if(labelDown.Content.ToString() == "New Game")
                {
                    myParent.LobbyGrid.Children.Clear();
                    int k = 0;
                    foreach(DrawCharacterBox DCB in returnDCBList())
                    {
                        myParent.LobbyGrid.Children.Add(DCB.StackView(-550 + k, 0, 0, 0));
                        k = k + 550;
                    }
                }
                if (labelDown.Content.ToString() == "Resume Game")
                {
                    
                }
                if (labelDown.Content.ToString() == "Options")
                {

                }
                if (labelDown.Content.ToString() == "Exit")
                {
                }
            }
        }
        public List<DrawCharacterBox> returnDCBList()
        {
            return characterBoxes;
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
        public void LoadCharacters()
        {
            int i = 0;
            CharacterSelection CS = new CharacterSelection();
            foreach (Character characters in CS.returnCharacterlist())
            {
                DrawCharacterBox DCB = new DrawCharacterBox(CS.returnCharacter(i), CS.returnCharacterImageUri(i), myParent);
                characterBoxes.Add(DCB);
                i++;
            }
        }
    }
}