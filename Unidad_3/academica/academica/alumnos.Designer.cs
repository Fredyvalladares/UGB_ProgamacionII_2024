namespace academica {
    partial class alumnos {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.grbDatosAlumnos = new System.Windows.Forms.GroupBox();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.txtNotapromedio = new System.Windows.Forms.TextBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.txtNotalab2 = new System.Windows.Forms.TextBox();
            this.txtNotalab1 = new System.Windows.Forms.TextBox();
            this.lblNotalab2 = new System.Windows.Forms.Label();
            this.lblnlab1 = new System.Windows.Forms.Label();
            this.txtnota_parcialAlumno = new System.Windows.Forms.TextBox();
            this.lblNparcial = new System.Windows.Forms.Label();
            this.txtgeneroAlumno = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtedadAlumno = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.txtCodigoAlumno = new System.Windows.Forms.TextBox();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.grbNavegacionAlumno = new System.Windows.Forms.GroupBox();
            this.lblNRegistroAlumno = new System.Windows.Forms.Label();
            this.btnUltimoAlumno = new System.Windows.Forms.Button();
            this.btnSiguienteAlumno = new System.Windows.Forms.Button();
            this.btnAnteriorAlumno = new System.Windows.Forms.Button();
            this.btnPrimeroAlumno = new System.Windows.Forms.Button();
            this.grbEdicionAlumno = new System.Windows.Forms.GroupBox();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.grdDatosAlumno = new System.Windows.Forms.DataGridView();
            this.idAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota_parcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarAlumno = new System.Windows.Forms.TextBox();
            this.lblBuscarAlumno = new System.Windows.Forms.Label();
            this.grbDatosAlumnos.SuspendLayout();
            this.grbNavegacionAlumno.SuspendLayout();
            this.grbEdicionAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosAlumnos
            // 
            this.grbDatosAlumnos.Controls.Add(this.btnPromedio);
            this.grbDatosAlumnos.Controls.Add(this.txtNotapromedio);
            this.grbDatosAlumnos.Controls.Add(this.lblPromedio);
            this.grbDatosAlumnos.Controls.Add(this.txtNotalab2);
            this.grbDatosAlumnos.Controls.Add(this.txtNotalab1);
            this.grbDatosAlumnos.Controls.Add(this.lblNotalab2);
            this.grbDatosAlumnos.Controls.Add(this.lblnlab1);
            this.grbDatosAlumnos.Controls.Add(this.txtnota_parcialAlumno);
            this.grbDatosAlumnos.Controls.Add(this.lblNparcial);
            this.grbDatosAlumnos.Controls.Add(this.txtgeneroAlumno);
            this.grbDatosAlumnos.Controls.Add(this.lblSexo);
            this.grbDatosAlumnos.Controls.Add(this.txtedadAlumno);
            this.grbDatosAlumnos.Controls.Add(this.lblEdad);
            this.grbDatosAlumnos.Controls.Add(this.txtNombreAlumno);
            this.grbDatosAlumnos.Controls.Add(this.lblNombreAlumno);
            this.grbDatosAlumnos.Controls.Add(this.txtCodigoAlumno);
            this.grbDatosAlumnos.Controls.Add(this.lblCodigoAlumno);
            this.grbDatosAlumnos.Enabled = false;
            this.grbDatosAlumnos.Location = new System.Drawing.Point(35, 27);
            this.grbDatosAlumnos.Name = "grbDatosAlumnos";
            this.grbDatosAlumnos.Size = new System.Drawing.Size(387, 381);
            this.grbDatosAlumnos.TabIndex = 0;
            this.grbDatosAlumnos.TabStop = false;
            this.grbDatosAlumnos.Text = "Datos";
            // 
            // btnPromedio
            // 
            this.btnPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromedio.Location = new System.Drawing.Point(240, 303);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(93, 43);
            this.btnPromedio.TabIndex = 17;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // txtNotapromedio
            // 
            this.txtNotapromedio.Location = new System.Drawing.Point(110, 313);
            this.txtNotapromedio.Name = "txtNotapromedio";
            this.txtNotapromedio.Size = new System.Drawing.Size(86, 20);
            this.txtNotapromedio.TabIndex = 16;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(6, 315);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(81, 18);
            this.lblPromedio.TabIndex = 14;
            this.lblPromedio.Text = "Promedio:";
            // 
            // txtNotalab2
            // 
            this.txtNotalab2.Location = new System.Drawing.Point(281, 251);
            this.txtNotalab2.Name = "txtNotalab2";
            this.txtNotalab2.Size = new System.Drawing.Size(52, 20);
            this.txtNotalab2.TabIndex = 13;
            // 
            // txtNotalab1
            // 
            this.txtNotalab1.Location = new System.Drawing.Point(110, 250);
            this.txtNotalab1.Name = "txtNotalab1";
            this.txtNotalab1.Size = new System.Drawing.Size(52, 20);
            this.txtNotalab1.TabIndex = 12;
            // 
            // lblNotalab2
            // 
            this.lblNotalab2.AutoSize = true;
            this.lblNotalab2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotalab2.Location = new System.Drawing.Point(186, 250);
            this.lblNotalab2.Name = "lblNotalab2";
            this.lblNotalab2.Size = new System.Drawing.Size(89, 18);
            this.lblNotalab2.TabIndex = 11;
            this.lblNotalab2.Text = "Nota Lab 2:";
            // 
            // lblnlab1
            // 
            this.lblnlab1.AutoSize = true;
            this.lblnlab1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnlab1.Location = new System.Drawing.Point(6, 249);
            this.lblnlab1.Name = "lblnlab1";
            this.lblnlab1.Size = new System.Drawing.Size(89, 18);
            this.lblnlab1.TabIndex = 10;
            this.lblnlab1.Text = "Nota Lab 1:";
            // 
            // txtnota_parcialAlumno
            // 
            this.txtnota_parcialAlumno.Location = new System.Drawing.Point(110, 199);
            this.txtnota_parcialAlumno.Name = "txtnota_parcialAlumno";
            this.txtnota_parcialAlumno.Size = new System.Drawing.Size(52, 20);
            this.txtnota_parcialAlumno.TabIndex = 9;
            // 
            // lblNparcial
            // 
            this.lblNparcial.AutoSize = true;
            this.lblNparcial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNparcial.Location = new System.Drawing.Point(6, 201);
            this.lblNparcial.Name = "lblNparcial";
            this.lblNparcial.Size = new System.Drawing.Size(98, 18);
            this.lblNparcial.TabIndex = 8;
            this.lblNparcial.Text = "Nota Parcial:";
            // 
            // txtgeneroAlumno
            // 
            this.txtgeneroAlumno.Location = new System.Drawing.Point(76, 155);
            this.txtgeneroAlumno.Name = "txtgeneroAlumno";
            this.txtgeneroAlumno.Size = new System.Drawing.Size(75, 20);
            this.txtgeneroAlumno.TabIndex = 7;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(6, 157);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(44, 18);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo";
            // 
            // txtedadAlumno
            // 
            this.txtedadAlumno.Location = new System.Drawing.Point(76, 115);
            this.txtedadAlumno.Name = "txtedadAlumno";
            this.txtedadAlumno.Size = new System.Drawing.Size(47, 20);
            this.txtedadAlumno.TabIndex = 5;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(6, 115);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(50, 18);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad:";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(76, 76);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(305, 20);
            this.txtNombreAlumno.TabIndex = 3;
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAlumno.Location = new System.Drawing.Point(6, 75);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(68, 18);
            this.lblNombreAlumno.TabIndex = 2;
            this.lblNombreAlumno.Text = "Nombre:";
            // 
            // txtCodigoAlumno
            // 
            this.txtCodigoAlumno.Location = new System.Drawing.Point(76, 39);
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";
            this.txtCodigoAlumno.Size = new System.Drawing.Size(160, 20);
            this.txtCodigoAlumno.TabIndex = 1;
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAlumno.Location = new System.Drawing.Point(6, 38);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(64, 18);
            this.lblCodigoAlumno.TabIndex = 0;
            this.lblCodigoAlumno.Text = "Codigo:";
            // 
            // grbNavegacionAlumno
            // 
            this.grbNavegacionAlumno.Controls.Add(this.lblNRegistroAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnUltimoAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnSiguienteAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnAnteriorAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnPrimeroAlumno);
            this.grbNavegacionAlumno.Location = new System.Drawing.Point(483, 323);
            this.grbNavegacionAlumno.Name = "grbNavegacionAlumno";
            this.grbNavegacionAlumno.Size = new System.Drawing.Size(247, 69);
            this.grbNavegacionAlumno.TabIndex = 1;
            this.grbNavegacionAlumno.TabStop = false;
            this.grbNavegacionAlumno.Text = "Navegacion";
            // 
            // lblNRegistroAlumno
            // 
            this.lblNRegistroAlumno.AutoSize = true;
            this.lblNRegistroAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRegistroAlumno.Location = new System.Drawing.Point(76, 31);
            this.lblNRegistroAlumno.Name = "lblNRegistroAlumno";
            this.lblNRegistroAlumno.Size = new System.Drawing.Size(49, 18);
            this.lblNRegistroAlumno.TabIndex = 10;
            this.lblNRegistroAlumno.Text = "x de n";
            // 
            // btnUltimoAlumno
            // 
            this.btnUltimoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoAlumno.Location = new System.Drawing.Point(206, 19);
            this.btnUltimoAlumno.Name = "btnUltimoAlumno";
            this.btnUltimoAlumno.Size = new System.Drawing.Size(37, 43);
            this.btnUltimoAlumno.TabIndex = 3;
            this.btnUltimoAlumno.Text = ">|";
            this.btnUltimoAlumno.UseVisualStyleBackColor = true;
            this.btnUltimoAlumno.Click += new System.EventHandler(this.btnUltimoAlumno_Click);
            // 
            // btnSiguienteAlumno
            // 
            this.btnSiguienteAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteAlumno.Location = new System.Drawing.Point(169, 19);
            this.btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            this.btnSiguienteAlumno.Size = new System.Drawing.Size(37, 43);
            this.btnSiguienteAlumno.TabIndex = 2;
            this.btnSiguienteAlumno.Text = ">";
            this.btnSiguienteAlumno.UseVisualStyleBackColor = true;
            this.btnSiguienteAlumno.Click += new System.EventHandler(this.btnSiguienteAlumno_Click);
            // 
            // btnAnteriorAlumno
            // 
            this.btnAnteriorAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorAlumno.Location = new System.Drawing.Point(39, 19);
            this.btnAnteriorAlumno.Name = "btnAnteriorAlumno";
            this.btnAnteriorAlumno.Size = new System.Drawing.Size(37, 43);
            this.btnAnteriorAlumno.TabIndex = 1;
            this.btnAnteriorAlumno.Text = "<";
            this.btnAnteriorAlumno.UseVisualStyleBackColor = true;
            this.btnAnteriorAlumno.Click += new System.EventHandler(this.btnAnteriorAlumno_Click);
            // 
            // btnPrimeroAlumno
            // 
            this.btnPrimeroAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroAlumno.Location = new System.Drawing.Point(2, 19);
            this.btnPrimeroAlumno.Name = "btnPrimeroAlumno";
            this.btnPrimeroAlumno.Size = new System.Drawing.Size(37, 43);
            this.btnPrimeroAlumno.TabIndex = 0;
            this.btnPrimeroAlumno.Text = "|<";
            this.btnPrimeroAlumno.UseVisualStyleBackColor = true;
            this.btnPrimeroAlumno.Click += new System.EventHandler(this.btnPrimeroAlumno_Click);
            // 
            // grbEdicionAlumno
            // 
            this.grbEdicionAlumno.Controls.Add(this.btnEliminarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnModificarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnAgregarAlumno);
            this.grbEdicionAlumno.Location = new System.Drawing.Point(737, 323);
            this.grbEdicionAlumno.Name = "grbEdicionAlumno";
            this.grbEdicionAlumno.Size = new System.Drawing.Size(347, 69);
            this.grbEdicionAlumno.TabIndex = 2;
            this.grbEdicionAlumno.TabStop = false;
            this.grbEdicionAlumno.Text = "Edicion";
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.Location = new System.Drawing.Point(192, 19);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(86, 43);
            this.btnEliminarAlumno.TabIndex = 13;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlumno.Location = new System.Drawing.Point(93, 19);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(97, 43);
            this.btnModificarAlumno.TabIndex = 12;
            this.btnModificarAlumno.Text = "Modificar";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            this.btnModificarAlumno.Click += new System.EventHandler(this.btnModificarAlumno_Click);
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumno.Location = new System.Drawing.Point(6, 19);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(86, 43);
            this.btnAgregarAlumno.TabIndex = 11;
            this.btnAgregarAlumno.Text = "Agregar";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // grdDatosAlumno
            // 
            this.grdDatosAlumno.AllowUserToAddRows = false;
            this.grdDatosAlumno.AllowUserToDeleteRows = false;
            this.grdDatosAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumno,
            this.codigo,
            this.nombre,
            this.edad,
            this.genero,
            this.nota_parcial});
            this.grdDatosAlumno.Location = new System.Drawing.Point(428, 59);
            this.grdDatosAlumno.Name = "grdDatosAlumno";
            this.grdDatosAlumno.ReadOnly = true;
            this.grdDatosAlumno.Size = new System.Drawing.Size(640, 239);
            this.grdDatosAlumno.TabIndex = 3;
            this.grdDatosAlumno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosAlumno_CellClick);
            // 
            // idAlumno
            // 
            this.idAlumno.DataPropertyName = "idAlumno";
            this.idAlumno.HeaderText = "idAlumno";
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.ReadOnly = true;
            this.idAlumno.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 80;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // edad
            // 
            this.edad.DataPropertyName = "edad";
            this.edad.HeaderText = "Edad";
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            this.edad.Width = 150;
            // 
            // genero
            // 
            this.genero.DataPropertyName = "genero";
            this.genero.HeaderText = "Genero";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            this.genero.Width = 80;
            // 
            // nota_parcial
            // 
            this.nota_parcial.DataPropertyName = "nota_parcial";
            this.nota_parcial.HeaderText = "Nota_parcial";
            this.nota_parcial.Name = "nota_parcial";
            this.nota_parcial.ReadOnly = true;
            this.nota_parcial.Width = 80;
            // 
            // txtBuscarAlumno
            // 
            this.txtBuscarAlumno.Location = new System.Drawing.Point(492, 33);
            this.txtBuscarAlumno.Name = "txtBuscarAlumno";
            this.txtBuscarAlumno.Size = new System.Drawing.Size(521, 20);
            this.txtBuscarAlumno.TabIndex = 10;
            this.txtBuscarAlumno.TextChanged += new System.EventHandler(this.txtBuscarAlumno_TextChanged);
            this.txtBuscarAlumno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarAlumno_KeyUp);
            // 
            // lblBuscarAlumno
            // 
            this.lblBuscarAlumno.AutoSize = true;
            this.lblBuscarAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarAlumno.Location = new System.Drawing.Point(425, 33);
            this.lblBuscarAlumno.Name = "lblBuscarAlumno";
            this.lblBuscarAlumno.Size = new System.Drawing.Size(61, 18);
            this.lblBuscarAlumno.TabIndex = 10;
            this.lblBuscarAlumno.Text = "Buscar:";
            // 
            // alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 420);
            this.Controls.Add(this.lblBuscarAlumno);
            this.Controls.Add(this.txtBuscarAlumno);
            this.Controls.Add(this.grdDatosAlumno);
            this.Controls.Add(this.grbEdicionAlumno);
            this.Controls.Add(this.grbNavegacionAlumno);
            this.Controls.Add(this.grbDatosAlumnos);
            this.Name = "alumnos";
            this.Text = "Administracion de Alumnos";
            this.Load += new System.EventHandler(this.alumnos_Load);
            this.grbDatosAlumnos.ResumeLayout(false);
            this.grbDatosAlumnos.PerformLayout();
            this.grbNavegacionAlumno.ResumeLayout(false);
            this.grbNavegacionAlumno.PerformLayout();
            this.grbEdicionAlumno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosAlumnos;
        private System.Windows.Forms.TextBox txtgeneroAlumno;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtedadAlumno;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.GroupBox grbNavegacionAlumno;
        private System.Windows.Forms.Button btnPrimeroAlumno;
        private System.Windows.Forms.GroupBox grbEdicionAlumno;
        private System.Windows.Forms.TextBox txtnota_parcialAlumno;
        private System.Windows.Forms.Label lblNparcial;
        private System.Windows.Forms.Label lblNRegistroAlumno;
        private System.Windows.Forms.Button btnUltimoAlumno;
        private System.Windows.Forms.Button btnSiguienteAlumno;
        private System.Windows.Forms.Button btnAnteriorAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.DataGridView grdDatosAlumno;
        private System.Windows.Forms.TextBox txtBuscarAlumno;
        private System.Windows.Forms.Label lblBuscarAlumno;
        private System.Windows.Forms.Label lblNotalab2;
        private System.Windows.Forms.Label lblnlab1;
        private System.Windows.Forms.TextBox txtNotalab2;
        private System.Windows.Forms.TextBox txtNotalab1;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.TextBox txtNotapromedio;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota_parcial;
    }
}

