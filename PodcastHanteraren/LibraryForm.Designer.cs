namespace PodcastHanteraren
{
    partial class LibraryForm
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
            this.components = new System.ComponentModel.Container();
            this.listViewPodcasts = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sök = new System.Windows.Forms.TextBox();
            this.kategoriCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listViewPodcasts
            // 
            this.listViewPodcasts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewPodcasts.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPodcasts.HideSelection = false;
            this.listViewPodcasts.Location = new System.Drawing.Point(27, 79);
            this.listViewPodcasts.Name = "listViewPodcasts";
            this.listViewPodcasts.Size = new System.Drawing.Size(647, 400);
            this.listViewPodcasts.TabIndex = 0;
            this.listViewPodcasts.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(150, 150);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // sök
            // 
            this.sök.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sök.Location = new System.Drawing.Point(27, 15);
            this.sök.Name = "sök";
            this.sök.Size = new System.Drawing.Size(289, 29);
            this.sök.TabIndex = 1;
            this.sök.Text = "Sök...";
            this.sök.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.sök.Enter += new System.EventHandler(this.sök_Enter);
            // 
            // kategoriCombo
            // 
            this.kategoriCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategoriCombo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriCombo.FormattingEnabled = true;
            this.kategoriCombo.Location = new System.Drawing.Point(412, 15);
            this.kategoriCombo.Name = "kategoriCombo";
            this.kategoriCombo.Size = new System.Drawing.Size(250, 29);
            this.kategoriCombo.TabIndex = 35;
            this.kategoriCombo.SelectedIndexChanged += new System.EventHandler(this.kategoriCombo_SelectedIndexChanged);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 483);
            this.Controls.Add(this.kategoriCombo);
            this.Controls.Add(this.sök);
            this.Controls.Add(this.listViewPodcasts);
            this.Name = "LibraryForm";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPodcasts;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox sök;
        private System.Windows.Forms.ComboBox kategoriCombo;
    }
}