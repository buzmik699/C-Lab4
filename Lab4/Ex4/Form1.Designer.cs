namespace Ex4
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.CentiMLabel = new System.Windows.Forms.Label();
            this.CentiMTextBox = new System.Windows.Forms.TextBox();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.YardRadioButton = new System.Windows.Forms.RadioButton();
            this.FootRadioButton = new System.Windows.Forms.RadioButton();
            this.InchRadioButton = new System.Windows.Forms.RadioButton();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExecuteButton.Location = new System.Drawing.Point(116, 217);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(118, 41);
            this.ExecuteButton.TabIndex = 1;
            this.ExecuteButton.Text = "Перевести";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // CentiMLabel
            // 
            this.CentiMLabel.AutoSize = true;
            this.CentiMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CentiMLabel.Location = new System.Drawing.Point(12, 39);
            this.CentiMLabel.Name = "CentiMLabel";
            this.CentiMLabel.Size = new System.Drawing.Size(204, 16);
            this.CentiMLabel.TabIndex = 3;
            this.CentiMLabel.Text = "Введите длину в сантиметрах";
            // 
            // CentiMTextBox
            // 
            this.CentiMTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CentiMTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CentiMTextBox.Location = new System.Drawing.Point(233, 39);
            this.CentiMTextBox.Name = "CentiMTextBox";
            this.CentiMTextBox.Size = new System.Drawing.Size(91, 22);
            this.CentiMTextBox.TabIndex = 4;
            this.CentiMTextBox.Text = "0";
            this.CentiMTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CentiMTextBox.TextChanged += new System.EventHandler(this.CentiMTextBox_TextChanged);
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.YardRadioButton);
            this.ResultGroupBox.Controls.Add(this.FootRadioButton);
            this.ResultGroupBox.Controls.Add(this.InchRadioButton);
            this.ResultGroupBox.Controls.Add(this.ResultTextBox);
            this.ResultGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultGroupBox.Location = new System.Drawing.Point(15, 78);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(319, 91);
            this.ResultGroupBox.TabIndex = 5;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Результат";
            // 
            // YardRadioButton
            // 
            this.YardRadioButton.AutoSize = true;
            this.YardRadioButton.Location = new System.Drawing.Point(26, 65);
            this.YardRadioButton.Name = "YardRadioButton";
            this.YardRadioButton.Size = new System.Drawing.Size(73, 20);
            this.YardRadioButton.TabIndex = 13;
            this.YardRadioButton.TabStop = true;
            this.YardRadioButton.Text = "в ярдах";
            this.YardRadioButton.UseVisualStyleBackColor = true;
            this.YardRadioButton.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // FootRadioButton
            // 
            this.FootRadioButton.AutoSize = true;
            this.FootRadioButton.Location = new System.Drawing.Point(26, 43);
            this.FootRadioButton.Name = "FootRadioButton";
            this.FootRadioButton.Size = new System.Drawing.Size(76, 20);
            this.FootRadioButton.TabIndex = 12;
            this.FootRadioButton.TabStop = true;
            this.FootRadioButton.Text = "в футах";
            this.FootRadioButton.UseVisualStyleBackColor = true;
            this.FootRadioButton.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // InchRadioButton
            // 
            this.InchRadioButton.AutoSize = true;
            this.InchRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InchRadioButton.Location = new System.Drawing.Point(26, 25);
            this.InchRadioButton.Name = "InchRadioButton";
            this.InchRadioButton.Size = new System.Drawing.Size(86, 21);
            this.InchRadioButton.TabIndex = 11;
            this.InchRadioButton.TabStop = true;
            this.InchRadioButton.Text = "в дюймах";
            this.InchRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InchRadioButton.UseVisualStyleBackColor = true;
            this.InchRadioButton.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTextBox.Location = new System.Drawing.Point(234, 22);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(75, 22);
            this.ResultTextBox.TabIndex = 10;
            this.ResultTextBox.Text = "0";
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 268);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.CentiMTextBox);
            this.Controls.Add(this.CentiMLabel);
            this.Controls.Add(this.ExecuteButton);
            this.Name = "MainForm";
            this.Text = "Конвертер";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Label CentiMLabel;
        private System.Windows.Forms.TextBox CentiMTextBox;
        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.RadioButton YardRadioButton;
        private System.Windows.Forms.RadioButton FootRadioButton;
        private System.Windows.Forms.RadioButton InchRadioButton;
        private System.Windows.Forms.Timer timer1;
    }
}

