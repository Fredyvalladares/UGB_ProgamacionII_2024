namespace ISNP152823_UNIDAD_2 {
    partial class FormPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            achivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            aplicacionesToolStripMenuItem = new ToolStripMenuItem();
            convertirToolStripMenuItem = new ToolStripMenuItem();
            convertirDistanciaToolStripMenuItem = new ToolStripMenuItem();
            operacioesBasicasToolStripMenuItem = new ToolStripMenuItem();
            calculoDeCompraToolStripMenuItem = new ToolStripMenuItem();
            promedioFinalToolStripMenuItem = new ToolStripMenuItem();
            convertirNumerosARomanosToolStripMenuItem = new ToolStripMenuItem();
            sumaDeToolStripMenuItem = new ToolStripMenuItem();
            tablaDeMultiplicarToolStripMenuItem = new ToolStripMenuItem();
            encontrarElNumeroMayorToolStripMenuItem = new ToolStripMenuItem();
            solicitarUsuarioYContraseñaToolStripMenuItem = new ToolStripMenuItem();
            btnsalir = new Button();
            btnConvertirp = new Button();
            btnConvertirm = new Button();
            btnCalculoporcntaje = new Button();
            btnOpbasicas = new Button();
            btnPromedio = new Button();
            btnNumerosromanos = new Button();
            btnSumnaturales = new Button();
            btnTablamultiplicar = new Button();
            btnNumeromayor = new Button();
            btnUsuariocontra = new Button();
            pictureBox1 = new PictureBox();
            lblNombre = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { achivoToolStripMenuItem, aplicacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(456, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // achivoToolStripMenuItem
            // 
            achivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            achivoToolStripMenuItem.Name = "achivoToolStripMenuItem";
            achivoToolStripMenuItem.Size = new Size(56, 20);
            achivoToolStripMenuItem.Text = "Achivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // aplicacionesToolStripMenuItem
            // 
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { convertirToolStripMenuItem, convertirDistanciaToolStripMenuItem, operacioesBasicasToolStripMenuItem, calculoDeCompraToolStripMenuItem, promedioFinalToolStripMenuItem, convertirNumerosARomanosToolStripMenuItem, sumaDeToolStripMenuItem, tablaDeMultiplicarToolStripMenuItem, encontrarElNumeroMayorToolStripMenuItem, solicitarUsuarioYContraseñaToolStripMenuItem });
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(68, 20);
            aplicacionesToolStripMenuItem.Text = "Ejercicios";
            // 
            // convertirToolStripMenuItem
            // 
            convertirToolStripMenuItem.Name = "convertirToolStripMenuItem";
            convertirToolStripMenuItem.Size = new Size(237, 22);
            convertirToolStripMenuItem.Text = "Convertir Peso y Masa";
            convertirToolStripMenuItem.Click += convertirToolStripMenuItem_Click;
            // 
            // convertirDistanciaToolStripMenuItem
            // 
            convertirDistanciaToolStripMenuItem.Name = "convertirDistanciaToolStripMenuItem";
            convertirDistanciaToolStripMenuItem.Size = new Size(237, 22);
            convertirDistanciaToolStripMenuItem.Text = "Convertir Longitud";
            convertirDistanciaToolStripMenuItem.Click += convertirDistanciaToolStripMenuItem_Click;
            // 
            // operacioesBasicasToolStripMenuItem
            // 
            operacioesBasicasToolStripMenuItem.Name = "operacioesBasicasToolStripMenuItem";
            operacioesBasicasToolStripMenuItem.Size = new Size(237, 22);
            operacioesBasicasToolStripMenuItem.Text = "Operacioes Basicas";
            operacioesBasicasToolStripMenuItem.Click += operacioesBasicasToolStripMenuItem_Click;
            // 
            // calculoDeCompraToolStripMenuItem
            // 
            calculoDeCompraToolStripMenuItem.Name = "calculoDeCompraToolStripMenuItem";
            calculoDeCompraToolStripMenuItem.Size = new Size(237, 22);
            calculoDeCompraToolStripMenuItem.Text = "Calculo de Compra";
            calculoDeCompraToolStripMenuItem.Click += calculoDeCompraToolStripMenuItem_Click;
            // 
            // promedioFinalToolStripMenuItem
            // 
            promedioFinalToolStripMenuItem.Name = "promedioFinalToolStripMenuItem";
            promedioFinalToolStripMenuItem.Size = new Size(237, 22);
            promedioFinalToolStripMenuItem.Text = "Promedio Final";
            promedioFinalToolStripMenuItem.Click += promedioFinalToolStripMenuItem_Click;
            // 
            // convertirNumerosARomanosToolStripMenuItem
            // 
            convertirNumerosARomanosToolStripMenuItem.Name = "convertirNumerosARomanosToolStripMenuItem";
            convertirNumerosARomanosToolStripMenuItem.Size = new Size(237, 22);
            convertirNumerosARomanosToolStripMenuItem.Text = "Convertir Numeros a Romanos";
            convertirNumerosARomanosToolStripMenuItem.Click += convertirNumerosARomanosToolStripMenuItem_Click;
            // 
            // sumaDeToolStripMenuItem
            // 
            sumaDeToolStripMenuItem.Name = "sumaDeToolStripMenuItem";
            sumaDeToolStripMenuItem.Size = new Size(237, 22);
            sumaDeToolStripMenuItem.Text = "Suma de Numeros Naturales";
            sumaDeToolStripMenuItem.Click += sumaDeToolStripMenuItem_Click;
            // 
            // tablaDeMultiplicarToolStripMenuItem
            // 
            tablaDeMultiplicarToolStripMenuItem.Name = "tablaDeMultiplicarToolStripMenuItem";
            tablaDeMultiplicarToolStripMenuItem.Size = new Size(237, 22);
            tablaDeMultiplicarToolStripMenuItem.Text = "Tabla de Multiplicar";
            tablaDeMultiplicarToolStripMenuItem.Click += tablaDeMultiplicarToolStripMenuItem_Click;
            // 
            // encontrarElNumeroMayorToolStripMenuItem
            // 
            encontrarElNumeroMayorToolStripMenuItem.Name = "encontrarElNumeroMayorToolStripMenuItem";
            encontrarElNumeroMayorToolStripMenuItem.Size = new Size(237, 22);
            encontrarElNumeroMayorToolStripMenuItem.Text = "Encontrar el Numero Mayor";
            encontrarElNumeroMayorToolStripMenuItem.Click += encontrarElNumeroMayorToolStripMenuItem_Click;
            // 
            // solicitarUsuarioYContraseñaToolStripMenuItem
            // 
            solicitarUsuarioYContraseñaToolStripMenuItem.Name = "solicitarUsuarioYContraseñaToolStripMenuItem";
            solicitarUsuarioYContraseñaToolStripMenuItem.Size = new Size(237, 22);
            solicitarUsuarioYContraseñaToolStripMenuItem.Text = "Solicitar Usuario y Contraseña";
            solicitarUsuarioYContraseñaToolStripMenuItem.Click += solicitarUsuarioYContraseñaToolStripMenuItem_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(351, 412);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 1;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnConvertirp
            // 
            btnConvertirp.Location = new Point(107, 107);
            btnConvertirp.Name = "btnConvertirp";
            btnConvertirp.Size = new Size(204, 24);
            btnConvertirp.TabIndex = 3;
            btnConvertirp.Text = "Convertir Peso";
            btnConvertirp.UseVisualStyleBackColor = true;
            btnConvertirp.Click += btnConvertirp_Click;
            // 
            // btnConvertirm
            // 
            btnConvertirm.Location = new Point(107, 137);
            btnConvertirm.Name = "btnConvertirm";
            btnConvertirm.Size = new Size(204, 24);
            btnConvertirm.TabIndex = 4;
            btnConvertirm.Text = "Convertir Longitud";
            btnConvertirm.UseVisualStyleBackColor = true;
            btnConvertirm.Click += btnConvertirm_Click;
            // 
            // btnCalculoporcntaje
            // 
            btnCalculoporcntaje.Location = new Point(107, 197);
            btnCalculoporcntaje.Name = "btnCalculoporcntaje";
            btnCalculoporcntaje.Size = new Size(204, 24);
            btnCalculoporcntaje.TabIndex = 5;
            btnCalculoporcntaje.Text = "Calculo de Porcentaje";
            btnCalculoporcntaje.UseVisualStyleBackColor = true;
            btnCalculoporcntaje.Click += btnCalculoporcntaje_Click;
            // 
            // btnOpbasicas
            // 
            btnOpbasicas.Location = new Point(107, 167);
            btnOpbasicas.Name = "btnOpbasicas";
            btnOpbasicas.Size = new Size(204, 24);
            btnOpbasicas.TabIndex = 6;
            btnOpbasicas.Text = "Operaciones Basicas";
            btnOpbasicas.UseVisualStyleBackColor = true;
            btnOpbasicas.Click += btnOpbasicas_Click;
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(107, 227);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(204, 24);
            btnPromedio.TabIndex = 7;
            btnPromedio.Text = "Promedio Final";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // btnNumerosromanos
            // 
            btnNumerosromanos.Location = new Point(107, 257);
            btnNumerosromanos.Name = "btnNumerosromanos";
            btnNumerosromanos.Size = new Size(204, 24);
            btnNumerosromanos.TabIndex = 9;
            btnNumerosromanos.Text = "Convertir Numeros Romanos";
            btnNumerosromanos.UseVisualStyleBackColor = true;
            btnNumerosromanos.Click += btnNumerosromanos_Click;
            // 
            // btnSumnaturales
            // 
            btnSumnaturales.Location = new Point(107, 287);
            btnSumnaturales.Name = "btnSumnaturales";
            btnSumnaturales.Size = new Size(204, 24);
            btnSumnaturales.TabIndex = 10;
            btnSumnaturales.Text = "Suma de Numeros Naturales";
            btnSumnaturales.UseVisualStyleBackColor = true;
            btnSumnaturales.Click += btnSumnaturales_Click;
            // 
            // btnTablamultiplicar
            // 
            btnTablamultiplicar.Location = new Point(107, 317);
            btnTablamultiplicar.Name = "btnTablamultiplicar";
            btnTablamultiplicar.Size = new Size(204, 24);
            btnTablamultiplicar.TabIndex = 11;
            btnTablamultiplicar.Text = "Tabla de Multiplicar";
            btnTablamultiplicar.UseVisualStyleBackColor = true;
            btnTablamultiplicar.Click += btnTablamultiplicar_Click;
            // 
            // btnNumeromayor
            // 
            btnNumeromayor.Location = new Point(107, 347);
            btnNumeromayor.Name = "btnNumeromayor";
            btnNumeromayor.Size = new Size(204, 24);
            btnNumeromayor.TabIndex = 12;
            btnNumeromayor.Text = "Encontar el Numero Mayor";
            btnNumeromayor.UseVisualStyleBackColor = true;
            btnNumeromayor.Click += btnNumeromayor_Click;
            // 
            // btnUsuariocontra
            // 
            btnUsuariocontra.Location = new Point(107, 377);
            btnUsuariocontra.Name = "btnUsuariocontra";
            btnUsuariocontra.Size = new Size(204, 24);
            btnUsuariocontra.TabIndex = 13;
            btnUsuariocontra.Text = "Solictar Usurio y Contraseña";
            btnUsuariocontra.UseVisualStyleBackColor = true;
            btnUsuariocontra.Click += btnUsuariocontra_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(370, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 91);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(21, 52);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(343, 18);
            lblNombre.TabIndex = 15;
            lblNombre.Text = "Unidad II – Diseño de Interfaz Gráfica";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumBlue;
            ClientSize = new Size(456, 447);
            Controls.Add(lblNombre);
            Controls.Add(pictureBox1);
            Controls.Add(btnUsuariocontra);
            Controls.Add(btnNumeromayor);
            Controls.Add(btnTablamultiplicar);
            Controls.Add(btnSumnaturales);
            Controls.Add(btnNumerosromanos);
            Controls.Add(btnPromedio);
            Controls.Add(btnOpbasicas);
            Controls.Add(btnCalculoporcntaje);
            Controls.Add(btnConvertirm);
            Controls.Add(btnConvertirp);
            Controls.Add(btnsalir);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "Menu Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem achivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Button btnsalir;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem convertirToolStripMenuItem;
        private ToolStripMenuItem convertirDistanciaToolStripMenuItem;
        private ToolStripMenuItem operacioesBasicasToolStripMenuItem;
        private ToolStripMenuItem calculoDeCompraToolStripMenuItem;
        private ToolStripMenuItem promedioFinalToolStripMenuItem;
        private ToolStripMenuItem convertirNumerosARomanosToolStripMenuItem;
        private ToolStripMenuItem sumaDeToolStripMenuItem;
        private ToolStripMenuItem tablaDeMultiplicarToolStripMenuItem;
        private ToolStripMenuItem encontrarElNumeroMayorToolStripMenuItem;
        private ToolStripMenuItem solicitarUsuarioYContraseñaToolStripMenuItem;
        private Button btnConvertirp;
        private Button btnConvertirm;
        private Button btnCalculoporcntaje;
        private Button btnOpbasicas;
        private Button btnPromedio;
        private Button btnNumerosromanos;
        private Button btnSumnaturales;
        private Button btnTablamultiplicar;
        private Button btnNumeromayor;
        private Button btnUsuariocontra;
        private PictureBox pictureBox1;
        private Label lblNombre;
    }
}