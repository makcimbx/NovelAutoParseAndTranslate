namespace Novel_Google_Translate
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textFragmentsToTranslateCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textLoadedCount = new System.Windows.Forms.Label();
            this.LoadFromFileButton = new System.Windows.Forms.Button();
            this.translatedFragmentsCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StartTranslateButton = new System.Windows.Forms.Button();
            this.SaveTranslateButton = new System.Windows.Forms.Button();
            this.proxyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фрагментов для перевода: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(27, 25);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            4900,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.maxFragmentLenghtUpdate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Число символов в одном фрагменте для перевода";
            // 
            // textFragmentsToTranslateCount
            // 
            this.textFragmentsToTranslateCount.AutoSize = true;
            this.textFragmentsToTranslateCount.Location = new System.Drawing.Point(204, 107);
            this.textFragmentsToTranslateCount.Name = "textFragmentsToTranslateCount";
            this.textFragmentsToTranslateCount.Size = new System.Drawing.Size(13, 13);
            this.textFragmentsToTranslateCount.TabIndex = 3;
            this.textFragmentsToTranslateCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Загружено абзацев: ";
            // 
            // textLoadedCount
            // 
            this.textLoadedCount.AutoSize = true;
            this.textLoadedCount.Location = new System.Drawing.Point(204, 85);
            this.textLoadedCount.Name = "textLoadedCount";
            this.textLoadedCount.Size = new System.Drawing.Size(13, 13);
            this.textLoadedCount.TabIndex = 5;
            this.textLoadedCount.Text = "0";
            // 
            // LoadFromFileButton
            // 
            this.LoadFromFileButton.Location = new System.Drawing.Point(27, 51);
            this.LoadFromFileButton.Name = "LoadFromFileButton";
            this.LoadFromFileButton.Size = new System.Drawing.Size(120, 23);
            this.LoadFromFileButton.TabIndex = 6;
            this.LoadFromFileButton.Text = "Загрузить из файла";
            this.LoadFromFileButton.UseVisualStyleBackColor = true;
            this.LoadFromFileButton.Click += new System.EventHandler(this.LoadFromFile);
            // 
            // translatedFragmentsCount
            // 
            this.translatedFragmentsCount.AutoSize = true;
            this.translatedFragmentsCount.Location = new System.Drawing.Point(204, 169);
            this.translatedFragmentsCount.Name = "translatedFragmentsCount";
            this.translatedFragmentsCount.Size = new System.Drawing.Size(13, 13);
            this.translatedFragmentsCount.TabIndex = 17;
            this.translatedFragmentsCount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Фрагментов переведено:";
            // 
            // StartTranslateButton
            // 
            this.StartTranslateButton.Location = new System.Drawing.Point(27, 132);
            this.StartTranslateButton.Name = "StartTranslateButton";
            this.StartTranslateButton.Size = new System.Drawing.Size(120, 23);
            this.StartTranslateButton.TabIndex = 18;
            this.StartTranslateButton.Text = "Начать перевод";
            this.StartTranslateButton.UseVisualStyleBackColor = true;
            this.StartTranslateButton.Click += new System.EventHandler(this.StartTranslate);
            // 
            // SaveTranslateButton
            // 
            this.SaveTranslateButton.Location = new System.Drawing.Point(153, 132);
            this.SaveTranslateButton.Name = "SaveTranslateButton";
            this.SaveTranslateButton.Size = new System.Drawing.Size(121, 23);
            this.SaveTranslateButton.TabIndex = 19;
            this.SaveTranslateButton.Text = "Сохранить перевод";
            this.SaveTranslateButton.UseVisualStyleBackColor = true;
            this.SaveTranslateButton.Click += new System.EventHandler(this.SaveTranslatedText);
            // 
            // proxyTextBox
            // 
            this.proxyTextBox.Location = new System.Drawing.Point(162, 51);
            this.proxyTextBox.Name = "proxyTextBox";
            this.proxyTextBox.Size = new System.Drawing.Size(100, 20);
            this.proxyTextBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Прокси";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 195);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.proxyTextBox);
            this.Controls.Add(this.SaveTranslateButton);
            this.Controls.Add(this.StartTranslateButton);
            this.Controls.Add(this.translatedFragmentsCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LoadFromFileButton);
            this.Controls.Add(this.textLoadedCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textFragmentsToTranslateCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Novel Google Translate";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textFragmentsToTranslateCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label textLoadedCount;
        private System.Windows.Forms.Button LoadFromFileButton;
        private System.Windows.Forms.Label translatedFragmentsCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button StartTranslateButton;
        private System.Windows.Forms.Button SaveTranslateButton;
        private System.Windows.Forms.TextBox proxyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}