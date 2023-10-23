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
            
        }

        private void tabellProperties()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.Columns.Clear();
            dataGridView2.AutoGenerateColumns = false;

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
                HeaderText = "Podcast Name",
                DataPropertyName = "PodcastName",
                Visible = true
            };

            DataGridViewColumn titleColumn = new DataGridViewTextBoxColumn
            {
                Name = "Title",
                HeaderText = "Title",
                DataPropertyName = "Title", 
                Visible = true
            };

            DataGridViewColumn categoryColumn = new DataGridViewTextBoxColumn
            {
                Name = "Category",
                HeaderText = "Category",
                DataPropertyName = "Category", 
                Visible = true
            };

            DataGridViewColumn avsnittNamnColumn = new DataGridViewTextBoxColumn
            {
                Name = "Avsnitt",
                HeaderText = "Avsnitt",
                DataPropertyName = "EpisodeName",
                Visible = true,
                Width = 350
            };

            dataGridView1.Columns.Add(antalAvsnittColumn);
            dataGridView1.Columns.Add(podcastNamnColumn);
            dataGridView1.Columns.Add(titleColumn);
            dataGridView1.Columns.Add(categoryColumn);
            dataGridView2.Columns.Add(avsnittNamnColumn);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string rssUrl = textBox1.Text;
            string namnet = textBox2.Text;
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
            dataGridView1.DataSource = allPodcasts;
        }
  
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count) // Check for valid row index
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string podcastName = selectedRow.Cells["PodcastName"].Value.ToString();

                // Call RetrieveAllPodcastEpisodes with the selected podcastName
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = podcastManager.RetrieveAllPodcastEpisodes(podcastName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    string podcastName = dataGridView1.SelectedRows[0].Cells["PodcastName"].Value.ToString();
                    podcastManager.DeletePodcast(podcastName);
                    visaTabell();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
