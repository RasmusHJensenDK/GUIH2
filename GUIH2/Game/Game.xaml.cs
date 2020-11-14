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
        private List<StackPanel> _GAMEOBJECTS = new List<StackPanel>();
        private string[] _GAMETEXT =
        {
            "Russia",
            "North Korea",
            "Germany",
            "France",
            "China",
            "USA"
        };
        private string[] _GAMEQUESTIONS =
        {
            "",
            "",
            "",
            "",
            "",
            ""
        };
        public Game()
        {
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\wwwroot\GUIH2\GUIH2\Media\map.jpg")));
            _GAMEOBJECTS.Add(CreateStackPanel());
            _GAMEOBJECTS.Add(CreateSecondStackPanel());
            InitializeComponent();
            foreach (StackPanel p in _GAMEOBJECTS)
            {
                GameGrid.Children.Add(p);
            }
        }

        private void MoveIt(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) this.DragMove();
        }
        private void AddGameCards()
        {
            for (int i = 0; i < 3; i++)
            {
                CharacterSelection CS = new CharacterSelection();
                GameLabel GML = new GameLabel(_GAMETEXT[i], Brushes.White, Brushes.Black);
                GameCard GameCard = new GameCard(CS.returnCharacter(0), GML);
                _GAMECARDLIST.Add(GameCard);
            }
        }
        private void AddSecondGameCards()
        {
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
            stp.Orientation = Orientation.Vertical;
            AddGameCards();
            foreach (GameCard GC in _GAMECARDLIST)
            {
                stp.Children.Add(GC.CreateCard(300, 200));
            }
            return stp;
        }
        private StackPanel CreateSecondStackPanel()
        {
            StackPanel stp = new StackPanel();
            stp.Orientation = Orientation.Horizontal;
            AddSecondGameCards();
            foreach (GameCard GC in _GAMESECONDLIST)
            {
                stp.Children.Add(GC.CreateCard(300, 200));
            }
            return stp;
        }
    }
}
