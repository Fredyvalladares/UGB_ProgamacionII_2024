namespace ISNP152823_UNIDAD_2 {
    partial class Ejercicio9 {
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
            btnNmayor = new Button();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            lblNum1 = new Label();
            label2 = new Label();
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // btnNmayor
            // 
            btnNmayor.Location = new Point(7, 130);
            btnNmayor.Name = "btnNmayor";
            btnNmayor.Size = new Size(146, 36);
            btnNmayor.TabIndex = 0;
            btnNmayor.Text = "Buscar Numero";
            btnNmayor.UseVisualStyleBackColor = true;
            btnNmayor.Click += btnNmayor_Click;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(167, 29);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(167, 75);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 1;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(19, 37);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(133, 15);
            lblNum1.TabIndex = 2;
            lblNum1.Text = "Ingrese Primer Numero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 78);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 2;
            label2.Text = "Ingrese Segundo Numero:";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(199, 130);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(146, 36);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // Ejercicio9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 178);
            Controls.Add(btnRegresar);
            Controls.Add(label2);
            Controls.Add(lblNum1);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(btnNmayor);
            Name = "Ejercicio9";
            Text = "Ejercicio9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNmayor;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label lblNum1;
        private Label label2;
        private Button btnRegresar;
    }
}