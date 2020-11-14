using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace GUIH2.Controls
{
    class FreshButton
    {
        private int _BTNWIDTH { get; set; }
        private int _BTNHEIGHT { get; set; }
        private Brush _BTNFORECOLOR { get; set; }
        private Brush _BTNBACKCOLOR { get; set; }
        private string _BTNTEXT { get; set; }

        public FreshButton(string _BTNTEXT, Brush _BTNFORECOLOR, Brush _BTNBACKCOLOR, int _BTNWIDTH = 100, int _BTNHEIGHT = 50)
        {
            this._BTNWIDTH = _BTNWIDTH;
            this._BTNHEIGHT = _BTNHEIGHT;
            this._BTNFORECOLOR = _BTNFORECOLOR;
            this._BTNBACKCOLOR = _BTNBACKCOLOR;
            this._BTNTEXT = _BTNTEXT;
        }

        public Button DrawButton(double top, double left, double bottom, double right)
        {
            Button btn = new Button()
            {
                Width = _BTNWIDTH,
                Height = _BTNHEIGHT,
                Margin =  new System.Windows.Thickness(top, left, bottom, right)
            };
            btn.Background = _BTNBACKCOLOR;
            btn.Foreground = _BTNFORECOLOR;
            btn.Content = _BTNTEXT;
            return btn;
        }
    }
}
 