namespace Ex1
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
            this.CentiMLabel = new System.Windows.Forms.Label();
            this.InchLabel = new System.Windows.Forms.Label();
            this.InchTextBox = new System.Windows.Forms.TextBox();
            this.Yard = new System.Windows.Forms.TextBox();
            this.Fut = new System.Windows.Forms.TextBox();
            this.yards = new System.Windows.Forms.Label();
            this.futs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExecuteButton.Location = new System.Drawing.Point(156, 206);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(118, 41);
            this.ExecuteButton.TabIndex = 0;
            this.ExecuteButton.Text = "Перевести";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.button1_Click);
            this.ExecuteButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExecuteButton_KeyDown);
            // 
            // CentiMTextBox
            // 
            this.CentiMTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CentiMTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CentiMTextBox.Location = new System.Drawing.Point(304, 46);
            this.CentiMTextBox.Name = "CentiMTextBox";
            this.CentiMTextBox.Size = new System.Drawing.Size(91, 22);
            this.CentiMTextBox.TabIndex = 1;
            this.CentiMTextBox.Text = "0";
            this.CentiMTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CentiMTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CentiMLabel
            // 
            this.CentiMLabel.AutoSize = true;
            this.CentiMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CentiMLabel.Location = new System.Drawing.Point(22, 46);
            this.CentiMLabel.Name = "CentiMLabel";
            this.CentiMLabel.Size = new System.Drawing.Size(204, 16);
            this.CentiMLabel.TabIndex = 2;
            this.CentiMLabel.Text = "Введите длину в сантиметрах";
            // 
            // InchLabel
            // 
            this.InchLabel.AutoSize = true;
            this.InchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InchLabel.Location = new System.Drawing.Point(22, 83);
            this.InchLabel.Name = "InchLabel";
            this.InchLabel.Size = new System.Drawing.Size(111, 16);
            this.InchLabel.TabIndex = 3;
            this.InchLabel.Text = "Длина в дюймах";
            this.InchLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // InchTextBox
            // 
            this.InchTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.InchTextBox.Enabled = false;
            this.InchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InchTextBox.Location = new System.Drawing.Point(304, 83);
            this.InchTextBox.Name = "InchTextBox";
            this.InchTextBox.Size = new System.Drawing.Size(91, 22);
            this.InchTextBox.TabIndex = 4;
            this.InchTextBox.Text = "0";
            this.InchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InchTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Yard
            // 
            this.Yard.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Yard.Enabled = false;
            this.Yard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Yard.Location = new System.Drawing.Point(304, 122);
            this.Yard.Name = "Yard";
            this.Yard.Size = new System.Drawing.Size(91, 22);
            this.Yard.TabIndex = 5;
            this.Yard.Text = "0";
            this.Yard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Fut
            // 
            this.Fut.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Fut.Enabled = false;
            this.Fut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fut.Location = new System.Drawing.Point(304, 159);
            this.Fut.Name = "Fut";
            this.Fut.Size = new System.Drawing.Size(91, 22);
            this.Fut.TabIndex = 6;
            this.Fut.Text = "0";
            this.Fut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yards
            // 
            this.yards.AutoSize = true;
            this.yards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yards.Location = new System.Drawing.Point(22, 122);
            this.yards.Name = "yards";
            this.yards.Size = new System.Drawing.Size(99, 16);
            this.yards.TabIndex = 7;
            this.yards.Text = "Длина в ярдах";
            this.yards.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // futs
            // 
            this.futs.AutoSize = true;
            this.futs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.futs.Location = new System.Drawing.Point(22, 159);
            this.futs.Name = "futs";
            this.futs.Size = new System.Drawing.Size(102, 16);
            this.futs.TabIndex = 8;
            this.futs.Text = "Длина в футах";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(426, 259);
            this.Controls.Add(this.futs);
            this.Controls.Add(this.yards);
            this.Controls.Add(this.Fut);
            this.Controls.Add(this.Yard);
            this.Controls.Add(this.InchTextBox);
            this.Controls.Add(this.InchLabel);
            this.Controls.Add(this.CentiMLabel);
            this.Controls.Add(this.CentiMTextBox);
            this.Controls.Add(this.ExecuteButton);
            this.Name = "MainForm";
            this.Text = "Конвертер";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.TextBox CentiMTextBox;
        private System.Windows.Forms.Label CentiMLabel;
        private System.Windows.Forms.Label InchLabel;
        private System.Windows.Forms.TextBox InchTextBox;
        private System.Windows.Forms.TextBox Yard;
        private System.Windows.Forms.TextBox Fut;
        private System.Windows.Forms.Label yards;
        private System.Windows.Forms.Label futs;
    }
}

