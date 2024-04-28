namespace ISNP152823_UNIDAD_2 {
    partial class Ejercicio4 {
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
            btnCalcular = new Button();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            lblCantidadproductos = new Label();
            btnRegesar = new Button();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(30, 109);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(30, 24);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(110, 15);
            lblPrecio.TabIndex = 1;
            lblPrecio.Text = "Precio del Articulo :";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(161, 21);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 2;
            txtPrecio.TextChanged += textBox1_TextChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(161, 66);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 3;
            // 
            // lblCantidadproductos
            // 
            lblCantidadproductos.AutoSize = true;
            lblCantidadproductos.Location = new Point(30, 69);
            lblCantidadproductos.Name = "lblCantidadproductos";
            lblCantidadproductos.Size = new Size(131, 15);
            lblCantidadproductos.TabIndex = 4;
            lblCantidadproductos.Text = "Cantidad de productos:";
            // 
            // btnRegesar
            // 
            btnRegesar.Location = new Point(161, 109);
            btnRegesar.Name = "btnRegesar";
            btnRegesar.Size = new Size(75, 23);
            btnRegesar.TabIndex = 5;
            btnRegesar.Text = "Regesar";
            btnRegesar.UseVisualStyleBackColor = true;
            btnRegesar.Click += btnRegesar_Click;
            // 
            // Ejercicio4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 164);
            Controls.Add(btnRegesar);
            Controls.Add(lblCantidadproductos);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(btnCalcular);
            Name = "Ejercicio4";
            Text = "Ejercicio4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private Label lblCantidadproductos;
        private Button btnRegesar;
    }
}