namespace App2
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
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.CentiMTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.Information = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExecuteButton.Location = new System.Drawing.Point(294, 101);
            this.ExecuteButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(157, 50);
            this.ExecuteButton.TabIndex = 16;
            this.ExecuteButton.Text = "Рассчитать";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // CentiMTextBox
            // 
            this.CentiMTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CentiMTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CentiMTextBox.Location = new System.Drawing.Point(329, 39);
            this.CentiMTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CentiMTextBox.Name = "CentiMTextBox";
            this.CentiMTextBox.Size = new System.Drawing.Size(103, 26);
            this.CentiMTextBox.TabIndex = 17;
            this.CentiMTextBox.Text = "0";
            this.CentiMTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTextBox.Location = new System.Drawing.Point(39, 113);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(104, 26);
            this.ResultTextBox.TabIndex = 18;
            this.ResultTextBox.Text = "0";
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Information.Location = new System.Drawing.Point(26, 39);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(261, 20);
            this.Information.TabIndex = 19;
            this.Information.Text = "Пишите в формате 00/00/0000";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 164);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.CentiMTextBox);
            this.Controls.Add(this.ExecuteButton);
            this.Name = "MainForm";
            this.Text = "До конца года";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.TextBox CentiMTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label Information;
    }
}

