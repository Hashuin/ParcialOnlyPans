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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            cbPanes.Items.Add("Pan Aliñado");
            cbPanes.Items.Add("Pan no aliñado");
            cbPanes.Items.Add("Pan Especial");
        }


        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtValue.Text = Slider.Value.ToString();
        }

        private void BtnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            lstBox.Items.Add(cbPanes.Text+": "+txtValue.Text+" Und");
            
        }
    }
}
