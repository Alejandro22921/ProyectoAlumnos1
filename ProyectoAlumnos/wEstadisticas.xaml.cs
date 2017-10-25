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
    /// Interaction logic for wEstadisticas.xaml
    /// </summary>
    public partial class wEstadisticas : Window
    {
        public wEstadisticas()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            if (MainWindow.lista.Count == 0)
            {
                txtPromGeneral.Text = "0.0";
                txtPromAprobados.Text = "0.0";
                txtPromNoAprobados.Text = "0.0";
            }
            else
            {
                double promGeneral = 0, contAprobado = 0, contNoAprobado = 0;
                foreach (Alumno alumno in MainWindow.lista)
                {
                    promGeneral += alumno.Promedio();
                    if (alumno.Promedio() >= 70)
                        contAprobado++;
                    else
                        contNoAprobado++;
                }

                txtPromGeneral.Text = Convert.ToString(promGeneral / MainWindow.lista.Count * 100);
                txtPromAprobados.Text = Convert.ToString(contAprobado / MainWindow.lista.Count * 100);
                txtPromNoAprobados.Text = Convert.ToString(contNoAprobado / MainWindow.lista.Count * 100);
            }
        }
    }
}
