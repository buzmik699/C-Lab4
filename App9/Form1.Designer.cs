namespace App9
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
            this.ImagineButton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImagineButton
            // 
            this.ImagineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImagineButton.Location = new System.Drawing.Point(107, 340);
            this.ImagineButton.Name = "ImagineButton";
            this.ImagineButton.Size = new System.Drawing.Size(299, 33);
            this.ImagineButton.TabIndex = 2;
            this.ImagineButton.Text = "Изобразить новый треугольник";
            this.ImagineButton.UseVisualStyleBackColor = true;
            this.ImagineButton.Click += new System.EventHandler(this.ImagineButton_Click);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBox.Enabled = false;
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.Location = new System.Drawing.Point(303, 381);
            this.TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(103, 26);
            this.TextBox.TabIndex = 22;
            this.TextBox.Text = "0";
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(107, 381);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(142, 26);
            this.StartButton.TabIndex = 23;
            this.StartButton.Text = "Начать";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 421);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.ImagineButton);
            this.Name = "MainForm";
            this.Text = "Треугольники и хаос";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImagineButton;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button StartButton;
    }
}

