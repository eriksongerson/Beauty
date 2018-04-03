using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Beauty.Forms
{
    public partial class AddInformationForm : Form
    {
        public string nextWay = "";

        public AddInformationForm()
        {
            InitializeComponent();
        }

        private void AddInformationForm_Load(object sender, EventArgs e)
        {
            reloadMasterDataGridView();
        }

        private void informationTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(informationTabControl.SelectedTab == mastersTabPage)
            {
                reloadMasterDataGridView();
            }
            else if (informationTabControl.SelectedTab == clientsTabPage)
            {
                reloadClientDataGridView();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CloseThis();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CloseThis();
        }

        private void CloseThis()
        {
            if (nextWay == "startup")
            {
                StartupForm startupForm = new StartupForm();
                Hide();
                if(startupForm.ShowDialog() != DialogResult.OK)
                    Close();
            }
            if (nextWay == "entry")
            {
                NewEntry newEntry = new NewEntry();
                Hide();
                if(newEntry.ShowDialog() != DialogResult.OK)
                    Close();
            }
        }

        private void addMasterButton_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[A-Za-z0-9]+$");
            string position = positionTextBox.Text;
            if (regex.IsMatch(position))
            {
                MessageBox.Show("Нельзя использовать цифры или иностранные символы.");
                return;
            }

            string experience = yearsNumericUpDown.Value + "," + monthsNumericUpDown.Value;
            string Surname = masterSurnameTextBox.Text;
            string Name = masterNameTextBox.Text;
            string Patronymic = masterPatronymicTextBox.Text;

            Master master = new Master(Surname, Name, Patronymic, experience, position);

            if (DatabaseHelper.addNewMaster(master)){
                reloadMasterDataGridView();
                masterSurnameTextBox.Text = "";
                masterNameTextBox.Text = "";
                masterPatronymicTextBox.Text = "";
                yearsNumericUpDown.Value = 0;
                monthsNumericUpDown.Value = 0;
                positionTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Не удалось добавить запись. Проверьте данные.");
                return;
            }
        }

        private void reloadMasterDataGridView()
        {
            addMasterDataGridView.DataSource = DatabaseHelper.getMasterDataSource();
            addMasterDataGridView.Columns[0].Visible = false;
            addMasterDataGridView.Columns[1].Width = 70;
            addMasterDataGridView.Columns[3].Width = 70;
            addMasterDataGridView.Columns[4].Width = 200;
            addMasterDataGridView.ClearSelection();
        }

        private void reloadClientDataGridView()
        {
            addClientDataGridView.DataSource = DatabaseHelper.getClientDataSource();
            addClientDataGridView.Columns[0].Visible = false;
            addClientDataGridView.Columns[1].Width = 70;
            addClientDataGridView.Columns[3].Width = 150;
            addClientDataGridView.Columns[4].Width = 90;
            addClientDataGridView.ClearSelection();
        }

        private void addClientButton_Click(object sender, EventArgs e)
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

            Client client = new Client(Surname, Name, Patronymic, phone, age);

            if (DatabaseHelper.addNewClient(client))
            {
                reloadClientDataGridView();
                clientSurnameTextBox.Text = "";
                clientNameTextBox.Text = "";
                clientPatronymicTextBox.Text = "";
                phoneTextBox.Text = "";
                ageTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Не удалось добавить запись. Проверьте данные.");
                return;
            }

        }

        List<int> firstYears = new List<int>(){ 1, 21, 31, 41, 51, 61 };//год;
        List<int> secondYears = new List<int>(){ 2, 3, 4, 22, 23, 24, 32, 33, 34, 42, 43, 44, 52, 53, 54, 62, 63, 64 };//года
        private void yearsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int years = Convert.ToInt32(yearsNumericUpDown.Value);

            if (firstYears.Contains(years))
            {
                label3.Text = "год";
            }else if (secondYears.Contains(years))
            {
                label3.Text = "года";
            }else { label3.Text = "лет"; }
        }
        private void checkRussianWords(KeyPressEventArgs e)
        {
            string ch = e.KeyChar.ToString();
            Regex regex = new Regex("[А-Яа-я ]");
            if (!regex.IsMatch(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        List<int> firstMonths = new List<int>(){  };//месяц

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