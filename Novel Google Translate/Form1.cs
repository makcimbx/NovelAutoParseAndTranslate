using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Novel_Google_Translate
{
    public partial class Form1 : Form
    {
        private List<string> parsedPages;

        private Form2 translateForm;

        public Form1()
        {
            InitializeComponent();

            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            SaveButtonButton.Enabled = false;
            TakeInTranslateButton.Enabled = false;
            comboBox1.SelectedIndex = 0;
        }

        private async void StartParse(object sender, EventArgs e)
        {
            StartParseButton.Enabled = false;
            SaveButtonButton.Enabled = false;
            TakeInTranslateButton.Enabled = false;
            GoToTranslatorButton.Enabled = false;
            string defaultStartParseText = StartParseButton.Text;
            StartParseButton.Text = "Ожидайте";

            string url = urlTextBox.Text;
            string xpath = xPathTextBox.Text;
            int startNumber = (int)startPageNumber.Value;
            int endNumber = (int)endPageNumber.Value;

            if(!url.Contains("{0}"))
            {
                MessageBox.Show("Укажите в ссылке на ресурс {0} чтобы была возможность подставить номер страницы");
                return;
            }
            else if(xpath == string.Empty)
            {
                MessageBox.Show("Укажите xpath для парсинга страницы");
                return;
            }

            int pageParsedCount = 0;
            parsedPages = new List<string>();
            for (int i = startNumber; i <= endNumber; i++)
            {
                string pageUrl = string.Format(url, i);
                List<string> page = await DownloadPage(pageUrl, xpath);
                page.RemoveAll(item => item.Equals("вЂ¦"));
                for (int y = 0; y < page.Count; y++)
                {
                    page[y] = System.Net.WebUtility.HtmlDecode(page[y]);
                    page[y] = page[y].Replace("вЂ¦", "");
                    bool allGavno = true;
                    foreach (var word in page[y])
                    {
                        if (word != ' ')
                        {
                            allGavno = false;
                            break;
                        }
                    }
                    if(allGavno)
                    {
                        page.RemoveAt(y);
                        y--;
                    }
                }
                parsedPages.AddRange(page);

                pageParsedCount++;
                parsedPageCount.Text = pageParsedCount.ToString();
            }

            StartParseButton.Text = defaultStartParseText;
            StartParseButton.Enabled = true;
            SaveButtonButton.Enabled = true;
            TakeInTranslateButton.Enabled = true;
            GoToTranslatorButton.Enabled = true;
        }

        private async Task<List<string>> DownloadPage(string url, string xpath)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            HtmlAgilityPack.HtmlDocument htmlDoc = null;
            try
            {
                WebResponse myResponse = await request.GetResponseAsync();
                htmlDoc = new HtmlAgilityPack.HtmlDocument();
                htmlDoc.OptionFixNestedTags = true;
                htmlDoc.Load(myResponse.GetResponseStream());
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); return new List<string>(); }

            HtmlNodeCollection collection = htmlDoc.DocumentNode.SelectNodes(xpath);
            if (collection == null) return new List<string>();
            else
            {
                string collectedText = string.Empty;
                foreach (HtmlNode item in collection)
                {
                    if(comboBox1.SelectedIndex == 0)
                    {
                        collectedText += $"{item.InnerText}\n";
                    }
                    else if(comboBox1.SelectedIndex == 1)
                    {
                        string[] mas = item.InnerHtml.Split(new string[] { "<br>", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                        foreach(var mes in mas)
                        {
                            if (mes[0] == '<') continue;
                            collectedText += $"{mes}\n";
                        }
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        string[] mas = item.InnerHtml.Split(new string[] { "<p>" }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var mes in mas)
                        {
                            if (mes[0] == '<') continue;
                            collectedText += $"{mes}\n";
                        }
                    }
                }

                return new List<string>(collectedText.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries));
            }
        }

        private void UpdatePageCount(object sender, EventArgs e)
        {
            int startNumber = (int)startPageNumber.Value;

            if ((int)endPageNumber.Value < startNumber) endPageNumber.Value = startNumber;

            int endNumber = (int)endPageNumber.Value;
            pageToParseCount.Text = (endNumber - startNumber + 1).ToString();
        }

        private void GoToTranslator(object sender, EventArgs e)
        {
            if (translateForm == null) translateForm = new Form2();
            translateForm.Show();
        }

        private void TakeInTranslateButton_Click(object sender, EventArgs e)
        {
            translateForm = new Form2(parsedPages);
        }

        private void SaveButtonButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            string text = string.Empty;
            foreach (var element in parsedPages)
            {
                text += $"{element}\n";
            }
            System.IO.File.WriteAllText(filename, text);
        }
    }
}
