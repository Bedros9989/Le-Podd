using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PodcastHanteraren
{
    public partial class ChangeForm : Form
    {

        private string currentCategory;
        private int index;
        private List<string> categoryList;
        PodcastManager podcastManager;
        public event EventHandler<string> Form6CategoryUpdated;

        public ChangeForm(int index, string currentCategory)
        {
            InitializeComponent();
            podcastManager = new PodcastManager();
            this.currentCategory = currentCategory;
            this.index = index;
            läggTillInfo();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void läggTillInfo(){

            comboBox2.Text = currentCategory;
            comboBox1.DataSource = categoryList;
            List<Category> categories = podcastManager.RetrieveAll<Category>();
            foreach (Category category in categories)
            {
                comboBox1.Items.Add(category.Name);
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            string updatedCategory = comboBox1.SelectedItem?.ToString();

            if (updatedCategory != null)
            {
                if (index != -1)
                {
                    podcastManager.Update(index, updatedCategory, "Category");
                    DialogResult = DialogResult.OK;
                    if (Form6CategoryUpdated != null)
                    {
                        Form6CategoryUpdated(this, updatedCategory);
                    }
                    Close();

                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
