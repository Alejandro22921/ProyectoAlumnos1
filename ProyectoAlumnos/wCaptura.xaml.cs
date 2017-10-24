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
    /// Interaction logic for wCaptura.xaml
    /// </summary>
    public partial class wCaptura : Window
    {
        Alumno alumno;
        int numeroCalificaciones = 0;

        public wCaptura()
        {
            InitializeComponent();
            alumno = new Alumno("");
        }

        private void txtCalificacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                try
                {
                    alumno.Calificaciones.Add(Convert.ToInt32(txtCalificacion.Text));
                    numeroCalificaciones++;
                    labelContador.Content = numeroCalificaciones.ToString();
                    txtCalificacion.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Campos inválidos.");
                }
            }
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Campos inválidos.");
            }
            else
            {
                alumno.Nombre = txtNombre.Text;
                MainWindow.lista.Add(alumno);
                Close();
            }
        }
    }
}
