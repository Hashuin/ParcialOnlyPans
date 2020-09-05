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
    /// Lógica de interacción para Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bienvenid@ Administrador");
        }

        private void LstPrecio_Loaded(object sender, RoutedEventArgs e)
        {
            lstPrecio.Items.Add("Pan Aliñado = 1000");
            lstPrecio.Items.Add("Pan no Aliñado= 500");
            lstPrecio.Items.Add("Pan Especial = 2000");
        }



        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserControl1());
        }

    }
}
