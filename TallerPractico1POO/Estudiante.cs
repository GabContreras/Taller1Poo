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
        //campos privados (backing fields) que respaldan las propiedades
        private string nombre;
        private string carnet;
        private string carrera;
        private double promedio;

        //propiedades del estudiante, ahora con validación incorporada en el set
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                nombre = value.Trim();
            }
        }

        public string Carnet
        {
            get { return carnet; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El carnet no puede estar vacío.");
                carnet = value.Trim();
            }
        }

        public string Carrera
        {
            get { return carrera; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La carrera no puede estar vacía.");
                carrera = value.Trim();
            }
        }

        public double Promedio
        {
            get { return promedio; }
            set
            {
                //el promedio debe estar dentro del rango permitido (0 a 10)
                if (value < 0 || value > 10)
                    throw new ArgumentException("El promedio debe estar entre 0 y 10.");
                promedio = value;
            }
        }

        //constructor: al asignar mediante las propiedades, las validaciones se ejecutan solas
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