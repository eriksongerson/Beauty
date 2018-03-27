namespace Beauty.Forms
{
    partial class StartupForm
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
            this.addInformationButton = new System.Windows.Forms.Button();
            this.editInformationButton = new System.Windows.Forms.Button();
            this.entryOnVisitButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addInformationButton
            // 
            this.addInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addInformationButton.Location = new System.Drawing.Point(12, 12);
            this.addInformationButton.Name = "addInformationButton";
            this.addInformationButton.Size = new System.Drawing.Size(318, 45);
            this.addInformationButton.TabIndex = 0;
            this.addInformationButton.Text = "Добавление информации";
            this.addInformationButton.UseVisualStyleBackColor = true;
            this.addInformationButton.Click += new System.EventHandler(this.addInformationButton_Click);
            // 
            // editInformationButton
            // 
            this.editInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editInformationButton.Location = new System.Drawing.Point(12, 63);
            this.editInformationButton.Name = "editInformationButton";
            this.editInformationButton.Size = new System.Drawing.Size(318, 45);
            this.editInformationButton.TabIndex = 1;
            this.editInformationButton.Text = "Редактирование информации";
            this.editInformationButton.UseVisualStyleBackColor = true;
            this.editInformationButton.Click += new System.EventHandler(this.editInformationButton_Click);
            // 
            // entryOnVisitButton
            // 
            this.entryOnVisitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entryOnVisitButton.Location = new System.Drawing.Point(12, 114);
            this.entryOnVisitButton.Name = "entryOnVisitButton";
            this.entryOnVisitButton.Size = new System.Drawing.Size(318, 45);
            this.entryOnVisitButton.TabIndex = 2;
            this.entryOnVisitButton.Text = "Запись на посещение";
            this.entryOnVisitButton.UseVisualStyleBackColor = true;
            this.entryOnVisitButton.Click += new System.EventHandler(this.entryOnVisitButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyButton.Location = new System.Drawing.Point(12, 165);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(318, 45);
            this.historyButton.TabIndex = 3;
            this.historyButton.Text = "История";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(12, 229);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(318, 45);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(342, 284);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.entryOnVisitButton);
            this.Controls.Add(this.editInformationButton);
            this.Controls.Add(this.addInformationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Салон красоты";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addInformationButton;
        private System.Windows.Forms.Button editInformationButton;
        private System.Windows.Forms.Button entryOnVisitButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button exitButton;
    }
}

