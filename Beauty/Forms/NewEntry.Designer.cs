namespace Beauty.Forms
{
    partial class NewEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.masterComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.makeEntryButton = new System.Windows.Forms.Button();
            this.newClientButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.timeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(659, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мастер:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // masterComboBox
            // 
            this.masterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.masterComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.masterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.masterComboBox.FormattingEnabled = true;
            this.masterComboBox.Location = new System.Drawing.Point(12, 35);
            this.masterComboBox.Name = "masterComboBox";
            this.masterComboBox.Size = new System.Drawing.Size(659, 28);
            this.masterComboBox.TabIndex = 0;
            this.masterComboBox.SelectedIndexChanged += new System.EventHandler(this.masterComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(578, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Клиент:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата и время:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientComboBox
            // 
            this.clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(12, 92);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(659, 28);
            this.clientComboBox.TabIndex = 2;
            this.clientComboBox.SelectedIndexChanged += new System.EventHandler(this.clientComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Стоимость:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.priceTextBox.Location = new System.Drawing.Point(209, 160);
            this.priceTextBox.MaxLength = 5;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(93, 26);
            this.priceTextBox.TabIndex = 5;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // makeEntryButton
            // 
            this.makeEntryButton.Enabled = false;
            this.makeEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.makeEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.makeEntryButton.Location = new System.Drawing.Point(463, 126);
            this.makeEntryButton.Name = "makeEntryButton";
            this.makeEntryButton.Size = new System.Drawing.Size(208, 29);
            this.makeEntryButton.TabIndex = 6;
            this.makeEntryButton.Text = "Записаться";
            this.makeEntryButton.UseVisualStyleBackColor = true;
            this.makeEntryButton.Click += new System.EventHandler(this.makeEntryButton_Click);
            // 
            // newClientButton
            // 
            this.newClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newClientButton.Location = new System.Drawing.Point(463, 64);
            this.newClientButton.Name = "newClientButton";
            this.newClientButton.Size = new System.Drawing.Size(208, 27);
            this.newClientButton.TabIndex = 1;
            this.newClientButton.Text = "Новый клиент";
            this.newClientButton.UseVisualStyleBackColor = true;
            this.newClientButton.Click += new System.EventHandler(this.newClientButton_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(308, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "рублей";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(463, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateMaskedTextBox
            // 
            this.dateMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateMaskedTextBox.Location = new System.Drawing.Point(209, 126);
            this.dateMaskedTextBox.Mask = "00/00/0000";
            this.dateMaskedTextBox.Name = "dateMaskedTextBox";
            this.dateMaskedTextBox.Size = new System.Drawing.Size(93, 26);
            this.dateMaskedTextBox.TabIndex = 3;
            this.dateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.dateMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.dateMaskedTextBox_MaskInputRejected);
            this.dateMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateMaskedTextBox_KeyPress);
            // 
            // timeMaskedTextBox
            // 
            this.timeMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.timeMaskedTextBox.Location = new System.Drawing.Point(312, 126);
            this.timeMaskedTextBox.Mask = "00:00";
            this.timeMaskedTextBox.Name = "timeMaskedTextBox";
            this.timeMaskedTextBox.Size = new System.Drawing.Size(49, 26);
            this.timeMaskedTextBox.TabIndex = 4;
            this.timeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.timeMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.timeMaskedTextBox_MaskInputRejected);
            this.timeMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeMaskedTextBox_KeyPress);
            // 
            // NewEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(683, 201);
            this.ControlBox = false;
            this.Controls.Add(this.timeMaskedTextBox);
            this.Controls.Add(this.dateMaskedTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newClientButton);
            this.Controls.Add(this.makeEntryButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.masterComboBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewEntry";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Записать на посещение";
            this.Load += new System.EventHandler(this.NewEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox masterComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button makeEntryButton;
        private System.Windows.Forms.Button newClientButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox dateMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox timeMaskedTextBox;
    }
}