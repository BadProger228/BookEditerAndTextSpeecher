using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Speech.Synthesis;

namespace Learn_Project
{
    public partial class RedactForm : Form
    {
        bool statusAdd = false;
        Book book = null;
        const int MaxPageSize = 2200;
        int page = 1;
        Form1 mainForm;
        public RedactForm(Book book, Form1 mainForm)
        {
            InitializeComponent();
            PageDown.Enabled = false;
            NameOfBook.Text = book.GetName();
            TextOfBook.Text = book.GetPage(Book.StartPage);
            this.book = book;
            TextOfBook.ContextMenuStrip = contextMenuStrip1;
            this.mainForm = mainForm;
        }
        public RedactForm(string pathToBook)
        {
            InitializeComponent();
            PageUp.Enabled = false;
            PageDown.Enabled = false;
            book = new(pathToBook);
            statusAdd = true;
            TextOfBook.ContextMenuStrip = contextMenuStrip1;
        }

        private void RedactForm_Load(object sender, EventArgs e)
        {

        }

        private void NameOfBook_TextChanged(object sender, EventArgs e)
        {

        }

        private void PageUp_Click(object sender, EventArgs e)
        {
            book.RedactPage(TextOfBook.Text.ToString(), page - 1);
            PageDown.Enabled = true;
            page++;
            PageNumber.Text = page.ToString();
            if (page == book.GetMaxPage())
                PageUp.Enabled = false;
            else
                PageUp.Enabled = true;

            //TextOfBook.Text = book.GetPage(page - 1);
        }

        private void PageDown_Click(object sender, EventArgs e)
        {
            book.RedactPage(TextOfBook.Text.ToString(), page - 1);
            PageUp.Enabled = true;
            page--;
            PageNumber.Text = page.ToString();
            if (page == 1)
                PageDown.Enabled = false;
            else
                PageDown.Enabled = true;

            //TextOfBook.Text = book.GetPage(page - 1);
        }

        private void TextOfBook_TextChanged(object sender, EventArgs e)
        {
            if (TextOfBook.Text.Length > MaxPageSize)
            {
                MaxCharsError.Visible = true;
                MaxCharsError.Text = $"You entered to many chars for this page. Max size is {MaxPageSize} chars, but now is {TextOfBook.Text.Length}";
                return;
            }
            MaxCharsError.Visible = false;
        }

        private void SaveRedactBook_Click(object sender, EventArgs e)
        {
            book.RedactPage(TextOfBook.Text.ToString(), page - 1);

            XmlDocument xmlDoc = new XmlDocument();
            XmlElement bookElement = xmlDoc.CreateElement("Book");

            bookElement.SetAttribute("name", NameOfBook.Text);

            for (int i = 1; i <= book.GetMaxPage(); i++)
            {
                XmlElement pageElement = xmlDoc.CreateElement($"Page{i}");
                pageElement.InnerText = book.GetPage(i - 1);
                bookElement.AppendChild(pageElement);
            }

            xmlDoc.AppendChild(bookElement);

            if (statusAdd == true)
            {
                xmlDoc.Save(book.GetPathToBook() + "\\" + NameOfBook.Text + ".xml");
            }
            else
            {
                File.Move(book.GetPathToBook(), Path.GetDirectoryName(book.GetPathToBook()) + "\\" + NameOfBook.Text + ".xml");
                xmlDoc.Save(Path.GetDirectoryName(book.GetPathToBook()) + "\\" + NameOfBook.Text + ".xml");
            }
            
            if(mainForm != null) 
                mainForm.RefreshListBox();
            
            Close();
        }

        private void PageNumber_TextChanged(object sender, EventArgs e)
        {


            if (int.TryParse(PageNumber.Text, out page))
            {


                if (page == 1)
                {
                    PageUp.Enabled = true;
                    PageDown.Enabled = false;
                }
                else if (page == book.GetMaxPage())
                {
                    PageUp.Enabled = false;
                    PageDown.Enabled = true;
                }
                else
                {
                    PageUp.Enabled = true;
                    PageDown.Enabled = true;
                }

                if (page < 1 && page >= book.GetMaxPage())
                    return;

                TextOfBook.Text = book.GetPage(page - 1);
            }
        }

        private void VoiceButton_Click(object sender, EventArgs e)
        {

        }

        private void SavePage_Click(object sender, EventArgs e) => book.RedactPage(TextOfBook.Text.ToString(), int.Parse(PageNumber.Text) - 1);


        private void AddAfter_Click(object sender, EventArgs e)
        {
            book.RedactPage(TextOfBook.Text.ToString(), page - 1);
            book.SetNewPage(page);
            page++;
            PageNumber.Text = page.ToString();
        }

        private void AddBefore_Click(object sender, EventArgs e)
        {
            book.RedactPage(TextOfBook.Text.ToString(), page - 1);
            book.SetNewPage(page - 1);
            PageNumber_TextChanged(sender, e);
        }

        private void voiceSelectedTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TextOfBook.SelectedText is null)
                return;

            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                if (synthesizer.GetInstalledVoices().Count > 0)
                {
                    synthesizer.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.Teen);
                }

                string textToSpeak = TextOfBook.SelectedText;
                synthesizer.Speak(textToSpeak);
            }
        }

        private void deletePage_Click(object sender, EventArgs e)
        {
            
            book.DeletePage(int.Parse(PageNumber.Text) - 1);

            if (book.GetMaxPage() == int.Parse(PageNumber.Text) - 1)
            {
                TextOfBook.Text = book.GetPage(int.Parse(PageNumber.Text) - 2);
                PageNumber.Text = (int.Parse(PageNumber.Text) - 2).ToString();
            }
            else
                TextOfBook.Text = book.GetPage(int.Parse(PageNumber.Text) - 1);

        }
    }
}
