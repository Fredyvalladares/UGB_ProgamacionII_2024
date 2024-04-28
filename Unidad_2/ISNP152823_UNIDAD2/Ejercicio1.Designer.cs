namespace ISNP152823_UNIDAD_2 {
    partial class Ejercicio1 {
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
            lblDe = new Label();
            lblRespuesta = new Label();
            txtPeso = new TextBox();
            lblDee = new Label();
            rgoConvertir = new GroupBox();
            rdbKilolibras = new RadioButton();
            rdbLibraskilo = new RadioButton();
            btnRegresar = new Button();
            lblA = new Label();
            rgoConvertir.SuspendLayout();
            SuspendLayout();
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(131, 165);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(121, 40);
            btnConvertir.TabIndex = 0;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblDe
            // 
            lblDe.AutoSize = true;
            lblDe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDe.Location = new Point(235, 48);
            lblDe.Name = "lblDe";
            lblDe.Size = new Size(31, 20);
            lblDe.TabIndex = 3;
            lblDe.Text = "De:";
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRespuesta.Location = new Point(235, 103);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(0, 21);
            lblRespuesta.TabIndex = 8;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(273, 45);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(83, 23);
            txtPeso.TabIndex = 10;
            txtPeso.KeyPress += txtPeso_KeyPress;
            // 
            // lblDee
            // 
            lblDee.AutoSize = true;
            lblDee.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDee.Location = new Point(362, 48);
            lblDee.Name = "lblDee";
            lblDee.Size = new Size(48, 20);
            lblDee.TabIndex = 14;
            lblDee.Text = "Libras";
            // 
            // rgoConvertir
            // 
            rgoConvertir.Controls.Add(rdbKilolibras);
            rgoConvertir.Controls.Add(rdbLibraskilo);
            rgoConvertir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rgoConvertir.Location = new Point(12, 23);
            rgoConvertir.Name = "rgoConvertir";
            rgoConvertir.Size = new Size(201, 108);
            rgoConvertir.TabIndex = 15;
            rgoConvertir.TabStop = false;
            rgoConvertir.Text = "Convertir";
            // 
            // rdbKilolibras
            // 
            rdbKilolibras.AutoSize = true;
            rdbKilolibras.Location = new Point(13, 71);
            rdbKilolibras.Name = "rdbKilolibras";
            rdbKilolibras.Size = new Size(160, 25);
            rdbKilolibras.TabIndex = 1;
            rdbKilolibras.TabStop = true;
            rdbKilolibras.Text = "Kilograms a Libras";
            rdbKilolibras.UseVisualStyleBackColor = true;
            rdbKilolibras.CheckedChanged += rdbKilolibras_CheckedChanged;
            // 
            // rdbLibraskilo
            // 
            rdbLibraskilo.AutoSize = true;
            rdbLibraskilo.Location = new Point(14, 34);
            rdbLibraskilo.Name = "rdbLibraskilo";
            rdbLibraskilo.Size = new Size(170, 25);
            rdbLibraskilo.TabIndex = 0;
            rdbLibraskilo.TabStop = true;
            rdbLibraskilo.Text = "Libras a Kilogramos";
            rdbLibraskilo.UseMnemonic = false;
            rdbLibraskilo.UseVisualStyleBackColor = true;
            rdbLibraskilo.CheckedChanged += rdbLibraskilo_CheckedChanged;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(342, 165);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(121, 40);
            btnRegresar.TabIndex = 16;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblA.Location = new Point(235, 82);
            lblA.Name = "lblA";
            lblA.Size = new Size(82, 21);
            lblA.TabIndex = 4;
            lblA.Text = "Resultado:";
            // 
            // Ejercicio1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 215);
            Controls.Add(btnRegresar);
            Controls.Add(rgoConvertir);
            Controls.Add(lblDee);
            Controls.Add(txtPeso);
            Controls.Add(lblRespuesta);
            Controls.Add(lblA);
            Controls.Add(lblDe);
            Controls.Add(btnConvertir);
            Name = "Ejercicio1";
            Text = "Ejercicio1";
            Load += Ejercicio1_Load;
            rgoConvertir.ResumeLayout(false);
            rgoConvertir.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvertir;
        private Label lblDe;
        private Label lblRespuesta;
        private TextBox txtPeso;
        private Label lblDee;
        private GroupBox rgoConvertir;
        private RadioButton rdbKilolibras;
        private RadioButton rdbLibraskilo;
        private Button btnRegresar;
        private Label lblA;
    }
}