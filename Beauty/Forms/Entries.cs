using System;
using System.Windows.Forms;

namespace Beauty.Forms
{
    public partial class Entries : Form
    {
        public Entries()
        {
            InitializeComponent();
        }

        private void Entries_Load(object sender, EventArgs e)
        {
            entriesDataGridView.DataSource = DatabaseHelper.getEntriesDataSource();
            entriesDataGridView.Columns[0].Visible = false;
            entriesDataGridView.ClearSelection();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entriesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string id = entriesDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                DatabaseHelper.deleteEntry(id);
                entriesDataGridView.DataSource = DatabaseHelper.getEntriesDataSource();
                entriesDataGridView.Columns[0].Visible = false;
                entriesDataGridView.ClearSelection();
            }
        }
    }
}
