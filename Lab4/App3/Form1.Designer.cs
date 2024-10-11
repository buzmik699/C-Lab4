namespace App3
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
            this.K_GroupBox = new System.Windows.Forms.GroupBox();
            this.Man = new System.Windows.Forms.RadioButton();
            this.Woman = new System.Windows.Forms.RadioButton();
            this.Height = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.CurrentBox = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.K_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // K_GroupBox
            // 
            this.K_GroupBox.Controls.Add(this.Woman);
            this.K_GroupBox.Controls.Add(this.Man);
            this.K_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.K_GroupBox.Location = new System.Drawing.Point(12, 22);
            this.K_GroupBox.Name = "K_GroupBox";
            this.K_GroupBox.Size = new System.Drawing.Size(200, 100);
            this.K_GroupBox.TabIndex = 0;
            this.K_GroupBox.TabStop = false;
            this.K_GroupBox.Text = "Коэфициент";
            // 
            // Man
            // 
            this.Man.AutoSize = true;
            this.Man.Location = new System.Drawing.Point(7, 31);
            this.Man.Name = "Man";
            this.Man.Size = new System.Drawing.Size(104, 24);
            this.Man.TabIndex = 0;
            this.Man.TabStop = true;
            this.Man.Text = "Мужчина";
            this.Man.UseVisualStyleBackColor = true;
            // 
            // Woman
            // 
            this.Woman.AutoSize = true;
            this.Woman.Location = new System.Drawing.Point(7, 58);
            this.Woman.Name = "Woman";
            this.Woman.Size = new System.Drawing.Size(108, 24);
            this.Woman.TabIndex = 1;
            this.Woman.TabStop = true;
            this.Woman.Text = "Женщина";
            this.Woman.UseVisualStyleBackColor = true;
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Height.Location = new System.Drawing.Point(238, 37);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(49, 20);
            this.Height.TabIndex = 1;
            this.Height.Text = "Рост";
            this.Height.Click += new System.EventHandler(this.label1_Click);
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Age.Location = new System.Drawing.Point(238, 82);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(79, 20);
            this.Age.TabIndex = 2;
            this.Age.Text = "Возраст";
            this.Age.Click += new System.EventHandler(this.label2_Click);
            // 
            // CurrentBox
            // 
            this.CurrentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentBox.Location = new System.Drawing.Point(19, 150);
            this.CurrentBox.Name = "CurrentBox";
            this.CurrentBox.Size = new System.Drawing.Size(118, 31);
            this.CurrentBox.TabIndex = 3;
            this.CurrentBox.Text = "Вычислить";
            this.CurrentBox.UseVisualStyleBackColor = true;
            this.CurrentBox.Click += new System.EventHandler(this.CurrentBox_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTextBox.Location = new System.Drawing.Point(340, 150);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(104, 26);
            this.ResultTextBox.TabIndex = 19;
            this.ResultTextBox.Text = "0";
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AgeBox
            // 
            this.AgeBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AgeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeBox.Location = new System.Drawing.Point(341, 82);
            this.AgeBox.Margin = new System.Windows.Forms.Padding(5);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(103, 26);
            this.AgeBox.TabIndex = 20;
            this.AgeBox.Text = "0";
            this.AgeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HeightBox
            // 
            this.HeightBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.HeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightBox.Location = new System.Drawing.Point(341, 37);
            this.HeightBox.Margin = new System.Windows.Forms.Padding(5);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(103, 26);
            this.HeightBox.TabIndex = 21;
            this.HeightBox.Text = "0";
            this.HeightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 193);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.CurrentBox);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.K_GroupBox);
            this.Name = "MainForm";
            this.Text = "Идеальный вес";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.K_GroupBox.ResumeLayout(false);
            this.K_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox K_GroupBox;
        private System.Windows.Forms.RadioButton Woman;
        private System.Windows.Forms.RadioButton Man;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Button CurrentBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.TextBox HeightBox;
    }
}

