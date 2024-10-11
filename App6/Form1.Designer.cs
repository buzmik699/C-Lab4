namespace App6
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Count2RadioButton = new System.Windows.Forms.RadioButton();
            this.Count1RadioButton = new System.Windows.Forms.RadioButton();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.SlowRadioButton = new System.Windows.Forms.RadioButton();
            this.MiddleRadioButton = new System.Windows.Forms.RadioButton();
            this.FastRadioButton = new System.Windows.Forms.RadioButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.AlipseRadioButton = new System.Windows.Forms.RadioButton();
            this.RictAllRadioButton = new System.Windows.Forms.RadioButton();
            this.RictanglesRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Count2RadioButton);
            this.GroupBox2.Controls.Add(this.Count1RadioButton);
            this.GroupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBox2.Location = new System.Drawing.Point(9, 157);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBox2.Size = new System.Drawing.Size(141, 65);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Количество фигур";
            // 
            // Count2RadioButton
            // 
            this.Count2RadioButton.AutoSize = true;
            this.Count2RadioButton.Location = new System.Drawing.Point(12, 36);
            this.Count2RadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Count2RadioButton.Name = "Count2RadioButton";
            this.Count2RadioButton.Size = new System.Drawing.Size(34, 21);
            this.Count2RadioButton.TabIndex = 1;
            this.Count2RadioButton.TabStop = true;
            this.Count2RadioButton.Text = "2";
            this.Count2RadioButton.UseVisualStyleBackColor = true;
            this.Count2RadioButton.CheckedChanged += new System.EventHandler(this.MiddleRadioButton_CheckedChanged);
            // 
            // Count1RadioButton
            // 
            this.Count1RadioButton.AutoSize = true;
            this.Count1RadioButton.Location = new System.Drawing.Point(12, 18);
            this.Count1RadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Count1RadioButton.Name = "Count1RadioButton";
            this.Count1RadioButton.Size = new System.Drawing.Size(34, 21);
            this.Count1RadioButton.TabIndex = 0;
            this.Count1RadioButton.TabStop = true;
            this.Count1RadioButton.Text = "1";
            this.Count1RadioButton.UseVisualStyleBackColor = true;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.SlowRadioButton);
            this.GroupBox3.Controls.Add(this.MiddleRadioButton);
            this.GroupBox3.Controls.Add(this.FastRadioButton);
            this.GroupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBox3.Location = new System.Drawing.Point(301, 35);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBox3.Size = new System.Drawing.Size(163, 97);
            this.GroupBox3.TabIndex = 3;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Скорость смены";
            // 
            // SlowRadioButton
            // 
            this.SlowRadioButton.AutoSize = true;
            this.SlowRadioButton.Location = new System.Drawing.Point(11, 20);
            this.SlowRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SlowRadioButton.Name = "SlowRadioButton";
            this.SlowRadioButton.Size = new System.Drawing.Size(93, 21);
            this.SlowRadioButton.TabIndex = 2;
            this.SlowRadioButton.TabStop = true;
            this.SlowRadioButton.Text = "Медленно";
            this.SlowRadioButton.UseVisualStyleBackColor = true;
            // 
            // MiddleRadioButton
            // 
            this.MiddleRadioButton.AutoSize = true;
            this.MiddleRadioButton.Location = new System.Drawing.Point(10, 44);
            this.MiddleRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MiddleRadioButton.Name = "MiddleRadioButton";
            this.MiddleRadioButton.Size = new System.Drawing.Size(75, 21);
            this.MiddleRadioButton.TabIndex = 1;
            this.MiddleRadioButton.TabStop = true;
            this.MiddleRadioButton.Text = "Средне";
            this.MiddleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FastRadioButton
            // 
            this.FastRadioButton.AutoSize = true;
            this.FastRadioButton.Location = new System.Drawing.Point(11, 68);
            this.FastRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FastRadioButton.Name = "FastRadioButton";
            this.FastRadioButton.Size = new System.Drawing.Size(75, 21);
            this.FastRadioButton.TabIndex = 0;
            this.FastRadioButton.TabStop = true;
            this.FastRadioButton.Text = "Быстро";
            this.FastRadioButton.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.AlipseRadioButton);
            this.GroupBox1.Controls.Add(this.RictAllRadioButton);
            this.GroupBox1.Controls.Add(this.RictanglesRadioButton);
            this.GroupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBox1.Location = new System.Drawing.Point(9, 35);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBox1.Size = new System.Drawing.Size(207, 106);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Фигура";
            // 
            // AlipseRadioButton
            // 
            this.AlipseRadioButton.AutoSize = true;
            this.AlipseRadioButton.Location = new System.Drawing.Point(12, 42);
            this.AlipseRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AlipseRadioButton.Name = "AlipseRadioButton";
            this.AlipseRadioButton.Size = new System.Drawing.Size(74, 21);
            this.AlipseRadioButton.TabIndex = 2;
            this.AlipseRadioButton.TabStop = true;
            this.AlipseRadioButton.Text = "Эллипс";
            this.AlipseRadioButton.UseVisualStyleBackColor = true;
            // 
            // RictAllRadioButton
            // 
            this.RictAllRadioButton.AutoSize = true;
            this.RictAllRadioButton.Location = new System.Drawing.Point(12, 67);
            this.RictAllRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RictAllRadioButton.Name = "RictAllRadioButton";
            this.RictAllRadioButton.Size = new System.Drawing.Size(199, 21);
            this.RictAllRadioButton.TabIndex = 1;
            this.RictAllRadioButton.TabStop = true;
            this.RictAllRadioButton.Text = "Прямоугольники и элипсы";
            this.RictAllRadioButton.UseVisualStyleBackColor = true;
            // 
            // RictanglesRadioButton
            // 
            this.RictanglesRadioButton.AutoSize = true;
            this.RictanglesRadioButton.Location = new System.Drawing.Point(12, 18);
            this.RictanglesRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RictanglesRadioButton.Name = "RictanglesRadioButton";
            this.RictanglesRadioButton.Size = new System.Drawing.Size(127, 21);
            this.RictanglesRadioButton.TabIndex = 0;
            this.RictanglesRadioButton.TabStop = true;
            this.RictanglesRadioButton.Text = "Прямоугольник";
            this.RictanglesRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Создал Харитонов И. А. При двойном щелчке начинается заставка";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 232);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Информация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDoubleClick);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.RadioButton Count2RadioButton;
        private System.Windows.Forms.RadioButton Count1RadioButton;
        private System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.RadioButton SlowRadioButton;
        private System.Windows.Forms.RadioButton MiddleRadioButton;
        private System.Windows.Forms.RadioButton FastRadioButton;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.RadioButton AlipseRadioButton;
        private System.Windows.Forms.RadioButton RictAllRadioButton;
        private System.Windows.Forms.RadioButton RictanglesRadioButton;
        private System.Windows.Forms.Label label1;
    }
}

