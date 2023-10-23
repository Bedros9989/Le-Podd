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
            visaTabell();
            kategoriTabellen();
        }

        private void tabellProperties()
        {
            poddTabell.Columns.Clear();
            poddTabell.AutoGenerateColumns = false;
            avsnittsTabell.Columns.Clear();
            avsnittsTabell.AutoGenerateColumns = false;

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
                Width = 300
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

        private void button1_Click(object sender, EventArgs e)
        {

            string rssUrl = urlTextBox.Text;
            string namnet = namnTextBox.Text;
            SyndicationFeed feed = podcastManager.FetchRssData(rssUrl);

            if (feed != null)
            {
                string podcastName = namnet;
                string title = feed.Title?.Text ?? "Unknown Podcast";
                string category = "YourCategory";
                string url = rssUrl;
                int AntalAvsnitt = 0;

                Podcast podcasten = new Podcast(podcastName, title, url, category, AntalAvsnitt);

                foreach (SyndicationItem item in feed.Items)
                {
                    string episodeName = item.Title?.Text ?? "Unkown Episode Name";
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
                // Handle the case where RSS data could not be fetched
            }
        }

        public void visaTabell()
        {
            List<Podcast> allPodcasts = podcastManager.RetrieveAllPodcasts();
            poddTabell.DataSource = allPodcasts;
        }
  
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < poddTabell.Rows.Count) // Check for valid row index
            {
                DataGridViewRow selectedRow = poddTabell.Rows[e.RowIndex];
                string podcastName = selectedRow.Cells["PodcastName"].Value.ToString();

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
                // Create a new Category object
                Category newCategory = new Category(categoryName);

                // Add the new category to your list of categories
                podcastManager.CreateEnCategory(newCategory);

                // Optionally, clear the text box for the next input
                kategoriTextBox.Text = "";

                // Refresh the category list in your form if needed
                kategoriTabellen();
            }
            else
            {
                MessageBox.Show("Please enter a valid category name.");
            }

        }
        private void kategoriTabellen()
        {
            kategoriTabell.DataSource = null;
            List<Category> allCategories = podcastManager.RetrieveAllCategories();
            kategoriTabell.DataSource = allCategories;
        }

        private void taBort2_Click(object sender, EventArgs e)
        {
            if (kategoriTabell.SelectedRows.Count > 0)
            {
                string categoryName = kategoriTabell.SelectedRows[0].Cells["Name"].Value.ToString();

                try
                {
                    podcastManager.DeleteACategory(categoryName);
                    MessageBox.Show($"Category '{categoryName}' has been deleted.");
                    kategoriTabellen();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to delete the category: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete.");
            }
        }
    }
}
