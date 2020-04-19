namespace GUI_sharp_lab3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RealTextBox = new System.Windows.Forms.TextBox();
            this.ImagineTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CounterLabel = new System.Windows.Forms.Label();
            this.OutPutTextBox = new System.Windows.Forms.RichTextBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.ChoiceBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "a,b,c = x + y * i - алгебраическая форма;\r\na,b,c = r * (cosФ + i * sinФ) - тригон" +
    "ометрическая форма;\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите а или r\r\n(в зависимости от формы)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите b или угол Ф\r\n(в зависимости от формы)";
            // 
            // RealTextBox
            // 
            this.RealTextBox.Location = new System.Drawing.Point(26, 325);
            this.RealTextBox.Name = "RealTextBox";
            this.RealTextBox.Size = new System.Drawing.Size(100, 22);
            this.RealTextBox.TabIndex = 3;
            // 
            // ImagineTextBox
            // 
            this.ImagineTextBox.Location = new System.Drawing.Point(233, 325);
            this.ImagineTextBox.Name = "ImagineTextBox";
            this.ImagineTextBox.Size = new System.Drawing.Size(100, 22);
            this.ImagineTextBox.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.BlueViolet;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Location = new System.Drawing.Point(26, 380);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(122, 41);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CounterLabel
            // 
            this.CounterLabel.AutoSize = true;
            this.CounterLabel.Location = new System.Drawing.Point(202, 392);
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(177, 17);
            this.CounterLabel.TabIndex = 6;
            this.CounterLabel.Text = "Комплексное число №0/3";
            // 
            // OutPutTextBox
            // 
            this.OutPutTextBox.ForeColor = System.Drawing.Color.Black;
            this.OutPutTextBox.Location = new System.Drawing.Point(469, 46);
            this.OutPutTextBox.Name = "OutPutTextBox";
            this.OutPutTextBox.Size = new System.Drawing.Size(261, 159);
            this.OutPutTextBox.TabIndex = 7;
            this.OutPutTextBox.Text = "X = ((a + b) * c^2) / (b - a)";
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.LimeGreen;
            this.ShowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowButton.Location = new System.Drawing.Point(510, 220);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(190, 52);
            this.ShowButton.TabIndex = 8;
            this.ShowButton.Text = "Показать числа и решить пример";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Green;
            this.linkLabel1.Location = new System.Drawing.Point(106, 65);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 17);
            this.linkLabel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(65, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 51);
            this.label4.TabIndex = 10;
            this.label4.Text = "         Выберите форму записи/вывода:\r\n0 - тригонометрическая форма;\r\n1 - алгебр" +
    "аическая форма (по умолчанию);";
            // 
            // ChoiceBox
            // 
            this.ChoiceBox.Location = new System.Drawing.Point(140, 183);
            this.ChoiceBox.Name = "ChoiceBox";
            this.ChoiceBox.Size = new System.Drawing.Size(100, 22);
            this.ChoiceBox.TabIndex = 11;
            this.ChoiceBox.Text = "1";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Location = new System.Drawing.Point(544, 369);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(121, 40);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ChoiceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.OutPutTextBox);
            this.Controls.Add(this.CounterLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ImagineTextBox);
            this.Controls.Add(this.RealTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RealTextBox;
        private System.Windows.Forms.TextBox ImagineTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label CounterLabel;
        private System.Windows.Forms.RichTextBox OutPutTextBox;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ChoiceBox;
        private System.Windows.Forms.Button ExitButton;
    }
}

