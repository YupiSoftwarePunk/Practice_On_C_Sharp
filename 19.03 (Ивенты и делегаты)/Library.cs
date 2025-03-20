using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IventsAndDelegats.Library;
using static System.Reflection.Metadata.BlobBuilder;

namespace IventsAndDelegats
{
    public class Library
    {
        private List<Book> books = new List<Book>();


        public delegate void BookIsAvailable(string message);
        public event BookIsAvailable BookAvailable;

        public void AddBook(Book book) => books.Add(book);
        public void UpdateBookStatus(string title, bool isAvailable)
        {
            var book = books.FirstOrDefault(x => x.Title == title);
            if (book != null)
            {
                book.IsAvailable = isAvailable;
                if (isAvailable)
                {
                    BookAvailable?.Invoke($"Book {title} is available");
                }
            }
        }

        public IEnumerable<Book> FindBook(string query)
        {
            return books.Where(x => x.Title.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                x.Author.Contains(query, StringComparison.OrdinalIgnoreCase));
        }

        //public string Author { get; set; }
        //public string Title { get; set; }

        //public bool IsAvailable { get; set; }
    }
}
