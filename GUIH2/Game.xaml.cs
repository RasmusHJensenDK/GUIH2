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
        private List<GameCard> _GAMESECONDLIST = new List<GameCard>();
        private string[] _GAMETEXT =
        {
            "First String",
            "Second String",
            "Third String",
            "Foruth String",
            "Fifth String",
            "Sixth String"
        };
        public Game()
        {
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\wwwroot\GUIH2\GUIH2\Media\map.jpg")));
            InitializeComponent();
            GameGrid.Children.Add(CreateStackPanel());
            GameGrid.Children.Add(CreateSecondStackPanel());
        }

        private void MoveIt(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) this.DragMove();
        }
        private void AddGameCards()
        {
            for(int i = 0; i < 3; i++)
            {
                CharacterSelection CS = new CharacterSelection();
                GameLabel GML = new GameLabel(_GAMETEXT[i], Brushes.White, Brushes.Black);
                GameCard GameCard = new GameCard(CS.returnCharacter(0), GML);
                _GAMECARDLIST.Add(GameCard);
            }
            for (int i = 0; i < 3; i++)
            {
                CharacterSelection CS = new CharacterSelection();
                GameLabel GML = new GameLabel(_GAMETEXT[i], Brushes.White, Brushes.Black);
                GameCard GameCard = new GameCard(CS.returnCharacter(0), GML);
                _GAMESECONDLIST.Add(GameCard);
            }

        }
        private StackPanel CreateStackPanel()
        {
            StackPanel stp = new StackPanel();
            stp.Orientation = Orientation.Horizontal;
            AddGameCards();
            foreach(GameCard GC in _GAMECARDLIST)
            {
                stp.Children.Add(GC.CreateCard(300, 200));
            }
            return stp;
        }
        private StackPanel CreateSecondStackPanel()
        {
            StackPanel stp = new StackPanel();
            stp.Orientation = Orientation.Vertical;
            AddGameCards();
            foreach (GameCard GC in _GAMESECONDLIST)
            {
                stp.Children.Add(GC.CreateCard(300, 200));
            }
            return stp;
        }

    }
}
