using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PodcastHanteraren
{
    public partial class PodcastForm : Form
    {
        private Podcast selectedPodcast;
        PodcastManager podcastManager;
        public event EventHandler CategoryUpdated;


        public PodcastForm(Podcast selectedPodcast)
        {
            InitializeComponent();
            podcastManager = new PodcastManager();
            this.selectedPodcast = selectedPodcast;
            this.Text = selectedPodcast.Title;
            sparaKnapp.Visible= false;
            start();
        }

        private void start()
        {
            Podcast enPodcast = podcastManager.RetrieveAll<Podcast>().FirstOrDefault(podcast => podcast.Title == selectedPodcast.Title);
            string podcastName = selectedPodcast.Title;
            titelLabel.Text = podcastName;
            namnTextBox.Text = enPodcast.PodcastName;


            if (!string.IsNullOrEmpty(selectedPodcast.ImageURL))
            {
                using (System.Net.WebClient client = new System.Net.WebClient())
                {
                    byte[] imageBytes = client.DownloadData(selectedPodcast.ImageURL);
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes))
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }

            avsnittsTabell.DataSource = null;
            avsnittsTabell.DataSource = podcastManager.RetrieveAllPodcastEpisodes(podcastName);
            avsnittsTabell.Columns.Clear();
            avsnittsTabell.AutoGenerateColumns = false;
            DataGridViewColumn avsnittNamnColumn = new DataGridViewTextBoxColumn
            {
                Name = "Avsnitt",
                HeaderText = "Avsnitt",
                DataPropertyName = "EpisodeName",
                Visible = true,
                Width = 366
            };
            avsnittsTabell.Columns.Add(avsnittNamnColumn);

            kategoriLabel.Text = "Kategori: " + selectedPodcast.Category;
            CategoryUpdated?.Invoke(this, EventArgs.Empty);
            antalAvsnitt.Text = "Antal avsnitt: " + selectedPodcast.AntalAvsnitt;

        }

        private void tillbaka()
        {
            this.Hide();
            if (this.ParentForm is MainForm mainForm)
            {
                mainForm.ShowChildForm("LibraryForm");
            }
        }

        private void ändra_Click(object sender, EventArgs e)
        {
            List<Podcast> allPodcasts = podcastManager.RetrieveAll<Podcast>();

            int index = allPodcasts.FindIndex(podcast => podcast.Title == selectedPodcast.Title);

            if (index != -1)
            {
                Console.WriteLine(index);

                using (ChangeForm categoryChangeForm = new ChangeForm(index, selectedPodcast.Category))
                {
                    categoryChangeForm.Form6CategoryUpdated += (s, updatedCategory) =>
                    {
                        selectedPodcast.Category = updatedCategory;
                        kategoriLabel.Text = "Kategori: " + selectedPodcast.Category;
                    };

                    if (categoryChangeForm.ShowDialog() == DialogResult.OK)
                    {
                        start();
                    }
                }

            }
            else
            {
                
            }
        }

        private void tillbaka_Click(object sender, EventArgs e)
        {
            tillbaka();
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
                    
                }
            }
        }

        private void taBort_Click(object sender, EventArgs e)
        {
            DialogResult confirmationResult = MessageBox.Show($"Är du säker att du vill ta bort '{selectedPodcast.Title}'?", "Beräfta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                if (this.ParentForm is MainForm mainForm)
                {
                    if (mainForm.childForms.TryGetValue("LibraryForm", out Form libraryForm))
                    {
                        if (libraryForm is LibraryForm)
                        {
                            podcastManager.Delete(selectedPodcast.Title);
                            tillbaka();
                            ((LibraryForm)libraryForm).PopulatePodcastsListView();
                            AddNewForm addNew = Application.OpenForms.OfType<AddNewForm>().FirstOrDefault();
                            addNew?.Close();
                            mainForm.initializeAddNew();
                        }
                    }
                }
            }
        }

        private void redigera_Click(object sender, EventArgs e)
        {
            namnTextBox.Enabled = true;
            sparaKnapp.Visible = true;
        }

        private void sparaKnapp_Click(object sender, EventArgs e)
        {
            string newValue = namnTextBox.Text;
            List <Podcast> allPodcasts = podcastManager.RetrieveAll<Podcast>();

            if (!ValidationClass.PodcastExists(newValue, true))
            {
                int index = allPodcasts.FindIndex(podcast => podcast.Title == selectedPodcast.Title);

                if (this.ParentForm is MainForm mainForm)
                {
                    if (mainForm.childForms.TryGetValue("LibraryForm", out Form libraryForm))
                    {
                        if (libraryForm is LibraryForm)
                        {
                            podcastManager.Update(index, newValue, "Name"); 
                            sparaKnapp.Visible = false;
                            ((LibraryForm)libraryForm).PopulatePodcastsListView();
                            start();
                        }
                    }
                }
            }
        }

    }
}
