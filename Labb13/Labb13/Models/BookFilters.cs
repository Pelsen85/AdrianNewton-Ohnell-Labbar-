using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13.Models
{
    public delegate bool BookFilter(Book book);
    class BookFilters
    {
        public static bool IsLong(Book book)
        {
            return book.Pages > 200;
        }

        public static bool IsShort(Book book)
        {
            return book.Pages < 200;
        }
    }
}
