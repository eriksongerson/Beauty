﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Beauty.Forms
{
    public partial class NewEntry : Form
    {
        private static List<Master> masters;
        private static List<Client> clients;
        // переменные для проверки полей 
        string hardwiredDate;
        string hardwiredTime;

        public NewEntry()
        {
            InitializeComponent();
        }

        private void NewEntry_Load(object sender, EventArgs e)
        {
            hardwiredDate = dateMaskedTextBox.Text;
            hardwiredTime = timeMaskedTextBox.Text;
            // Заполнение comboBox'ов
            masters = DatabaseHelper.getMasters();
            clients = DatabaseHelper.getClients();

            Object[] items = new Object[masters.Count];
            for (int i = 0; i < masters.Count; i++)
            {
                var item = masters[i];
                items[i] = item.secondName + " " + item.firstName + " " + item.patronymic + ": стаж " + item.experience + " - " + item.position;
            }
            masterComboBox.Items.AddRange(items);

            items = new Object[clients.Count];
            for (int i = 0; i < clients.Count; i++)
            {
                var item = clients[i];
                items[i] = item.secondName + " " + item.firstName + " " + item.patronymic + " : " + item.age + " лет. тел: " + item.phone;
            }
            clientComboBox.Items.AddRange(items);
        }
        // кнопка перехода на форму создания записей
        private void newClientButton_Click(object sender, EventArgs e)
        {
            AddInformationForm addInformationForm = new AddInformationForm();
            Hide();
            addInformationForm.nextWay = "entry";
            if(addInformationForm.ShowDialog() != DialogResult.OK)
                Close();
        }
        // запрет на ввод всего, кроме цифр
        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }
        // создание записи
        private void makeEntryButton_Click(object sender, EventArgs e)
        {
            // проверка полей
            string priceLine = priceTextBox.Text;
            if (priceLine == "")
            {
                MessageBox.Show("Не указана стоимость услуги.");
                return;
            }
            int price = Convert.ToInt32(priceLine);
            if (price <= 0)
            {
                MessageBox.Show("Стоимость не может быть равна нулю.");
                return;
            }

            Master master = null;
            Client client = null;
            // получение мастера
            string MasterLine = masterComboBox.SelectedItem.ToString();
            foreach (var item in masters)
            {
                if (item.secondName + " " + item.firstName + " " + item.patronymic + ": стаж " + item.experience + " - " + item.position == MasterLine)
                {
                    master = item;
                }
            }
            // получение клиента
            string ClientLine = clientComboBox.SelectedItem.ToString();
            foreach (var item in clients)
            {
                if (item.secondName + " " + item.firstName + " " + item.patronymic + " : " + item.age + " лет. тел: " + item.phone == ClientLine)
                {
                    client = item;
                }
            }
            // проверка на правильность введенной даты
            Regex regex = new Regex("^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\\d\\d$");
            string date = dateMaskedTextBox.Text;
            if (!regex.IsMatch(date))
            {
                MessageBox.Show("Дата записи введена некорректно.");
                return;
            }
            // проверка на правильность введенного времени
            regex = new Regex("^(0[0-9]|1[0-9]|2[0-3])(:[0-5][0-9])$");
            string time = timeMaskedTextBox.Text;
            if (!regex.IsMatch(time))
            {
                MessageBox.Show("Время записи введено некорректно.");
                return;
            }
            // создание записи
            Entry entry;
            if (master != null && client != null)
            {
                entry = new Entry(master, client, date, time, price);
                DatabaseHelper.addEntry(entry);
                masterComboBox.SelectedIndex = -1;
                clientComboBox.SelectedIndex = -1;
                priceTextBox.Text = "";
                dateMaskedTextBox.Text = "";
                timeMaskedTextBox.Text = "";
                makeEntryButton.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartupForm startupForm = new StartupForm();
            Hide();
            if(startupForm.ShowDialog() != DialogResult.OK)
                Close();
        }
        // если поля не пусты, должна активироваться кнопка
        private void masterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkForButton();
        }
        private void clientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkForButton();
        }
        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            checkForButton();
        }
        private void dateMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            checkForButton();
        }
        private void timeMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            checkForButton();
        }
        // проверка на заполненность полей
        private void checkForButton()
        {
            if(clientComboBox.SelectedIndex != -1 
                && masterComboBox.SelectedIndex != -1
                && priceTextBox.Text != "" 
                && dateMaskedTextBox.Text != hardwiredDate
                && timeMaskedTextBox.Text != hardwiredTime)
            {
                makeEntryButton.Enabled = true;
            }else
            {
                makeEntryButton.Enabled = false;
            }
        }
        // проверка вводимых символов
        private void dateMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) || e.KeyChar != 8;
        }
        private void timeMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) || e.KeyChar != 8;
        }
    }
}
