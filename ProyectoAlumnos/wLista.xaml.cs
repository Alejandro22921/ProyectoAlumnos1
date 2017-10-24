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
using System.Windows.Shapes;

namespace ProyectoAlumnos
{
    /// <summary>
    /// Interaction logic for wLista.xaml
    /// </summary>
    public partial class wLista : Window
    {
        public wLista()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Alumno alumno in MainWindow.lista)
            {
                textBlockLista.Text += string.Format("{0,-90} {1,15:0.00}\n", alumno.Nombre, alumno.Promedio() );
            }
        }
    }
}
