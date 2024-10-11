namespace App7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CheezeBox = new System.Windows.Forms.PictureBox();
            this.MouseBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CheezeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MouseBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CheezeBox
            // 
            this.CheezeBox.Image = ((System.Drawing.Image)(resources.GetObject("CheezeBox.Image")));
            this.CheezeBox.Location = new System.Drawing.Point(9, 10);
            this.CheezeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheezeBox.Name = "CheezeBox";
            this.CheezeBox.Size = new System.Drawing.Size(52, 57);
            this.CheezeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CheezeBox.TabIndex = 0;
            this.CheezeBox.TabStop = false;
            // 
            // MouseBox
            // 
            this.MouseBox.Image = ((System.Drawing.Image)(resources.GetObject("MouseBox.Image")));
            this.MouseBox.Location = new System.Drawing.Point(262, 261);
            this.MouseBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MouseBox.Name = "MouseBox";
            this.MouseBox.Size = new System.Drawing.Size(52, 57);
            this.MouseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MouseBox.TabIndex = 1;
            this.MouseBox.TabStop = false;
            this.MouseBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 327);
            this.Controls.Add(this.MouseBox);
            this.Controls.Add(this.CheezeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Сыр";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.CheezeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MouseBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CheezeBox;
        private System.Windows.Forms.PictureBox MouseBox;
        private System.Windows.Forms.Timer timer1;
    }
}

