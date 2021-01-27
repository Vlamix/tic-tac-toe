namespace WindowsFormsApp1
{
    partial class Form1
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
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.top_left = new System.Windows.Forms.Button();
            this.top_center = new System.Windows.Forms.Button();
            this.top_right = new System.Windows.Forms.Button();
            this.middle_right = new System.Windows.Forms.Button();
            this.middle_center = new System.Windows.Forms.Button();
            this.middle_left = new System.Windows.Forms.Button();
            this.bottom_left = new System.Windows.Forms.Button();
            this.bottom_right = new System.Windows.Forms.Button();
            this.bottom_center = new System.Windows.Forms.Button();
            this.StepInfo = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.score1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.score1.Location = new System.Drawing.Point(180, 50);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(29, 31);
            this.score1.TabIndex = 0;
            this.score1.Text = "0";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.BackColor = System.Drawing.SystemColors.Control;
            this.score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.score2.ForeColor = System.Drawing.Color.Red;
            this.score2.Location = new System.Drawing.Point(280, 50);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(29, 31);
            this.score2.TabIndex = 1;
            this.score2.Text = "0";
            // 
            // top_left
            // 
            this.top_left.Location = new System.Drawing.Point(50, 150);
            this.top_left.Name = "top_left";
            this.top_left.Size = new System.Drawing.Size(100, 100);
            this.top_left.TabIndex = 2;
            this.top_left.UseVisualStyleBackColor = true;
            this.top_left.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameButton_MouseClick);
            // 
            // top_center
            // 
            this.top_center.Location = new System.Drawing.Point(200, 150);
            this.top_center.Name = "top_center";
            this.top_center.Size = new System.Drawing.Size(100, 100);
            this.top_center.TabIndex = 3;
            this.top_center.UseVisualStyleBackColor = true;
            this.top_center.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameButton_MouseClick);
            // 
            // top_right
            // 
            this.top_right.Location = new System.Drawing.Point(350, 150);
            this.top_right.Name = "top_right";
            this.top_right.Size = new System.Drawing.Size(100, 100);
            this.top_right.TabIndex = 4;
            this.top_right.UseVisualStyleBackColor = true;
            this.top_right.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameButton_MouseClick);
            // 
            // middle_right
            // 
            this.middle_right.Location = new System.Drawing.Point(350, 300);
            this.middle_right.Name = "middle_right";
            this.middle_right.Size = new System.Drawing.Size(100, 100);
            this.middle_right.TabIndex = 7;
            this.middle_right.UseVisualStyleBackColor = true;
            this.middle_right.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameButton_MouseClick);
            // 
            // middle_center
            // 
            this.middle_center.Location = new System.Drawing.Point(200, 300);
            this.middle_center.Name = "middle_center";
            this.middle_center.Size = new System.Drawing.Size(100, 100);
            this.middle_center.TabIndex = 6;
            this.middle_center.UseVisualStyleBackColor = true;
            this.middle_center.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameButton_MouseClick);
            // 
            // middle_left
            // 
            this.middle_left.Location = new System.Drawing.Point(50, 300);
            this.middle_left.Name = "middle_left";
            this.middle_left.Size = new System.Drawing.Size(100, 100);
            this.middle_left.TabIndex = 5;
            this.middle_left.UseVisualStyleBackColor = true;
            this.middle_left.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameButton_MouseClick);
            // 
            // bottom_left
            // 
            this.bottom_left.Location = new System.Drawing.Point(50, 450);
            this.bottom_left.Name = "bottom_left";
            this.bottom_left.Size = new System.Drawing.Size(100, 100);
            this.bottom_left.TabIndex = 8;
            this.bottom_left.UseVisualStyleBackColor = true;
            this.bottom_left.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameButton_MouseClick);
            // 
            // bottom_right
            // 
            this.bottom_right.Location = new System.Drawing.Point(350, 450);
            this.bottom_right.Name = "bottom_right";
            this.bottom_right.Size = new System.Drawing.Size(100, 100);
            this.bottom_right.TabIndex = 10;
            this.bottom_right.UseVisualStyleBackColor = true;
            this.bottom_right.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameButton_MouseClick);
            // 
            // bottom_center
            // 
            this.bottom_center.Location = new System.Drawing.Point(200, 450);
            this.bottom_center.Name = "bottom_center";
            this.bottom_center.Size = new System.Drawing.Size(100, 100);
            this.bottom_center.TabIndex = 9;
            this.bottom_center.UseVisualStyleBackColor = true;
            this.bottom_center.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameButton_MouseClick);
            // 
            // StepInfo
            // 
            this.StepInfo.AutoSize = true;
            this.StepInfo.BackColor = System.Drawing.Color.Yellow;
            this.StepInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.StepInfo.Location = new System.Drawing.Point(229, 18);
            this.StepInfo.Name = "StepInfo";
            this.StepInfo.Size = new System.Drawing.Size(32, 31);
            this.StepInfo.TabIndex = 11;
            this.StepInfo.Text = "X";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(375, 50);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 31);
            this.ResetButton.TabIndex = 12;
            this.ResetButton.Text = "reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(375, 18);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 31);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.Text = "close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StepInfo);
            this.Controls.Add(this.bottom_right);
            this.Controls.Add(this.bottom_center);
            this.Controls.Add(this.bottom_left);
            this.Controls.Add(this.middle_right);
            this.Controls.Add(this.middle_center);
            this.Controls.Add(this.middle_left);
            this.Controls.Add(this.top_right);
            this.Controls.Add(this.top_center);
            this.Controls.Add(this.top_left);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label score1;
        public System.Windows.Forms.Label score2;
        private System.Windows.Forms.Button top_left;
        private System.Windows.Forms.Button top_center;
        private System.Windows.Forms.Button top_right;
        private System.Windows.Forms.Button middle_right;
        private System.Windows.Forms.Button middle_center;
        private System.Windows.Forms.Button middle_left;
        private System.Windows.Forms.Button bottom_left;
        private System.Windows.Forms.Button bottom_right;
        private System.Windows.Forms.Button bottom_center;
        public System.Windows.Forms.Label StepInfo;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button CloseButton;
    }
}

