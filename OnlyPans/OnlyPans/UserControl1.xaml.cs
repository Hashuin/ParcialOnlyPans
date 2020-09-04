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

namespace OnlyPans
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void BntLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "admin" & txtPassword.Password == "1234"){
                MainWindow w = (MainWindow)Window.GetWindow(this);
                w.mainFrame.NavigationService.Navigate(new Admin());

            }

            else if (txtUsername.Text == "Empleado" & txtPassword.Password == "1234")
            {
                MainWindow w = (MainWindow)Window.GetWindow(this);
                w.mainFrame.NavigationService.Navigate(new Empleado());
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }



        }
    }
}
