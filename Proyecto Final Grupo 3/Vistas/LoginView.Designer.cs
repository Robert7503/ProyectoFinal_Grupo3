
namespace Proyecto_Final_Grupo_3.Vistas
{
    partial class LoginView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SalirButton = new System.Windows.Forms.Button();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.txtClaveLOGIN = new System.Windows.Forms.TextBox();
            this.txtNombreLOGIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(169, 87);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(102, 34);
            this.SalirButton.TabIndex = 11;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(65, 87);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(88, 34);
            this.AceptarButton.TabIndex = 10;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // txtClaveLOGIN
            // 
            this.txtClaveLOGIN.Location = new System.Drawing.Point(74, 49);
            this.txtClaveLOGIN.Name = "txtClaveLOGIN";
            this.txtClaveLOGIN.PasswordChar = '*';
            this.txtClaveLOGIN.Size = new System.Drawing.Size(144, 20);
            this.txtClaveLOGIN.TabIndex = 9;
            this.txtClaveLOGIN.Text = "1234";
            this.txtClaveLOGIN.TextChanged += new System.EventHandler(this.ContraseñaTextBox_TextChanged);
            // 
            // txtNombreLOGIN
            // 
            this.txtNombreLOGIN.Location = new System.Drawing.Point(74, 16);
            this.txtNombreLOGIN.Name = "txtNombreLOGIN";
            this.txtNombreLOGIN.Size = new System.Drawing.Size(145, 20);
            this.txtNombreLOGIN.TabIndex = 8;
            this.txtNombreLOGIN.Text = "GRUPO3";
            this.txtNombreLOGIN.TextChanged += new System.EventHandler(this.NombretextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(321, 134);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.txtClaveLOGIN);
            this.Controls.Add(this.txtNombreLOGIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button SalirButton;
        public System.Windows.Forms.Button AceptarButton;
        public System.Windows.Forms.TextBox txtClaveLOGIN;
        public System.Windows.Forms.TextBox txtNombreLOGIN;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}