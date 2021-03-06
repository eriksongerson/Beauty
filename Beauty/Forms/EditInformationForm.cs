﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Beauty.Forms
{
    public partial class EditInformationForm : Form
    {
        // переменные для сохранения выбранных
        private static Master selectedMaster;// мастера
        private static Client selectedClient;// клиента

        public EditInformationForm()
        {
            InitializeComponent();
        }

        private void EditInformationForm_Load(object sender, EventArgs e)
        {
            reloadMasterTable();
            clearAllFields();
        }
        // функция загрузки таблиц при смене вкладок
        private void editInformationTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (editInformationTabControl.SelectedTab == editMastersTabPane)
            {
                reloadMasterTable();
                clearAllFields();
            }
            else if (editInformationTabControl.SelectedTab == editClientsTabPane)
            {
                reloadClientTable();
                clearAllFields();
            }
        }
        // функция очистки всех полей 
        private void clearAllFields()
        {
            cleanClientFields();
            cleanMasterFields();
        }
        // функция загрузки мастеров
        private void reloadMasterTable()
        {
            editMasterDataGridView.DataSource = DatabaseHelper.getMasterDataSource();
            editMasterDataGridView.Columns[0].Visible = false;
            editMasterDataGridView.Columns[1].Width = 70;
            editMasterDataGridView.Columns[3].Width = 70;
            editMasterDataGridView.Columns[4].Width = 200;
            editMasterDataGridView.ClearSelection();
        }
        // функция загрузки клиентов
        private void reloadClientTable()
        {
            editClientDataGridView.DataSource = DatabaseHelper.getClientDataSource();
            editClientDataGridView.Columns[0].Visible = false;
            editClientDataGridView.Columns[1].Width = 70;
            editClientDataGridView.Columns[3].Width = 150;
            editClientDataGridView.Columns[4].Width = 90;
            editClientDataGridView.ClearSelection();
        }
        // функция очистки полей на вкладке "Мастера"
        private void cleanMasterFields()
        {
            masterSurnameTextBox.Text = "";
            masterNameTextBox.Text = "";
            masterPatronymicTextBox.Text = "";
            yearsNumericUpDown.Value = 0;
            monthsNumericUpDown.Value = 0;
            positionTextBox.Text = "";
            deleteMasterButton.Enabled = false;
            editMasterButton.Enabled = false;
        }
        // функция очистки полей на вкладке "Клиенты"
        private void cleanClientFields()
        {
            clientSurnameTextBox.Text = "";
            clientNameTextBox.Text = "";
            clientPatronymicTextBox.Text = "";
            phoneTextBox.Text = "";
            ageTextBox.Text = "";
            deleteClientButton.Enabled = false;
            editClientButton.Enabled = false;
        }
        // закрытие формы
        private void backMasterButton_Click(object sender, EventArgs e)
        {
            StartupForm startupForm = new StartupForm();
            Hide();
            if(startupForm.ShowDialog() != DialogResult.OK)
                Close();
        }
        private void backClientButton_Click(object sender, EventArgs e)
        {
            StartupForm startupForm = new StartupForm();
            Hide();
            if(startupForm.ShowDialog() != DialogResult.OK)
                Close();
        }
        // удаление мастера
        private void deleteMasterButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить этого мастера из базы данных?", "Удалить?", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                DatabaseHelper.deleteMaster(selectedMaster);
                selectedMaster = null;
                reloadMasterTable();
                cleanMasterFields();
                return;
            }
            if(result == DialogResult.No)
            {
                return;
            }
        }
        // изменение мастера
        private void editMasterButton_Click(object sender, EventArgs e)
        {
            string position = positionTextBox.Text;
            string experience = yearsNumericUpDown.Value + "," + monthsNumericUpDown.Value;
            string Surname = masterSurnameTextBox.Text;
            string Name = masterNameTextBox.Text;
            string Patronymic = masterPatronymicTextBox.Text;

            selectedMaster.setFullName(Surname, Name, Patronymic);
            selectedMaster.experience = yearsNumericUpDown.Value + "," + monthsNumericUpDown.Value;
            selectedMaster.position = positionTextBox.Text;

            DatabaseHelper.editMaster(selectedMaster);
            selectedMaster = null;
            reloadMasterTable();
            cleanMasterFields();
        }
        // заполнение полей при выборе записи таблицы мастеров
        private void editMasterDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in editMasterDataGridView.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                int number = Convert.ToInt32(row.Cells[1].Value);
                string fullName = row.Cells[2].Value.ToString();
                string experience = row.Cells[3].Value.ToString();
                string position = row.Cells[4].Value.ToString();

                var arr = fullName.Split(' ');

                selectedMaster = new Master(id, number, arr[0], arr[1], arr[2], experience, position);
            }
            if (selectedMaster != null)
            {
                masterSurnameTextBox.Text = selectedMaster.secondName;
                masterNameTextBox.Text = selectedMaster.firstName;
                masterPatronymicTextBox.Text = selectedMaster.patronymic;
                string exp = selectedMaster.experience.ToString();
                var arr = exp.Split(',');
                yearsNumericUpDown.Value = Convert.ToInt32(arr[0]);
                monthsNumericUpDown.Value = Convert.ToInt32(arr[1]);
                positionTextBox.Text = selectedMaster.position;
            }
            deleteMasterButton.Enabled = true;
            editMasterButton.Enabled = true;
        }
        // заполнение полей при выборе записи таблицы клиентов
        private void editClientDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in editClientDataGridView.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                int number = Convert.ToInt32(row.Cells[1].Value);
                string fullName = row.Cells[2].Value.ToString();
                string phone = row.Cells[3].Value.ToString();
                int age = Convert.ToInt32(row.Cells[4].Value);

                var arr = fullName.Split(' ');

                selectedClient = new Client(id, number, arr[0], arr[1], arr[2], phone, age);
            }

            if (selectedClient != null)
            {
                clientSurnameTextBox.Text = selectedClient.secondName;
                clientNameTextBox.Text = selectedClient.firstName;
                clientPatronymicTextBox.Text = selectedClient.patronymic;
                phoneTextBox.Text = selectedClient.phone;
                ageTextBox.Text = selectedClient.age.ToString();
            }

            deleteClientButton.Enabled = true;
            editClientButton.Enabled = true;
        }
        // удаление клиента
        private void deleteClientButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить этого клиента из базы данных?", "Удалить?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DatabaseHelper.deleteClient(selectedClient);
                selectedClient = null;
                reloadClientTable();
                cleanClientFields();
                return;
            }
            if (result == DialogResult.No)
            {
                return;
            }
        }
        // изменение клиента
        private void editClientButton_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("^((8|\\+7)[\\- ]?)?(\\(?\\d{3}\\)?[\\- ]?)?[\\d\\- ]{7,10}$");
            string phone = phoneTextBox.Text;
            if (!regex.IsMatch(phone))
            {
                MessageBox.Show("Введите номер в правильном формате");
                return;
            }
            int age = Convert.ToInt32(ageTextBox.Text);
            if(age > 120 || age <= 0)
            {
                MessageBox.Show("Недопустимый возраст.");
                return;
            }
            string Surname = clientSurnameTextBox.Text;
            string Name = clientNameTextBox.Text;
            string Patronymic = clientPatronymicTextBox.Text;

            selectedClient.setFullName(Surname, Name, Patronymic);
            selectedClient.phone = phone;
            selectedClient.age = age;

            DatabaseHelper.editClient(selectedClient);
            selectedClient = null;
            reloadClientTable();
            cleanClientFields();
        }
        // изменение полей при выборе количества лет стажа
        List<int> first = new List<int>(){ 1, 21, 31, 41, 51, 61 };//год;
        List<int> second = new List<int>(){ 2, 3, 4, 22, 23, 24, 32, 33, 34, 42, 43, 44, 52, 53, 54, 62, 63, 64 };//года
        private void yearsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int years = Convert.ToInt32(yearsNumericUpDown.Value);

            if (first.Contains(years))
            {
                label3.Text = "год";
            }else if (second.Contains(years))
            {
                label3.Text = "года";
            }else { label3.Text = "лет"; }

        }
        // изменение полей при выборе количества месяцев стажа
        private void monthsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int months = Convert.ToInt32(monthsNumericUpDown.Value);

            if (months == 1)
            {
                label12.Text = "месяц";
            }else if (months == 2 || months == 3)
            {
                label12.Text = "месяца";
            }else { label12.Text = "месяцев"; }
        }
        // функция проверки ввода русских букв
        private void checkRussianWords(KeyPressEventArgs e)
        {
            string ch = e.KeyChar.ToString();
            Regex regex = new Regex("[А-Яа-я ]");
            if (!regex.IsMatch(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        // событие, привязанное к 6 текстовым полям, которые проверятся на наличие только русских букв
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkRussianWords(e);
        }
        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || e.KeyChar == 8 || Convert.ToChar(e.KeyChar) == '+' ? false : true;
        }
        private void ageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }
        private void positionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string ch = e.KeyChar.ToString();
            Regex regex = new Regex("[А-Яа-я -]");
            if (!regex.IsMatch(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox) sender;

            string Line = textBox.Text;
            var arr = Line.ToCharArray();
            try{
                arr[0] = char.ToUpper(arr[0]);
            }catch(IndexOutOfRangeException){ }
            textBox.Text = string.Concat(arr);

            textBox.Select(textBox.Text.Length, 0);
        }
    }
}
