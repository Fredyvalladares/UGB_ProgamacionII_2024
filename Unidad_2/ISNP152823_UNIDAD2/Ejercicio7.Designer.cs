namespace ISNP152823_UNIDAD_2 {
    partial class Ejercicio7 {
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
            btnSumar = new Button();
            txtNumero = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnRegresar = new Button();
            label3 = new Label();
            lblResutado = new Label();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(27, 100);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(75, 23);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(127, 29);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(54, 23);
            txtNumero.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 2;
            label1.Text = "Sumar los primeros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 32);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 3;
            label2.Text = "numeros naturales";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(228, 101);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 69);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 5;
            label3.Text = "El Resultado es:";
            // 
            // lblResutado
            // 
            lblResutado.AutoSize = true;
            lblResutado.Location = new Point(127, 69);
            lblResutado.Name = "lblResutado";
            lblResutado.Size = new Size(0, 15);
            lblResutado.TabIndex = 6;
            // 
            // Ejercicio7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 136);
            Controls.Add(lblResutado);
            Controls.Add(label3);
            Controls.Add(btnRegresar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Controls.Add(btnSumar);
            Name = "Ejercicio7";
            Text = "Ejercicio7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private TextBox txtNumero;
        private Label label1;
        private Label label2;
        private Button btnRegresar;
        private Label label3;
        private Label lblResutado;
    }
}