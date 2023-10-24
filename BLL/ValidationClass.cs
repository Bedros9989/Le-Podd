using Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BLL
{
    public class ValidationClass
    {
     
        public static bool RutanÄrTom(TextBox enRuta, Label namn)
        {
            bool resultat = true;
            if (string.IsNullOrWhiteSpace(enRuta.Text))
            {
                MessageBox.Show($"Ruta {namn.Text} får ej vara tom!", "Felmeddelande", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resultat = false;
            }
            return resultat;
        }

        public static bool IsComboBoxEmpty(ComboBox comboBox)
        {
            bool result = true;
            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Du har inte valt en kategori");
                result = false;
            }
            return result;
        }

        public static bool KategoriExisterarRedan(string enRuta)
        {

            bool result = true;
            PodcastManager podcastManager = new PodcastManager();
            List<Category> categories = podcastManager.RetrieveAll<Category>();
            if (categories.Any(category => category.Name == enRuta))
            {
                MessageBox.Show($"Kategori '{enRuta}' finns redan.", "Existerande Kategori", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = false;
            }

            return result;
            
        }

        public static bool PodcastExists(string enRuta, bool checkByName)
        {
            bool result = false;

            if (string.IsNullOrEmpty(enRuta))
            {
                return result;
            }

            PodcastManager podcastManager = new PodcastManager();
            List<Podcast> podcasts = podcastManager.RetrieveAll<Podcast>();

            if (checkByName)
            {
                if (podcasts.Any(podcast => podcast.PodcastName == enRuta))
                {
                    MessageBox.Show($"Podcast med namn '{enRuta}' existerar redan.", "Existerande Podcast", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = true;
                }
            }
            else
            {
                if (podcasts.Any(podcast => podcast.URL == enRuta))
                {
                    MessageBox.Show($"Podcast med URL '{enRuta}' existerar redan.", "Existerande Podcast", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = true;
                }
            }

            return result;
        }
    }
}
