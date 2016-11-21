using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb5.Models;


namespace Labb5
{
    class ListRepository : IRepository
    {
        public Book[] GetBooks()
        {
            return MyLists.Books.ToArray();
        }

        public void AddBook(Book newBook)
        {
            MyLists.Books.Add(newBook);
        }

        public void RemoveBook(Book book)
        {
            MyLists.Books.Remove(book);
        }
    }
}
