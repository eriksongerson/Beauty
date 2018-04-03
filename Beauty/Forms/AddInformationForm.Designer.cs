namespace Beauty.Forms
{
    partial class AddInformationForm
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
            this.informationTabControl = new System.Windows.Forms.TabControl();
            this.mastersTabPage = new System.Windows.Forms.TabPage();
            this.masterPatronymicTextBox = new System.Windows.Forms.TextBox();
            this.masterNameTextBox = new System.Windows.Forms.TextBox();
            this.masterSurnameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addMasterButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addMasterDataGridView = new System.Windows.Forms.DataGridView();
            this.clientsTabPage = new System.Windows.Forms.TabPage();
            this.clientPatronymicTextBox = new System.Windows.Forms.TextBox();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.clientSurnameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.addClientButton = new System.Windows.Forms.Button();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addClientDataGridView = new System.Windows.Forms.DataGridView();
            this.yearsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.monthsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.informationTabControl.SuspendLayout();
            this.mastersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addMasterDataGridView)).BeginInit();
            this.clientsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addClientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // informationTabControl
            // 
            this.informationTabControl.Controls.Add(this.mastersTabPage);
            this.informationTabControl.Controls.Add(this.clientsTabPage);
            this.informationTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informationTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.informationTabControl.Location = new System.Drawing.Point(0, 0);
            this.informationTabControl.Name = "informationTabControl";
            this.informationTabControl.SelectedIndex = 0;
            this.informationTabControl.Size = new System.Drawing.Size(800, 506);
            this.informationTabControl.TabIndex = 0;
            this.informationTabControl.SelectedIndexChanged += new System.EventHandler(this.informationTabControl_SelectedIndexChanged);
            // 
            // mastersTabPage
            // 
            this.mastersTabPage.Controls.Add(this.label12);
            this.mastersTabPage.Controls.Add(this.monthsNumericUpDown);
            this.mastersTabPage.Controls.Add(this.label3);
            this.mastersTabPage.Controls.Add(this.yearsNumericUpDown);
            this.mastersTabPage.Controls.Add(this.masterPatronymicTextBox);
            this.mastersTabPage.Controls.Add(this.masterNameTextBox);
            this.mastersTabPage.Controls.Add(this.masterSurnameTextBox);
            this.mastersTabPage.Controls.Add(this.label9);
            this.mastersTabPage.Controls.Add(this.label8);
            this.mastersTabPage.Controls.Add(this.label1);
            this.mastersTabPage.Controls.Add(this.addMasterButton);
            this.mastersTabPage.Controls.Add(this.button3);
            this.mastersTabPage.Controls.Add(this.positionTextBox);
            this.mastersTabPage.Controls.Add(this.label4);
            this.mastersTabPage.Controls.Add(this.label2);
            this.mastersTabPage.Controls.Add(this.addMasterDataGridView);
            this.mastersTabPage.Location = new System.Drawing.Point(4, 29);
            this.mastersTabPage.Name = "mastersTabPage";
            this.mastersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mastersTabPage.Size = new System.Drawing.Size(792, 473);
            this.mastersTabPage.TabIndex = 0;
            this.mastersTabPage.Text = "Мастера";
            this.mastersTabPage.UseVisualStyleBackColor = true;
            // 
            // masterPatronymicTextBox
            // 
            this.masterPatronymicTextBox.Location = new System.Drawing.Point(141, 333);
            this.masterPatronymicTextBox.MaxLength = 50;
            this.masterPatronymicTextBox.Name = "masterPatronymicTextBox";
            this.masterPatronymicTextBox.Size = new System.Drawing.Size(641, 26);
            this.masterPatronymicTextBox.TabIndex = 30;
            // 
            // masterNameTextBox
            // 
            this.masterNameTextBox.Location = new System.Drawing.Point(141, 293);
            this.masterNameTextBox.MaxLength = 50;
            this.masterNameTextBox.Name = "masterNameTextBox";
            this.masterNameTextBox.Size = new System.Drawing.Size(641, 26);
            this.masterNameTextBox.TabIndex = 29;
            // 
            // masterSurnameTextBox
            // 
            this.masterSurnameTextBox.Location = new System.Drawing.Point(141, 254);
            this.masterSurnameTextBox.MaxLength = 50;
            this.masterSurnameTextBox.Name = "masterSurnameTextBox";
            this.masterSurnameTextBox.Size = new System.Drawing.Size(641, 26);
            this.masterSurnameTextBox.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(8, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 28);
            this.label9.TabIndex = 27;
            this.label9.Text = "Отчество:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(8, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 28);
            this.label8.TabIndex = 26;
            this.label8.Text = "Имя:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(8, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Фамилия:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addMasterButton
            // 
            this.addMasterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addMasterButton.Location = new System.Drawing.Point(634, 425);
            this.addMasterButton.Name = "addMasterButton";
            this.addMasterButton.Size = new System.Drawing.Size(150, 40);
            this.addMasterButton.TabIndex = 9;
            this.addMasterButton.Text = "Добавить";
            this.addMasterButton.UseVisualStyleBackColor = true;
            this.addMasterButton.Click += new System.EventHandler(this.addMasterButton_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(6, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // positionTextBox
            // 
            this.positionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positionTextBox.Location = new System.Drawing.Point(523, 374);
            this.positionTextBox.MaxLength = 255;
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(259, 26);
            this.positionTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(396, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Должность:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(8, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Стаж работы:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addMasterDataGridView
            // 
            this.addMasterDataGridView.AllowUserToAddRows = false;
            this.addMasterDataGridView.AllowUserToDeleteRows = false;
            this.addMasterDataGridView.AllowUserToResizeColumns = false;
            this.addMasterDataGridView.AllowUserToResizeRows = false;
            this.addMasterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addMasterDataGridView.ColumnHeadersHeight = 30;
            this.addMasterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.addMasterDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.addMasterDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.addMasterDataGridView.Location = new System.Drawing.Point(3, 3);
            this.addMasterDataGridView.MultiSelect = false;
            this.addMasterDataGridView.Name = "addMasterDataGridView";
            this.addMasterDataGridView.RowHeadersVisible = false;
            this.addMasterDataGridView.RowHeadersWidth = 40;
            this.addMasterDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.addMasterDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.addMasterDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addMasterDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addMasterDataGridView.Size = new System.Drawing.Size(786, 247);
            this.addMasterDataGridView.TabIndex = 0;
            // 
            // clientsTabPage
            // 
            this.clientsTabPage.Controls.Add(this.clientPatronymicTextBox);
            this.clientsTabPage.Controls.Add(this.clientNameTextBox);
            this.clientsTabPage.Controls.Add(this.clientSurnameTextBox);
            this.clientsTabPage.Controls.Add(this.label5);
            this.clientsTabPage.Controls.Add(this.label10);
            this.clientsTabPage.Controls.Add(this.label11);
            this.clientsTabPage.Controls.Add(this.button2);
            this.clientsTabPage.Controls.Add(this.addClientButton);
            this.clientsTabPage.Controls.Add(this.ageTextBox);
            this.clientsTabPage.Controls.Add(this.phoneTextBox);
            this.clientsTabPage.Controls.Add(this.label7);
            this.clientsTabPage.Controls.Add(this.label6);
            this.clientsTabPage.Controls.Add(this.addClientDataGridView);
            this.clientsTabPage.Location = new System.Drawing.Point(4, 29);
            this.clientsTabPage.Name = "clientsTabPage";
            this.clientsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.clientsTabPage.Size = new System.Drawing.Size(792, 473);
            this.clientsTabPage.TabIndex = 1;
            this.clientsTabPage.Text = "Клиенты";
            this.clientsTabPage.UseVisualStyleBackColor = true;
            // 
            // clientPatronymicTextBox
            // 
            this.clientPatronymicTextBox.Location = new System.Drawing.Point(152, 333);
            this.clientPatronymicTextBox.MaxLength = 50;
            this.clientPatronymicTextBox.Name = "clientPatronymicTextBox";
            this.clientPatronymicTextBox.Size = new System.Drawing.Size(630, 26);
            this.clientPatronymicTextBox.TabIndex = 30;
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(152, 293);
            this.clientNameTextBox.MaxLength = 50;
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(630, 26);
            this.clientNameTextBox.TabIndex = 29;
            // 
            // clientSurnameTextBox
            // 
            this.clientSurnameTextBox.Location = new System.Drawing.Point(152, 254);
            this.clientSurnameTextBox.MaxLength = 50;
            this.clientSurnameTextBox.Name = "clientSurnameTextBox";
            this.clientSurnameTextBox.Size = new System.Drawing.Size(630, 26);
            this.clientSurnameTextBox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(8, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Отчество:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Location = new System.Drawing.Point(8, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 28);
            this.label10.TabIndex = 26;
            this.label10.Text = "Имя:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Location = new System.Drawing.Point(8, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 28);
            this.label11.TabIndex = 25;
            this.label11.Text = "Фамилия:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(8, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addClientButton
            // 
            this.addClientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addClientButton.Location = new System.Drawing.Point(636, 425);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(150, 38);
            this.addClientButton.TabIndex = 9;
            this.addClientButton.Text = "Добавить";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(590, 371);
            this.ageTextBox.MaxLength = 3;
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(54, 26);
            this.ageTextBox.TabIndex = 8;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(152, 371);
            this.phoneTextBox.MaxLength = 15;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(177, 26);
            this.phoneTextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(422, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Возраст:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(8, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Телефон:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addClientDataGridView
            // 
            this.addClientDataGridView.AllowUserToAddRows = false;
            this.addClientDataGridView.AllowUserToDeleteRows = false;
            this.addClientDataGridView.AllowUserToResizeColumns = false;
            this.addClientDataGridView.AllowUserToResizeRows = false;
            this.addClientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addClientDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.addClientDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.addClientDataGridView.Location = new System.Drawing.Point(3, 3);
            this.addClientDataGridView.MultiSelect = false;
            this.addClientDataGridView.Name = "addClientDataGridView";
            this.addClientDataGridView.ReadOnly = true;
            this.addClientDataGridView.RowHeadersVisible = false;
            this.addClientDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.addClientDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addClientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addClientDataGridView.Size = new System.Drawing.Size(786, 247);
            this.addClientDataGridView.TabIndex = 0;
            // 
            // yearsNumericUpDown
            // 
            this.yearsNumericUpDown.Location = new System.Drawing.Point(141, 372);
            this.yearsNumericUpDown.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.yearsNumericUpDown.Name = "yearsNumericUpDown";
            this.yearsNumericUpDown.Size = new System.Drawing.Size(41, 26);
            this.yearsNumericUpDown.TabIndex = 31;
            this.yearsNumericUpDown.ValueChanged += new System.EventHandler(this.yearsNumericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(188, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 26);
            this.label3.TabIndex = 32;
            this.label3.Text = "лет";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // monthsNumericUpDown
            // 
            this.monthsNumericUpDown.Location = new System.Drawing.Point(243, 373);
            this.monthsNumericUpDown.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.monthsNumericUpDown.Name = "monthsNumericUpDown";
            this.monthsNumericUpDown.Size = new System.Drawing.Size(50, 26);
            this.monthsNumericUpDown.TabIndex = 33;
            this.monthsNumericUpDown.ValueChanged += new System.EventHandler(this.monthsNumericUpDown_ValueChanged);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(299, 373);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 25);
            this.label12.TabIndex = 34;
            this.label12.Text = "месяцев";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.informationTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddInformationForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление информации";
            this.Load += new System.EventHandler(this.AddInformationForm_Load);
            this.informationTabControl.ResumeLayout(false);
            this.mastersTabPage.ResumeLayout(false);
            this.mastersTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addMasterDataGridView)).EndInit();
            this.clientsTabPage.ResumeLayout(false);
            this.clientsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addClientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthsNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl informationTabControl;
        private System.Windows.Forms.TabPage mastersTabPage;
        private System.Windows.Forms.DataGridView addMasterDataGridView;
        private System.Windows.Forms.TabPage clientsTabPage;
        private System.Windows.Forms.DataGridView addClientDataGridView;
        private System.Windows.Forms.Button addMasterButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox masterPatronymicTextBox;
        private System.Windows.Forms.TextBox masterNameTextBox;
        private System.Windows.Forms.TextBox masterSurnameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
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