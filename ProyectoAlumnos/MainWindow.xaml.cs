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

namespace ProyectoAlumnos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Alumno> lista;
        public MainWindow()
        {
            InitializeComponent();
            lista = new List<Alumno>();
        }

        private void menuSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void menuAgregar_Click(object sender, RoutedEventArgs e)
        {
            wCaptura ventana = new wCaptura();
            ventana.ShowDialog();
        }

        private void menuConsulta_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuLista_Click(object sender, RoutedEventArgs e)
        {
            (new wLista()).ShowDialog();
        }

        private void menuEstadisticas_Click(object sender, RoutedEventArgs e)
        {
            (new wEstadisticas()).ShowDialog();
        }

        private void menuAcercaDe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Acerca de...\nCreado por:\nAlejandro Hernández Villa\nIssac Vladimir");
        }
    }
}
