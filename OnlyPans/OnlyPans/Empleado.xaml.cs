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
    /// Lógica de interacción para Empleado.xaml
    /// </summary>
    public partial class Empleado : Page
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtValue.Text = Slider.Value.ToString();
        }

        private void BtnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            DateTime Now = DateTime.Now;
            lstBox.Items.Add(txtClient.Text+": "+txtCedula.Text+"\n"+txtPanes.Text+ ": " + txtValue.Text+" : "+DateTime.Now);
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            int n1;
            n1 = Convert.ToInt32(txtValue.Text);
            int total = 0;
            if (txtPanes.Text == "Pan aliñado") 
            total = (total + 1000) * n1;
            if (txtPanes.Text == "Pan no aliñado")
                total = (total + 500) * n1;
            if (txtPanes.Text == "Pan especial")
                total = (total + 2000) * n1;

            lstTotal.Items.Add("Las ventas totales son: "+total);

        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserControl1());
        }

    }
}
