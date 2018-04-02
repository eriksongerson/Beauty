using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Beauty.Forms
{
    public partial class EditInformationForm : Form
    {
        private static Master selectedMaster;
        private static Client selectedClient;

        public EditInformationForm()
        {
            InitializeComponent();
        }

        private void EditInformationForm_Load(object sender, EventArgs e)
        {
            reloadMasterTable();
            clearAllFields();
        }

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

        private void clearAllFields()
        {
            cleanClientFields();
            cleanMasterFields();
        }

        private void reloadMasterTable()
        {
            editMasterDataGridView.DataSource = DatabaseHelper.getMasterDataSource();
            editMasterDataGridView.Columns[0].Visible = false;
            editMasterDataGridView.Columns[1].Width = 70;
            editMasterDataGridView.Columns[3].Width = 70;
            editMasterDataGridView.Columns[4].Width = 200;
            editMasterDataGridView.ClearSelection();
        }

        private void reloadClientTable()
        {
            editClientDataGridView.DataSource = DatabaseHelper.getClientDataSource();
            editClientDataGridView.Columns[0].Visible = false;
            editClientDataGridView.Columns[1].Width = 70;
            editClientDataGridView.Columns[3].Width = 150;
            editClientDataGridView.Columns[4].Width = 90;
            editClientDataGridView.ClearSelection();
        }

        private void cleanMasterFields()
        {
            masterSurnameTextBox.Text = "";
            masterNameTextBox.Text = "";
            masterPatronymicTextBox.Text = "";
            experienceTextBox.Text = "";
            positionTextBox.Text = "";
            deleteMasterButton.Enabled = false;
            editMasterButton.Enabled = false;
        }
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

        private void editMasterButton_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[А-ЯЁ][а-яё]{2,50}$");

            string Surname = masterSurnameTextBox.Text;
            if (!regex.IsMatch(Surname))
            {
                MessageBox.Show("Введите Фамилию в верном формате (формат: Иванов).");
                return;
            }
            string Name = masterNameTextBox.Text;
            if (!regex.IsMatch(Name))
            {
                MessageBox.Show("Введите Имя в верном формате (формат: Иван).");
                return;
            }
            string Patronymic = masterPatronymicTextBox.Text;
            if (!regex.IsMatch(Patronymic))
            {
                MessageBox.Show("Введите Отчество в верном формате (формат: Иванович).");
                return;
            }

            regex = new Regex("^[0-9]{1,2}$");
            string experienceString = experienceTextBox.Text;
            if (!regex.IsMatch(experienceString))
            {
                MessageBox.Show("При указании стажа можно использовать только цифры.");
                return;
            }
            int experience = Convert.ToInt32(experienceString);
            if (experience < 0 || experience >= 100)
            {
                MessageBox.Show("Введите адекватный стаж.");
                return;
            }

            regex = new Regex("^[A-Za-z0-9]+$");
            string position = positionTextBox.Text;
            if (regex.IsMatch(position))
            {
                MessageBox.Show("Нельзя использовать цифры или иностранные символы.");
                return;
            }

            selectedMaster.setFullName(Surname, Name, Patronymic);
            selectedMaster.experience = Convert.ToInt32(experienceTextBox.Text);
            selectedMaster.position = positionTextBox.Text;

            DatabaseHelper.editMaster(selectedMaster);
            selectedMaster = null;
            reloadMasterTable();
            cleanMasterFields();
        }

        private void editMasterDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in editMasterDataGridView.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                int number = Convert.ToInt32(row.Cells[1].Value);
                string fullName = row.Cells[2].Value.ToString();
                int experience = Convert.ToInt32(row.Cells[3].Value);
                string position = row.Cells[4].Value.ToString();

                var arr = fullName.Split(' ');

                selectedMaster = new Master(id, number, arr[0], arr[1], arr[2], experience, position);
            }

            if (selectedMaster != null)
            {
                masterSurnameTextBox.Text = selectedMaster.secondName;
                masterNameTextBox.Text = selectedMaster.firstName;
                masterPatronymicTextBox.Text = selectedMaster.patronymic;
                experienceTextBox.Text = selectedMaster.experience.ToString();
                positionTextBox.Text = selectedMaster.position;
            }

            deleteMasterButton.Enabled = true;
            editMasterButton.Enabled = true;
        }

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

        private void editClientButton_Click(object sender, EventArgs e)
        {

            Regex regex = new Regex("^[А-ЯЁ][а-яё]{2,50}$");
            string Surname = clientSurnameTextBox.Text;
            if (!regex.IsMatch(Surname))
            {
                MessageBox.Show("Введите Фамилию в верном формате (формат: Иванов).");
                return;
            }
            string Name = clientNameTextBox.Text;
            if (!regex.IsMatch(Name))
            {
                MessageBox.Show("Введите Имя в верном формате (формат: Иван).");
                return;
            }
            string Patronymic = clientPatronymicTextBox.Text;
            if (!regex.IsMatch(Patronymic))
            {
                MessageBox.Show("Введите Отчество в верном формате (формат: Иванович).");
                return;
            }

            regex = new Regex("^((8|\\+7)[\\- ]?)?(\\(?\\d{3}\\)?[\\- ]?)?[\\d\\- ]{7,10}$");
            string phone = phoneTextBox.Text;
            if (!regex.IsMatch(phone))
            {
                MessageBox.Show("Введите номер в правильном формате");
                return;
            }

            regex = new Regex("^[0-9]{1,2}$");
            string ageString = ageTextBox.Text;
            if (!regex.IsMatch(ageString))
            {
                MessageBox.Show("При указании возраста можно использовать только цифры.");
                return;
            }
            int age = Convert.ToInt32(ageString);
            if (age > 120 || age < 0)
            {
                MessageBox.Show("Недопустимый возраст.");
                return;
            }

            selectedClient.setFullName(Surname, Name, Patronymic);
            selectedClient.phone = phone;
            selectedClient.age = age;

            DatabaseHelper.editClient(selectedClient);
            selectedClient = null;
            reloadClientTable();
            cleanClientFields();
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
        private void experienceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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
