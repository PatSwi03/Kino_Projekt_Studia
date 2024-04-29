
namespace Kino
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Login_Button = new System.Windows.Forms.Button();
            this.user_log = new System.Windows.Forms.TextBox();
            this.user_pas = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_Button
            // 
            this.Login_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Login_Button.BackColor = System.Drawing.Color.Transparent;
            this.Login_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login_Button.FlatAppearance.BorderSize = 0;
            this.Login_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Button.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login_Button.Location = new System.Drawing.Point(74, 362);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(190, 52);
            this.Login_Button.TabIndex = 0;
            this.Login_Button.Text = "Zaloguj";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_log
            // 
            this.user_log.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user_log.BackColor = System.Drawing.Color.DimGray;
            this.user_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_log.Location = new System.Drawing.Point(74, 250);
            this.user_log.Name = "user_log";
            this.user_log.Size = new System.Drawing.Size(190, 13);
            this.user_log.TabIndex = 2;
            this.user_log.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // user_pas
            // 
            this.user_pas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user_pas.BackColor = System.Drawing.Color.DimGray;
            this.user_pas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_pas.Location = new System.Drawing.Point(74, 299);
            this.user_pas.Name = "user_pas";
            this.user_pas.Size = new System.Drawing.Size(190, 13);
            this.user_pas.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(74, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(73, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 1);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Kino.Properties.Resources.account;
            this.pictureBox3.Location = new System.Drawing.Point(44, 248);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kino.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(44, 297);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Kino.Properties.Resources.Projekt_bez_nazwy;
            this.pictureBox1.Location = new System.Drawing.Point(-118, -6);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(574, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 523);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.user_pas);
            this.Controls.Add(this.user_log);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Login_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox user_log;
        private System.Windows.Forms.TextBox user_pas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

