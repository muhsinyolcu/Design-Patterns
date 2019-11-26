using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class Memento
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public DateTime LastEdited { get; set; }
        public Memento(string isbn, string title, string author, DateTime lastEdited)
        {
            Isbn = isbn;
            Title = title;
            LastEdited = lastEdited;
        }
    }
}
