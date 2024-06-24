namespace task1
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
            this.create = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(179, 327);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(178, 23);
            this.create.TabIndex = 0;
            this.create.Text = "Создать документ по шаблону";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(73, 68);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(270, 235);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(53, 330);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.create);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button create;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}

