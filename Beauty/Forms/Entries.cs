﻿using System;
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
            reloadDataGridView();
        }
        // кнопка выхода из формы
        private void backButton_Click(object sender, EventArgs e)
        {
            StartupForm startupForm = new StartupForm();
            Hide();
            if(startupForm.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void entriesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = true;
        }
        // обновление таблицы
        void reloadDataGridView()
        {
            entriesDataGridView.DataSource = DatabaseHelper.getEntriesDataSource();
            entriesDataGridView.Columns[0].Visible = false;
            entriesDataGridView.Columns[1].Width = 220;
            entriesDataGridView.Columns[2].Width = 219;
            entriesDataGridView.Columns[3].Width = 100;
            entriesDataGridView.Columns[4].Width = 100;
            entriesDataGridView.Columns[5].Width = 100;
            entriesDataGridView.ClearSelection();
        }
        // удаление записи на прием
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string id = entriesDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                DatabaseHelper.deleteEntry(id);
                reloadDataGridView();
                
            }
            deleteButton.Enabled = false;
        }
    }
}
