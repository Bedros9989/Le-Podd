using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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


    }
}
