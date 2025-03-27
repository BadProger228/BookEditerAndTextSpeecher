using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Learn_Project
{
    public class Book
    {
        public static int StartPage = 0;
        private const string NoFoundPage = null;
        private string name;
        private List<string> pages;
        private int maxPage = 0;
        private string PathToBook;

        public int GetMaxPage() => maxPage;
        public string GetPathToBook() => PathToBook;
        public string GetName() => name;

        public Book(string name, List<string> pages, string PathToBook) {
            this.name = name;
            this.pages = pages;
            maxPage = pages.Count;
            this.PathToBook = PathToBook;
        }
        public Book(string PathToBook) {
            this.PathToBook= PathToBook;
            name = string.Empty;
            pages = new List<string>();
            pages.Add(string.Empty);
        }

        public string GetPage(int page) {
            if (page < 0 && page >= pages.Count)
                return NoFoundPage;
            return pages[page];
        }
        

        public void SetName(string name) {
            if (name is "") 
                return;
            this.name = name;
        }
        public void RedactPage(string text, int indexOfPage) {
            if (text is "" || indexOfPage < 0 && indexOfPage >= pages.Count)
                return;
            pages[indexOfPage] = text;
        }
        public void SetNewPage(int page)
        {
            pages.Insert(page, "");
            maxPage++;
        }

        public void DeletePage(int indexOfPage) { 
            pages.RemoveAt(indexOfPage); 
            maxPage--;
        }
        

    }
}
