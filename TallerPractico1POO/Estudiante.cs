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

        //método estático que calcula el promedio general de una lista de estudiantes
        public static double CalcularPromedioGeneral(List<Estudiante> estudiantes)
        {
            double suma = 0;

            for (int i = 0; i < estudiantes.Count; i++) //recorremos la lista completa
            {
                suma = suma + estudiantes[i].Promedio; //sumamos el promedio de cada estudiante
            }

            if (estudiantes.Count > 0)
            {
                return suma / estudiantes.Count;
            }
            else
            {
                return 0;
            }
        }
        public static void ObtenerDestacados(List<Estudiante> destacados, List<Estudiante> estudiantes)
        {
            destacados.Clear();
            for (int i = 0; i < estudiantes.Count; i++)
            {
                if (estudiantes[i].Promedio > 8.0)
                {
                    destacados.Add(estudiantes[i]);
                }
            }
        }

    }
}
