using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel.Syndication;
using System.Windows.Forms;

namespace PodcastHanteraren
{
    public partial class AddNewForm : Form
    {
        PodcastManager podcastManager;

        public AddNewForm()
        {
            InitializeComponent();
            podcastManager = new PodcastManager();
            kategoriDropBox();
            start();
        }

        private void start()
        {
            titelLabel.Visible = false;
            titelTextBox.Visible = false;
            namnTextBox.Visible = false;
            nameLabel.Visible = false;
            kategoriLabel.Visible = false;
            kategoriCombo.Visible = false;
            antalAvsnitt.Visible = false;
            läggTillKnapp.Visible = false;
            progressBar1.Visible = false;
        }

        private void kategoriDropBox()
        {
            List<Category> categories = podcastManager.RetrieveAll<Category>();
            foreach (Category category in categories)
            {
                kategoriCombo.Items.Add(category.Name);
            }
        }

        private async void sök_Click(object sender, EventArgs e)
        {
            string rssUrl = urlTextBox.Text;
            SyndicationFeed feed = await podcastManager.FetchRssDataAsync(rssUrl);

            if (feed != null)
            {
                string title = feed.Title?.Text ?? "Unknown Podcast";
                int episodeCount = feed.Items.Count();

                titelTextBox.Text = title;
                titelLabel.Visible = true;
                titelTextBox.Visible = true;
                namnTextBox.Visible = true;
                nameLabel.Visible = true;
                kategoriLabel.Visible = true;
                kategoriCombo.Visible = true;
                antalAvsnitt.Visible = true;
                läggTillKnapp.Visible = true;
                antalAvsnitt.Text = $"Antal avsnitt: {episodeCount}";
                
                string imageUrl = feed.ImageUrl?.ToString();

                if (!string.IsNullOrEmpty(imageUrl))
                {
                   
                    using (WebClient client = new WebClient())
                    {
                        byte[] imageBytes = client.DownloadData(imageUrl);
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            Image podcastImage = Image.FromStream(ms);
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.Image = podcastImage;
                        }
                    }
                    
                }
                
                else
                {   
                    pictureBox1.Image = null;
                }
            }
            else
            {
                antalAvsnitt.Text = "Episodes: N/A";
                pictureBox1.Image = null;
            }
        }

        private async void läggTill_Click_1(object sender, EventArgs e)
        {
            string rssUrl = urlTextBox.Text;
            string namnet = namnTextBox.Text;

            if (ValidationClass.IsComboBoxEmpty(kategoriCombo) && ValidationClass.RutanÄrTom(urlTextBox, urlLabel) &&
                !ValidationClass.PodcastExists(namnet, true) && !ValidationClass.PodcastExists(rssUrl, false))
            {
                progressBar1.Visible = true;
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.MarqueeAnimationSpeed = 30;

                SyndicationFeed feed = await podcastManager.FetchRssDataAsync(rssUrl);

                if (feed != null)
                {
                    string podcastName = namnet;
                    string title = feed.Title?.Text ?? "Unknown Podcast";
                    string category = kategoriCombo.SelectedItem.ToString();
                    string url = rssUrl;
                    int AntalAvsnitt = 0;

                    Podcast podcasten = new Podcast(podcastName, title, url, category, AntalAvsnitt);

                    string imageUrl = feed.ImageUrl?.ToString();

                    if (!string.IsNullOrEmpty(imageUrl))
                    {
                        podcasten.ImageURL = imageUrl;
                    }

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
                    progressBar1.Style = ProgressBarStyle.Continuous;
                    progressBar1.MarqueeAnimationSpeed = 0;
                    progressBar1.Visible = false;

                    if (this.ParentForm is MainForm mainForm)
                    {
                        if (mainForm.childForms.TryGetValue("LibraryForm", out Form libraryForm))
                        {
                            if (libraryForm is LibraryForm)
                            {
                                MessageBox.Show("Ny podcast har registrerats");
                                AddNewForm addNew = Application.OpenForms.OfType<AddNewForm>().FirstOrDefault();
                                ((LibraryForm)libraryForm).PopulatePodcastsListView();
                                addNew?.Close();
                                mainForm.initializeAddNew();
                                mainForm.ShowChildForm("AddNew");
                            }
                        }
                    }
                }
                else
                {
                    
                }
            }
        }
    }
}
