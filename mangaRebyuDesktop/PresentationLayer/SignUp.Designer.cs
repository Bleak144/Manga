namespace PresentationLayer
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsuarioR = new System.Windows.Forms.TextBox();
            this.txtContraseñaR = new System.Windows.Forms.TextBox();
            this.txtCconfirmarContraseñaR = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new PresentationLayer.CustomizableButton();
            this.customizableButton1 = new PresentationLayer.CustomizableButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.Registro;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsuarioR
            // 
            this.txtUsuarioR.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUsuarioR.Location = new System.Drawing.Point(309, 137);
            this.txtUsuarioR.Name = "txtUsuarioR";
            this.txtUsuarioR.PlaceholderText = "Usuario...";
            this.txtUsuarioR.Size = new System.Drawing.Size(186, 21);
            this.txtUsuarioR.TabIndex = 1;
            // 
            // txtContraseñaR
            // 
            this.txtContraseñaR.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtContraseñaR.Location = new System.Drawing.Point(309, 193);
            this.txtContraseñaR.Name = "txtContraseñaR";
            this.txtContraseñaR.PlaceholderText = "Contraseña...";
            this.txtContraseñaR.Size = new System.Drawing.Size(186, 21);
            this.txtContraseñaR.TabIndex = 2;
            // 
            // txtCconfirmarContraseñaR
            // 
            this.txtCconfirmarContraseñaR.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCconfirmarContraseñaR.Location = new System.Drawing.Point(309, 247);
            this.txtCconfirmarContraseñaR.Name = "txtCconfirmarContraseñaR";
            this.txtCconfirmarContraseñaR.PlaceholderText = "Confirmar Contraseña";
            this.txtCconfirmarContraseñaR.Size = new System.Drawing.Size(186, 20);
            this.txtCconfirmarContraseñaR.TabIndex = 3;
            this.txtCconfirmarContraseñaR.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegistrarse.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegistrarse.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrarse.BorderRadius = 50;
            this.btnRegistrarse.BorderSize = 0;
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarse.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarse.Location = new System.Drawing.Point(319, 306);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(165, 49);
            this.btnRegistrarse.TabIndex = 4;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.TextColor = System.Drawing.Color.Black;
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // customizableButton1
            // 
            this.customizableButton1.BackColor = System.Drawing.Color.Black;
            this.customizableButton1.BackgroundColor = System.Drawing.Color.Black;
            this.customizableButton1.BackgroundImage = global::PresentationLayer.Properties.Resources.flechas_izquierda;
            this.customizableButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customizableButton1.BorderColor = System.Drawing.Color.Black;
            this.customizableButton1.BorderRadius = 0;
            this.customizableButton1.BorderSize = 0;
            this.customizableButton1.FlatAppearance.BorderSize = 0;
            this.customizableButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizableButton1.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customizableButton1.ForeColor = System.Drawing.Color.Transparent;
            this.customizableButton1.Location = new System.Drawing.Point(12, 67);
            this.customizableButton1.Name = "customizableButton1";
            this.customizableButton1.Size = new System.Drawing.Size(44, 42);
            this.customizableButton1.TabIndex = 6;
            this.customizableButton1.TextColor = System.Drawing.Color.Transparent;
            this.customizableButton1.UseVisualStyleBackColor = false;
            this.customizableButton1.Click += new System.EventHandler(this.customizableButton1_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 445);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.txtCconfirmarContraseñaR);
            this.Controls.Add(this.txtContraseñaR);
            this.Controls.Add(this.txtUsuarioR);
            this.Controls.Add(this.customizableButton1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUsuarioR;
        private TextBox txtContraseñaR;
        private TextBox txtCconfirmarContraseñaR;
        private CustomizableButton btnRegistrarse;
        private CustomizableButton customizableButton1;
    }
}