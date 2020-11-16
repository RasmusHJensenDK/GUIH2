using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace GUIH2
{
    class GameShop
    {
        public StackPanel DrawShop(string country)
        {
            StackPanel shop = new StackPanel()
            {
                Width = 940,
                Height = 400,
                Margin = new System.Windows.Thickness(0,10,0,0)
            };
            shop.Background = Brushes.DeepSkyBlue;
            shop.Children.Add(lblInformation(country));
            return shop;
        }
        public Label lblInformation(string country)
        {
            GameLabel lbl = new GameLabel("SHOP japoefjøpofewjøafjwfpoijwaøefpjewfp" + country, Brushes.Red, Brushes.Transparent);
            return lbl.DrawLabel(100, 100, fontSize: 20);
        }
    }
}
