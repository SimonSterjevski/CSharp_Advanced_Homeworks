using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace AuthorStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new AuthorRepo();
            var authors = repo.GetAuthors();
            Console.WriteLine($"There are {authors.Count()} total authors");
            Console.WriteLine($"with {authors.SelectMany(a => a.Books).Count()} total books");
            Console.WriteLine("------------------------------");


            var books = authors.SelectMany(a => a.Books).ToList();
            var listByID = from book in books
                           group book by book.ID;

            Console.WriteLine("How many books are collaborations (have more than one author)?");
            var duplicateList = from book in listByID
                                where book.Count() > 1
                                select book;
            Console.WriteLine($"{duplicateList.Count()} books have more than author.");
            Console.WriteLine("------------------------------");


            Console.WriteLine("Which book has the most authors (and how many)?");
            var orderedListById = from book in listByID
                                     orderby book.Count()
                                     select book;
            var dictionaryBooks = orderedListById.ToDictionary(x => x.Key, y => y.Count());
            var bookTitle = from book in books
                            where book.ID == dictionaryBooks.LastOrDefault().Key
                            select book.Title;
            Console.WriteLine($"The book {bookTitle.FirstOrDefault()} has {dictionaryBooks.LastOrDefault().Value} authors.");
            Console.WriteLine("------------------------------");


            Console.WriteLine("What author wrote most collaborations?");
            var duplicateIDs = from book in duplicateList
                               select book.Key;
            var duplicateListIDs = duplicateIDs.ToList();
            var authorsWithCollaborations = from author in authors
                                            from book in author.Books
                                            where duplicateListIDs.Contains(book.ID)
                                            group author by author.Name;
            var orderedListByCollaborations = from author in authorsWithCollaborations
                                              orderby author.Count()
                                              select author;
            Console.WriteLine($"{orderedListByCollaborations.ToList().LastOrDefault().Key} wrote most collaborations." +
                $" ({orderedListByCollaborations.ToList().LastOrDefault().Count()})");

            //var test = from author in authors
            //           where author.ID == 1735
            //           from book in author.Books
            //           select book;
            //var proba = from book in test.ToList()
            //            where duplicateListIDs.Contains(book.ID)
            //            select book;
            //Console.WriteLine(proba.Count());

            Console.ReadLine();
        }
    }
}
