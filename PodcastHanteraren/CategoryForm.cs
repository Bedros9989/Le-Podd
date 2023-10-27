using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PodcastHanteraren
{
    public partial class CategoryForm : Form
    {
        PodcastManager podcastManager;
        public CategoryForm()
        {
            podcastManager = new PodcastManager();
            InitializeComponent();
            kategoriTabellen();
            fyllTabellen();
        }

        private void killOtherWindows()
        {
            if (this.ParentForm is MainForm mainForm)
            {
                if (mainForm.childForms.TryGetValue("LibraryForm", out Form libraryForm))
                {
                    if (libraryForm is LibraryForm)
                    {
                        AddNewForm addNew = Application.OpenForms.OfType<AddNewForm>().FirstOrDefault();
                        LibraryForm library = Application.OpenForms.OfType<LibraryForm>().FirstOrDefault();
                        addNew?.Close();
                        library?.Close();
                        mainForm.initializeAddNew();
                        mainForm.initializeLibrary();
                    }
                }
            }
        }

        private void fyllTabellen()
        {
            kategoriTabell.ReadOnly = true;
            kategoriTabell.DataSource = null;
            List<Category> allCategories = podcastManager.RetrieveAll<Category>();
            kategoriTabell.DataSource = allCategories;
            kategoriTabell.AutoGenerateColumns = false;
            
        }

        private void kategoriTabellen()
        {
            DataGridViewColumn categoryNamnColumn = new DataGridViewTextBoxColumn
            {
                Name = "Kategorier",
                HeaderText = "Kategorier",
                DataPropertyName = "Name",
                Visible = true,
                Width = 244
            };
            kategoriTabell.Columns.Add(categoryNamnColumn);
            kategoriTabell.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void läggTill_Click(object sender, EventArgs e)
        {
            string categoryName = kategoriTextBox.Text;

            if (ValidationClass.KategoriExisterarRedan(categoryName) && ValidationClass.RutanÄrTom(kategoriTextBox, kategoriLabel2))
            {
                Category newCategory = new Category(categoryName);
                podcastManager.Create(newCategory);
                kategoriTextBox.Text = "";
                fyllTabellen();
                killOtherWindows();
            }
        }

        private void taBort_Click(object sender, EventArgs e)
        {
            if (kategoriTabell.SelectedRows.Count > 0)
            {
                string itemName = kategoriTabell.SelectedRows[0].Cells["Kategorier"].Value.ToString();
                DialogResult result = MessageBox.Show($"Är du säker att du vill ta bort '{itemName}'?", "Beräfta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        
                        podcastManager.Delete(itemName, true);
                        MessageBox.Show($"Kategori '{itemName}' har tagits bort.");
                        fyllTabellen();
                        killOtherWindows();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Kunde inte ta bort: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vänligen välj ett element att ta bort.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ändra_Click(object sender, EventArgs e)
        {
            if (kategoriTabell.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = kategoriTabell.SelectedRows[0];
                DataGridViewCell categoryNameCell = selectedRow.Cells["Kategorier"];

                if (categoryNameCell != null)
                {
                    kategoriTabell.ReadOnly = false;
                    kategoriTabell.CurrentCell = categoryNameCell;
                    kategoriTabell.BeginEdit(true);
                    spara.Visible = true;
                    ändra.Visible = false;
                }
            }
        }

        private void spara_Click(object sender, EventArgs e)
        {
            if (kategoriTabell.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = kategoriTabell.SelectedRows[0];

                if (selectedRow.Cells["Kategorier"].Value != null)
                {
                    int selectedIndex = kategoriTabell.SelectedRows[0].Index;
                    string newValue = selectedRow.Cells["Kategorier"].Value.ToString();

                    if (ValidationClass.KategoriExisterarRedan(newValue))
                    {
                        podcastManager.Update(selectedIndex, newValue);
                        spara.Visible = false;
                        ändra.Visible = true;
                        fyllTabellen();
                        killOtherWindows();
                    }
                }
            }
        }
    }
}
