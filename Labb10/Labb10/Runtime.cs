using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb10
{
    class Runtime
    {
        public void Start()
        {
            BookManager manager = new BookManager();

            BookFilter IsNovelFilter = BookFilters.IsNovel;
            BookFilter IsShortStoryFilter = BookFilters.IsShortStory;
            BookFilter IsMysteryFilter = BookFilters.IsGenreMystery;
            BookFilter IsFantasyFilter = BookFilters.IsGenreFantasy;
            BookFilter IsRomanceFilter = BookFilters.IsGenreRomance;
            BookFilter IsCheapFilter = BookFilters.IsCheap;
            BookFilter IsExpensiveFilter = BookFilters.IsExpensive;

            Console.WriteLine("Novel Books");
            manager.PrintWhere(IsNovelFilter);

            Console.WriteLine("\nShortstory Books");
            manager.PrintWhere(IsShortStoryFilter);

            Console.WriteLine("\nMystery Books");
            manager.PrintWhere(IsMysteryFilter);

            Console.WriteLine("\nFantasy Books");
            manager.PrintWhere(IsFantasyFilter);

            Console.WriteLine("\nRomance Books");
            manager.PrintWhere(IsRomanceFilter);

            Console.WriteLine("\nCheap Books");
            manager.PrintWhere(IsCheapFilter);

            Console.WriteLine("\nExpensive Books");
            manager.PrintWhere(IsExpensiveFilter);



        }
    }
}
