using System.Reflection;
using System.Xml;
using System.Xml.Linq;

namespace Learn_Project
{
    public partial class Form1 : Form
    {
        readonly string folderPath;
        public Form1()
        {
            InitializeComponent();
            listBox1.ContextMenuStrip = contextMenuBooks;
            folderPath = getPerenseDirectory(Assembly.GetExecutingAssembly().Location.ToString(), 4) + "\\Books\\";
        }
        private string getPerenseDirectory(string path, int n)
        {
            if (Equals(path, null))
                return null;

            string pathFolder = path;
            for (int i = 0; i < n; i++)
                pathFolder = Path.GetDirectoryName(pathFolder);

            return pathFolder;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void RefreshListBox()
        {
            listBox1.Items.Clear();

            foreach (string filePath in Directory.GetFiles(folderPath, "*.xml"))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);
                listBox1.Items.Add(xmlDoc.DocumentElement.GetAttribute("name").ToString());
            }
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
                return;

            string pathToBook = folderPath + listBox1.SelectedItem.ToString() + ".xml";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(pathToBook);

            string nameOfBook = xmlDoc.DocumentElement.GetAttribute("name").ToString();
            List<string> pages = new List<string>();
            XmlNode xmlNode = xmlDoc.DocumentElement;
            foreach (XmlNode node in xmlNode.ChildNodes)
                pages.Add(node.InnerText);

            RedactForm redactForm = new(new Book(nameOfBook, pages, pathToBook), this);

            this.Visible = false;
            redactForm.ShowDialog();
            this.Visible = true;

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var RedactForm = new RedactForm(folderPath);

            this.Visible = false;
            RedactForm.ShowDialog();
            this.Visible = true;

            RefreshListBox();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is null)
                return;

            File.Delete(folderPath + $"\\{listBox1.SelectedItem}.xml");
            RefreshListBox();
        }
    }
}
