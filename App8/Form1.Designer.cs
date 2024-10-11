namespace App8
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
            this.Question = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question.Location = new System.Drawing.Point(29, 38);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(436, 32);
            this.Question.TabIndex = 27;
            this.Question.Text = "Вы довольны своей зарплатой?";
            this.Question.Click += new System.EventHandler(this.Question_Click);
            // 
            // YesButton
            // 
            this.YesButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.YesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YesButton.Location = new System.Drawing.Point(71, 153);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(76, 32);
            this.YesButton.TabIndex = 28;
            this.YesButton.Text = "Да";
            this.toolTip1.SetToolTip(this.YesButton, "Нажми сюда");
            this.YesButton.UseVisualStyleBackColor = false;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoButton.Location = new System.Drawing.Point(349, 152);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 33);
            this.NoButton.TabIndex = 29;
            this.NoButton.Text = "Нет";
            this.NoButton.UseVisualStyleBackColor = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            this.NoButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NoButton_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 232);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.Question);
            this.Name = "MainForm";
            this.Text = "Вопрос работодателя";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

