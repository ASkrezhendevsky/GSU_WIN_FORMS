namespace WinAnim
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
            this.binAW_BLEND = new System.Windows.Forms.Button();
            this.btnHOR_AW_SLIDE = new System.Windows.Forms.Button();
            this.btnCenter_AW_SLIDE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // binAW_BLEND
            // 
            this.binAW_BLEND.Location = new System.Drawing.Point(30, 62);
            this.binAW_BLEND.Name = "binAW_BLEND";
            this.binAW_BLEND.Size = new System.Drawing.Size(232, 23);
            this.binAW_BLEND.TabIndex = 0;
            this.binAW_BLEND.Text = "Проявление";
            this.binAW_BLEND.UseVisualStyleBackColor = true;
            // 
            // btnHOR_AW_SLIDE
            // 
            this.btnHOR_AW_SLIDE.Location = new System.Drawing.Point(30, 118);
            this.btnHOR_AW_SLIDE.Name = "btnHOR_AW_SLIDE";
            this.btnHOR_AW_SLIDE.Size = new System.Drawing.Size(232, 23);
            this.btnHOR_AW_SLIDE.TabIndex = 1;
            this.btnHOR_AW_SLIDE.Text = "Горизонтальное появление";
            this.btnHOR_AW_SLIDE.UseVisualStyleBackColor = true;
            // 
            // btnCenter_AW_SLIDE
            // 
            this.btnCenter_AW_SLIDE.Location = new System.Drawing.Point(30, 182);
            this.btnCenter_AW_SLIDE.Name = "btnCenter_AW_SLIDE";
            this.btnCenter_AW_SLIDE.Size = new System.Drawing.Size(232, 23);
            this.btnCenter_AW_SLIDE.TabIndex = 2;
            this.btnCenter_AW_SLIDE.Text = "Появление из центра";
            this.btnCenter_AW_SLIDE.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 294);
            this.Controls.Add(this.btnCenter_AW_SLIDE);
            this.Controls.Add(this.btnHOR_AW_SLIDE);
            this.Controls.Add(this.binAW_BLEND);
            this.Name = "Form1";
            this.Text = "Анимация формы";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button binAW_BLEND;
        private System.Windows.Forms.Button btnHOR_AW_SLIDE;
        private System.Windows.Forms.Button btnCenter_AW_SLIDE;
    }
}

