using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb5.Models;

namespace Labb5
{
    class MyLists
    {
        private static List<Book> books;

        public static List<Book> Books
        {
          get
            {
                if (books == null)
                    books = new List<Book>();

                return books;
            }
        }
    }
}
