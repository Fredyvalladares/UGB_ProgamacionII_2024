namespace ISNP152823_UNIDAD_2 {
    partial class Ejercicio8 {
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
            btnMultiplicar = new Button();
            txtTabla = new TextBox();
            lbltabla = new Label();
            ltsMostrartabla = new ListBox();
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(55, 90);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(111, 36);
            btnMultiplicar.TabIndex = 0;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // txtTabla
            // 
            txtTabla.Location = new Point(12, 52);
            txtTabla.Name = "txtTabla";
            txtTabla.Size = new Size(100, 23);
            txtTabla.TabIndex = 1;
            // 
            // lbltabla
            // 
            lbltabla.AutoSize = true;
            lbltabla.Location = new Point(6, 22);
            lbltabla.Name = "lbltabla";
            lbltabla.Size = new Size(234, 15);
            lbltabla.TabIndex = 2;
            lbltabla.Text = "Ingrese el Numero de la Tabla a Multiplicar:";
            // 
            // ltsMostrartabla
            // 
            ltsMostrartabla.FormattingEnabled = true;
            ltsMostrartabla.ItemHeight = 15;
            ltsMostrartabla.Location = new Point(246, 12);
            ltsMostrartabla.Name = "ltsMostrartabla";
            ltsMostrartabla.Size = new Size(150, 169);
            ltsMostrartabla.TabIndex = 3;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(55, 145);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(111, 36);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // Ejercicio8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 200);
            Controls.Add(btnRegresar);
            Controls.Add(ltsMostrartabla);
            Controls.Add(lbltabla);
            Controls.Add(txtTabla);
            Controls.Add(btnMultiplicar);
            Name = "Ejercicio8";
            Text = "Ejercicio8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMultiplicar;
        private TextBox txtTabla;
        private Label lbltabla;
        private ListBox ltsMostrartabla;
        private Button btnRegresar;
    }
}