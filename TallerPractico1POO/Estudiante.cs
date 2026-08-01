using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TallerPractico1POO
{
    internal class Estudiante
    {
        //propiedades del estudiante
        public string Nombre { get; set; }
        public string Carnet { get; set; }
        public string Carrera { get; set; }
        public double Promedio { get; set; }

        //constructor 
        public Estudiante(string nombre, string carnet, string carrera, double promedio)
        {
            Nombre = nombre;
            Carnet = carnet;
            Carrera = carrera;
            Promedio = promedio;
        }

        

        //método que indica si el estudiante es destacado (promedio mayor a 8.0)
        public bool EsDestacado()
        {
            if (Promedio > 8.0) //verifica si el promedio supera 8.0
                return true;
            else
                return false;
        }

    }
}
