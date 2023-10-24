using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.ServiceModel.Syndication;
using BLL;
using Models;

namespace PodcastHanteraren
{
    public partial class Form1 : Form
    {
        PodcastManager podcastManager;
        public Form1()
        {
            InitializeComponent();
            podcastManager = new PodcastManager();
            tabellProperties();
            visaTabell<Podcast>();
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
            List<Category> categories = podcastManager.RetrieveAll<Category>();
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
            string rssUrl = urlTextBox.Text;
            string namnet = namnTextBox.Text;

            if (ValidationClass.IsComboBoxEmpty(kategoriCombo) && ValidationClass.RutanÄrTom(urlTextBox, urlLabel) &&
                !ValidationClass.PodcastExists(namnet, true) && !ValidationClass.PodcastExists(rssUrl, false))
            {
                SyndicationFeed feed = await podcastManager.FetchRssDataAsync(rssUrl);

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
                    podcastManager.Create(podcasten);
                    visaTabell<Podcast>();
                }
                else
                {

                }
            }
        }

        public void visaTabell<T>()
        {
            poddTabell.ReadOnly = true;
            List<Podcast> allItems = podcastManager.RetrieveAll<Podcast>();
            poddTabell.DataSource = allItems;
        }
  
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < poddTabell.Rows.Count) 
            {
                DataGridViewRow selectedRow = poddTabell.Rows[e.RowIndex];
                string podcastName = selectedRow.Cells["Title"].Value.ToString();
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
                    string title = poddTabell.SelectedRows[0].Cells["Title"].Value.ToString();
                    DialogResult confirmationResult = MessageBox.Show($"Är du säker att du vill ta bort '{title}'?", "Beräfta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmationResult == DialogResult.Yes)
                    {
                        podcastManager.Delete(title);
                        visaTabell<Podcast>();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ett fel har inträffats: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void läggTill2_Click(object sender, EventArgs e)
        {
            string categoryName = kategoriTextBox.Text;

            if (ValidationClass.KategoriExisterarRedan(categoryName) && ValidationClass.RutanÄrTom(kategoriTextBox, kategoriLabel2))
            {
                Category newCategory = new Category(categoryName);
                podcastManager.Create(newCategory);
                kategoriTextBox.Text = "";
                kategoriTabellen();
                kategoriDropBox();
            }
        }

        private void kategoriTabellen()
        {
            kategoriTabell.ReadOnly = true;
            kategoriTabell.DataSource = null;
            List<Category> allCategories = podcastManager.RetrieveAll<Category>();
            kategoriTabell.DataSource = allCategories;
        }

        private void taBort2_Click(object sender, EventArgs e)
        {
            if (kategoriTabell.SelectedRows.Count > 0)
            {
                string itemName = kategoriTabell.SelectedRows[0].Cells["Kategorier"].Value.ToString();
                DialogResult result = MessageBox.Show($"Är du säker att du vill ta bort '{itemName}'?", "Beräfta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (kategoriTabell.Name == "podcastTabell")
                        {
                            podcastManager.Delete(itemName);
                            MessageBox.Show($"Podcast '{itemName}' har tagits bort.");
                        }
                        else
                        {
                            podcastManager.Delete(itemName, true);
                            MessageBox.Show($"Kategori '{itemName}' har tagits bort.");
                        }

                        kategoriTabellen();
                        kategoriDropBox();
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
            visaTabell<Podcast>();
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
                    if (!ValidationClass.PodcastExists(newValue, true))
                    {
                        podcastManager.Update(selectedIndex, newValue, "Name");
                        spara.Visible = false;
                        visaTabell<Podcast>();
                    }
                    else
                    {
                        selectedRow.Cells["PodcastName"].Style.BackColor = Color.Red;
                    }
                }
            }
        }

        private void poddTabell_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == poddTabell.Columns["Category"].Index && e.RowIndex >= 0)
            {
                int selectedIndex = e.RowIndex;
                string currentCategory = poddTabell.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                List<Category> categoryList = podcastManager.RetrieveAll<Category>();
                List<string> categoryNames = categoryList.Select(cat => cat.Name).ToList();

                using (Form2 categoryChangeForm = new Form2(currentCategory, categoryNames))
                {
                    if (categoryChangeForm.ShowDialog() == DialogResult.OK)
                    {
                        string selectedCategory = categoryChangeForm.SelectedCategory;
                        podcastManager.Update(selectedIndex, selectedCategory, "Category");
                        visaTabell<Podcast>();
                    }
                }
            }
        }

        private void avsnittsTabell_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < avsnittsTabell.Rows.Count) 
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
                    richTextBox1.Text = "Avsnitt hittades inte.";
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

                    if (ValidationClass.KategoriExisterarRedan(newValue))
                    {
                        podcastManager.Update(selectedIndex, newValue, "Name");
                        spara2.Visible = false;
                        kategoriTabellen();
                    }
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
