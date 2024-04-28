
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user_log = new System.Windows.Forms.TextBox();
            this.user_pas = new System.Windows.Forms.TextBox();
            this.logintxt = new System.Windows.Forms.Label();
            this.haslotxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_Button
            // 
            this.Login_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Login_Button.Location = new System.Drawing.Point(693, 514);
            this.Login_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(253, 64);
            this.Login_Button.TabIndex = 0;
            this.Login_Button.Text = "Zaloguj";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Kino.Properties.Resources.Projekt_bez_nazwy;
            this.pictureBox1.Location = new System.Drawing.Point(440, 68);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(765, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(765, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // user_log
            // 
            this.user_log.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user_log.Location = new System.Drawing.Point(694, 393);
            this.user_log.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.user_log.Name = "user_log";
            this.user_log.Size = new System.Drawing.Size(252, 22);
            this.user_log.TabIndex = 2;
            this.user_log.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // user_pas
            // 
            this.user_pas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user_pas.Location = new System.Drawing.Point(693, 453);
            this.user_pas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.user_pas.Name = "user_pas";
            this.user_pas.Size = new System.Drawing.Size(252, 22);
            this.user_pas.TabIndex = 3;
            // 
            // logintxt
            // 
            this.logintxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logintxt.AutoSize = true;
            this.logintxt.BackColor = System.Drawing.Color.Transparent;
            this.logintxt.Location = new System.Drawing.Point(800, 373);
            this.logintxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logintxt.Name = "logintxt";
            this.logintxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logintxt.Size = new System.Drawing.Size(40, 16);
            this.logintxt.TabIndex = 4;
            this.logintxt.Text = "Login";
            this.logintxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logintxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // haslotxt
            // 
            this.haslotxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.haslotxt.AutoSize = true;
            this.haslotxt.BackColor = System.Drawing.Color.Transparent;
            this.haslotxt.Location = new System.Drawing.Point(800, 433);
            this.haslotxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.haslotxt.Name = "haslotxt";
            this.haslotxt.Size = new System.Drawing.Size(43, 16);
            this.haslotxt.TabIndex = 5;
            this.haslotxt.Text = "Haslo";
            this.haslotxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.BackgroundImage = global::Kino.Properties.Resources.gradient_circle_loop_orange_abstract_background_free_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.Controls.Add(this.haslotxt);
            this.Controls.Add(this.logintxt);
            this.Controls.Add(this.user_pas);
            this.Controls.Add(this.user_log);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Login_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox user_log;
        private System.Windows.Forms.TextBox user_pas;
        private System.Windows.Forms.Label logintxt;
        private System.Windows.Forms.Label haslotxt;
    }
}

