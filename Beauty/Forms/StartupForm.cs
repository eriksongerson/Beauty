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
            addInformationForm.ShowDialog();
        }

        private void editInformationButton_Click(object sender, EventArgs e)
        {
            EditInformationForm editInformationForm = new EditInformationForm();
            editInformationForm.ShowDialog();
        }

        private void entryOnVisitButton_Click(object sender, EventArgs e)
        {
            NewEntry newEntry = new NewEntry();
            newEntry.ShowDialog();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            Entries entries = new Entries();
            entries.ShowDialog();
        }
    }
}
