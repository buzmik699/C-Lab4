namespace App4
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
            this.LevelGroupBox = new System.Windows.Forms.GroupBox();
            this.EasyRadioButton = new System.Windows.Forms.RadioButton();
            this.MiddleRadioButton = new System.Windows.Forms.RadioButton();
            this.HardRadioButton = new System.Windows.Forms.RadioButton();
            this.PlayButton = new System.Windows.Forms.Button();
            this.LevelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LevelGroupBox
            // 
            this.LevelGroupBox.Controls.Add(this.HardRadioButton);
            this.LevelGroupBox.Controls.Add(this.MiddleRadioButton);
            this.LevelGroupBox.Controls.Add(this.EasyRadioButton);
            this.LevelGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.LevelGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevelGroupBox.Location = new System.Drawing.Point(12, 12);
            this.LevelGroupBox.Name = "LevelGroupBox";
            this.LevelGroupBox.Size = new System.Drawing.Size(208, 100);
            this.LevelGroupBox.TabIndex = 0;
            this.LevelGroupBox.TabStop = false;
            this.LevelGroupBox.Text = "Уровень сложности";
            // 
            // EasyRadioButton
            // 
            this.EasyRadioButton.AutoSize = true;
            this.EasyRadioButton.Location = new System.Drawing.Point(16, 22);
            this.EasyRadioButton.Name = "EasyRadioButton";
            this.EasyRadioButton.Size = new System.Drawing.Size(89, 24);
            this.EasyRadioButton.TabIndex = 0;
            this.EasyRadioButton.TabStop = true;
            this.EasyRadioButton.Text = "Легкий";
            this.EasyRadioButton.UseVisualStyleBackColor = true;
            // 
            // MiddleRadioButton
            // 
            this.MiddleRadioButton.AutoSize = true;
            this.MiddleRadioButton.Location = new System.Drawing.Point(16, 44);
            this.MiddleRadioButton.Name = "MiddleRadioButton";
            this.MiddleRadioButton.Size = new System.Drawing.Size(104, 24);
            this.MiddleRadioButton.TabIndex = 1;
            this.MiddleRadioButton.TabStop = true;
            this.MiddleRadioButton.Text = "Средний";
            this.MiddleRadioButton.UseVisualStyleBackColor = true;
            // 
            // HardRadioButton
            // 
            this.HardRadioButton.AutoSize = true;
            this.HardRadioButton.Location = new System.Drawing.Point(16, 70);
            this.HardRadioButton.Name = "HardRadioButton";
            this.HardRadioButton.Size = new System.Drawing.Size(102, 24);
            this.HardRadioButton.TabIndex = 2;
            this.HardRadioButton.TabStop = true;
            this.HardRadioButton.Text = "Высокий";
            this.HardRadioButton.UseVisualStyleBackColor = true;
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayButton.Location = new System.Drawing.Point(74, 118);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(86, 33);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Играть";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 163);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.LevelGroupBox);
            this.Name = "MainForm";
            this.Text = "Игра - Клавиши";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LevelGroupBox.ResumeLayout(false);
            this.LevelGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LevelGroupBox;
        private System.Windows.Forms.RadioButton HardRadioButton;
        private System.Windows.Forms.RadioButton MiddleRadioButton;
        private System.Windows.Forms.RadioButton EasyRadioButton;
        private System.Windows.Forms.Button PlayButton;
    }
}

