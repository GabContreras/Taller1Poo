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

            for (int i = 0; i < estudiantes.Count; i++) //recorre la lista completa
            {
                suma = suma + estudiantes[i].Promedio; //suma el promedio de cada estudiante
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

        //Filtra los estudiantes destacados (promedio mayor a 8.0)
        //recibe dos listas: "destacados" es la que se va a llenar, "estudiantes" es la lista completa de donde se filtra
        public static void ObtenerDestacados(List<Estudiante> destacados, List<Estudiante> estudiantes)
        {
            destacados.Clear(); //limpia la lista de destacados antes de volver a llenarla para evitar que se acumulen duplicados cada vez que se presiona el botón
            for (int i = 0; i < estudiantes.Count; i++) 
            {
                if (estudiantes[i].Promedio > 8.0)
                {
                    destacados.Add(estudiantes[i]); //si cumple la condición, se agrega a la lista de destacados
                }
            }
        }

    }
}
