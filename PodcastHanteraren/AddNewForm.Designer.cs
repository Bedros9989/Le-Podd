namespace PodcastHanteraren
{
    partial class AddNewForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.kategoriLabel = new System.Windows.Forms.Label();
            this.kategoriCombo = new System.Windows.Forms.ComboBox();
            this.titelLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.titelTextBox = new System.Windows.Forms.TextBox();
            this.sökKnapp = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.läggTillKnapp = new System.Windows.Forms.Button();
            this.antalAvsnitt = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.namnTextBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 37);
            this.label2.TabIndex = 37;
            this.label2.Text = "Lägg till podcast";
            // 
            // kategoriLabel
            // 
            this.kategoriLabel.AutoSize = true;
            this.kategoriLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriLabel.Location = new System.Drawing.Point(372, 220);
            this.kategoriLabel.Name = "kategoriLabel";
            this.kategoriLabel.Size = new System.Drawing.Size(71, 21);
            this.kategoriLabel.TabIndex = 35;
            this.kategoriLabel.Text = "Kategori:";
            // 
            // kategoriCombo
            // 
            this.kategoriCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategoriCombo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriCombo.FormattingEnabled = true;
            this.kategoriCombo.Location = new System.Drawing.Point(376, 244);
            this.kategoriCombo.Name = "kategoriCombo";
            this.kategoriCombo.Size = new System.Drawing.Size(250, 29);
            this.kategoriCombo.TabIndex = 34;
            // 
            // titelLabel
            // 
            this.titelLabel.AutoSize = true;
            this.titelLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titelLabel.Location = new System.Drawing.Point(374, 81);
            this.titelLabel.Name = "titelLabel";
            this.titelLabel.Size = new System.Drawing.Size(42, 21);
            this.titelLabel.TabIndex = 33;
            this.titelLabel.Text = "Titel:";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(57, 79);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(42, 21);
            this.urlLabel.TabIndex = 32;
            this.urlLabel.Text = "URL:";
            // 
            // titelTextBox
            // 
            this.titelTextBox.Enabled = false;
            this.titelTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titelTextBox.Location = new System.Drawing.Point(377, 108);
            this.titelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.titelTextBox.Name = "titelTextBox";
            this.titelTextBox.Size = new System.Drawing.Size(250, 29);
            this.titelTextBox.TabIndex = 30;
            // 
            // sökKnapp
            // 
            this.sökKnapp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(166)))), ((int)(((byte)(138)))));
            this.sökKnapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sökKnapp.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sökKnapp.ForeColor = System.Drawing.Color.White;
            this.sökKnapp.Location = new System.Drawing.Point(130, 147);
            this.sökKnapp.Margin = new System.Windows.Forms.Padding(2);
            this.sökKnapp.Name = "sökKnapp";
            this.sökKnapp.Size = new System.Drawing.Size(90, 38);
            this.sökKnapp.TabIndex = 29;
            this.sökKnapp.Text = "Sök";
            this.sökKnapp.UseVisualStyleBackColor = false;
            this.sökKnapp.Click += new System.EventHandler(this.sök_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlTextBox.Location = new System.Drawing.Point(54, 108);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(250, 29);
            this.urlTextBox.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(74, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // läggTillKnapp
            // 
            this.läggTillKnapp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(166)))), ((int)(((byte)(138)))));
            this.läggTillKnapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.läggTillKnapp.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.läggTillKnapp.ForeColor = System.Drawing.Color.White;
            this.läggTillKnapp.Location = new System.Drawing.Point(458, 291);
            this.läggTillKnapp.Margin = new System.Windows.Forms.Padding(2);
            this.läggTillKnapp.Name = "läggTillKnapp";
            this.läggTillKnapp.Size = new System.Drawing.Size(90, 38);
            this.läggTillKnapp.TabIndex = 39;
            this.läggTillKnapp.Text = "Lägg till";
            this.läggTillKnapp.UseVisualStyleBackColor = false;
            this.läggTillKnapp.Click += new System.EventHandler(this.läggTill_Click_1);
            // 
            // antalAvsnitt
            // 
            this.antalAvsnitt.AutoSize = true;
            this.antalAvsnitt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antalAvsnitt.Location = new System.Drawing.Point(109, 428);
            this.antalAvsnitt.Name = "antalAvsnitt";
            this.antalAvsnitt.Size = new System.Drawing.Size(67, 21);
            this.antalAvsnitt.TabIndex = 42;
            this.antalAvsnitt.Text = "Avsnitt...";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(374, 149);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(115, 21);
            this.nameLabel.TabIndex = 44;
            this.nameLabel.Text = "Namn (valfritt):";
            // 
            // namnTextBox
            // 
            this.namnTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namnTextBox.Location = new System.Drawing.Point(377, 178);
            this.namnTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.namnTextBox.Name = "namnTextBox";
            this.namnTextBox.Size = new System.Drawing.Size(250, 29);
            this.namnTextBox.TabIndex = 43;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(377, 421);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(249, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 45;
            // 
            // AddNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(674, 445);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.namnTextBox);
            this.Controls.Add(this.antalAvsnitt);
            this.Controls.Add(this.läggTillKnapp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kategoriLabel);
            this.Controls.Add(this.kategoriCombo);
            this.Controls.Add(this.titelLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.titelTextBox);
            this.Controls.Add(this.sökKnapp);
            this.Controls.Add(this.urlTextBox);
            this.Name = "AddNewForm";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label kategoriLabel;
        private System.Windows.Forms.ComboBox kategoriCombo;
        private System.Windows.Forms.Label titelLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox titelTextBox;
        private System.Windows.Forms.Button sökKnapp;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button läggTillKnapp;
        private System.Windows.Forms.Label antalAvsnitt;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox namnTextBox;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}