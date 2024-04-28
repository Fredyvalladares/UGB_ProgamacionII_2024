namespace ISNP152823_UNIDAD_2 {
    partial class Ejercicio3 {
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
            lblNum1 = new Label();
            lblNum2 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            rgoOperaciones = new GroupBox();
            rdbRaiz = new RadioButton();
            rdbPotencia = new RadioButton();
            rdbDivision = new RadioButton();
            rdbMultiplicacion = new RadioButton();
            rdbResta = new RadioButton();
            rdbSuma = new RadioButton();
            btnResultado = new Button();
            lblResultado = new Label();
            lblResult = new Label();
            lbloperador = new Label();
            btnLimpiar = new Button();
            btnRegresar = new Button();
            lblRaiz = new Label();
            rgoOperaciones.SuspendLayout();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNum1.Location = new Point(30, 46);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(78, 20);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Numero 1:";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNum2.Location = new Point(30, 125);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(84, 21);
            lblNum2.TabIndex = 1;
            lblNum2.Text = "Numero 2:";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(114, 42);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(114, 123);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 3;
            // 
            // rgoOperaciones
            // 
            rgoOperaciones.Controls.Add(rdbRaiz);
            rgoOperaciones.Controls.Add(rdbPotencia);
            rgoOperaciones.Controls.Add(rdbDivision);
            rgoOperaciones.Controls.Add(rdbMultiplicacion);
            rgoOperaciones.Controls.Add(rdbResta);
            rgoOperaciones.Controls.Add(rdbSuma);
            rgoOperaciones.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rgoOperaciones.Location = new Point(248, 12);
            rgoOperaciones.Name = "rgoOperaciones";
            rgoOperaciones.Size = new Size(243, 186);
            rgoOperaciones.TabIndex = 4;
            rgoOperaciones.TabStop = false;
            rgoOperaciones.Text = "Operaciones Matematicas";
            // 
            // rdbRaiz
            // 
            rdbRaiz.AutoSize = true;
            rdbRaiz.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdbRaiz.Location = new Point(6, 152);
            rdbRaiz.Name = "rdbRaiz";
            rdbRaiz.Size = new Size(125, 24);
            rdbRaiz.TabIndex = 5;
            rdbRaiz.TabStop = true;
            rdbRaiz.Text = "Raiz Cuadrada";
            rdbRaiz.UseVisualStyleBackColor = true;
            rdbRaiz.CheckedChanged += rdbRaiz_CheckedChanged;
            // 
            // rdbPotencia
            // 
            rdbPotencia.AutoSize = true;
            rdbPotencia.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdbPotencia.Location = new Point(6, 127);
            rdbPotencia.Name = "rdbPotencia";
            rdbPotencia.Size = new Size(173, 24);
            rdbPotencia.TabIndex = 4;
            rdbPotencia.TabStop = true;
            rdbPotencia.Text = "Elevar a una Potencia";
            rdbPotencia.UseVisualStyleBackColor = true;
            rdbPotencia.CheckedChanged += rdbPotencia_CheckedChanged;
            // 
            // rdbDivision
            // 
            rdbDivision.AutoSize = true;
            rdbDivision.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdbDivision.Location = new Point(6, 102);
            rdbDivision.Name = "rdbDivision";
            rdbDivision.Size = new Size(82, 24);
            rdbDivision.TabIndex = 3;
            rdbDivision.TabStop = true;
            rdbDivision.Text = "Division";
            rdbDivision.UseVisualStyleBackColor = true;
            rdbDivision.CheckedChanged += rdbDivision_CheckedChanged;
            // 
            // rdbMultiplicacion
            // 
            rdbMultiplicacion.AutoSize = true;
            rdbMultiplicacion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdbMultiplicacion.Location = new Point(6, 77);
            rdbMultiplicacion.Name = "rdbMultiplicacion";
            rdbMultiplicacion.Size = new Size(124, 24);
            rdbMultiplicacion.TabIndex = 2;
            rdbMultiplicacion.TabStop = true;
            rdbMultiplicacion.Text = "Multiplicacion";
            rdbMultiplicacion.UseVisualStyleBackColor = true;
            rdbMultiplicacion.CheckedChanged += rdbMultiplicacion_CheckedChanged;
            // 
            // rdbResta
            // 
            rdbResta.AutoSize = true;
            rdbResta.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdbResta.Location = new Point(6, 52);
            rdbResta.Name = "rdbResta";
            rdbResta.Size = new Size(63, 24);
            rdbResta.TabIndex = 1;
            rdbResta.TabStop = true;
            rdbResta.Text = "Resta";
            rdbResta.UseVisualStyleBackColor = true;
            rdbResta.CheckedChanged += rdbResta_CheckedChanged;
            // 
            // rdbSuma
            // 
            rdbSuma.AutoSize = true;
            rdbSuma.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdbSuma.Location = new Point(6, 27);
            rdbSuma.Name = "rdbSuma";
            rdbSuma.Size = new Size(65, 24);
            rdbSuma.TabIndex = 0;
            rdbSuma.TabStop = true;
            rdbSuma.Text = "Suma";
            rdbSuma.TextImageRelation = TextImageRelation.ImageBeforeText;
            rdbSuma.UseVisualStyleBackColor = true;
            rdbSuma.CheckedChanged += rdbSuma_CheckedChanged;
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(21, 280);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(142, 38);
            btnResultado.TabIndex = 5;
            btnResultado.Text = "Resultado";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(30, 175);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(121, 21);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "El Resultado es :";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.Location = new Point(114, 221);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 25);
            lblResult.TabIndex = 7;
            // 
            // lbloperador
            // 
            lbloperador.AutoSize = true;
            lbloperador.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbloperador.Location = new Point(146, 76);
            lbloperador.Name = "lbloperador";
            lbloperador.Size = new Size(28, 30);
            lbloperador.TabIndex = 8;
            lbloperador.Text = "+";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(193, 280);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(154, 38);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(374, 280);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(142, 38);
            btnRegresar.TabIndex = 10;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblRaiz
            // 
            lblRaiz.AutoSize = true;
            lblRaiz.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRaiz.Location = new Point(21, 12);
            lblRaiz.Name = "lblRaiz";
            lblRaiz.Size = new Size(0, 18);
            lblRaiz.TabIndex = 11;
            // 
            // Ejercicio3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(536, 348);
            Controls.Add(lblRaiz);
            Controls.Add(btnRegresar);
            Controls.Add(btnLimpiar);
            Controls.Add(lbloperador);
            Controls.Add(lblResult);
            Controls.Add(lblResultado);
            Controls.Add(btnResultado);
            Controls.Add(rgoOperaciones);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            ForeColor = Color.Blue;
            Name = "Ejercicio3";
            Text = "Ejercicio3";
            Load += Ejercicio3_Load;
            rgoOperaciones.ResumeLayout(false);
            rgoOperaciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private Label lblNum2;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private GroupBox rgoOperaciones;
        private RadioButton rdbRaiz;
        private RadioButton rdbPotencia;
        private RadioButton rdbDivision;
        private RadioButton rdbMultiplicacion;
        private RadioButton rdbResta;
        private RadioButton rdbSuma;
        private Button btnResultado;
        private Label lblResultado;
        private Label lblResult;
        private Label lbloperador;
        private Button btnLimpiar;
        private Button btnRegresar;
        private Label lblRaiz;
    }
}