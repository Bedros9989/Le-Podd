namespace PodcastHanteraren
{
    partial class PodcastForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titelLabel = new System.Windows.Forms.Label();
            this.kategoriLabel = new System.Windows.Forms.Label();
            this.ändraKnapp = new System.Windows.Forms.Button();
            this.avsnittsTabell = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.namnLabel = new System.Windows.Forms.Label();
            this.namnTextBox = new System.Windows.Forms.TextBox();
            this.sparaKnapp = new System.Windows.Forms.Button();
            this.raderaKnapp = new System.Windows.Forms.Button();
            this.redigeraKnapp = new System.Windows.Forms.Button();
            this.tillbakaKnapp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.antalAvsnitt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avsnittsTabell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titelLabel
            // 
            this.titelLabel.AutoSize = true;
            this.titelLabel.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titelLabel.Location = new System.Drawing.Point(107, 12);
            this.titelLabel.Name = "titelLabel";
            this.titelLabel.Size = new System.Drawing.Size(90, 37);
            this.titelLabel.TabIndex = 40;
            this.titelLabel.Text = "label1";
            // 
            // kategoriLabel
            // 
            this.kategoriLabel.AutoSize = true;
            this.kategoriLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriLabel.Location = new System.Drawing.Point(47, 98);
            this.kategoriLabel.Name = "kategoriLabel";
            this.kategoriLabel.Size = new System.Drawing.Size(52, 21);
            this.kategoriLabel.TabIndex = 41;
            this.kategoriLabel.Text = "label2";
            // 
            // ändraKnapp
            // 
            this.ändraKnapp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(166)))), ((int)(((byte)(138)))));
            this.ändraKnapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ändraKnapp.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ändraKnapp.Location = new System.Drawing.Point(291, 93);
            this.ändraKnapp.Margin = new System.Windows.Forms.Padding(2);
            this.ändraKnapp.Name = "ändraKnapp";
            this.ändraKnapp.Size = new System.Drawing.Size(90, 30);
            this.ändraKnapp.TabIndex = 42;
            this.ändraKnapp.Text = "Ändra";
            this.ändraKnapp.UseVisualStyleBackColor = false;
            this.ändraKnapp.Click += new System.EventHandler(this.ändra_Click);
            // 
            // avsnittsTabell
            // 
            this.avsnittsTabell.AllowUserToAddRows = false;
            this.avsnittsTabell.AllowUserToDeleteRows = false;
            this.avsnittsTabell.AllowUserToResizeColumns = false;
            this.avsnittsTabell.AllowUserToResizeRows = false;
            this.avsnittsTabell.BackgroundColor = System.Drawing.Color.White;
            this.avsnittsTabell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avsnittsTabell.GridColor = System.Drawing.SystemColors.ControlText;
            this.avsnittsTabell.Location = new System.Drawing.Point(33, 142);
            this.avsnittsTabell.Margin = new System.Windows.Forms.Padding(2);
            this.avsnittsTabell.Name = "avsnittsTabell";
            this.avsnittsTabell.RowHeadersVisible = false;
            this.avsnittsTabell.RowHeadersWidth = 82;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avsnittsTabell.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.avsnittsTabell.RowTemplate.Height = 35;
            this.avsnittsTabell.RowTemplate.ReadOnly = true;
            this.avsnittsTabell.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.avsnittsTabell.Size = new System.Drawing.Size(386, 315);
            this.avsnittsTabell.TabIndex = 43;
            this.avsnittsTabell.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.avsnittsTabell_CellClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(459, 258);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(200, 200);
            this.richTextBox1.TabIndex = 44;
            this.richTextBox1.Text = "";
            // 
            // namnLabel
            // 
            this.namnLabel.AutoSize = true;
            this.namnLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namnLabel.Location = new System.Drawing.Point(97, 59);
            this.namnLabel.Name = "namnLabel";
            this.namnLabel.Size = new System.Drawing.Size(56, 21);
            this.namnLabel.TabIndex = 48;
            this.namnLabel.Text = "Namn:";
            // 
            // namnTextBox
            // 
            this.namnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namnTextBox.Enabled = false;
            this.namnTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namnTextBox.Location = new System.Drawing.Point(157, 60);
            this.namnTextBox.Name = "namnTextBox";
            this.namnTextBox.Size = new System.Drawing.Size(135, 22);
            this.namnTextBox.TabIndex = 49;
            // 
            // sparaKnapp
            // 
            this.sparaKnapp.FlatAppearance.BorderSize = 0;
            this.sparaKnapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sparaKnapp.Image = global::PodcastHanteraren.Properties.Resources.diskette__1_;
            this.sparaKnapp.Location = new System.Drawing.Point(298, 56);
            this.sparaKnapp.Name = "sparaKnapp";
            this.sparaKnapp.Size = new System.Drawing.Size(27, 28);
            this.sparaKnapp.TabIndex = 50;
            this.sparaKnapp.UseVisualStyleBackColor = true;
            this.sparaKnapp.Click += new System.EventHandler(this.sparaKnapp_Click);
            // 
            // raderaKnapp
            // 
            this.raderaKnapp.FlatAppearance.BorderSize = 0;
            this.raderaKnapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raderaKnapp.Image = global::PodcastHanteraren.Properties.Resources.bin__1_;
            this.raderaKnapp.Location = new System.Drawing.Point(402, 8);
            this.raderaKnapp.Name = "raderaKnapp";
            this.raderaKnapp.Size = new System.Drawing.Size(29, 23);
            this.raderaKnapp.TabIndex = 47;
            this.raderaKnapp.UseVisualStyleBackColor = true;
            this.raderaKnapp.Click += new System.EventHandler(this.taBort_Click);
            // 
            // redigeraKnapp
            // 
            this.redigeraKnapp.FlatAppearance.BorderSize = 0;
            this.redigeraKnapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redigeraKnapp.Image = global::PodcastHanteraren.Properties.Resources.edit;
            this.redigeraKnapp.Location = new System.Drawing.Point(373, 8);
            this.redigeraKnapp.Name = "redigeraKnapp";
            this.redigeraKnapp.Size = new System.Drawing.Size(29, 23);
            this.redigeraKnapp.TabIndex = 46;
            this.redigeraKnapp.UseVisualStyleBackColor = true;
            this.redigeraKnapp.Click += new System.EventHandler(this.redigera_Click);
            // 
            // tillbakaKnapp
            // 
            this.tillbakaKnapp.FlatAppearance.BorderSize = 0;
            this.tillbakaKnapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tillbakaKnapp.Image = global::PodcastHanteraren.Properties.Resources.back__2_;
            this.tillbakaKnapp.Location = new System.Drawing.Point(12, 8);
            this.tillbakaKnapp.Name = "tillbakaKnapp";
            this.tillbakaKnapp.Size = new System.Drawing.Size(52, 37);
            this.tillbakaKnapp.TabIndex = 45;
            this.tillbakaKnapp.UseVisualStyleBackColor = true;
            this.tillbakaKnapp.Click += new System.EventHandler(this.tillbaka_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(459, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // antalAvsnitt
            // 
            this.antalAvsnitt.AutoSize = true;
            this.antalAvsnitt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antalAvsnitt.Location = new System.Drawing.Point(161, 469);
            this.antalAvsnitt.Name = "antalAvsnitt";
            this.antalAvsnitt.Size = new System.Drawing.Size(52, 21);
            this.antalAvsnitt.TabIndex = 51;
            this.antalAvsnitt.Text = "label2";
            // 
            // PodcastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 503);
            this.Controls.Add(this.antalAvsnitt);
            this.Controls.Add(this.sparaKnapp);
            this.Controls.Add(this.namnTextBox);
            this.Controls.Add(this.namnLabel);
            this.Controls.Add(this.raderaKnapp);
            this.Controls.Add(this.redigeraKnapp);
            this.Controls.Add(this.tillbakaKnapp);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.avsnittsTabell);
            this.Controls.Add(this.ändraKnapp);
            this.Controls.Add(this.kategoriLabel);
            this.Controls.Add(this.titelLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PodcastForm";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.avsnittsTabell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titelLabel;
        private System.Windows.Forms.Label kategoriLabel;
        private System.Windows.Forms.Button ändraKnapp;
        private System.Windows.Forms.DataGridView avsnittsTabell;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button tillbakaKnapp;
        private System.Windows.Forms.Button redigeraKnapp;
        private System.Windows.Forms.Button raderaKnapp;
        private System.Windows.Forms.Label namnLabel;
        private System.Windows.Forms.TextBox namnTextBox;
        private System.Windows.Forms.Button sparaKnapp;
        private System.Windows.Forms.Label antalAvsnitt;
    }
}