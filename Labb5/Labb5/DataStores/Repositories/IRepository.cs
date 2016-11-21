using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb5.Models;

namespace Labb5
{
    interface IRepository
    {
        Book[] GetBooks();

        void AddBook(Book newBook);
        void RemoveBook(Book book);
    }
}
