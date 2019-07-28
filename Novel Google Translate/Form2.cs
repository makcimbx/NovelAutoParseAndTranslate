using GoogleTranslateFreeApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novel_Google_Translate
{
    public partial class Form2 : Form
    {
        private GoogleTranslator translateInstance;

        private int maxTranslateLength;
        private List<string> stringsToTranslate;

        private List<string[]> translatedTextArray;

        public Form2()
        {
            InitializeComponent();

            translateInstance = new GoogleTranslator();
            maxTranslateLength = (int)numericUpDown1.Value;

            StartTranslateButton.Enabled = false;
            SaveTranslateButton.Enabled = false;

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        public Form2(List<string> stringsToTranslate)
        {
            InitializeComponent();

            this.stringsToTranslate = stringsToTranslate;
            translateInstance = new GoogleTranslator();
            maxTranslateLength = (int)numericUpDown1.Value;
            textLoadedCount.Text = stringsToTranslate.Count.ToString();

            int count = 0;
            stringsToTranslate.ForEach(item => count += item.Length);
            textFragmentsToTranslateCount.Text = (count / maxTranslateLength + 1).ToString();

            SaveTranslateButton.Enabled = false;

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void LoadFromFile(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            string[] strings = fileText.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            stringsToTranslate = new List<string>(strings);

            SaveTranslateButton.Enabled = false;
        }

        private void maxFragmentLenghtUpdate(object sender, EventArgs e)
        {
            maxTranslateLength = (int)numericUpDown1.Value;

            int count = 0;
            stringsToTranslate.ForEach(item => count += item.Length);
            textFragmentsToTranslateCount.Text = (count / maxTranslateLength + 1).ToString();
        }

        private async void StartTranslate(object sender, EventArgs e)
        {
            LoadFromFileButton.Enabled = false;
            StartTranslateButton.Enabled = false;
            SaveTranslateButton.Enabled = false;

            if(proxyTextBox.Text != "")
            {
                var proxy = new WebProxy(proxyTextBox.Text);
                translateInstance.Proxy = proxy;
            }

            List<string> textToTranslate = new List<string>();
            string textPart = string.Empty;
            for (int i = 0; i < stringsToTranslate.Count; i++)
            {
                string testText = textPart + stringsToTranslate[i];
                if (testText.Length >= maxTranslateLength)
                {
                    textToTranslate.Add(textPart);
                    textPart = string.Empty;
                }

                textPart += $"{stringsToTranslate[i]}\n";
            }
            if (textPart != string.Empty) textToTranslate.Add(textPart);

            int translatedFragments = 0;
            translatedTextArray = new List<string[]>();
            foreach (var item in textToTranslate)
            {
                string[] translatedText = null;
                try
                {
                    translatedText = await TranslateText(item, Language.English, Language.Russian);
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                    LoadFromFileButton.Enabled = true;
                    StartTranslateButton.Enabled = true;
                    return;
                }
                translatedTextArray.Add(translatedText);

                translatedFragments++;
                translatedFragmentsCount.Text = translatedFragments.ToString();
            }

            LoadFromFileButton.Enabled = true;
            StartTranslateButton.Enabled = true;
            SaveTranslateButton.Enabled = true;
        }

        private void SaveTranslatedText(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            string text = string.Empty;
            foreach (var massive in translatedTextArray)
            {
                foreach (var element in massive)
                {
                    text += element;
                }
            }
            System.IO.File.WriteAllText(filename, text);
        }

        private async Task<string[]> TranslateText(string text, Language from, Language to)
        {
            TranslationResult result = await translateInstance.TranslateLiteAsync(text, from, to);

            return result.FragmentedTranslation;
            //string resultMerged = result.MergedTranslation;
            //string transcription = result.TranslatedTextTranscription;
        }
    }
}
