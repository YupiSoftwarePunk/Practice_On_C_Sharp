using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IventsAndDelegats
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public bool IsAvailable { get; set; }


        public Book(string Author, string Title, bool IsAvailable)
        {
            this.Author = Author;
            this.Title = Title;
            this.IsAvailable = IsAvailable;
        }
    }
}
