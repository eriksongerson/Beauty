using System;
using System.Windows.Forms;

namespace Beauty.Forms
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addInformationButton_Click(object sender, EventArgs e)
        {
            AddInformationForm addInformationForm = new AddInformationForm();
            Hide();
            addInformationForm.nextWay = "startup";
            if(addInformationForm.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void editInformationButton_Click(object sender, EventArgs e)
        {
            EditInformationForm editInformationForm = new EditInformationForm();
            Hide();
            if(editInformationForm.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void entryOnVisitButton_Click(object sender, EventArgs e)
        {
            NewEntry newEntry = new NewEntry();
            Hide();
            if(newEntry.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            Entries entries = new Entries();
            Hide();
            if(entries.ShowDialog() != DialogResult.OK)
                Close();
        }
    }
}
