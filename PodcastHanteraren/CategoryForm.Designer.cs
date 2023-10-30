namespace PodcastHanteraren
{
    partial class CategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.kategoriTabell = new System.Windows.Forms.DataGridView();
            this.spara = new System.Windows.Forms.Button();
            this.kategoriLabel2 = new System.Windows.Forms.Label();
            this.taBort = new System.Windows.Forms.Button();
            this.läggTill = new System.Windows.Forms.Button();
            this.kategoriTextBox = new System.Windows.Forms.TextBox();
            this.ändra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriTabell)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 37);
            this.label2.TabIndex = 38;
            this.label2.Text = "Kategorier";
            // 
            // kategoriTabell
            // 
            this.kategoriTabell.AllowUserToAddRows = false;
            this.kategoriTabell.AllowUserToDeleteRows = false;
            this.kategoriTabell.AllowUserToResizeColumns = false;
            this.kategoriTabell.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriTabell.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.kategoriTabell.BackgroundColor = System.Drawing.Color.White;
            this.kategoriTabell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.kategoriTabell.Location = new System.Drawing.Point(41, 98);
            this.kategoriTabell.Name = "kategoriTabell";
            this.kategoriTabell.RowHeadersVisible = false;
            this.kategoriTabell.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriTabell.RowTemplate.Height = 35;
            this.kategoriTabell.RowTemplate.ReadOnly = true;
            this.kategoriTabell.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kategoriTabell.Size = new System.Drawing.Size(247, 315);
            this.kategoriTabell.TabIndex = 39;
            // 
            // spara
            // 
            this.spara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.spara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spara.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spara.ForeColor = System.Drawing.Color.White;
            this.spara.Location = new System.Drawing.Point(72, 426);
            this.spara.Name = "spara";
            this.spara.Size = new System.Drawing.Size(90, 38);
            this.spara.TabIndex = 44;
            this.spara.Text = "Spara";
            this.spara.UseVisualStyleBackColor = false;
            this.spara.Click += new System.EventHandler(this.spara_Click);
            // 
            // kategoriLabel2
            // 
            this.kategoriLabel2.AutoSize = true;
            this.kategoriLabel2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriLabel2.Location = new System.Drawing.Point(361, 192);
            this.kategoriLabel2.Name = "kategoriLabel2";
            this.kategoriLabel2.Size = new System.Drawing.Size(111, 21);
            this.kategoriLabel2.TabIndex = 43;
            this.kategoriLabel2.Text = "Kategorinamn:";
            // 
            // taBort
            // 
            this.taBort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(166)))), ((int)(((byte)(138)))));
            this.taBort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taBort.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taBort.ForeColor = System.Drawing.Color.White;
            this.taBort.Location = new System.Drawing.Point(168, 426);
            this.taBort.Name = "taBort";
            this.taBort.Size = new System.Drawing.Size(90, 38);
            this.taBort.TabIndex = 42;
            this.taBort.Text = "Ta bort";
            this.taBort.UseVisualStyleBackColor = false;
            this.taBort.Click += new System.EventHandler(this.taBort_Click);
            // 
            // läggTill
            // 
            this.läggTill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(166)))), ((int)(((byte)(138)))));
            this.läggTill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.läggTill.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.läggTill.ForeColor = System.Drawing.Color.White;
            this.läggTill.Location = new System.Drawing.Point(438, 268);
            this.läggTill.Name = "läggTill";
            this.läggTill.Size = new System.Drawing.Size(90, 38);
            this.läggTill.TabIndex = 41;
            this.läggTill.Text = "Lägg till";
            this.läggTill.UseVisualStyleBackColor = false;
            this.läggTill.Click += new System.EventHandler(this.läggTill_Click);
            // 
            // kategoriTextBox
            // 
            this.kategoriTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriTextBox.Location = new System.Drawing.Point(363, 226);
            this.kategoriTextBox.Name = "kategoriTextBox";
            this.kategoriTextBox.Size = new System.Drawing.Size(247, 29);
            this.kategoriTextBox.TabIndex = 40;
            // 
            // ändra
            // 
            this.ändra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(166)))), ((int)(((byte)(138)))));
            this.ändra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ändra.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ändra.ForeColor = System.Drawing.Color.White;
            this.ändra.Location = new System.Drawing.Point(72, 426);
            this.ändra.Name = "ändra";
            this.ändra.Size = new System.Drawing.Size(90, 38);
            this.ändra.TabIndex = 45;
            this.ändra.Text = "Ändra";
            this.ändra.UseVisualStyleBackColor = false;
            this.ändra.Click += new System.EventHandler(this.ändra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 30);
            this.label1.TabIndex = 46;
            this.label1.Text = "Lägg till ny kategori";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(674, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ändra);
            this.Controls.Add(this.spara);
            this.Controls.Add(this.kategoriLabel2);
            this.Controls.Add(this.taBort);
            this.Controls.Add(this.läggTill);
            this.Controls.Add(this.kategoriTextBox);
            this.Controls.Add(this.kategoriTabell);
            this.Controls.Add(this.label2);
            this.Name = "CategoryForm";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.kategoriTabell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView kategoriTabell;
        private System.Windows.Forms.Button spara;
        private System.Windows.Forms.Label kategoriLabel2;
        private System.Windows.Forms.Button taBort;
        private System.Windows.Forms.Button läggTill;
        private System.Windows.Forms.TextBox kategoriTextBox;
        private System.Windows.Forms.Button ändra;
        private System.Windows.Forms.Label label1;
    }
}