namespace App5
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
            this.ABox = new System.Windows.Forms.TextBox();
            this.BBox = new System.Windows.Forms.TextBox();
            this.CBox = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.CurrentBox = new System.Windows.Forms.Button();
            this.X1 = new System.Windows.Forms.Label();
            this.X2 = new System.Windows.Forms.Label();
            this.X1ResultTextBox = new System.Windows.Forms.TextBox();
            this.X2ResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ABox
            // 
            this.ABox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ABox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ABox.Location = new System.Drawing.Point(266, 32);
            this.ABox.Margin = new System.Windows.Forms.Padding(5);
            this.ABox.Name = "ABox";
            this.ABox.Size = new System.Drawing.Size(103, 26);
            this.ABox.TabIndex = 22;
            this.ABox.Text = "0";
            this.ABox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BBox
            // 
            this.BBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BBox.Location = new System.Drawing.Point(266, 66);
            this.BBox.Margin = new System.Windows.Forms.Padding(5);
            this.BBox.Name = "BBox";
            this.BBox.Size = new System.Drawing.Size(103, 26);
            this.BBox.TabIndex = 23;
            this.BBox.Text = "0";
            this.BBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CBox
            // 
            this.CBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBox.Location = new System.Drawing.Point(266, 102);
            this.CBox.Margin = new System.Windows.Forms.Padding(5);
            this.CBox.Name = "CBox";
            this.CBox.Size = new System.Drawing.Size(103, 26);
            this.CBox.TabIndex = 24;
            this.CBox.Text = "0";
            this.CBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A.Location = new System.Drawing.Point(12, 32);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(207, 20);
            this.A.TabIndex = 25;
            this.A.Text = "Введите коэфициент a";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B.Location = new System.Drawing.Point(12, 66);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(207, 20);
            this.B.TabIndex = 26;
            this.B.Text = "Введите коэфициент b";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C.Location = new System.Drawing.Point(12, 102);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(207, 20);
            this.C.TabIndex = 27;
            this.C.Text = "Введите коэфициент c";
            // 
            // CurrentBox
            // 
            this.CurrentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentBox.Location = new System.Drawing.Point(16, 173);
            this.CurrentBox.Name = "CurrentBox";
            this.CurrentBox.Size = new System.Drawing.Size(118, 31);
            this.CurrentBox.TabIndex = 28;
            this.CurrentBox.Text = "Вычислить";
            this.CurrentBox.UseVisualStyleBackColor = true;
            this.CurrentBox.Click += new System.EventHandler(this.CurrentBox_Click);
            // 
            // X1
            // 
            this.X1.AutoSize = true;
            this.X1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X1.Location = new System.Drawing.Point(190, 164);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(29, 20);
            this.X1.TabIndex = 29;
            this.X1.Text = "X1";
            // 
            // X2
            // 
            this.X2.AutoSize = true;
            this.X2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X2.Location = new System.Drawing.Point(190, 193);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(29, 20);
            this.X2.TabIndex = 30;
            this.X2.Text = "X2";
            // 
            // X1ResultTextBox
            // 
            this.X1ResultTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.X1ResultTextBox.Enabled = false;
            this.X1ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X1ResultTextBox.Location = new System.Drawing.Point(265, 158);
            this.X1ResultTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.X1ResultTextBox.Name = "X1ResultTextBox";
            this.X1ResultTextBox.Size = new System.Drawing.Size(104, 26);
            this.X1ResultTextBox.TabIndex = 31;
            this.X1ResultTextBox.Text = "0";
            this.X1ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // X2ResultTextBox
            // 
            this.X2ResultTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.X2ResultTextBox.Enabled = false;
            this.X2ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X2ResultTextBox.Location = new System.Drawing.Point(266, 196);
            this.X2ResultTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.X2ResultTextBox.Name = "X2ResultTextBox";
            this.X2ResultTextBox.Size = new System.Drawing.Size(104, 26);
            this.X2ResultTextBox.TabIndex = 32;
            this.X2ResultTextBox.Text = "0";
            this.X2ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 236);
            this.Controls.Add(this.X2ResultTextBox);
            this.Controls.Add(this.X1ResultTextBox);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.CurrentBox);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.CBox);
            this.Controls.Add(this.BBox);
            this.Controls.Add(this.ABox);
            this.Name = "MainForm";
            this.Text = "Квадратное уравнение";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ABox;
        private System.Windows.Forms.TextBox BBox;
        private System.Windows.Forms.TextBox CBox;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Button CurrentBox;
        private System.Windows.Forms.Label X1;
        private System.Windows.Forms.Label X2;
        private System.Windows.Forms.TextBox X1ResultTextBox;
        private System.Windows.Forms.TextBox X2ResultTextBox;
    }
}

