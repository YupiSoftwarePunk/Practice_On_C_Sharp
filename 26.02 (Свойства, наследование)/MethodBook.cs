using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class MethodBook
    {
        private string _title;
        private string _author;
        private int _year;
        private int _pages;
        private string _publisher;

        public void SetTitle(string title) => _title = title;
        public string GetTitle() => _title;

        public string GetPublisher() => _publisher;
        public string Info() => $"Название: {_title}, автор: {_author}, год издания: {_year}, кол-во страниц: {_pages}, издатель: {_publisher}";

        public MethodBook(string title, string author, int year, int pages, string publisher)
        {
            _title = title;
            _author = author;
            _year = year;
            _pages = pages;
            _publisher = publisher;
        }
    }
}
