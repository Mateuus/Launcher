namespace Launcher
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.label1 = new System.Windows.Forms.Label();
            this.Minimized = new System.Windows.Forms.Button();
            this.Closed = new System.Windows.Forms.Button();
            this.Noticias = new System.Windows.Forms.WebBrowser();
            this.logo = new System.Windows.Forms.PictureBox();
            this.background2 = new System.Windows.Forms.Panel();
            this.img_senha = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.fillet2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fillet1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.img_email = new System.Windows.Forms.PictureBox();
            this.Background1 = new System.Windows.Forms.Panel();
            this.Login_Start = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Login_Start_Off = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.background2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_senha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_email)).BeginInit();
            this.Background1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Minimized
            // 
            this.Minimized.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Minimized, "Minimized");
            this.Minimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Minimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Minimized.Name = "Minimized";
            this.Minimized.UseVisualStyleBackColor = false;
            this.Minimized.Click += new System.EventHandler(this.Minimized_Click);
            // 
            // Closed
            // 
            this.Closed.BackColor = System.Drawing.Color.Transparent;
            this.Closed.FlatAppearance.BorderSize = 2;
            this.Closed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Closed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.Closed, "Closed");
            this.Closed.Name = "Closed";
            this.Closed.UseVisualStyleBackColor = false;
            this.Closed.Click += new System.EventHandler(this.Close_Click);
            // 
            // Noticias
            // 
            resources.ApplyResources(this.Noticias, "Noticias");
            this.Noticias.Name = "Noticias";
            this.Noticias.Url = new System.Uri("http://www.lambero.com.br/newpatch/novidades.php", System.UriKind.Absolute);
            this.Noticias.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Noticias_DocumentCompleted);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::Launcher.Properties.Resources.logo;
            resources.ApplyResources(this.logo, "logo");
            this.logo.Name = "logo";
            this.logo.TabStop = false;
            // 
            // background2
            // 
            this.background2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.background2.Controls.Add(this.img_senha);
            this.background2.Controls.Add(this.textBox2);
            this.background2.Controls.Add(this.fillet2);
            resources.ApplyResources(this.background2, "background2");
            this.background2.Name = "background2";
            // 
            // img_senha
            // 
            this.img_senha.Image = global::Launcher.Properties.Resources.appbar_interface2;
            resources.ApplyResources(this.img_senha, "img_senha");
            this.img_senha.Name = "img_senha";
            this.img_senha.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.Name = "textBox2";
            this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // fillet2
            // 
            this.fillet2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.fillet2, "fillet2");
            this.fillet2.Name = "fillet2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Launcher.Properties.Resources.painel_login;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // fillet1
            // 
            this.fillet1.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.fillet1, "fillet1");
            this.fillet1.Name = "fillet1";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Name = "textBox1";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // img_email
            // 
            this.img_email.Image = global::Launcher.Properties.Resources.appbar_interface1;
            resources.ApplyResources(this.img_email, "img_email");
            this.img_email.Name = "img_email";
            this.img_email.TabStop = false;
            this.img_email.Click += new System.EventHandler(this.img_email_Click);
            // 
            // Background1
            // 
            this.Background1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Background1.Controls.Add(this.img_email);
            this.Background1.Controls.Add(this.textBox1);
            this.Background1.Controls.Add(this.fillet1);
            resources.ApplyResources(this.Background1, "Background1");
            this.Background1.Name = "Background1";
            // 
            // Login_Start
            // 
            this.Login_Start.BackColor = System.Drawing.Color.SeaGreen;
            this.Login_Start.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Login_Start, "Login_Start");
            this.Login_Start.ForeColor = System.Drawing.Color.White;
            this.Login_Start.Name = "Login_Start";
            this.Login_Start.UseVisualStyleBackColor = false;
            this.Login_Start.Click += new System.EventHandler(this.Login_Start_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Name = "label9";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Login_Start_Off
            // 
            this.Login_Start_Off.BackColor = System.Drawing.Color.Green;
            this.Login_Start_Off.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Login_Start_Off, "Login_Start_Off");
            this.Login_Start_Off.ForeColor = System.Drawing.Color.White;
            this.Login_Start_Off.Name = "Login_Start_Off";
            this.Login_Start_Off.UseVisualStyleBackColor = false;
            this.Login_Start_Off.Click += new System.EventHandler(this.Login_Start_Off_Click);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Launcher
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Launcher.Properties.Resources.backgroundimg;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Login_Start);
            this.Controls.Add(this.background2);
            this.Controls.Add(this.Background1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.Noticias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Minimized);
            this.Controls.Add(this.Closed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Login_Start_Off);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Launcher";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.background2.ResumeLayout(false);
            this.background2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_senha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_email)).EndInit();
            this.Background1.ResumeLayout(false);
            this.Background1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Minimized;
        private System.Windows.Forms.Button Closed;
        private System.Windows.Forms.WebBrowser Noticias;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel background2;
        private System.Windows.Forms.PictureBox img_senha;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel fillet2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel fillet1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox img_email;
        private System.Windows.Forms.Panel Background1;
        private System.Windows.Forms.Button Login_Start;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Login_Start_Off;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;


    }
}

