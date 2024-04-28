namespace ISNP152823_UNIDAD_2 {
    partial class Ejercicio2 {
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
            btnRegresar = new Button();
            rgoConvertir = new GroupBox();
            rdbMilimetroscentimetros = new RadioButton();
            rdbCentimetrosmilimetros = new RadioButton();
            rdbYardasmetros = new RadioButton();
            rdbMetrosyardas = new RadioButton();
            lblDee = new Label();
            txtPeso = new TextBox();
            lblRespuesta = new Label();
            lblA = new Label();
            lblDe = new Label();
            btnConvertir = new Button();
            rgoConvertir.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(474, 198);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(121, 32);
            btnRegresar.TabIndex = 25;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // rgoConvertir
            // 
            rgoConvertir.BackColor = Color.Azure;
            rgoConvertir.Controls.Add(rdbMilimetroscentimetros);
            rgoConvertir.Controls.Add(rdbCentimetrosmilimetros);
            rgoConvertir.Controls.Add(rdbYardasmetros);
            rgoConvertir.Controls.Add(rdbMetrosyardas);
            rgoConvertir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rgoConvertir.Location = new Point(12, 12);
            rgoConvertir.Name = "rgoConvertir";
            rgoConvertir.Size = new Size(275, 218);
            rgoConvertir.TabIndex = 24;
            rgoConvertir.TabStop = false;
            rgoConvertir.Text = "Convertir";
            // 
            // rdbMilimetroscentimetros
            // 
            rdbMilimetroscentimetros.AutoSize = true;
            rdbMilimetroscentimetros.Location = new Point(14, 123);
            rdbMilimetroscentimetros.Name = "rdbMilimetroscentimetros";
            rdbMilimetroscentimetros.Size = new Size(213, 25);
            rdbMilimetroscentimetros.TabIndex = 3;
            rdbMilimetroscentimetros.TabStop = true;
            rdbMilimetroscentimetros.Text = "Milimetros a Centimetros";
            rdbMilimetroscentimetros.UseVisualStyleBackColor = true;
            rdbMilimetroscentimetros.CheckedChanged += rdbMilimetroscentimetros_CheckedChanged;
            // 
            // rdbCentimetrosmilimetros
            // 
            rdbCentimetrosmilimetros.AutoSize = true;
            rdbCentimetrosmilimetros.Location = new Point(14, 95);
            rdbCentimetrosmilimetros.Name = "rdbCentimetrosmilimetros";
            rdbCentimetrosmilimetros.Size = new Size(213, 25);
            rdbCentimetrosmilimetros.TabIndex = 2;
            rdbCentimetrosmilimetros.TabStop = true;
            rdbCentimetrosmilimetros.Text = "Centimetros a Milimetros";
            rdbCentimetrosmilimetros.UseMnemonic = false;
            rdbCentimetrosmilimetros.UseVisualStyleBackColor = true;
            rdbCentimetrosmilimetros.CheckedChanged += rdbCentimetrosmilimetros_CheckedChanged;
            // 
            // rdbYardasmetros
            // 
            rdbYardasmetros.AutoSize = true;
            rdbYardasmetros.Location = new Point(13, 65);
            rdbYardasmetros.Name = "rdbYardasmetros";
            rdbYardasmetros.Size = new Size(144, 25);
            rdbYardasmetros.TabIndex = 1;
            rdbYardasmetros.TabStop = true;
            rdbYardasmetros.Text = "Yardas a Metros";
            rdbYardasmetros.UseVisualStyleBackColor = true;
            rdbYardasmetros.CheckedChanged += rdbYardasmetros_CheckedChanged;
            // 
            // rdbMetrosyardas
            // 
            rdbMetrosyardas.AutoSize = true;
            rdbMetrosyardas.Location = new Point(14, 34);
            rdbMetrosyardas.Name = "rdbMetrosyardas";
            rdbMetrosyardas.Size = new Size(144, 25);
            rdbMetrosyardas.TabIndex = 0;
            rdbMetrosyardas.TabStop = true;
            rdbMetrosyardas.Text = "Metros a Yardas";
            rdbMetrosyardas.UseMnemonic = false;
            rdbMetrosyardas.UseVisualStyleBackColor = true;
            rdbMetrosyardas.CheckedChanged += rdbMetrosyardas_CheckedChanged;
            // 
            // lblDee
            // 
            lblDee.AutoSize = true;
            lblDee.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDee.Location = new Point(441, 37);
            lblDee.Name = "lblDee";
            lblDee.Size = new Size(55, 20);
            lblDee.TabIndex = 23;
            lblDee.Text = "Metros";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(352, 34);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(83, 23);
            txtPeso.TabIndex = 21;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRespuesta.Location = new Point(314, 111);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(0, 25);
            lblRespuesta.TabIndex = 20;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblA.Location = new Point(314, 81);
            lblA.Name = "lblA";
            lblA.Size = new Size(104, 21);
            lblA.TabIndex = 19;
            lblA.Text = "Conversion a:";
            // 
            // lblDe
            // 
            lblDe.AutoSize = true;
            lblDe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDe.Location = new Point(314, 34);
            lblDe.Name = "lblDe";
            lblDe.Size = new Size(32, 21);
            lblDe.TabIndex = 18;
            lblDe.Text = "De:";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(314, 198);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(121, 32);
            btnConvertir.TabIndex = 17;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // Ejercicio2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 243);
            Controls.Add(btnRegresar);
            Controls.Add(rgoConvertir);
            Controls.Add(lblDee);
            Controls.Add(txtPeso);
            Controls.Add(lblRespuesta);
            Controls.Add(lblA);
            Controls.Add(lblDe);
            Controls.Add(btnConvertir);
            Name = "Ejercicio2";
            Text = "Ejercicio2";
            Load += Ejercicio2_Load;
            rgoConvertir.ResumeLayout(false);
            rgoConvertir.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private GroupBox rgoConvertir;
        private RadioButton rdbMilimetroscentimetros;
        private RadioButton rdbCentimetrosmilimetros;
        private RadioButton rdbYardasmetros;
        private RadioButton rdbMetrosyardas;
        private Label lblDee;
        private TextBox txtPeso;
        private Label lblRespuesta;
        private Label lblA;
        private Label lblDe;
        private Button btnConvertir;
    }
}