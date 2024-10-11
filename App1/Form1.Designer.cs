namespace App1
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
            this.v = new System.Windows.Forms.GroupBox();
            this.MetrButton = new System.Windows.Forms.RadioButton();
            this.SanButton = new System.Windows.Forms.RadioButton();
            this.YardRadioButton = new System.Windows.Forms.RadioButton();
            this.FootRadioButton = new System.Windows.Forms.RadioButton();
            this.InchRadioButton = new System.Windows.Forms.RadioButton();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.CentiMTextBox = new System.Windows.Forms.TextBox();
            this.DataGroupBox = new System.Windows.Forms.GroupBox();
            this.mt = new System.Windows.Forms.RadioButton();
            this.sm = new System.Windows.Forms.RadioButton();
            this.yr = new System.Windows.Forms.RadioButton();
            this.ft = new System.Windows.Forms.RadioButton();
            this.dm = new System.Windows.Forms.RadioButton();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.v.SuspendLayout();
            this.DataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // v
            // 
            this.v.Controls.Add(this.MetrButton);
            this.v.Controls.Add(this.SanButton);
            this.v.Controls.Add(this.YardRadioButton);
            this.v.Controls.Add(this.FootRadioButton);
            this.v.Controls.Add(this.InchRadioButton);
            this.v.Controls.Add(this.ResultTextBox);
            this.v.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.v.Location = new System.Drawing.Point(404, 45);
            this.v.Margin = new System.Windows.Forms.Padding(5);
            this.v.Name = "v";
            this.v.Padding = new System.Windows.Forms.Padding(5);
            this.v.Size = new System.Drawing.Size(346, 165);
            this.v.TabIndex = 6;
            this.v.TabStop = false;
            this.v.Text = "Результат";
            // 
            // MetrButton
            // 
            this.MetrButton.AutoSize = true;
            this.MetrButton.Location = new System.Drawing.Point(44, 130);
            this.MetrButton.Margin = new System.Windows.Forms.Padding(5);
            this.MetrButton.Name = "MetrButton";
            this.MetrButton.Size = new System.Drawing.Size(105, 24);
            this.MetrButton.TabIndex = 15;
            this.MetrButton.TabStop = true;
            this.MetrButton.Text = "в метрах";
            this.MetrButton.UseVisualStyleBackColor = true;
            this.MetrButton.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // SanButton
            // 
            this.SanButton.AutoSize = true;
            this.SanButton.Location = new System.Drawing.Point(44, 107);
            this.SanButton.Margin = new System.Windows.Forms.Padding(5);
            this.SanButton.Name = "SanButton";
            this.SanButton.Size = new System.Drawing.Size(154, 24);
            this.SanButton.TabIndex = 14;
            this.SanButton.TabStop = true;
            this.SanButton.Text = "в сантиметрах";
            this.SanButton.UseVisualStyleBackColor = true;
            this.SanButton.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // YardRadioButton
            // 
            this.YardRadioButton.AutoSize = true;
            this.YardRadioButton.Location = new System.Drawing.Point(44, 83);
            this.YardRadioButton.Margin = new System.Windows.Forms.Padding(5);
            this.YardRadioButton.Name = "YardRadioButton";
            this.YardRadioButton.Size = new System.Drawing.Size(95, 24);
            this.YardRadioButton.TabIndex = 13;
            this.YardRadioButton.TabStop = true;
            this.YardRadioButton.Text = "в ярдах";
            this.YardRadioButton.UseVisualStyleBackColor = true;
            this.YardRadioButton.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // FootRadioButton
            // 
            this.FootRadioButton.AutoSize = true;
            this.FootRadioButton.Location = new System.Drawing.Point(44, 59);
            this.FootRadioButton.Margin = new System.Windows.Forms.Padding(5);
            this.FootRadioButton.Name = "FootRadioButton";
            this.FootRadioButton.Size = new System.Drawing.Size(97, 24);
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
            this.InchRadioButton.Location = new System.Drawing.Point(44, 39);
            this.InchRadioButton.Margin = new System.Windows.Forms.Padding(5);
            this.InchRadioButton.Name = "InchRadioButton";
            this.InchRadioButton.Size = new System.Drawing.Size(110, 24);
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
            this.ResultTextBox.Location = new System.Drawing.Point(232, 37);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(104, 26);
            this.ResultTextBox.TabIndex = 10;
            this.ResultTextBox.Text = "0";
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ResultTextBox.TextChanged += new System.EventHandler(this.ResultTextBox_TextChanged);
            // 
            // CentiMTextBox
            // 
            this.CentiMTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CentiMTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CentiMTextBox.Location = new System.Drawing.Point(232, 37);
            this.CentiMTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CentiMTextBox.Name = "CentiMTextBox";
            this.CentiMTextBox.Size = new System.Drawing.Size(103, 26);
            this.CentiMTextBox.TabIndex = 7;
            this.CentiMTextBox.Text = "0";
            this.CentiMTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DataGroupBox
            // 
            this.DataGroupBox.Controls.Add(this.mt);
            this.DataGroupBox.Controls.Add(this.sm);
            this.DataGroupBox.Controls.Add(this.yr);
            this.DataGroupBox.Controls.Add(this.CentiMTextBox);
            this.DataGroupBox.Controls.Add(this.ft);
            this.DataGroupBox.Controls.Add(this.dm);
            this.DataGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGroupBox.Location = new System.Drawing.Point(14, 45);
            this.DataGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.DataGroupBox.Name = "DataGroupBox";
            this.DataGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.DataGroupBox.Size = new System.Drawing.Size(346, 165);
            this.DataGroupBox.TabIndex = 14;
            this.DataGroupBox.TabStop = false;
            this.DataGroupBox.Text = "Исходные данные";
            // 
            // mt
            // 
            this.mt.AutoSize = true;
            this.mt.Location = new System.Drawing.Point(44, 130);
            this.mt.Margin = new System.Windows.Forms.Padding(5);
            this.mt.Name = "mt";
            this.mt.Size = new System.Drawing.Size(105, 24);
            this.mt.TabIndex = 15;
            this.mt.TabStop = true;
            this.mt.Text = "в метрах";
            this.mt.UseVisualStyleBackColor = true;
            this.mt.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // sm
            // 
            this.sm.AutoSize = true;
            this.sm.Location = new System.Drawing.Point(44, 107);
            this.sm.Margin = new System.Windows.Forms.Padding(5);
            this.sm.Name = "sm";
            this.sm.Size = new System.Drawing.Size(154, 24);
            this.sm.TabIndex = 14;
            this.sm.TabStop = true;
            this.sm.Text = "в сантиметрах";
            this.sm.UseVisualStyleBackColor = true;
            this.sm.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // yr
            // 
            this.yr.AutoSize = true;
            this.yr.Location = new System.Drawing.Point(44, 83);
            this.yr.Margin = new System.Windows.Forms.Padding(5);
            this.yr.Name = "yr";
            this.yr.Size = new System.Drawing.Size(95, 24);
            this.yr.TabIndex = 13;
            this.yr.TabStop = true;
            this.yr.Text = "в ярдах";
            this.yr.UseVisualStyleBackColor = true;
            this.yr.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ft
            // 
            this.ft.AutoSize = true;
            this.ft.Location = new System.Drawing.Point(44, 59);
            this.ft.Margin = new System.Windows.Forms.Padding(5);
            this.ft.Name = "ft";
            this.ft.Size = new System.Drawing.Size(97, 24);
            this.ft.TabIndex = 12;
            this.ft.TabStop = true;
            this.ft.Text = "в футах";
            this.ft.UseVisualStyleBackColor = true;
            this.ft.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // dm
            // 
            this.dm.AutoSize = true;
            this.dm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dm.Location = new System.Drawing.Point(44, 39);
            this.dm.Margin = new System.Windows.Forms.Padding(5);
            this.dm.Name = "dm";
            this.dm.Size = new System.Drawing.Size(110, 24);
            this.dm.TabIndex = 11;
            this.dm.TabStop = true;
            this.dm.Text = "в дюймах";
            this.dm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dm.UseVisualStyleBackColor = true;
            this.dm.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExecuteButton.Location = new System.Drawing.Point(300, 229);
            this.ExecuteButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(157, 50);
            this.ExecuteButton.TabIndex = 15;
            this.ExecuteButton.Text = "Перевести";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 305);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.DataGroupBox);
            this.Controls.Add(this.v);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Конвертер";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.v.ResumeLayout(false);
            this.v.PerformLayout();
            this.DataGroupBox.ResumeLayout(false);
            this.DataGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox v;
        private System.Windows.Forms.RadioButton YardRadioButton;
        private System.Windows.Forms.RadioButton FootRadioButton;
        private System.Windows.Forms.RadioButton InchRadioButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TextBox CentiMTextBox;
        private System.Windows.Forms.GroupBox DataGroupBox;
        private System.Windows.Forms.RadioButton yr;
        private System.Windows.Forms.RadioButton ft;
        private System.Windows.Forms.RadioButton dm;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.RadioButton SanButton;
        private System.Windows.Forms.RadioButton MetrButton;
        private System.Windows.Forms.RadioButton mt;
        private System.Windows.Forms.RadioButton sm;
    }
}

