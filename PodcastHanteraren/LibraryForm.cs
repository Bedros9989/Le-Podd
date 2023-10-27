using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PodcastHanteraren
{
    public partial class LibraryForm : Form
    {
        PodcastManager podcastManager;
        private bool textBoxFirstClick = true;

        public LibraryForm()
        {
            podcastManager = new PodcastManager();
            InitializeComponent();
            listViewPodcasts.View = View.LargeIcon;
            listViewPodcasts.LargeImageList = imageList1;
            PopulatePodcastsListView();
            kategoriDropBox();
            listViewPodcasts.ItemActivate += listViewPodcasts_ItemActivate;
        }

        private void kategoriDropBox()
        {
            kategoriCombo.Items.Add("");
            List<Category> categories = podcastManager.RetrieveAll<Category>();
            foreach (Category category in categories)
            {
                kategoriCombo.Items.Add(category.Name);
            }
        }

        public void PopulatePodcastsListView()
        {
            listViewPodcasts.Items.Clear();
            imageList1.Images.Clear(); 

            List<Podcast> podcasts = podcastManager.RetrieveAll<Podcast>();

            foreach (Podcast podcast in podcasts)
            {

                string displayText = string.IsNullOrEmpty(podcast.PodcastName) ? podcast.Title : podcast.PodcastName;
                string imageKey = string.IsNullOrEmpty(podcast.ImageURL) ? "DefaultImage" : podcast.Title;

                if (!string.IsNullOrEmpty(podcast.ImageURL))
                {
                    using (System.Net.WebClient client = new System.Net.WebClient())
                    {
                        byte[] imageBytes = client.DownloadData(podcast.ImageURL);
                        using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes))
                        {
                            Image podcastImage = Image.FromStream(ms);
                            imageList1.Images.Add(imageKey, podcastImage);
                        }
                    }
                }
                else
                {
                    if (!imageList1.Images.ContainsKey("DefaultImage"))
                    {
                        Image defaultImage = Image.FromFile("default_image.png");
                        imageList1.Images.Add("DefaultImage", defaultImage);
                    }
                }

                ListViewItem item = new ListViewItem
                {
                    Text = displayText, 
                    ImageKey = imageKey, 
                    Tag = podcast,
                };

                listViewPodcasts.Items.Add(item);
            }
        }

        private void listViewPodcasts_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listViewPodcasts.SelectedItems[0];
            Podcast selectedPodcast = selectedItem.Tag as Podcast;
           
            if (selectedPodcast != null)
            {
                PodcastForm podcastForm = new PodcastForm(selectedPodcast);
                ((MainForm)this.ParentForm).OpenPodcastInsidePanel(podcastForm);
            }
        }

        private void kategoriCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewPodcasts.Items.Clear();
            string category = (kategoriCombo.SelectedItem != null) ? kategoriCombo.SelectedItem.ToString() : string.Empty;
            List<Podcast> filteredPodcasts;
            if (string.IsNullOrWhiteSpace(category))
            {
                filteredPodcasts = podcastManager.RetrieveAll<Podcast>();
            }
            else
            {
                filteredPodcasts = podcastManager.SortByCategory(category);
            }

            PopulateListViewWithPodcasts(filteredPodcasts);
        }

        private void PopulateListViewWithPodcasts(List<Podcast> podcasts)
        {
            listViewPodcasts.Items.Clear();
            foreach (Podcast podcast in podcasts)
            {
                ListViewItem item = new ListViewItem
                {
                    Text = podcast.Title,
                    ImageKey = podcast.Title,
                    Tag = podcast,
                };

                listViewPodcasts.Items.Add(item);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = sök.Text;
            listViewPodcasts.Items.Clear();
            List<Podcast> allPodcasts = podcastManager.RetrieveAll<Podcast>();

            List<Podcast> filteredPodcasts = allPodcasts
                .Where(podcast =>
                    podcast.Title.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 || // Search in Title
                    (!string.IsNullOrEmpty(podcast.PodcastName) && podcast.PodcastName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0) // Search in PodcastName
                )
                .ToList();

            foreach (Podcast podcast in filteredPodcasts)
            {
                string displayText = string.IsNullOrEmpty(podcast.PodcastName) ? podcast.Title : podcast.PodcastName;
                ListViewItem item = new ListViewItem(displayText)
                {
                    ImageKey = podcast.Title,
                    Tag = podcast
                };
                listViewPodcasts.Items.Add(item);
            }
        }

        private void sök_Enter(object sender, EventArgs e)
        {

            if (textBoxFirstClick)
            {
                sök.Text = "";
                textBoxFirstClick = false;
            }
        }
    }
}
