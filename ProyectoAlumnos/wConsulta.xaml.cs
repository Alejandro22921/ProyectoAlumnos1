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
    /// Interaction logic for wConsulta.xaml
    /// </summary>
    public partial class wConsulta : Window
    {
        public wConsulta()
        {
            InitializeComponent();
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            string nombre = txtNombre.Text;
            if (e.Key == Key.Return)
            {
                cmbCalificaciones.Items.Clear();
                try
                {
                    Alumno alumno= MainWindow.lista.Find(x =>x.Nombre==nombre);
                    txtPromedio.Text = Convert.ToString(alumno.Promedio());
                    foreach(int calificacion in alumno.Calificaciones){
                        cmbCalificaciones.Items.Add(calificacion);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Nombre no encontrado");
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
