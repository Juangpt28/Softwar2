namespace Softwar2
{
    partial class grbEmpleado
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
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblGradoMaximoDeEstudios = new System.Windows.Forms.Label();
            this.grbDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboGradoMaximoDeEstudios = new System.Windows.Forms.ComboBox();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.grbDatosEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(32, 183);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(59, 20);
            this.lblSueldo.TabIndex = 3;
            this.lblSueldo.Text = "Sueldo";
            this.lblSueldo.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(32, 133);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(54, 20);
            this.lblGrupo.TabIndex = 1;
            this.lblGrupo.Text = "Grupo";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(333, 115);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(333, 72);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(47, 20);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad";
            this.lblEdad.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblGradoMaximoDeEstudios
            // 
            this.lblGradoMaximoDeEstudios.AutoSize = true;
            this.lblGradoMaximoDeEstudios.Location = new System.Drawing.Point(333, 170);
            this.lblGradoMaximoDeEstudios.Name = "lblGradoMaximoDeEstudios";
            this.lblGradoMaximoDeEstudios.Size = new System.Drawing.Size(203, 20);
            this.lblGradoMaximoDeEstudios.TabIndex = 6;
            this.lblGradoMaximoDeEstudios.Text = "Grado Maximo De Estudios";
            this.lblGradoMaximoDeEstudios.Click += new System.EventHandler(this.label6_Click);
            // 
            // grbDatosEmpleado
            // 
            this.grbDatosEmpleado.Controls.Add(this.btnCapturar);
            this.grbDatosEmpleado.Controls.Add(this.dtpFecha);
            this.grbDatosEmpleado.Controls.Add(this.cboGradoMaximoDeEstudios);
            this.grbDatosEmpleado.Controls.Add(this.cboGrupo);
            this.grbDatosEmpleado.Controls.Add(this.txtSueldo);
            this.grbDatosEmpleado.Controls.Add(this.txtNombre);
            this.grbDatosEmpleado.Controls.Add(this.lblGradoMaximoDeEstudios);
            this.grbDatosEmpleado.Controls.Add(this.lblNombre);
            this.grbDatosEmpleado.Controls.Add(this.lblEdad);
            this.grbDatosEmpleado.Controls.Add(this.lblFecha);
            this.grbDatosEmpleado.Controls.Add(this.lblGrupo);
            this.grbDatosEmpleado.Controls.Add(this.lblSueldo);
            this.grbDatosEmpleado.Location = new System.Drawing.Point(12, 12);
            this.grbDatosEmpleado.Name = "grbDatosEmpleado";
            this.grbDatosEmpleado.Size = new System.Drawing.Size(772, 255);
            this.grbDatosEmpleado.TabIndex = 0;
            this.grbDatosEmpleado.TabStop = false;
            this.grbDatosEmpleado.Text = "Datos De Empleado";
            this.grbDatosEmpleado.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(504, 206);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(85, 34);
            this.btnCapturar.TabIndex = 15;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(389, 110);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 26);
            this.dtpFecha.TabIndex = 14;
            // 
            // cboGradoMaximoDeEstudios
            // 
            this.cboGradoMaximoDeEstudios.FormattingEnabled = true;
            this.cboGradoMaximoDeEstudios.Location = new System.Drawing.Point(542, 162);
            this.cboGradoMaximoDeEstudios.Name = "cboGradoMaximoDeEstudios";
            this.cboGradoMaximoDeEstudios.Size = new System.Drawing.Size(121, 28);
            this.cboGradoMaximoDeEstudios.TabIndex = 13;
            // 
            // cboGrupo
            // 
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Location = new System.Drawing.Point(100, 130);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(121, 28);
            this.cboGrupo.TabIndex = 12;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(100, 180);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(175, 26);
            this.txtSueldo.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 26);
            this.txtNombre.TabIndex = 9;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(48, 301);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.Size = new System.Drawing.Size(829, 316);
            this.dgvDatos.TabIndex = 1;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // grbEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 652);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.grbDatosEmpleado);
            this.Name = "grbEmpleado";
            this.Text = "EMPLEADO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDatosEmpleado.ResumeLayout(false);
            this.grbDatosEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblGradoMaximoDeEstudios;
        private System.Windows.Forms.GroupBox grbDatosEmpleado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboGradoMaximoDeEstudios;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}

