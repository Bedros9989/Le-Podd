using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodcastHanteraren
{
    public partial class Form2 : Form
    {

        private string currentCategory;
        private List<string> categoryList;

        public Form2(string currentCategory, List<string> categoryList)
        {
            InitializeComponent();
            this.currentCategory = currentCategory;
            this.categoryList = categoryList;
            läggTillInfo();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void läggTillInfo(){

            comboBox2.Text = currentCategory;
            comboBox1.DataSource = categoryList;
        }

        public string SelectedCategory
        {
            get
            {
                return comboBox1.SelectedItem?.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
