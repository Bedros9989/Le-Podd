using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Security.Policy;

namespace PodcastHanteraren
{

    public partial class MainForm : Form
    {
        private Form currentChildForm = null;
        internal Dictionary<string, Form> childForms = new Dictionary<string, Form>();
        private List<PodcastForm> podcastFormInstances = new List<PodcastForm>();
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public MainForm()
        {
            InitializeComponent();
            initializeLibrary();
            initializeAddNew();
            initializeCategory();
            this.StartPosition = FormStartPosition.CenterScreen;
            videoPlayback();
        }

        private Form InitializeChildForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(form);
            form.Hide();
            return form;

        }

        private void videoPlayback()
        {
            video.URL = "logooo.mp4";
            video.Ctlcontrols.play();
            video.uiMode = "none";
            video.stretchToFit = true;
            video.settings.setMode("loop", true);
        }

        internal void initializeLibrary()
        {
            childForms["LibraryForm"] = InitializeChildForm(new LibraryForm());
        }

        internal void initializeAddNew()
        {
            childForms["AddNew"] = InitializeChildForm(new AddNewForm());
        }

        internal void initializeCategory()
        {
            childForms["Category"] = InitializeChildForm(new CategoryForm());
        }

        internal void ShowChildForm(string formName)
        {
            if (childForms.TryGetValue(formName, out Form childForm))
            {
                if (currentChildForm != null)
                {
                    currentChildForm.Hide();
                }

                childForm.BringToFront();
                childForm.Show();
                currentChildForm = childForm;
            }
        }

        private void bibliotek_Click(object sender, EventArgs e)
        {
            foreach (PodcastForm podcastForm in podcastFormInstances)
            {
                podcastForm.Close();
            }
            podcastFormInstances.Clear();

            ShowChildForm("LibraryForm");
        }

        private void läggTill_Click_1(object sender, EventArgs e)
        {
            ShowChildForm("AddNew");

        }

        private void kategorier_Click(object sender, EventArgs e)
        {
            ShowChildForm("Category");
        }

        internal void OpenPodcastInsidePanel(PodcastForm podcastForm)
        {
            ((LibraryForm)childForms["LibraryForm"]).Hide();
            podcastForm.TopLevel = false;
            podcastForm.TopMost = false;
            podcastForm.FormBorderStyle = FormBorderStyle.None;
            podcastForm.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(podcastForm);
            podcastForm.Show();
            podcastFormInstances.Add(podcastForm);
            video.Hide();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursor = Cursor.Position;
                this.Location = new Point(lastForm.X + (currentCursor.X - lastCursor.X), lastForm.Y + (currentCursor.Y - lastCursor.Y));
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void avslutaKnapp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
