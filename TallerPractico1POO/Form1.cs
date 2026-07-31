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
        //lista para estudiantes destacados
        private List<Estudiante> listaDestacados = new List<Estudiante>();
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
        // Para mostrar solo estudiantes destacados
        private void MostrarDestacados()
        {
            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = listaDestacados;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
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

                double promedio = double.Parse(txtPromedio.Text.Trim());


                if (promedio < 0 || promedio > 10)
                {
                    MessageBox.Show("El promedio debe estar entre 0 y 10.", "Inválido",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Agrega el/los estudiantes a la lista

                Estudiante nuevoEstudiante = new Estudiante(nombre, carnet, carrera, promedio);
                listaEstudiantes.Add(nuevoEstudiante);

                //Agrega el/los estudiantes cuyo promedio es mayor a 8 la lista de destacados

                if (promedio > 8)
                    listaDestacados.Add(nuevoEstudiante);

                MessageBox.Show("Estudiante agregado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


                LimpiarCampos();
                MostrarTodos();
            }
            catch (FormatException)
            {
                MessageBox.Show("El promedio debe ser un número válido. (del 0 al 10)", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDestacados_Click(object sender, EventArgs e)
        {
            MostrarDestacados();

        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            MostrarTodos();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            if (listaEstudiantes.Count == 0) //validamos que haya al menos un estudiante
            {
                lblResultado.Text = "No hay estudiantes registrados.";
                return;
            }

            //llamamos al método estático de la clase Estudiante, mandándole la lista
            double promedioGeneral = Estudiante.CalcularPromedioGeneral(listaEstudiantes);

            lblResultado.Text = "Promedio general: " + promedioGeneral.ToString("F2");
        }

    }
}
