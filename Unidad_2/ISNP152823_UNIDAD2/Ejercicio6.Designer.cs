namespace ISNP152823_UNIDAD_2 {
    partial class Ejercicio6 {
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
            btnConvertir = new Button();
            lblNumeroentero = new Label();
            txtNumeroentero = new TextBox();
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(12, 109);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(84, 32);
            btnConvertir.TabIndex = 0;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblNumeroentero
            // 
            lblNumeroentero.AutoSize = true;
            lblNumeroentero.Location = new Point(83, 19);
            lblNumeroentero.Name = "lblNumeroentero";
            lblNumeroentero.Size = new Size(141, 15);
            lblNumeroentero.TabIndex = 1;
            lblNumeroentero.Text = "Ingre un Numero Entero :";
            // 
            // txtNumeroentero
            // 
            txtNumeroentero.Location = new Point(102, 53);
            txtNumeroentero.Name = "txtNumeroentero";
            txtNumeroentero.Size = new Size(100, 23);
            txtNumeroentero.TabIndex = 2;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(207, 109);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(84, 32);
            btnRegresar.TabIndex = 3;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // Ejercicio6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 153);
            Controls.Add(btnRegresar);
            Controls.Add(txtNumeroentero);
            Controls.Add(lblNumeroentero);
            Controls.Add(btnConvertir);
            Name = "Ejercicio6";
            Text = "Ejercicio6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvertir;
        private Label lblNumeroentero;
        private TextBox txtNumeroentero;
        private Button btnRegresar;
    }
}