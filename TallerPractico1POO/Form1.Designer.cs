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
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnMostrarTodos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDestacados = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPromedio = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblCarnet = new MaterialSkin.Controls.MaterialLabel();
            this.lblCarrera = new MaterialSkin.Controls.MaterialLabel();
            this.lblPromedio = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblResultado = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(168, 105);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(384, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(168, 169);
            this.txtCarnet.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(384, 22);
            this.txtCarnet.TabIndex = 1;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(168, 222);
            this.txtCarrera.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(384, 22);
            this.txtCarrera.TabIndex = 2;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(168, 280);
            this.txtPromedio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(384, 22);
            this.txtPromedio.TabIndex = 3;
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(605, 79);
            this.dgvEstudiantes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.RowHeadersWidth = 51;
            this.dgvEstudiantes.Size = new System.Drawing.Size(644, 449);
            this.dgvEstudiantes.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(46, 103);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 24);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(54, 380);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(90, 23);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Depth = 0;
            this.btnMostrarTodos.Location = new System.Drawing.Point(168, 380);
            this.btnMostrarTodos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Primary = true;
            this.btnMostrarTodos.Size = new System.Drawing.Size(161, 23);
            this.btnMostrarTodos.TabIndex = 18;
            this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnDestacados
            // 
            this.btnDestacados.Depth = 0;
            this.btnDestacados.Location = new System.Drawing.Point(54, 430);
            this.btnDestacados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDestacados.Name = "btnDestacados";
            this.btnDestacados.Primary = true;
            this.btnDestacados.Size = new System.Drawing.Size(161, 23);
            this.btnDestacados.TabIndex = 19;
            this.btnDestacados.Text = "Destacados";
            this.btnDestacados.UseVisualStyleBackColor = true;
            this.btnDestacados.Click += new System.EventHandler(this.btnDestacados_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Depth = 0;
            this.btnPromedio.Location = new System.Drawing.Point(238, 430);
            this.btnPromedio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Primary = true;
            this.btnPromedio.Size = new System.Drawing.Size(185, 23);
            this.btnPromedio.TabIndex = 20;
            this.btnPromedio.Text = "Promedio General";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Depth = 0;
            this.lblCarnet.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCarnet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCarnet.Location = new System.Drawing.Point(46, 167);
            this.lblCarnet.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(69, 24);
            this.lblCarnet.TabIndex = 21;
            this.lblCarnet.Text = "Carnet:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Depth = 0;
            this.lblCarrera.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCarrera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCarrera.Location = new System.Drawing.Point(46, 220);
            this.lblCarrera.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(75, 24);
            this.lblCarrera.TabIndex = 22;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Depth = 0;
            this.lblPromedio.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPromedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPromedio.Location = new System.Drawing.Point(46, 280);
            this.lblPromedio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(98, 24);
            this.lblPromedio.TabIndex = 23;
            this.lblPromedio.Text = "Promedio:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(601, 36);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(95, 24);
            this.materialLabel1.TabIndex = 24;
            this.materialLabel1.Text = "Resultado";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Depth = 0;
            this.lblResultado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblResultado.Location = new System.Drawing.Point(601, 548);
            this.lblResultado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(170, 24);
            this.lblResultado.TabIndex = 25;
            this.lblResultado.Text = "Promedio general: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 609);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblCarnet);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.btnDestacados);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.txtNombre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Estudiante";
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
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
        private MaterialSkin.Controls.MaterialRaisedButton btnMostrarTodos;
        private MaterialSkin.Controls.MaterialRaisedButton btnDestacados;
        private MaterialSkin.Controls.MaterialRaisedButton btnPromedio;
        private MaterialSkin.Controls.MaterialLabel lblCarnet;
        private MaterialSkin.Controls.MaterialLabel lblCarrera;
        private MaterialSkin.Controls.MaterialLabel lblPromedio;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblResultado;
    }
}

