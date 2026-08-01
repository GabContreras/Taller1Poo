using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerPractico1POO
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {

        //lista para guardar los estudiantes que se creen
        private List<Estudiante> listaEstudiantes = new List<Estudiante>();
      
        public Form1()
        {
            InitializeComponent();
        }

        // Método para limpiar los TextBox después de agregar
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCarnet.Clear();
            txtCarrera.Clear();
            txtPromedio.Clear();
            txtNombre.Focus();
        }
        // Para actualizar el datagridview
        private void MostrarTodos()
        {
            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = listaEstudiantes;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Trim quita espacios en blanco al inicio/final

            string nombre = txtNombre.Text.Trim();
            string carnet = txtCarnet.Text.Trim();
            string carrera = txtCarrera.Text.Trim();

            //esto es mejor que utilizar "" ya que string.IsNullOrEmpty() verifica directamente si es nulo o está vacio, cosa que no pasa con
            //"" que solo verifica si está vacio, pero no si es nulo
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(carnet) || string.IsNullOrEmpty(carrera))
            {
                MessageBox.Show("Completar todos los campos.", "Incompleto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TryParse intenta convertir el texto a double SIN lanzar excepción si falla.
            // Devuelve true/false según si la conversión fue exitosa, y guarda el resultado en "promedio" (parámetro out).
            // Si el texto no es un número válido (vacío, letras, etc.), TryParse devuelve false,
            // se muestra el error y se corta la ejecución con return.

            if (!double.TryParse(txtPromedio.Text.Trim(), out double promedio))
            {
                MessageBox.Show("El promedio debe ser un número válido. (del 0 al 10)", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (promedio < 0 || promedio > 10)
            {
                MessageBox.Show("El promedio debe estar entre 0 y 10.", "Inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Agrega el/los estudiantes a la lista

            Estudiante nuevoEstudiante = new Estudiante(nombre, carnet, carrera, promedio);
            listaEstudiantes.Add(nuevoEstudiante);

            MessageBox.Show("Estudiante agregado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


            LimpiarCampos();
            MostrarTodos();
        }

        private void btnDestacados_Click(object sender, EventArgs e)
        {
            //lista temporal para guardar solo los estudiantes destacados
            //se crea nueva cada vez que se presiona el botón, para no arrastrar datos de clics anteriores
            List<Estudiante> destacados = new List<Estudiante>();

            for (int i = 0; i < listaEstudiantes.Count; i++)
            {
                if (listaEstudiantes[i].EsDestacado()) //Se evalua si cada estudiante es destacado o no
                                                     
                {
                    destacados.Add(listaEstudiantes[i]); //si cumple la condición, se agrega a la lista temporal
                }
            }

            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = destacados; 
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            MostrarTodos();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            if (listaEstudiantes.Count == 0) //valida que haya al menos un estudiante registrado
            {
                lblResultado.Text = "No hay estudiantes registrados.";
                return;
            }

            double suma = 0; //acumulador de promedios

            for (int i = 0; i < listaEstudiantes.Count; i++) //recorre toda la lista de estudiantes
            {
                suma = suma + listaEstudiantes[i].Promedio; //suma el promedio de cada estudiante
            }

            double promedioGeneral = suma / listaEstudiantes.Count; //divide entre la cantidad total de estudiantes

            lblResultado.Text = "Promedio general: " + promedioGeneral.ToString("F2"); //se muestra el resultado con 2 decimales
        }

    }
}
