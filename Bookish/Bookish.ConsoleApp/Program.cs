using System;
using Bookish.DataAccess;

namespace Bookish
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            DataManager dataManager = new DataManager();
            var books = dataManager.GetAllBooks();

            foreach (var book in books)
            {
                Console.WriteLine($"{book.BookName} by {book.Author}");
            }
        }
    }
}
