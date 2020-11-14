using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace GUIH2
{
    class GameCard
    {
        private Random random;
        private GameLabel _GAMELABEL { get; set; }
        private Character _CHARACTER { get; set; }

        public GameCard(Character character, GameLabel gameLabel)
        {
            this._CHARACTER = character;
            this._GAMELABEL = gameLabel;
        }

        public StackPanel CreateCard(int width, int height)
        {
            StackPanel card = new StackPanel()
            {
                Width = width,
                Height = height
            };
            card.Children.Add(_CHARACTER.returnImage());
            card.Children.Add(_GAMELABEL);
            card.Background = Brushes.White;
            return card;
        }
    }
}
