namespace Novel_Google_Translate
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
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xPathTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startPageNumber = new System.Windows.Forms.NumericUpDown();
            this.endPageNumber = new System.Windows.Forms.NumericUpDown();
            this.StartParseButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pageToParseCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.parsedPageCount = new System.Windows.Forms.Label();
            this.SaveButtonButton = new System.Windows.Forms.Button();
            this.GoToTranslatorButton = new System.Windows.Forms.Button();
            this.TakeInTranslateButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.startPageNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPageNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(144, 6);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(269, 20);
            this.urlTextBox.TabIndex = 0;
            this.urlTextBox.Text = "https://boxnovel.com/novel/taming-master/chapter-{0}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сайт с произведением:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "XPath:";
            // 
            // xPathTextBox
            // 
            this.xPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xPathTextBox.Location = new System.Drawing.Point(144, 40);
            this.xPathTextBox.Name = "xPathTextBox";
            this.xPathTextBox.Size = new System.Drawing.Size(269, 23);
            this.xPathTextBox.TabIndex = 3;
            this.xPathTextBox.Text = "//*[@class=\'text-left\']";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Парсить от главы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "до";
            // 
            // startPageNumber
            // 
            this.startPageNumber.Location = new System.Drawing.Point(144, 76);
            this.startPageNumber.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.startPageNumber.Name = "startPageNumber";
            this.startPageNumber.Size = new System.Drawing.Size(120, 20);
            this.startPageNumber.TabIndex = 7;
            this.startPageNumber.ValueChanged += new System.EventHandler(this.UpdatePageCount);
            // 
            // endPageNumber
            // 
            this.endPageNumber.Location = new System.Drawing.Point(293, 76);
            this.endPageNumber.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.endPageNumber.Name = "endPageNumber";
            this.endPageNumber.Size = new System.Drawing.Size(120, 20);
            this.endPageNumber.TabIndex = 8;
            this.endPageNumber.ValueChanged += new System.EventHandler(this.UpdatePageCount);
            // 
            // StartParseButton
            // 
            this.StartParseButton.Location = new System.Drawing.Point(15, 112);
            this.StartParseButton.Name = "StartParseButton";
            this.StartParseButton.Size = new System.Drawing.Size(100, 23);
            this.StartParseButton.TabIndex = 9;
            this.StartParseButton.Text = "Начать парсить";
            this.StartParseButton.UseVisualStyleBackColor = true;
            this.StartParseButton.Click += new System.EventHandler(this.StartParse);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Всего глав для парсинга:";
            // 
            // pageToParseCount
            // 
            this.pageToParseCount.AutoSize = true;
            this.pageToParseCount.Location = new System.Drawing.Point(155, 150);
            this.pageToParseCount.Name = "pageToParseCount";
            this.pageToParseCount.Size = new System.Drawing.Size(13, 13);
            this.pageToParseCount.TabIndex = 11;
            this.pageToParseCount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Глав уже спарсили:";
            // 
            // parsedPageCount
            // 
            this.parsedPageCount.AutoSize = true;
            this.parsedPageCount.Location = new System.Drawing.Point(155, 173);
            this.parsedPageCount.Name = "parsedPageCount";
            this.parsedPageCount.Size = new System.Drawing.Size(13, 13);
            this.parsedPageCount.TabIndex = 13;
            this.parsedPageCount.Text = "0";
            // 
            // SaveButtonButton
            // 
            this.SaveButtonButton.Location = new System.Drawing.Point(252, 112);
            this.SaveButtonButton.Name = "SaveButtonButton";
            this.SaveButtonButton.Size = new System.Drawing.Size(85, 23);
            this.SaveButtonButton.TabIndex = 14;
            this.SaveButtonButton.Text = "Сохранить";
            this.SaveButtonButton.UseVisualStyleBackColor = true;
            this.SaveButtonButton.Click += new System.EventHandler(this.SaveButtonButton_Click);
            // 
            // GoToTranslatorButton
            // 
            this.GoToTranslatorButton.Location = new System.Drawing.Point(197, 176);
            this.GoToTranslatorButton.Name = "GoToTranslatorButton";
            this.GoToTranslatorButton.Size = new System.Drawing.Size(140, 23);
            this.GoToTranslatorButton.TabIndex = 15;
            this.GoToTranslatorButton.Text = "Перейти в переводчик";
            this.GoToTranslatorButton.UseVisualStyleBackColor = true;
            this.GoToTranslatorButton.Click += new System.EventHandler(this.GoToTranslator);
            // 
            // TakeInTranslateButton
            // 
            this.TakeInTranslateButton.Location = new System.Drawing.Point(197, 140);
            this.TakeInTranslateButton.Name = "TakeInTranslateButton";
            this.TakeInTranslateButton.Size = new System.Drawing.Size(140, 23);
            this.TakeInTranslateButton.TabIndex = 16;
            this.TakeInTranslateButton.Text = "Передать в переводчик";
            this.TakeInTranslateButton.UseVisualStyleBackColor = true;
            this.TakeInTranslateButton.Click += new System.EventHandler(this.TakeInTranslateButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(562, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "//*[@class=\'Readarea ReadAjax_content\']";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "m.wuxiaworld.co xpath";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(442, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "boxnovel.com xpath";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(562, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "//*[@class=\'text-left\']";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Парсить по \\n",
            "Парсить по <br>",
            "Парсить по <p>"});
            this.comboBox1.Location = new System.Drawing.Point(121, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(562, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(170, 20);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = "//*[@class=\'entry-content\']";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(442, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "novelhall.com xpath";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "bestlightnovel.com xpath";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(562, 114);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(170, 20);
            this.textBox4.TabIndex = 25;
            this.textBox4.Text = "//*[@class=\'vung_doc\']";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 211);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TakeInTranslateButton);
            this.Controls.Add(this.GoToTranslatorButton);
            this.Controls.Add(this.SaveButtonButton);
            this.Controls.Add(this.parsedPageCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pageToParseCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StartParseButton);
            this.Controls.Add(this.endPageNumber);
            this.Controls.Add(this.startPageNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xPathTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlTextBox);
            this.Name = "Form1";
            this.Text = "Novel Auto Parse";
            ((System.ComponentModel.ISupportInitialize)(this.startPageNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPageNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xPathTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown startPageNumber;
        private System.Windows.Forms.NumericUpDown endPageNumber;
        private System.Windows.Forms.Button StartParseButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label pageToParseCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label parsedPageCount;
        private System.Windows.Forms.Button SaveButtonButton;
        private System.Windows.Forms.Button GoToTranslatorButton;
        private System.Windows.Forms.Button TakeInTranslateButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
    }
}

