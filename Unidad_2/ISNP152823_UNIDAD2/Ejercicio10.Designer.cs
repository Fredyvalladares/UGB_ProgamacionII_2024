namespace ISNP152823_UNIDAD_2 {
    partial class Ejercicio10 {
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
            lblUser = new Label();
            label2 = new Label();
            lblIniciosesion = new Label();
            txtUser = new TextBox();
            txtPassw = new TextBox();
            btnIniciar = new Button();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(44, 65);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(43, 15);
            lblUser.TabIndex = 0;
            lblUser.Text = "Usuaio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 111);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // lblIniciosesion
            // 
            lblIniciosesion.AutoSize = true;
            lblIniciosesion.Location = new Point(93, 23);
            lblIniciosesion.Name = "lblIniciosesion";
            lblIniciosesion.Size = new Size(89, 15);
            lblIniciosesion.TabIndex = 2;
            lblIniciosesion.Text = "Inicio de Sesion";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(131, 62);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(100, 23);
            txtUser.TabIndex = 3;
            // 
            // txtPassw
            // 
            txtPassw.Location = new Point(131, 108);
            txtPassw.Name = "txtPassw";
            txtPassw.PasswordChar = '*';
            txtPassw.Size = new Size(100, 23);
            txtPassw.TabIndex = 4;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(44, 170);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(124, 37);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "Iniciar Sesión";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // Ejercicio10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 213);
            Controls.Add(btnIniciar);
            Controls.Add(txtPassw);
            Controls.Add(txtUser);
            Controls.Add(lblIniciosesion);
            Controls.Add(label2);
            Controls.Add(lblUser);
            Name = "Ejercicio10";
            Text = "Ejercicio10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label label2;
        private Label lblIniciosesion;
        private TextBox txtUser;
        private TextBox txtPassw;
        private Button btnIniciar;
    }
}