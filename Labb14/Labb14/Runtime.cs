using Labb14.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb14
{
    class Runtime
    {
        public void Start()
        {
            Book myBook = new Book
            {
                Title = "Blessing",
                Author = new Author { Name = "John", Age = 45},
                Genre = "Fantasy",
                Pages = 214,
                ReleaseDate = 1978

            };

            Magazine myMagazine = new Magazine
            {
                Title = "Hustler",
                Author = new Author { Name = "Larry Flint", Age = 80},
                Genre = "Erotic",
                Pages = 23,
                ReleaseDate = 2014
            };

            Paper myPaper = new Paper
            {
                Title = "Aqua",
                Author = new Author { Name = "Anna", Age =27},
                Genre = "Essay",
                Pages = 12,
                ReleaseDate = 2016
            };

            Author author1 = myBook.Author;


            Author author2 = myMagazine.Author;

            Author author3 = myPaper.Author;

    }
    }
}
