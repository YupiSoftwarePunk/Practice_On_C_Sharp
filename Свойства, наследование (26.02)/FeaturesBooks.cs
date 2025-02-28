using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class FeaturesBooks
    {
        private string _title;
        private string _author;
        private int _year;
        private int _pages;

        public string Title  // метод (свойство)
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author => _author;   // можно сделать геттер так
        //{
        //    get { return _author; }  //  и можно сделать геттер так
        //}

        public string Publisher { get; }   // автометод (автосвойство)


        //  вычисляемое свойство
        public string Info => $"Название: {Title}, автор: {_author}, год издания: {_year}, кол-во страниц: {_pages}, издатель: {Publisher}";

        // конструктор
        public FeaturesBooks(string title, string author, int year, int pages, string publisher)
        {
            Title = title;
            _author = author;
            _year = year;
            _pages = pages;
            Title = title;
            Publisher = publisher;
        }
    }
}
