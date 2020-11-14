using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace GUIH2
{
    class GameLabel : Label
    {
        private string _TEXT { get; set; }
        private Brush _FOREGROUND { get; set; }
        private Brush _BACKGROUND { get; set; }
        public GameLabel(string text, Brush foreground, Brush background)
        {
            this._TEXT = text;
            this._FOREGROUND = foreground;
            this._BACKGROUND = background;
        }
        public Label DrawLabel(int width, int height, int fontSize = 12, int top = 0, int left = 0, int bottom = 0, int right = 0)
        {
            Label lbl = new Label()
            {
                Width = width,
                Height = height,
                Margin = new System.Windows.Thickness(top, left, bottom, right)
            };
            lbl.FontSize = fontSize;
            lbl.Content = _TEXT;
            lbl.Foreground = _FOREGROUND;
            lbl.Background = _BACKGROUND;
            return lbl;
        }
    }
}
