namespace TallerPractico1POO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnDestacados = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblPromedioGral = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(126, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(289, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(126, 105);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(289, 20);
            this.txtCarnet.TabIndex = 1;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(126, 157);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(289, 20);
            this.txtCarrera.TabIndex = 2;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(126, 206);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(289, 20);
            this.txtPromedio.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(149, 306);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(240, 306);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(119, 23);
            this.btnMostrarTodos.TabIndex = 5;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnDestacados
            // 
            this.btnDestacados.Location = new System.Drawing.Point(149, 349);
            this.btnDestacados.Name = "btnDestacados";
            this.btnDestacados.Size = new System.Drawing.Size(75, 23);
            this.btnDestacados.TabIndex = 6;
            this.btnDestacados.Text = "Destacados";
            this.btnDestacados.UseVisualStyleBackColor = true;
            this.btnDestacados.Click += new System.EventHandler(this.btnDestacados_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(240, 349);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(119, 23);
            this.btnPromedio.TabIndex = 7;
            this.btnPromedio.Text = "Promedio General";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(623, 20);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(60, 13);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultados";
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(505, 36);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.Size = new System.Drawing.Size(300, 365);
            this.dgvEstudiantes.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(42, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Location = new System.Drawing.Point(42, 112);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(41, 13);
            this.lblCarnet.TabIndex = 11;
            this.lblCarnet.Text = "Carnet:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(42, 164);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(44, 13);
            this.lblCarrera.TabIndex = 12;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(42, 213);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(54, 13);
            this.lblPromedio.TabIndex = 13;
            this.lblPromedio.Text = "Promedio:";
            // 
            // lblPromedioGral
            // 
            this.lblPromedioGral.AutoSize = true;
            this.lblPromedioGral.Location = new System.Drawing.Point(502, 416);
            this.lblPromedioGral.Name = "lblPromedioGral";
            this.lblPromedioGral.Size = new System.Drawing.Size(97, 13);
            this.lblPromedioGral.TabIndex = 14;
            this.lblPromedioGral.Text = "Promedio General: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPromedioGral);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblCarnet);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.btnDestacados);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "frmEstudiante";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnDestacados;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblPromedioGral;
    }
}

