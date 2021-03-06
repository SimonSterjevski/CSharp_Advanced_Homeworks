﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Xml.XPath;

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

            // old
            //var orderedListById = from book in listByID
            //                      orderby book.Count()
            //                      select book;
            //var dictionaryBooks = orderedListById.ToDictionary(x => x.Key, y => y.Count());
            //var bookTitle = from book in books
            //                where book.ID == dictionaryBooks.LastOrDefault().Key
            //                select book.Title;
            //Console.WriteLine($"The book {bookTitle.FirstOrDefault()} has {dictionaryBooks.LastOrDefault().Value} authors.");
           
            // new
            var proba1 = from pair in listByID
                         orderby pair.Count() descending
                         join book in books on pair.Key equals book.ID
                         select (book.Title, pair.Count());

            Console.WriteLine($"The book {proba1.ToList().FirstOrDefault().Item1} has {proba1.ToList().FirstOrDefault().Item2} authors.");
            Console.WriteLine("------------------------------");



            Console.WriteLine("What author wrote most collaborations?");

            //old
            //var duplicateIDs = from book in duplicateList
            //                   select book.Key;
            // var duplicateListIDs = duplicateIDs.ToList();
            // var authorsWithCollaborations = from author in authors
            //                                 from book in author.Books
            //                                 where duplicateListIDs.Contains(book.ID)
            //                                 group author by author.Name;
            // var orderedListByCollaborations = from author in authorsWithCollaborations
            //                                   orderby author.Count()
            //                                   select author;
            // Console.WriteLine($"{orderedListByCollaborations.LastOrDefault().Key} wrote most collaborations." +
            //     $" ({orderedListByCollaborations.LastOrDefault().Count()})");

            // new
            var proba2 = from author in (from author in authors
                                         from book in author.Books
                                         join pair in duplicateList on book.ID equals pair.Key
                                         group author by author.Name)
                         orderby author.Count()
                         select author;

            Console.WriteLine($"{proba2.LastOrDefault().Key} wrote most collaborations." +
            $" ({proba2.LastOrDefault().Count()})");
            Console.WriteLine("------------------------------");


            Console.WriteLine("In what year were published most books in a specific genre ? Which genre ?");

            var booksByGenre = from pair in (from Genre genre in Enum.GetValues(typeof(Genre))
                                             select new
                                             {
                                                 Genre = genre,
                                                 BooksNum = (from book in books
                                                             where book.Genres.Contains(genre)
                                                             group book by book.Year).OrderBy(num => num.Count()).LastOrDefault()
                                             })
                               orderby pair.BooksNum.Count()
                               select pair;

            Console.WriteLine($"In year {booksByGenre.LastOrDefault().BooksNum.Key}, " +
            $"{booksByGenre.LastOrDefault().BooksNum.Count()} books " +
            $"(Genre:{booksByGenre.LastOrDefault().Genre}) were published");
            Console.WriteLine("------------------------------");


            Console.WriteLine("Which author has most books nominated for an award?");

            //old
            //var nominatedBooks = from author in authors
            //                     from book in author.Books
            //                     where book.Nominations > 0
            //                     group book by author.ID;
            //var nominatedBooksDictionary = nominatedBooks.ToDictionary(x => x.Key, y => y.Count());
            //var orderedNominationDictionary = from author in nominatedBooksDictionary
            //                                  orderby author.Value
            //                                  select author;
            //var author1Name = from author in authors
            //                  where author.ID == orderedNominationDictionary.LastOrDefault().Key
            //                  select author.Name;
            //Console.WriteLine($"The author with most nominated books ({orderedNominationDictionary.LastOrDefault().Value})" +
            //    $" is {author1Name.FirstOrDefault()}.");

            // new
            var proba4 = from pair in (from author in authors
                                       from book in author.Books
                                       where book.Nominations > 0
                                       join auth in authors on author.ID equals auth.ID
                                       group author by author.Name)
                          orderby pair.Count() descending
                          select pair;
           
            Console.WriteLine($"The author with most nominated books ({proba4.FirstOrDefault().Count()})" +
            $" is {proba4.FirstOrDefault().Key}.");
            Console.WriteLine("------------------------------");


            Console.WriteLine("Which auhtor has most books that won an award ?");

            //old
            //var winningBooks = from author in authors
            //                   from book in author.Books
            //                   where book.Wins > 0
            //                   group book by author.ID;
            //var winningBooksDictionary = winningBooks.ToDictionary(x => x.Key, y => y.Count());
            //var orderedWinningDictionary = from author in winningBooksDictionary
            //                               orderby author.Value descending
            //                               select author;
            //var orderedToList = from auth in orderedWinningDictionary
            //                    select auth.Value;
            //var bestScore = orderedToList.First();
            //var winners = from num in orderedToList
            //              where num == bestScore
            //              select num;
            //List<string> authorWinners = new List<string>();
            //foreach (Author author in authors)
            //{
            //    for (int i = 0; i < winners.ToList().Count; i++)
            //    {
            //        if (author.ID == orderedWinningDictionary.Skip(i).FirstOrDefault().Key)
            //        {
            //            authorWinners.Add(author.Name);
            //        }
            //    }
               
            //}
            //Console.WriteLine($"The authors with most winner books ({orderedWinningDictionary.FirstOrDefault().Value}) are:");
            //authorWinners.ForEach(Console.WriteLine);

            //new
            var proba5 = from pair in (from author in authors
                                       from book in author.Books
                                       where book.Wins > 0
                                       join auth in authors on author.ID equals auth.ID
                                       group author by author.Name)
                         orderby pair.Count() descending
                         select (pair.Key, pair.Count());
            var results = from pair in proba5
                          where pair.Item2 == proba5.First().Item2
                          select pair.Item1;

            Console.WriteLine($"The authors with most winner books ({proba5.First().Item2}) are:");
            results.ToList().ForEach(Console.WriteLine);
            Console.WriteLine("------------------------------");


            Console.WriteLine("Which author has most books nominated for an award, without winning a single award ?");

            // old
            //var bookNominationsWithoutWin = from author in authors
            //                                where author.Wins == 0
            //                                from book in author.Books
            //                                where book.Nominations > 0
            //                                group book by author.ID;
            //var bookNominationsWithoutWinDictionary = bookNominationsWithoutWin.ToDictionary(x => x.Key, y => y.Count());
            //var orderedbookNominationsWithoutWin = from author in bookNominationsWithoutWinDictionary
            //                                       orderby author.Value
            //                                       select author;
            //var author3Name = from author in authors
            //                  where author.ID == orderedbookNominationsWithoutWin.LastOrDefault().Key
            //                  select author.Name;
            //Console.WriteLine($"The author with most nominated books ({orderedbookNominationsWithoutWin.LastOrDefault().Value}) " +
            //    $"without a single award is {author3Name.FirstOrDefault()}.");

            // new
            var proba6 = from pair in (from author in authors
                                       where author.Wins == 0
                                       from book in author.Books
                                       where book.Nominations > 0
                                       group book by author.Name)
                         orderby pair.Count() descending
                         select (pair.Key, pair.Count());

            Console.WriteLine($"The author with most nominated books ({proba6.FirstOrDefault().Item2}) " +
            $"without a single award is {proba6.FirstOrDefault().Item1}.");
            Console.WriteLine("------------------------------");


            Console.WriteLine("Make a histogram of books published per decade per genre");
           
            var histogram = from Genre genre in Enum.GetValues(typeof(Genre))
                            select new
                            {
                                Genre = genre,
                                BooksNum = from pair in (from pair1 in (from book in books
                                                                        where book.Genres.Contains(genre)
                                                                        group book by book.Year / 10 * 10)
                                                         select new
                                                         {
                                                             Decade = pair1.Key,
                                                             BooksNumber = pair1.Count()
                                                         })
                                           orderby pair.Decade
                                           select pair
                            };

            var histogramDictionary = histogram.ToDictionary(x => x.Genre, y => y.BooksNum.ToDictionary(z => z.Decade, w => w.BooksNumber));
            var decadesFiltered = histogramDictionary.SelectMany(decad => decad.Value.Select(d => d.Key)).Distinct().OrderBy(decade => decade);
            foreach (int decade in decadesFiltered)
            {
                Console.WriteLine($"{decade} - {decade + 9}");
                foreach (var pair in histogramDictionary)
                {
                    if (pair.Value.ContainsKey(decade))
                    {
                        Console.Write($"{pair.Key}:");
                        foreach (var pair1 in pair.Value)
                        {
                            if (pair1.Key == decade)
                            {
                                Console.WriteLine(pair1.Value);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{pair.Key}:0");
                    }

                }
            }
            Console.WriteLine("------------------------------");


            Console.WriteLine("Which author has a highest percentage of nominated books?");
            Console.WriteLine("Tiebreakers: 1)More total books 2)More wins");

            var authorBooks = from pair in (from author in authors
                                            select new
                                            {
                                                AuthorId = author.ID,
                                                AuthorName = author.Name,
                                                AuthorBooks = author.Books.Count,
                                                AuthorNominations = author.Books.Count(book => book.Nominations > 0),
                                                AuthorWins = author.Wins
                                             })
                               orderby pair.AuthorNominations * 100 / pair.AuthorBooks, pair.AuthorBooks, pair.AuthorWins
                               select pair;

            Console.WriteLine($"{authorBooks.LastOrDefault().AuthorName} has the highest percentage of nominated books. " +
            $"({authorBooks.LastOrDefault().AuthorNominations * 100 / authorBooks.LastOrDefault().AuthorBooks}%)");
            Console.WriteLine($"Number of books: {authorBooks.LastOrDefault().AuthorBooks}, number of nominated books: " +
            $"{authorBooks.LastOrDefault().AuthorNominations}, number of book winners: {authorBooks.LastOrDefault().AuthorWins}");
            Console.ReadLine();
        }
    }
}
