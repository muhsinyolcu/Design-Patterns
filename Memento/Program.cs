using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book
            {
                Isbn = "123456",
                Title = "The Witcher",
                Author = "Andrzej Sapkowski",
            };
            book.ShowBook();
            CareTaker history = new CareTaker();
            history.Memento = book.CreateUndo();

            book.Isbn = "54645";
            book.Title = "Harry Potter";

            book.ShowBook();

            book.RestoreFromUndo(history.Memento);
            book.ShowBook();
        }
    }
}
