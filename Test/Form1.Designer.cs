namespace Test
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.rbtnAnswer4 = new System.Windows.Forms.RadioButton();
            this.rbtnAnswer3 = new System.Windows.Forms.RadioButton();
            this.rbtnAnswer2 = new System.Windows.Forms.RadioButton();
            this.rbtnAnswer1 = new System.Windows.Forms.RadioButton();
            this.tbxQuestion = new System.Windows.Forms.RichTextBox();
            this.cbxTheme = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbx = new System.Windows.Forms.GroupBox();
            this.gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 46);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(346, 35);
            this.progressBar.TabIndex = 0;
            // 
            // rbtnAnswer4
            // 
            this.rbtnAnswer4.AutoSize = true;
            this.rbtnAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnAnswer4.Location = new System.Drawing.Point(6, 106);
            this.rbtnAnswer4.Name = "rbtnAnswer4";
            this.rbtnAnswer4.Size = new System.Drawing.Size(88, 24);
            this.rbtnAnswer4.TabIndex = 1;
            this.rbtnAnswer4.TabStop = true;
            this.rbtnAnswer4.Tag = "4";
            this.rbtnAnswer4.Text = "Ответ 4";
            this.rbtnAnswer4.UseVisualStyleBackColor = true;
            // 
            // rbtnAnswer3
            // 
            this.rbtnAnswer3.AutoSize = true;
            this.rbtnAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnAnswer3.Location = new System.Drawing.Point(6, 76);
            this.rbtnAnswer3.Name = "rbtnAnswer3";
            this.rbtnAnswer3.Size = new System.Drawing.Size(88, 24);
            this.rbtnAnswer3.TabIndex = 2;
            this.rbtnAnswer3.TabStop = true;
            this.rbtnAnswer3.Tag = "3";
            this.rbtnAnswer3.Text = "Ответ 3";
            this.rbtnAnswer3.UseVisualStyleBackColor = true;
            // 
            // rbtnAnswer2
            // 
            this.rbtnAnswer2.AutoSize = true;
            this.rbtnAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnAnswer2.Location = new System.Drawing.Point(6, 46);
            this.rbtnAnswer2.Name = "rbtnAnswer2";
            this.rbtnAnswer2.Size = new System.Drawing.Size(88, 24);
            this.rbtnAnswer2.TabIndex = 3;
            this.rbtnAnswer2.TabStop = true;
            this.rbtnAnswer2.Tag = "2";
            this.rbtnAnswer2.Text = "Ответ 2";
            this.rbtnAnswer2.UseVisualStyleBackColor = true;
            // 
            // rbtnAnswer1
            // 
            this.rbtnAnswer1.AutoSize = true;
            this.rbtnAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnAnswer1.Location = new System.Drawing.Point(6, 16);
            this.rbtnAnswer1.Name = "rbtnAnswer1";
            this.rbtnAnswer1.Size = new System.Drawing.Size(88, 24);
            this.rbtnAnswer1.TabIndex = 4;
            this.rbtnAnswer1.TabStop = true;
            this.rbtnAnswer1.Tag = "1";
            this.rbtnAnswer1.Text = "Ответ 1";
            this.rbtnAnswer1.UseVisualStyleBackColor = true;
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxQuestion.Location = new System.Drawing.Point(13, 87);
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.ReadOnly = true;
            this.tbxQuestion.Size = new System.Drawing.Size(346, 79);
            this.tbxQuestion.TabIndex = 5;
            this.tbxQuestion.Text = "Вопрос";
            // 
            // cbxTheme
            // 
            this.cbxTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxTheme.FormattingEnabled = true;
            this.cbxTheme.Location = new System.Drawing.Point(12, 12);
            this.cbxTheme.Name = "cbxTheme";
            this.cbxTheme.Size = new System.Drawing.Size(346, 28);
            this.cbxTheme.TabIndex = 6;
            this.cbxTheme.SelectedValueChanged += new System.EventHandler(this.ChangeTheme);
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSend.Location = new System.Drawing.Point(202, 316);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(157, 42);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Ответить";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.Reply);
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.rbtnAnswer1);
            this.gbx.Controls.Add(this.rbtnAnswer2);
            this.gbx.Controls.Add(this.rbtnAnswer3);
            this.gbx.Controls.Add(this.rbtnAnswer4);
            this.gbx.Location = new System.Drawing.Point(13, 172);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(345, 138);
            this.gbx.TabIndex = 8;
            this.gbx.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 366);
            this.Controls.Add(this.gbx);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbxQuestion);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.cbxTheme);
            this.Name = "Form1";
            this.Text = "Test";
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RadioButton rbtnAnswer4;
        private System.Windows.Forms.RadioButton rbtnAnswer3;
        private System.Windows.Forms.RadioButton rbtnAnswer2;
        private System.Windows.Forms.RadioButton rbtnAnswer1;
        private System.Windows.Forms.RichTextBox tbxQuestion;
        private System.Windows.Forms.ComboBox cbxTheme;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox gbx;
    }
}

