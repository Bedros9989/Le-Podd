namespace PodcastHanteraren
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.avslutaKnapp = new System.Windows.Forms.Button();
            this.kategorierKnapp = new System.Windows.Forms.Button();
            this.läggTillKnapp = new System.Windows.Forms.Button();
            this.bibliotekKnapp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.video = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.video)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.avslutaKnapp);
            this.panelMenu.Controls.Add(this.kategorierKnapp);
            this.panelMenu.Controls.Add(this.läggTillKnapp);
            this.panelMenu.Controls.Add(this.bibliotekKnapp);
            this.panelMenu.Controls.Add(this.panel1);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // avslutaKnapp
            // 
            resources.ApplyResources(this.avslutaKnapp, "avslutaKnapp");
            this.avslutaKnapp.FlatAppearance.BorderSize = 0;
            this.avslutaKnapp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.avslutaKnapp.Image = global::PodcastHanteraren.Properties.Resources.shutdown;
            this.avslutaKnapp.Name = "avslutaKnapp";
            this.avslutaKnapp.UseVisualStyleBackColor = true;
            this.avslutaKnapp.Click += new System.EventHandler(this.avslutaKnapp_Click);
            // 
            // kategorierKnapp
            // 
            resources.ApplyResources(this.kategorierKnapp, "kategorierKnapp");
            this.kategorierKnapp.FlatAppearance.BorderSize = 0;
            this.kategorierKnapp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kategorierKnapp.Image = global::PodcastHanteraren.Properties.Resources.options_lines;
            this.kategorierKnapp.Name = "kategorierKnapp";
            this.kategorierKnapp.UseVisualStyleBackColor = true;
            this.kategorierKnapp.Click += new System.EventHandler(this.kategorier_Click);
            // 
            // läggTillKnapp
            // 
            resources.ApplyResources(this.läggTillKnapp, "läggTillKnapp");
            this.läggTillKnapp.FlatAppearance.BorderSize = 0;
            this.läggTillKnapp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.läggTillKnapp.Image = global::PodcastHanteraren.Properties.Resources.add1;
            this.läggTillKnapp.Name = "läggTillKnapp";
            this.läggTillKnapp.UseVisualStyleBackColor = true;
            this.läggTillKnapp.Click += new System.EventHandler(this.läggTill_Click_1);
            // 
            // bibliotekKnapp
            // 
            resources.ApplyResources(this.bibliotekKnapp, "bibliotekKnapp");
            this.bibliotekKnapp.FlatAppearance.BorderSize = 0;
            this.bibliotekKnapp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bibliotekKnapp.Image = global::PodcastHanteraren.Properties.Resources.library;
            this.bibliotekKnapp.Name = "bibliotekKnapp";
            this.bibliotekKnapp.UseVisualStyleBackColor = true;
            this.bibliotekKnapp.Click += new System.EventHandler(this.bibliotek_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.White;
            this.panelDesktopPane.Controls.Add(this.video);
            resources.ApplyResources(this.panelDesktopPane, "panelDesktopPane");
            this.panelDesktopPane.Name = "panelDesktopPane";
            // 
            // video
            // 
            resources.ApplyResources(this.video, "video");
            this.video.Name = "video";
            this.video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("video.OcxState")));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDesktopPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.video)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button bibliotekKnapp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button kategorierKnapp;
        private System.Windows.Forms.Button läggTillKnapp;
        private System.Windows.Forms.Button avslutaKnapp;
        private AxWMPLib.AxWindowsMediaPlayer video;
        private System.Windows.Forms.Label label1;
    }
}