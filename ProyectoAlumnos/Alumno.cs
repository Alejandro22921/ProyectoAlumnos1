using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAlumnos
{
    public class Alumno
    {
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        List<int> calificaciones;
        public List<int> Calificaciones
        {
            get { return calificaciones; }
            set { calificaciones = value; }
        }

        //Constructor.

        public Alumno(string nombre)
        {
            this.nombre = nombre;
            calificaciones = new List<int>();
        }

        public double Promedio()
        {
            if (calificaciones.Count > 0)
                return (double)calificaciones.Average();
            else
                return 0.0;
        }
    }
}
