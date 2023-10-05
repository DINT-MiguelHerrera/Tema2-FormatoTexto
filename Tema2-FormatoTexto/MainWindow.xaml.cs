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

namespace Tema2_FormatoTexto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void recuadroEscritura_TextChanged(object sender, TextChangedEventArgs e)
        {
            recuadroMuestraTexto.Text = recuadroEscritura.Text;
        }

        private void checkboxNegrita_Checked(object sender, RoutedEventArgs e)
        {
            
            recuadroMuestraTexto.FontWeight = FontWeights.Bold;
        }

        private void checkboxCursiva_Checked(object sender, RoutedEventArgs e)
        {
            recuadroMuestraTexto.FontStyle = FontStyles.Italic;
        }

        private void checkboxNegrita_Unchecked(object sender, RoutedEventArgs e)
        {
            recuadroMuestraTexto.FontWeight = FontWeights.Normal;
        }

        private void checkboxCursiva_Unchecked(object sender, RoutedEventArgs e)
        {
            recuadroMuestraTexto.FontStyle = FontStyles.Normal;
        }

        private void botonColorAzul_Checked(object sender, RoutedEventArgs e)
        {
            recuadroMuestraTexto.Foreground = Brushes.Blue;
        }

        private void botonColorRojo_Checked(object sender, RoutedEventArgs e)
        {
            recuadroMuestraTexto.Foreground = Brushes.Red;
        }

        private void botonColorVerde_Checked(object sender, RoutedEventArgs e)
        {
            recuadroMuestraTexto.Foreground = Brushes.Green;
        }
    }
}
