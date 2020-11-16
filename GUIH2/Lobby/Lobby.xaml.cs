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
        public Lobby(string username)
        {
            this.username = username;
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\wwwroot\GUIH2\GUIH2\Media\522618.jpg")));
            InitializeComponent();
            Menu menu = new Menu(this);
        }
        private void DragAble(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) this.DragMove();
        }
        public string GetUsername()
        {
            return username;
        }
    }
}