using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb10
{
    class BookFilters
    {
        public static bool IsNovel(Book book)
        {
            return book.Genre == "Novel";
        }

        public static bool IsShortStory(Book book)
        {
            return book.Genre == "Shortstory";
        }

        public static bool IsGenreMystery(Book book)
        {
            return book.Genre == "Mystery";
        }

        public static bool IsGenreFantasy(Book book)
        {
            return book.Genre == "Fantasy";
        }

        public static bool IsGenreRomance(Book book)
        {
            return book.Genre == "Romnace";
        }

        public static bool IsCheap(Book book)
        {
            return book.Price < 300;
        }

        public static bool IsExpensive(Book book)
        {
            return book.Price > 300;
        }
    }
}
