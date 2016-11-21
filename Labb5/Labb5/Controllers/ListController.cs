using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb5.Models;

namespace Labb5.Controllers
{
    class ListController
    {
        private IRepository repository = new ListRepository();


        public void CreateBook()
        {
            var newBook = UI.CreateBook();
            repository.AddBook(newBook);
        }

        public void RemoveBook()
        {
            var books = repository.GetBooks();
            var index = UI.SelectBook(repository.GetBooks()) - 1;
            repository.RemoveBook(books[index]);
        }

        public void EditBook()
        {
            var books = repository.GetBooks();
            UI.PrintBookList(repository.GetBooks());
            int index = UI.SelectBook(repository.GetBooks()) - 1;

            UI.EditBook(books[index]);
        }

        public void PrintBookList()
        {
            Console.Clear();
            UI.PrintBookList(repository.GetBooks());
            Console.ReadKey(true);
        }
    }
}
