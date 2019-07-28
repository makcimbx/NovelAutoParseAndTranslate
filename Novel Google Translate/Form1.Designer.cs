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
            this.xPathTextBox.Location = new System.Drawing.Point(144, 40);
            this.xPathTextBox.Name = "xPathTextBox";
            this.xPathTextBox.Size = new System.Drawing.Size(269, 20);
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
            100000,
            0,
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
            100000,
            0,
            0,
            0});
            this.endPageNumber.Name = "endPageNumber";
            this.endPageNumber.Size = new System.Drawing.Size(120, 20);
            this.endPageNumber.TabIndex = 8;
            this.endPageNumber.ValueChanged += new System.EventHandler(this.UpdatePageCount);
            // 
            // StartParseButton
            // 
            this.StartParseButton.Location = new System.Drawing.Point(34, 112);
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
            this.SaveButtonButton.Location = new System.Drawing.Point(174, 112);
            this.SaveButtonButton.Name = "SaveButtonButton";
            this.SaveButtonButton.Size = new System.Drawing.Size(70, 23);
            this.SaveButtonButton.TabIndex = 14;
            this.SaveButtonButton.Text = "Сохранить";
            this.SaveButtonButton.UseVisualStyleBackColor = true;
            this.SaveButtonButton.Click += new System.EventHandler(this.SaveButtonButton_Click);
            // 
            // GoToTranslatorButton
            // 
            this.GoToTranslatorButton.Location = new System.Drawing.Point(273, 176);
            this.GoToTranslatorButton.Name = "GoToTranslatorButton";
            this.GoToTranslatorButton.Size = new System.Drawing.Size(140, 23);
            this.GoToTranslatorButton.TabIndex = 15;
            this.GoToTranslatorButton.Text = "Перейти в переводчик";
            this.GoToTranslatorButton.UseVisualStyleBackColor = true;
            this.GoToTranslatorButton.Click += new System.EventHandler(this.GoToTranslator);
            // 
            // TakeInTranslateButton
            // 
            this.TakeInTranslateButton.Location = new System.Drawing.Point(273, 112);
            this.TakeInTranslateButton.Name = "TakeInTranslateButton";
            this.TakeInTranslateButton.Size = new System.Drawing.Size(140, 23);
            this.TakeInTranslateButton.TabIndex = 16;
            this.TakeInTranslateButton.Text = "Передать в переводчик";
            this.TakeInTranslateButton.UseVisualStyleBackColor = true;
            this.TakeInTranslateButton.Click += new System.EventHandler(this.TakeInTranslateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 211);
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
    }
}

