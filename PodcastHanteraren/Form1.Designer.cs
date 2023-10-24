namespace PodcastHanteraren
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.läggTill = new System.Windows.Forms.Button();
            this.poddTabell = new System.Windows.Forms.DataGridView();
            this.avsnittsTabell = new System.Windows.Forms.DataGridView();
            this.namnTextBox = new System.Windows.Forms.TextBox();
            this.taBort = new System.Windows.Forms.Button();
            this.urlLabel = new System.Windows.Forms.Label();
            this.namnLabel = new System.Windows.Forms.Label();
            this.kategoriCombo = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.kategoriLabel = new System.Windows.Forms.Label();
            this.ändra = new System.Windows.Forms.Button();
            this.filtrera = new System.Windows.Forms.ComboBox();
            this.återställ = new System.Windows.Forms.Button();
            this.avsnittLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kategoriTextBox = new System.Windows.Forms.TextBox();
            this.läggTill2 = new System.Windows.Forms.Button();
            this.ändra2 = new System.Windows.Forms.Button();
            this.taBort2 = new System.Windows.Forms.Button();
            this.kategoriLabel2 = new System.Windows.Forms.Label();
            this.kategoriTabell = new System.Windows.Forms.DataGridView();
            this.spara = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.spara2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.poddTabell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avsnittsTabell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriTabell)).BeginInit();
            this.SuspendLayout();
            // 
            // urlTextBox
            // 
            this.urlTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlTextBox.Location = new System.Drawing.Point(118, 62);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(250, 20);
            this.urlTextBox.TabIndex = 0;
            // 
            // läggTill
            // 
            this.läggTill.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.läggTill.Location = new System.Drawing.Point(410, 71);
            this.läggTill.Margin = new System.Windows.Forms.Padding(2);
            this.läggTill.Name = "läggTill";
            this.läggTill.Size = new System.Drawing.Size(81, 24);
            this.läggTill.TabIndex = 1;
            this.läggTill.Text = "Lägg till";
            this.läggTill.UseVisualStyleBackColor = true;
            this.läggTill.Click += new System.EventHandler(this.button1_Click);
            // 
            // poddTabell
            // 
            this.poddTabell.AllowUserToAddRows = false;
            this.poddTabell.AllowUserToDeleteRows = false;
            this.poddTabell.AllowUserToOrderColumns = true;
            this.poddTabell.AllowUserToResizeColumns = false;
            this.poddTabell.AllowUserToResizeRows = false;
            this.poddTabell.BackgroundColor = System.Drawing.Color.White;
            this.poddTabell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.poddTabell.Location = new System.Drawing.Point(39, 174);
            this.poddTabell.Margin = new System.Windows.Forms.Padding(2);
            this.poddTabell.Name = "poddTabell";
            this.poddTabell.RowHeadersVisible = false;
            this.poddTabell.RowHeadersWidth = 15;
            this.poddTabell.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.poddTabell.RowTemplate.Height = 23;
            this.poddTabell.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.poddTabell.Size = new System.Drawing.Size(453, 351);
            this.poddTabell.TabIndex = 2;
            this.poddTabell.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.poddTabell.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.poddTabell_CellDoubleClick);
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
            this.avsnittsTabell.Location = new System.Drawing.Point(521, 174);
            this.avsnittsTabell.Margin = new System.Windows.Forms.Padding(2);
            this.avsnittsTabell.Name = "avsnittsTabell";
            this.avsnittsTabell.RowHeadersVisible = false;
            this.avsnittsTabell.RowHeadersWidth = 82;
            this.avsnittsTabell.RowTemplate.Height = 23;
            this.avsnittsTabell.RowTemplate.ReadOnly = true;
            this.avsnittsTabell.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.avsnittsTabell.Size = new System.Drawing.Size(334, 351);
            this.avsnittsTabell.TabIndex = 3;
            this.avsnittsTabell.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.avsnittsTabell_CellClick);
            // 
            // namnTextBox
            // 
            this.namnTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namnTextBox.Location = new System.Drawing.Point(118, 89);
            this.namnTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.namnTextBox.Name = "namnTextBox";
            this.namnTextBox.Size = new System.Drawing.Size(250, 20);
            this.namnTextBox.TabIndex = 4;
            // 
            // taBort
            // 
            this.taBort.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taBort.Location = new System.Drawing.Point(410, 100);
            this.taBort.Name = "taBort";
            this.taBort.Size = new System.Drawing.Size(81, 23);
            this.taBort.TabIndex = 5;
            this.taBort.Text = "Ta bort";
            this.taBort.UseVisualStyleBackColor = true;
            this.taBort.Click += new System.EventHandler(this.button2_Click);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(81, 69);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(30, 14);
            this.urlLabel.TabIndex = 6;
            this.urlLabel.Text = "URL:";
            // 
            // namnLabel
            // 
            this.namnLabel.AutoSize = true;
            this.namnLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namnLabel.Location = new System.Drawing.Point(38, 92);
            this.namnLabel.Name = "namnLabel";
            this.namnLabel.Size = new System.Drawing.Size(78, 14);
            this.namnLabel.TabIndex = 7;
            this.namnLabel.Text = "Namn (valfritt):";
            // 
            // kategoriCombo
            // 
            this.kategoriCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategoriCombo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriCombo.FormattingEnabled = true;
            this.kategoriCombo.Location = new System.Drawing.Point(118, 114);
            this.kategoriCombo.Name = "kategoriCombo";
            this.kategoriCombo.Size = new System.Drawing.Size(152, 22);
            this.kategoriCombo.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(276, 114);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 22);
            this.comboBox2.TabIndex = 9;
            // 
            // kategoriLabel
            // 
            this.kategoriLabel.AutoSize = true;
            this.kategoriLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriLabel.Location = new System.Drawing.Point(63, 117);
            this.kategoriLabel.Name = "kategoriLabel";
            this.kategoriLabel.Size = new System.Drawing.Size(50, 14);
            this.kategoriLabel.TabIndex = 10;
            this.kategoriLabel.Text = "Kategori:";
            // 
            // ändra
            // 
            this.ändra.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ändra.Location = new System.Drawing.Point(410, 127);
            this.ändra.Name = "ändra";
            this.ändra.Size = new System.Drawing.Size(81, 23);
            this.ändra.TabIndex = 11;
            this.ändra.Text = "Ändra";
            this.ändra.UseVisualStyleBackColor = true;
            this.ändra.Click += new System.EventHandler(this.ändra_Click);
            // 
            // filtrera
            // 
            this.filtrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtrera.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrera.FormattingEnabled = true;
            this.filtrera.Location = new System.Drawing.Point(118, 142);
            this.filtrera.Name = "filtrera";
            this.filtrera.Size = new System.Drawing.Size(152, 22);
            this.filtrera.TabIndex = 12;
            this.filtrera.SelectedIndexChanged += new System.EventHandler(this.filtrera_SelectedIndexChanged);
            // 
            // återställ
            // 
            this.återställ.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.återställ.Location = new System.Drawing.Point(276, 140);
            this.återställ.Name = "återställ";
            this.återställ.Size = new System.Drawing.Size(92, 23);
            this.återställ.TabIndex = 13;
            this.återställ.Text = "Återställ";
            this.återställ.UseVisualStyleBackColor = true;
            this.återställ.Click += new System.EventHandler(this.återställ_Click);
            // 
            // avsnittLabel
            // 
            this.avsnittLabel.AutoSize = true;
            this.avsnittLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avsnittLabel.Location = new System.Drawing.Point(643, 121);
            this.avsnittLabel.Name = "avsnittLabel";
            this.avsnittLabel.Size = new System.Drawing.Size(83, 27);
            this.avsnittLabel.TabIndex = 16;
            this.avsnittLabel.Text = "Avsnitt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(952, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Beskrivning";
            // 
            // kategoriTextBox
            // 
            this.kategoriTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriTextBox.Location = new System.Drawing.Point(884, 116);
            this.kategoriTextBox.Name = "kategoriTextBox";
            this.kategoriTextBox.Size = new System.Drawing.Size(247, 20);
            this.kategoriTextBox.TabIndex = 18;
            // 
            // läggTill2
            // 
            this.läggTill2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.läggTill2.Location = new System.Drawing.Point(884, 144);
            this.läggTill2.Name = "läggTill2";
            this.läggTill2.Size = new System.Drawing.Size(75, 24);
            this.läggTill2.TabIndex = 19;
            this.läggTill2.Text = "Lägg till";
            this.läggTill2.UseVisualStyleBackColor = true;
            this.läggTill2.Click += new System.EventHandler(this.läggTill2_Click);
            // 
            // ändra2
            // 
            this.ändra2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ändra2.Location = new System.Drawing.Point(1056, 144);
            this.ändra2.Name = "ändra2";
            this.ändra2.Size = new System.Drawing.Size(75, 25);
            this.ändra2.TabIndex = 20;
            this.ändra2.Text = "Ändra";
            this.ändra2.UseVisualStyleBackColor = true;
            this.ändra2.Click += new System.EventHandler(this.ändra2_Click);
            // 
            // taBort2
            // 
            this.taBort2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taBort2.Location = new System.Drawing.Point(971, 144);
            this.taBort2.Name = "taBort2";
            this.taBort2.Size = new System.Drawing.Size(75, 25);
            this.taBort2.TabIndex = 21;
            this.taBort2.Text = "Ta bort";
            this.taBort2.UseVisualStyleBackColor = true;
            this.taBort2.Click += new System.EventHandler(this.taBort2_Click);
            // 
            // kategoriLabel2
            // 
            this.kategoriLabel2.AutoSize = true;
            this.kategoriLabel2.Location = new System.Drawing.Point(884, 95);
            this.kategoriLabel2.Name = "kategoriLabel2";
            this.kategoriLabel2.Size = new System.Drawing.Size(49, 13);
            this.kategoriLabel2.TabIndex = 22;
            this.kategoriLabel2.Text = "Kategori:";
            // 
            // kategoriTabell
            // 
            this.kategoriTabell.AllowUserToAddRows = false;
            this.kategoriTabell.AllowUserToDeleteRows = false;
            this.kategoriTabell.AllowUserToResizeColumns = false;
            this.kategoriTabell.AllowUserToResizeRows = false;
            this.kategoriTabell.BackgroundColor = System.Drawing.Color.White;
            this.kategoriTabell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.kategoriTabell.Location = new System.Drawing.Point(884, 174);
            this.kategoriTabell.Name = "kategoriTabell";
            this.kategoriTabell.RowHeadersVisible = false;
            this.kategoriTabell.RowTemplate.Height = 23;
            this.kategoriTabell.RowTemplate.ReadOnly = true;
            this.kategoriTabell.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kategoriTabell.Size = new System.Drawing.Size(247, 160);
            this.kategoriTabell.TabIndex = 23;
            // 
            // spara
            // 
            this.spara.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spara.Location = new System.Drawing.Point(410, 127);
            this.spara.Name = "spara";
            this.spara.Size = new System.Drawing.Size(81, 23);
            this.spara.TabIndex = 24;
            this.spara.Text = "Spara";
            this.spara.UseVisualStyleBackColor = true;
            this.spara.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(884, 386);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(247, 139);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // spara2
            // 
            this.spara2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spara2.Location = new System.Drawing.Point(1056, 144);
            this.spara2.Name = "spara2";
            this.spara2.Size = new System.Drawing.Size(75, 25);
            this.spara2.TabIndex = 26;
            this.spara2.Text = "Spara";
            this.spara2.UseVisualStyleBackColor = true;
            this.spara2.Click += new System.EventHandler(this.spara2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1171, 548);
            this.Controls.Add(this.spara2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.spara);
            this.Controls.Add(this.kategoriTabell);
            this.Controls.Add(this.kategoriLabel2);
            this.Controls.Add(this.taBort2);
            this.Controls.Add(this.ändra2);
            this.Controls.Add(this.läggTill2);
            this.Controls.Add(this.kategoriTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avsnittLabel);
            this.Controls.Add(this.återställ);
            this.Controls.Add(this.filtrera);
            this.Controls.Add(this.ändra);
            this.Controls.Add(this.kategoriLabel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.kategoriCombo);
            this.Controls.Add(this.namnLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.taBort);
            this.Controls.Add(this.namnTextBox);
            this.Controls.Add(this.avsnittsTabell);
            this.Controls.Add(this.poddTabell);
            this.Controls.Add(this.läggTill);
            this.Controls.Add(this.urlTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.poddTabell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avsnittsTabell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriTabell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button läggTill;
        private System.Windows.Forms.DataGridView poddTabell;
        private System.Windows.Forms.DataGridView avsnittsTabell;
        private System.Windows.Forms.TextBox namnTextBox;
        private System.Windows.Forms.Button taBort;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label namnLabel;
        private System.Windows.Forms.ComboBox kategoriCombo;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label kategoriLabel;
        private System.Windows.Forms.Button ändra;
        private System.Windows.Forms.ComboBox filtrera;
        private System.Windows.Forms.Button återställ;
        private System.Windows.Forms.Label avsnittLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kategoriTextBox;
        private System.Windows.Forms.Button läggTill2;
        private System.Windows.Forms.Button ändra2;
        private System.Windows.Forms.Button taBort2;
        private System.Windows.Forms.Label kategoriLabel2;
        private System.Windows.Forms.DataGridView kategoriTabell;
        private System.Windows.Forms.Button spara;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button spara2;
    }
}

