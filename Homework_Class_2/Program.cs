using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

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
            Console.WriteLine($"{orderedListByCollaborations.LastOrDefault().Key} wrote most collaborations." +
                $" ({orderedListByCollaborations.LastOrDefault().Count()})");
            Console.WriteLine("------------------------------");


            Console.WriteLine("In what year were published most books in a specific genre ? Which genre ?");
            var genres = from Genre genre in Enum.GetValues(typeof(Genre))
                         select genre;
            var booksByGenre = from genre in genres
                               select new
                               {
                                   Genre = genre,
                                   BooksNum = (from book in books
                                               where book.Genres.Contains(genre)
                                               group book by book.Year).OrderBy(num => num.Count()).LastOrDefault()
                               };
            var orderedBooksByGenre = from pair in booksByGenre
                                      orderby pair.BooksNum.Count()
                                      select pair;
            Console.WriteLine($"In year {orderedBooksByGenre.LastOrDefault().BooksNum.Key}, " +
                $"{orderedBooksByGenre.LastOrDefault().BooksNum.Count()} books " +
                $"(Genre:{orderedBooksByGenre.LastOrDefault().Genre}) were published");
            Console.WriteLine("------------------------------");


            Console.WriteLine("Which author has most books nominated for an award?");
            var nominatedBooks = from author in authors
                                 from book in author.Books
                                 where book.Nominations > 0
                                 group book by author.ID;
            var nominatedBooksDictionary = nominatedBooks.ToDictionary(x => x.Key, y => y.Count());
            var orderedNominationDictionary = from author in nominatedBooksDictionary
                                              orderby author.Value
                                              select author;
            var author1Name = from author in authors
                              where author.ID == orderedNominationDictionary.LastOrDefault().Key
                              select author.Name;
            Console.WriteLine($"The author with most nominated books ({orderedNominationDictionary.LastOrDefault().Value})" +
                $" is {author1Name.FirstOrDefault()}.");
            Console.WriteLine("------------------------------");


            Console.WriteLine("Which auhtor has most books that won an award ?");
            var winningBooks = from author in authors
                               from book in author.Books
                               where book.Wins > 0
                               group book by author.ID;
            var winningBooksDictionary = winningBooks.ToDictionary(x => x.Key, y => y.Count());
            var orderedWinningDictionary = from author in winningBooksDictionary
                                           orderby author.Value descending
                                           select author;
            var orderedToList = from auth in orderedWinningDictionary
                                select auth.Value;
            var bestScore = orderedToList.First();
            var winners = from num in orderedToList
                          where num == bestScore
                          select num;
            List<string> authorWinners = new List<string>();
            foreach (Author author in authors)
            {
                for (int i = 0; i < winners.ToList().Count; i++)
                {
                    if (author.ID == orderedWinningDictionary.Skip(i).FirstOrDefault().Key)
                    {
                        authorWinners.Add(author.Name);
                    }
                }
               
            }
            Console.WriteLine($"The authors with most winner books ({orderedWinningDictionary.FirstOrDefault().Value}) are:");
            authorWinners.ForEach(Console.WriteLine);
            Console.WriteLine("------------------------------");


            Console.WriteLine("Which author has most books nominated for an award, without winning a single award ?");
            var bookNominationsWithoutWin = from author in authors
                                            where author.Wins == 0
                                            from book in author.Books
                                            where book.Nominations > 0
                                            group book by author.ID;
            var bookNominationsWithoutWinDictionary = bookNominationsWithoutWin.ToDictionary(x => x.Key, y => y.Count());
            var orderedbookNominationsWithoutWin = from author in bookNominationsWithoutWinDictionary
                                                   orderby author.Value
                                                   select author;
            var author3Name = from author in authors
                              where author.ID == orderedbookNominationsWithoutWin.LastOrDefault().Key
                              select author.Name;
            Console.WriteLine($"The author with most nominated books ({orderedbookNominationsWithoutWin.LastOrDefault().Value}) " +
                $"without a single award is {author3Name.FirstOrDefault()}.");
            Console.WriteLine("------------------------------");


            Console.WriteLine("Make a histogram of books published per decade per genre");
            var histogram = from genre in genres
                            select new
                            {
                                Genre = genre,
                                BooksNum = (from book in books
                                            where book.Genres.Contains(genre)
                                            group book by book.Year / 10 * 10).Select(dec => new
                                            {
                                                Decade = dec.Key,
                                                BooksNumber = dec.Count()
                                            }).OrderBy(pair => pair.Decade)
                            };
            var histogramDictionary = histogram.ToDictionary(x => x.Genre, y => y.BooksNum.ToDictionary(z => z.Decade, w => w.BooksNumber));
            var decades = histogramDictionary.SelectMany(decad => decad.Value.Select(d => d.Key));
            var decadesFiltered = decades.Distinct().OrderBy(decade => decade);
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
            var authorBooks = from author in authors
                              select new
                              {
                                  AuthorId = author.ID,
                                  AuthorName = author.Name,
                                  AuthorBooks = author.Books.Count,
                                  AuthorNominations = author.Books.Count(book => book.Nominations > 0),
                                  AuthorWins = author.Wins
                              };
            var orderingAuthors = from author in authorBooks
                                  orderby author.AuthorNominations * 100 / author.AuthorBooks, author.AuthorBooks, author.AuthorWins
                                  select author;
            Console.WriteLine($"{orderingAuthors.LastOrDefault().AuthorName} has the highest percentage of nominated books. " +
                $"({orderingAuthors.LastOrDefault().AuthorNominations * 100 / orderingAuthors.LastOrDefault().AuthorBooks}%)");


            Console.ReadLine();
        }
    }
}
