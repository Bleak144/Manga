namespace PresentationLayer
{
    partial class Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Record));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new PresentationLayer.CustomizableButton();
            this.btnGet = new PresentationLayer.CustomizableButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbHistorial = new System.Windows.Forms.ComboBox();
            this.richTextBoxHistorial = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnGet);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cmbHistorial);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 78);
            this.panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnLogOut.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnLogOut.BackgroundImage = global::PresentationLayer.Properties.Resources.out_sign_icon_icons_com_70013;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.BorderColor = System.Drawing.Color.White;
            this.btnLogOut.BorderRadius = 5;
            this.btnLogOut.BorderSize = 0;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(758, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(71, 48);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.TextColor = System.Drawing.Color.Black;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnGet.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnGet.BackgroundImage = global::PresentationLayer.Properties.Resources.bookmark_11_icon_icons_com_62127;
            this.btnGet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGet.BorderColor = System.Drawing.Color.White;
            this.btnGet.BorderRadius = 5;
            this.btnGet.BorderSize = 0;
            this.btnGet.FlatAppearance.BorderSize = 0;
            this.btnGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGet.ForeColor = System.Drawing.Color.Black;
            this.btnGet.Location = new System.Drawing.Point(11, 12);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(53, 48);
            this.btnGet.TabIndex = 0;
            this.btnGet.TextColor = System.Drawing.Color.Black;
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 331);
            this.panel2.TabIndex = 1;
            // 
            // cmbHistorial
            // 
            this.cmbHistorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHistorial.FormattingEnabled = true;
            this.cmbHistorial.Location = new System.Drawing.Point(365, 27);
            this.cmbHistorial.Name = "cmbHistorial";
            this.cmbHistorial.Size = new System.Drawing.Size(121, 21);
            this.cmbHistorial.TabIndex = 0;
            this.cmbHistorial.SelectedIndexChanged += new System.EventHandler(this.cmbHistorial_SelectedIndexChanged);
            // 
            // richTextBoxHistorial
            // 
            this.richTextBoxHistorial.BackColor = System.Drawing.SystemColors.ControlText;
            this.richTextBoxHistorial.Location = new System.Drawing.Point(4, 84);
            this.richTextBoxHistorial.Name = "richTextBoxHistorial";
            this.richTextBoxHistorial.ReadOnly = true;
            this.richTextBoxHistorial.Size = new System.Drawing.Size(835, 317);
            this.richTextBoxHistorial.TabIndex = 1;
            this.richTextBoxHistorial.Text = "";
            this.richTextBoxHistorial.TextChanged += new System.EventHandler(this.richTextBoxHistorial_TextChanged);
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(842, 406);
            this.Controls.Add(this.richTextBoxHistorial);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Record";
            this.Load += new System.EventHandler(this.Record_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ComboBox cmbHistorial;
        private Panel panel2;
        private CustomizableButton btnLogOut;
        private CustomizableButton btnGet;
        private RichTextBox richTextBoxHistorial;
    }
}