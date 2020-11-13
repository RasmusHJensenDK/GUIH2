using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using System.Runtime.InteropServices;

namespace GUIH2
{
    public partial class MainWindow : Window
    {
        private string username = "Username";
        private string password = "Password";
        public MainWindow()
        {
            InitializeComponent();
            un.Text = username;
            pw.Text = password;
        }
        //Lobby
        private void enterShoppinggrounds_Click(object sender, RoutedEventArgs e)
        {
            //Check DB for username & password here AND THEN open the lobby..
            Lobby lobby = new Lobby(un.ToString())
            {
                Title = un.Text
            };
            lobby.Show();
            this.Hide();
        }
        //Dragable
        private void DragIt(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) this.DragMove();
        }
        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(un.Text))
                un.Text = "Username";
        }
        private void MouseEnterRemoveText(object sender, MouseEventArgs e)
        {
            if (un.Text == "Username")
            {
                un.Text = "";
            }
        }
        private void MouseLeaveUN(object sender, MouseEventArgs e)
        {
            if (un.Text == "")
            {
                un.Text = "Username";
            }
        }
        private void pw_MouseEnter(object sender, MouseEventArgs e)
        {
            if (pw.Text == "Password")
            {
                pw.Text = "";
            }
        }
        private void pw_MouseLeave(object sender, MouseEventArgs e)
        {
            if (pw.Text == "")
            {
                pw.Text = "Password";
            }
        }
    }
}
