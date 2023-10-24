using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel.Syndication;
using DAL.Repository; // Import your repository namespace
using BLL;
using Models;
using System.Security.Policy;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace PodcastHanteraren
{
    public partial class Form1 : Form
    {
        PodcastManager podcastManager;
        ValidationClass valideringsKlass;
        public Form1()
        {
            InitializeComponent();
            podcastManager = new PodcastManager();
            valideringsKlass = new ValidationClass();
            tabellProperties();
            visaTabell();
            kategoriTabellen();
            kategoriDropBox();
            frekvens();
            spara.Visible = false;
            spara2.Visible = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void tabellProperties()
        {
            poddTabell.Columns.Clear();
            poddTabell.AutoGenerateColumns = false;
            avsnittsTabell.Columns.Clear();
            avsnittsTabell.AutoGenerateColumns = false;
            kategoriTabell.AutoGenerateColumns = false;

            DataGridViewColumn antalAvsnittColumn = new DataGridViewTextBoxColumn
            {
                Name = "AntalAvsnitt",
                HeaderText = "Antal Avsnitt",
                DataPropertyName = "AntalAvsnitt",
                Visible = true 
            };

            DataGridViewColumn podcastNamnColumn = new DataGridViewTextBoxColumn
            {
                Name = "PodcastName",
                HeaderText = "Podcast Namn",
                DataPropertyName = "PodcastName",
                Visible = true
            };

            DataGridViewColumn titleColumn = new DataGridViewTextBoxColumn
            {
                Name = "Title",
                HeaderText = "Titel",
                DataPropertyName = "Title", 
                Visible = true,
                Width = 150
            };

            DataGridViewColumn categoryColumn = new DataGridViewTextBoxColumn
            {
                Name = "Category",
                HeaderText = "Kategori",
                DataPropertyName = "Category", 
                Visible = true
            };

            DataGridViewColumn avsnittNamnColumn = new DataGridViewTextBoxColumn
            {
                Name = "Avsnitt",
                HeaderText = "Avsnitt",
                DataPropertyName = "EpisodeName",
                Visible = true,
                Width = 331
            };

            DataGridViewColumn categoryNamnColumn = new DataGridViewTextBoxColumn
            {
                Name = "Kategorier",
                HeaderText = "Kategorier",
                DataPropertyName = "Name",
                Visible = true,
                Width = 244
            };

            
            poddTabell.Columns.Add(antalAvsnittColumn);
            poddTabell.Columns.Add(podcastNamnColumn);
            poddTabell.Columns.Add(titleColumn);
            poddTabell.Columns.Add(categoryColumn);
            kategoriTabell.Columns.Add(categoryNamnColumn);
            avsnittsTabell.Columns.Add(avsnittNamnColumn);
            poddTabell.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            kategoriTabell.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void kategoriDropBox()
        {
            List<Category> categories = podcastManager.RetrieveAllCategories();
            foreach (Category category in categories)
            {
                kategoriCombo.Items.Add(category.Name);
                filtrera.Items.Add(category.Name);
            }

        }

        private void frekvens()
        {
            frekvensCombo.Items.Clear();
            frekvensCombo.Items.Add("Frekvens");
            frekvensCombo.SelectedIndex = 0;
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            if (ValidationClass.IsComboBoxEmpty(kategoriCombo) && ValidationClass.RutanÄrTom(urlTextBox, urlLabel))
            {
                string rssUrl = urlTextBox.Text;
                string namnet = namnTextBox.Text;
                SyndicationFeed feed = await podcastManager.FetchRssDataAsync(rssUrl); // Använd await här

                if (feed != null)
                {
                    string podcastName = namnet;
                    string title = feed.Title?.Text ?? "Unknown Podcast";
                    string category = kategoriCombo.SelectedItem.ToString();
                    string url = rssUrl;
                    int AntalAvsnitt = 0;

                    Podcast podcasten = new Podcast(podcastName, title, url, category, AntalAvsnitt);

                    foreach (SyndicationItem item in feed.Items)
                    {
                        string episodeName = item.Title?.Text ?? "Unknown Episode Name";
                        string description = item.Summary?.Text ?? "No description";

                        PodcastEpisode episode = new PodcastEpisode(episodeName, description);

                        podcasten.Episodes.Add(episode);
                    }
                    podcasten.AntalAvsnitt = podcasten.Episodes.Count;
                    Console.WriteLine($"Episodes count for podcast '{podcastName}': {podcasten.Episodes.Count}");
                    podcastManager.CreateEnPodcast(podcasten);
                    visaTabell();
                }
                else
                {
                    // Hantera fallet där RSS-data inte kunde hämtas
                }
            }
        }

        public void visaTabell()
        {
            poddTabell.ReadOnly = true;
            List<Podcast> allPodcasts = podcastManager.RetrieveAllPodcasts();
            poddTabell.DataSource = allPodcasts;
        }
  
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < poddTabell.Rows.Count) // Check for valid row index
            {
                DataGridViewRow selectedRow = poddTabell.Rows[e.RowIndex];
                string podcastName = selectedRow.Cells["Title"].Value.ToString();

                // Call RetrieveAllPodcastEpisodes with the selected podcastName
                avsnittsTabell.DataSource = null;
                avsnittsTabell.DataSource = podcastManager.RetrieveAllPodcastEpisodes(podcastName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (poddTabell.SelectedRows.Count > 0)
            {
                try
                {
                    string podcastName = poddTabell.SelectedRows[0].Cells["PodcastName"].Value.ToString();
                    podcastManager.DeletePodcast(podcastName);
                    visaTabell();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void läggTill2_Click(object sender, EventArgs e)
        {

            string categoryName = kategoriTextBox.Text;

            if (!string.IsNullOrEmpty(categoryName))
            {
                Category newCategory = new Category(categoryName);
                podcastManager.CreateEnCategory(newCategory);
                kategoriTextBox.Text = "";
                kategoriTabellen();
                kategoriDropBox();
            }
            else
            {
                MessageBox.Show("Please enter a valid category name.");
            }

        }
        private void kategoriTabellen()
        {
            kategoriTabell.ReadOnly = true;
            kategoriTabell.DataSource = null;
            List<Category> allCategories = podcastManager.RetrieveAllCategories();
            kategoriTabell.DataSource = allCategories;
        }

        private void taBort2_Click(object sender, EventArgs e)
        {
            if (kategoriTabell.SelectedRows.Count > 0)
            {
                string categoryName = kategoriTabell.SelectedRows[0].Cells["Kategorier"].Value.ToString();

                // Display a confirmation dialog
                DialogResult result = MessageBox.Show($"Är du säker att du vill ta bort '{categoryName}'?", "Beräfta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        podcastManager.DeleteACategory(categoryName);
                        MessageBox.Show($"Kategori '{categoryName}' har tagits bort.");
                        kategoriTabellen();
                        kategoriDropBox();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to delete the category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete.");
            }
        }

        private void filtrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = (filtrera.SelectedItem != null) ? filtrera.SelectedItem.ToString() : string.Empty;

            if (category != null)
            {
                poddTabell.DataSource = null;
                poddTabell.DataSource = podcastManager.SortByCategory(category);
            }
            else
            {
                poddTabell.DataSource = null;
            }
        }

        private void ändra_Click(object sender, EventArgs e)
        {
            if (poddTabell.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = poddTabell.SelectedRows[0];
                DataGridViewCell podcastNameCell = selectedRow.Cells["PodcastName"];

                if (podcastNameCell != null)
                {
                    poddTabell.ReadOnly = false;
                    poddTabell.CurrentCell = podcastNameCell;
                    poddTabell.BeginEdit(true);
                    spara.Visible = true;
                }
            }

        }

        private void återställ_Click(object sender, EventArgs e)
        {
            filtrera.SelectedIndex = -1;
            visaTabell();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (poddTabell.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = poddTabell.SelectedRows[0];

                if (selectedRow.Cells["PodcastName"].Value != null)
                {
                    int selectedIndex = poddTabell.SelectedRows[0].Index;
                    string newValue = selectedRow.Cells["PodcastName"].Value.ToString();

                    podcastManager.UpdatePodcastName(selectedIndex,newValue);
                    spara.Visible = false;
                    visaTabell();
                }
            }
        }

        private void poddTabell_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == poddTabell.Columns["Category"].Index && e.RowIndex >= 0)
            {
                int selectedIndex = e.RowIndex;
                string currentCategory = poddTabell.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                List<Category> categoryList = podcastManager.RetrieveAllCategories();
                List<string> categoryNames = categoryList.Select(cat => cat.Name).ToList();

                using (Form2 categoryChangeForm = new Form2(currentCategory, categoryNames))
                {
                    if (categoryChangeForm.ShowDialog() == DialogResult.OK)
                    {
                        string selectedCategory = categoryChangeForm.SelectedCategory;
                        podcastManager.UpdatePodcastCategory(selectedIndex, selectedCategory);
                        visaTabell();
                    }
                }
            }
        }

        private void avsnittsTabell_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < avsnittsTabell.Rows.Count) // Check for valid row index
            {
                DataGridViewRow selectedRow = avsnittsTabell.Rows[e.RowIndex];
                string title = selectedRow.Cells["Avsnitt"].Value.ToString();

                PodcastEpisode episode = podcastManager.RetrieveEpisode(title);

                if (episode != null)
                {
                    richTextBox1.Text = episode.Description;
                }
                else
                {
                    richTextBox1.Text = "Episode not found.";
                }
            }

        }

        private void ändra2_Click(object sender, EventArgs e)
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
                    spara2.Visible = true;
                }
            }
        }

        private void spara2_Click(object sender, EventArgs e)
        {
            if (kategoriTabell.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = kategoriTabell.SelectedRows[0];

                if (selectedRow.Cells["Kategorier"].Value != null)
                {
                    int selectedIndex = kategoriTabell.SelectedRows[0].Index;
                    string newValue = selectedRow.Cells["Kategorier"].Value.ToString();

                    podcastManager.UpdateCategoryName(selectedIndex, newValue);
                    spara2.Visible = false;
                    kategoriTabellen();
                }
            }
        }

        private void frekvensCombo_DropDown(object sender, EventArgs e)
        {
            if (frekvensCombo.Items.Count > 0 && frekvensCombo.Items[0].ToString() == "Frekvens")
            {
                frekvensCombo.Items.RemoveAt(0);
            }
        }

        private void frekvensCombo_DropDownClosed(object sender, EventArgs e)
        {
            if (frekvensCombo.SelectedIndex == -1)
            {
                frekvensCombo.Items.Insert(0, "Frekvens");
                frekvensCombo.SelectedIndex = 0;
            }
        }
    }
}
