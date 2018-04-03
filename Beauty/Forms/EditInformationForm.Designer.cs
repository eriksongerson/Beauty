namespace Beauty.Forms
{
    partial class EditInformationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.editInformationTabControl = new System.Windows.Forms.TabControl();
            this.editMastersTabPane = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.monthsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.yearsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.masterPatronymicTextBox = new System.Windows.Forms.TextBox();
            this.masterNameTextBox = new System.Windows.Forms.TextBox();
            this.masterSurnameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.deleteMasterButton = new System.Windows.Forms.Button();
            this.editMasterButton = new System.Windows.Forms.Button();
            this.backMasterButton = new System.Windows.Forms.Button();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editMasterDataGridView = new System.Windows.Forms.DataGridView();
            this.editClientsTabPane = new System.Windows.Forms.TabPage();
            this.clientPatronymicTextBox = new System.Windows.Forms.TextBox();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.clientSurnameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.deleteClientButton = new System.Windows.Forms.Button();
            this.backClientButton = new System.Windows.Forms.Button();
            this.editClientButton = new System.Windows.Forms.Button();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.editClientDataGridView = new System.Windows.Forms.DataGridView();
            this.editInformationTabControl.SuspendLayout();
            this.editMastersTabPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editMasterDataGridView)).BeginInit();
            this.editClientsTabPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editClientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // editInformationTabControl
            // 
            this.editInformationTabControl.Controls.Add(this.editMastersTabPane);
            this.editInformationTabControl.Controls.Add(this.editClientsTabPane);
            this.editInformationTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editInformationTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editInformationTabControl.Location = new System.Drawing.Point(0, 0);
            this.editInformationTabControl.Name = "editInformationTabControl";
            this.editInformationTabControl.SelectedIndex = 0;
            this.editInformationTabControl.Size = new System.Drawing.Size(800, 506);
            this.editInformationTabControl.TabIndex = 0;
            this.editInformationTabControl.SelectedIndexChanged += new System.EventHandler(this.editInformationTabControl_SelectedIndexChanged);
            // 
            // editMastersTabPane
            // 
            this.editMastersTabPane.Controls.Add(this.label12);
            this.editMastersTabPane.Controls.Add(this.monthsNumericUpDown);
            this.editMastersTabPane.Controls.Add(this.label3);
            this.editMastersTabPane.Controls.Add(this.yearsNumericUpDown);
            this.editMastersTabPane.Controls.Add(this.masterPatronymicTextBox);
            this.editMastersTabPane.Controls.Add(this.masterNameTextBox);
            this.editMastersTabPane.Controls.Add(this.masterSurnameTextBox);
            this.editMastersTabPane.Controls.Add(this.label9);
            this.editMastersTabPane.Controls.Add(this.label8);
            this.editMastersTabPane.Controls.Add(this.deleteMasterButton);
            this.editMastersTabPane.Controls.Add(this.editMasterButton);
            this.editMastersTabPane.Controls.Add(this.backMasterButton);
            this.editMastersTabPane.Controls.Add(this.positionTextBox);
            this.editMastersTabPane.Controls.Add(this.label4);
            this.editMastersTabPane.Controls.Add(this.label2);
            this.editMastersTabPane.Controls.Add(this.label1);
            this.editMastersTabPane.Controls.Add(this.editMasterDataGridView);
            this.editMastersTabPane.Location = new System.Drawing.Point(4, 29);
            this.editMastersTabPane.Name = "editMastersTabPane";
            this.editMastersTabPane.Padding = new System.Windows.Forms.Padding(3);
            this.editMastersTabPane.Size = new System.Drawing.Size(792, 473);
            this.editMastersTabPane.TabIndex = 0;
            this.editMastersTabPane.Text = "Мастера";
            this.editMastersTabPane.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(299, 371);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 25);
            this.label12.TabIndex = 38;
            this.label12.Text = "месяцев";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // monthsNumericUpDown
            // 
            this.monthsNumericUpDown.Location = new System.Drawing.Point(243, 371);
            this.monthsNumericUpDown.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.monthsNumericUpDown.Name = "monthsNumericUpDown";
            this.monthsNumericUpDown.ReadOnly = true;
            this.monthsNumericUpDown.Size = new System.Drawing.Size(50, 26);
            this.monthsNumericUpDown.TabIndex = 37;
            this.monthsNumericUpDown.ValueChanged += new System.EventHandler(this.monthsNumericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(188, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 26);
            this.label3.TabIndex = 36;
            this.label3.Text = "лет";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yearsNumericUpDown
            // 
            this.yearsNumericUpDown.Location = new System.Drawing.Point(141, 371);
            this.yearsNumericUpDown.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.yearsNumericUpDown.Name = "yearsNumericUpDown";
            this.yearsNumericUpDown.ReadOnly = true;
            this.yearsNumericUpDown.Size = new System.Drawing.Size(41, 26);
            this.yearsNumericUpDown.TabIndex = 35;
            this.yearsNumericUpDown.ValueChanged += new System.EventHandler(this.yearsNumericUpDown_ValueChanged);
            // 
            // masterPatronymicTextBox
            // 
            this.masterPatronymicTextBox.Location = new System.Drawing.Point(141, 333);
            this.masterPatronymicTextBox.MaxLength = 50;
            this.masterPatronymicTextBox.Name = "masterPatronymicTextBox";
            this.masterPatronymicTextBox.Size = new System.Drawing.Size(643, 26);
            this.masterPatronymicTextBox.TabIndex = 24;
            this.masterPatronymicTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.masterPatronymicTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // masterNameTextBox
            // 
            this.masterNameTextBox.Location = new System.Drawing.Point(141, 293);
            this.masterNameTextBox.MaxLength = 50;
            this.masterNameTextBox.Name = "masterNameTextBox";
            this.masterNameTextBox.Size = new System.Drawing.Size(643, 26);
            this.masterNameTextBox.TabIndex = 23;
            this.masterNameTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.masterNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // masterSurnameTextBox
            // 
            this.masterSurnameTextBox.Location = new System.Drawing.Point(141, 254);
            this.masterSurnameTextBox.MaxLength = 50;
            this.masterSurnameTextBox.Name = "masterSurnameTextBox";
            this.masterSurnameTextBox.Size = new System.Drawing.Size(643, 26);
            this.masterSurnameTextBox.TabIndex = 22;
            this.masterSurnameTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.masterSurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(8, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 28);
            this.label9.TabIndex = 21;
            this.label9.Text = "Отчество:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "Имя:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deleteMasterButton
            // 
            this.deleteMasterButton.Enabled = false;
            this.deleteMasterButton.Location = new System.Drawing.Point(478, 425);
            this.deleteMasterButton.Name = "deleteMasterButton";
            this.deleteMasterButton.Size = new System.Drawing.Size(150, 40);
            this.deleteMasterButton.TabIndex = 19;
            this.deleteMasterButton.Text = "Удалить";
            this.deleteMasterButton.UseVisualStyleBackColor = true;
            this.deleteMasterButton.Click += new System.EventHandler(this.deleteMasterButton_Click);
            // 
            // editMasterButton
            // 
            this.editMasterButton.Enabled = false;
            this.editMasterButton.Location = new System.Drawing.Point(634, 425);
            this.editMasterButton.Name = "editMasterButton";
            this.editMasterButton.Size = new System.Drawing.Size(150, 40);
            this.editMasterButton.TabIndex = 18;
            this.editMasterButton.Text = "Изменить";
            this.editMasterButton.UseVisualStyleBackColor = true;
            this.editMasterButton.Click += new System.EventHandler(this.editMasterButton_Click);
            // 
            // backMasterButton
            // 
            this.backMasterButton.Location = new System.Drawing.Point(6, 425);
            this.backMasterButton.Name = "backMasterButton";
            this.backMasterButton.Size = new System.Drawing.Size(150, 40);
            this.backMasterButton.TabIndex = 17;
            this.backMasterButton.Text = "Назад";
            this.backMasterButton.UseVisualStyleBackColor = true;
            this.backMasterButton.Click += new System.EventHandler(this.backMasterButton_Click);
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(523, 374);
            this.positionTextBox.MaxLength = 255;
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(259, 26);
            this.positionTextBox.TabIndex = 16;
            this.positionTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.positionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.positionTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(396, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Должность:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Стаж работы:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Фамилия:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editMasterDataGridView
            // 
            this.editMasterDataGridView.AllowUserToAddRows = false;
            this.editMasterDataGridView.AllowUserToDeleteRows = false;
            this.editMasterDataGridView.AllowUserToResizeColumns = false;
            this.editMasterDataGridView.AllowUserToResizeRows = false;
            this.editMasterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.editMasterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editMasterDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.editMasterDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.editMasterDataGridView.Location = new System.Drawing.Point(3, 3);
            this.editMasterDataGridView.Name = "editMasterDataGridView";
            this.editMasterDataGridView.RowHeadersVisible = false;
            this.editMasterDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.editMasterDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.editMasterDataGridView.Size = new System.Drawing.Size(786, 247);
            this.editMasterDataGridView.TabIndex = 0;
            this.editMasterDataGridView.SelectionChanged += new System.EventHandler(this.editMasterDataGridView_SelectionChanged);
            // 
            // editClientsTabPane
            // 
            this.editClientsTabPane.Controls.Add(this.clientPatronymicTextBox);
            this.editClientsTabPane.Controls.Add(this.clientNameTextBox);
            this.editClientsTabPane.Controls.Add(this.clientSurnameTextBox);
            this.editClientsTabPane.Controls.Add(this.label5);
            this.editClientsTabPane.Controls.Add(this.label10);
            this.editClientsTabPane.Controls.Add(this.label11);
            this.editClientsTabPane.Controls.Add(this.deleteClientButton);
            this.editClientsTabPane.Controls.Add(this.backClientButton);
            this.editClientsTabPane.Controls.Add(this.editClientButton);
            this.editClientsTabPane.Controls.Add(this.ageTextBox);
            this.editClientsTabPane.Controls.Add(this.phoneTextBox);
            this.editClientsTabPane.Controls.Add(this.label7);
            this.editClientsTabPane.Controls.Add(this.label6);
            this.editClientsTabPane.Controls.Add(this.editClientDataGridView);
            this.editClientsTabPane.Location = new System.Drawing.Point(4, 29);
            this.editClientsTabPane.Name = "editClientsTabPane";
            this.editClientsTabPane.Padding = new System.Windows.Forms.Padding(3);
            this.editClientsTabPane.Size = new System.Drawing.Size(792, 473);
            this.editClientsTabPane.TabIndex = 1;
            this.editClientsTabPane.Text = "Клиенты";
            this.editClientsTabPane.UseVisualStyleBackColor = true;
            // 
            // clientPatronymicTextBox
            // 
            this.clientPatronymicTextBox.Location = new System.Drawing.Point(152, 333);
            this.clientPatronymicTextBox.MaxLength = 50;
            this.clientPatronymicTextBox.Name = "clientPatronymicTextBox";
            this.clientPatronymicTextBox.Size = new System.Drawing.Size(630, 26);
            this.clientPatronymicTextBox.TabIndex = 30;
            this.clientPatronymicTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.clientPatronymicTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(152, 293);
            this.clientNameTextBox.MaxLength = 50;
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(630, 26);
            this.clientNameTextBox.TabIndex = 29;
            this.clientNameTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.clientNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // clientSurnameTextBox
            // 
            this.clientSurnameTextBox.Location = new System.Drawing.Point(152, 254);
            this.clientSurnameTextBox.MaxLength = 50;
            this.clientSurnameTextBox.Name = "clientSurnameTextBox";
            this.clientSurnameTextBox.Size = new System.Drawing.Size(630, 26);
            this.clientSurnameTextBox.TabIndex = 28;
            this.clientSurnameTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.clientSurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Отчество:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(8, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 28);
            this.label10.TabIndex = 26;
            this.label10.Text = "Имя:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(8, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 28);
            this.label11.TabIndex = 25;
            this.label11.Text = "Фамилия:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deleteClientButton
            // 
            this.deleteClientButton.Location = new System.Drawing.Point(480, 425);
            this.deleteClientButton.Name = "deleteClientButton";
            this.deleteClientButton.Size = new System.Drawing.Size(150, 38);
            this.deleteClientButton.TabIndex = 19;
            this.deleteClientButton.Text = "Удалить";
            this.deleteClientButton.UseVisualStyleBackColor = true;
            this.deleteClientButton.Click += new System.EventHandler(this.deleteClientButton_Click);
            // 
            // backClientButton
            // 
            this.backClientButton.Location = new System.Drawing.Point(8, 425);
            this.backClientButton.Name = "backClientButton";
            this.backClientButton.Size = new System.Drawing.Size(150, 40);
            this.backClientButton.TabIndex = 18;
            this.backClientButton.Text = "Назад";
            this.backClientButton.UseVisualStyleBackColor = true;
            this.backClientButton.Click += new System.EventHandler(this.backClientButton_Click);
            // 
            // editClientButton
            // 
            this.editClientButton.Location = new System.Drawing.Point(636, 425);
            this.editClientButton.Name = "editClientButton";
            this.editClientButton.Size = new System.Drawing.Size(150, 38);
            this.editClientButton.TabIndex = 17;
            this.editClientButton.Text = "Изменить";
            this.editClientButton.UseVisualStyleBackColor = true;
            this.editClientButton.Click += new System.EventHandler(this.editClientButton_Click);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(590, 371);
            this.ageTextBox.MaxLength = 3;
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(54, 26);
            this.ageTextBox.TabIndex = 16;
            this.ageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTextBox_KeyPress);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(152, 371);
            this.phoneTextBox.MaxLength = 15;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(177, 26);
            this.phoneTextBox.TabIndex = 15;
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(422, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Возраст:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Телефон:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editClientDataGridView
            // 
            this.editClientDataGridView.AllowUserToAddRows = false;
            this.editClientDataGridView.AllowUserToDeleteRows = false;
            this.editClientDataGridView.AllowUserToResizeColumns = false;
            this.editClientDataGridView.AllowUserToResizeRows = false;
            this.editClientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.editClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editClientDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.editClientDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.editClientDataGridView.Location = new System.Drawing.Point(3, 3);
            this.editClientDataGridView.Name = "editClientDataGridView";
            this.editClientDataGridView.RowHeadersVisible = false;
            this.editClientDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.editClientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.editClientDataGridView.Size = new System.Drawing.Size(786, 247);
            this.editClientDataGridView.TabIndex = 0;
            this.editClientDataGridView.SelectionChanged += new System.EventHandler(this.editClientDataGridView_SelectionChanged);
            // 
            // EditInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.editInformationTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditInformationForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение информации";
            this.Load += new System.EventHandler(this.EditInformationForm_Load);
            this.editInformationTabControl.ResumeLayout(false);
            this.editMastersTabPane.ResumeLayout(false);
            this.editMastersTabPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editMasterDataGridView)).EndInit();
            this.editClientsTabPane.ResumeLayout(false);
            this.editClientsTabPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editClientDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl editInformationTabControl;
        private System.Windows.Forms.TabPage editMastersTabPane;
        private System.Windows.Forms.TabPage editClientsTabPane;
        private System.Windows.Forms.DataGridView editMasterDataGridView;
        private System.Windows.Forms.DataGridView editClientDataGridView;
        private System.Windows.Forms.Button deleteClientButton;
        private System.Windows.Forms.Button backClientButton;
        private System.Windows.Forms.Button editClientButton;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deleteMasterButton;
        private System.Windows.Forms.Button editMasterButton;
        private System.Windows.Forms.Button backMasterButton;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox masterPatronymicTextBox;
        private System.Windows.Forms.TextBox masterNameTextBox;
        private System.Windows.Forms.TextBox masterSurnameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox clientPatronymicTextBox;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.TextBox clientSurnameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown monthsNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown yearsNumericUpDown;
    }
}