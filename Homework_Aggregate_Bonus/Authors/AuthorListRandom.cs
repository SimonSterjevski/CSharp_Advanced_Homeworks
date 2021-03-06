using System;
using System.Collections.Generic;
using System.Text;

namespace Authors
{
    class AuthorRepo
    {
        public List<Author> GetAuthors()
        {
            return new List<Author>
            {
                new Author
                {
                    ID = 58,
                    Name = "Charles Stross",
                    Nominations = 32,
                    Wins = 3,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 5342,
                            Title = "The Rapture of the Nerds",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16588,
                            Title = "A Tall Tail",
                            Year = 2012,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2094,
                            Title = "Wireless",
                            Year = 2010,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 11285,
                            Title = "Palimpsest",
                            Year = 2009,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28542,
                            Title = "Trunk and Disorderly",
                            Year = 2007,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1005,
                            Title = "Glasshouse",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 4,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34504,
                            Title = "Missile Gap",
                            Year = 2005,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 26345,
                            Title = "Rogue Farm",
                            Year = 2003,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18005,
                            Title = "Toast:  And Other Rusted Futures",
                            Year = 2002,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20028,
                            Title = "Antibodies",
                            Year = 2000,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26346,
                            Title = "A Colder War",
                            Year = 2000,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20765,
                            Title = "Empire Games",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25682,
                            Title = "Dark State",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 57,
                            Title = "Singularity Sky",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 665,
                            Title = "Iron Sunrise",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1039,
                            Title = "Halting State",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2546,
                            Title = "Rule 34",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9374,
                            Title = "Equoid",
                            Year = 2013,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16059,
                            Title = "Overtime",
                            Year = 2009,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16066,
                            Title = "Down on the Farm",
                            Year = 2008,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 28634,
                            Title = "Pimpf ",
                            Year = 2006,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 20531,
                            Title = "The Concrete Jungle",
                            Year = 2004,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 2547,
                            Title = "The Atrocity Archives",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1008,
                            Title = "The Jennifer Morgue",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 2548,
                            Title = "The Fuller Memorandum",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 5339,
                            Title = "The Apocalypse Codex",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 5989,
                            Title = "The Rhesus Chart",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 13185,
                            Title = "The Annihilation Score",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16555,
                            Title = "The Nightmare Stacks",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 21355,
                            Title = "The Delirium Brief",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25904,
                            Title = "The Labyrinth Index",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 36676,
                            Title = "Dead Lies Dreaming",
                            Year = 2020,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 808,
                            Title = "Accelerando",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 4,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18603,
                            Title = "Lobsters",
                            Year = 2001,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19848,
                            Title = "Halo",
                            Year = 2002,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20918,
                            Title = "Nightfall",
                            Year = 2003,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20530,
                            Title = "Elector",
                            Year = 2004,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 677,
                            Title = "The Family Trade",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1593,
                            Title = "The Hidden Family",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1594,
                            Title = "The Clan Corporate",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1595,
                            Title = "The Merchants' War",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1596,
                            Title = "The Revolution Business",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1597,
                            Title = "The Trade of Queens",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1229,
                            Title = "Saturn's Children",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5616,
                            Title = "Neptune's Brood",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 183,
                    Name = "John Kessel",
                    Nominations = 5,
                    Wins = 1,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 26517,
                            Title = "Pride and Prometheus",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 22699,
                            Title = "The Moon and the Other",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26805,
                            Title = "Consolation",
                            Year = 2015,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7129,
                            Title = "Digital Rapture:  The Singularity Anthology",
                            Year = 2012,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28618,
                            Title = "Iteration",
                            Year = 2011,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7128,
                            Title = "Kafkaesque:  Stories Inspired by Franz Kafka",
                            Year = 2011,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 22320,
                            Title = "Events Preceding the Helvetican Renaissance",
                            Year = 2009,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28571,
                            Title = "The Motorman's Coat",
                            Year = 2009,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6575,
                            Title = "The Secret History of Science Fiction",
                            Year = 2009,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6379,
                            Title = "The Baum Plan for Financial Independence and Other Stories",
                            Year = 2008,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16127,
                            Title = "Pride and Prometheus",
                            Year = 2008,
                            Type = BookType.Novelette,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20096,
                            Title = "The Last American",
                            Year = 2007,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7127,
                            Title = "Rewired: The Post-Cyberpunk Anthology",
                            Year = 2007,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6576,
                            Title = "Feeling Very Strange:  The Slipstream Anthology ",
                            Year = 2006,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20079,
                            Title = "The Baum Plan for Financial Independence",
                            Year = 2004,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 20080,
                            Title = "It's All True",
                            Year = 2003,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16129,
                            Title = "Stories for Men",
                            Year = 2002,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20081,
                            Title = "The Juniper Tree",
                            Year = 2000,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17727,
                            Title = "Ninety Percent of Everything",
                            Year = 1999,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24028,
                            Title = "Every Angel Is Terrifying",
                            Year = 1998,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 25641,
                            Title = "Corrupting Dr. Nice",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26343,
                            Title = "Gulliver at Home",
                            Year = 1997,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6319,
                            Title = "The Pure Product (collection)",
                            Year = 1997,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18641,
                            Title = "Intersections:  The Sycamore Hill Anthology",
                            Year = 1996,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18642,
                            Title = "The Miracle of Ivar Avenue",
                            Year = 1996,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27584,
                            Title = "Some Like It Cold",
                            Year = 1995,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18687,
                            Title = "The Franchise",
                            Year = 1993,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17945,
                            Title = "Meeting in Infinity:  Allegories & Extrapolations",
                            Year = 1992,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17650,
                            Title = "Buffalo",
                            Year = 1991,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27721,
                            Title = "Invaders",
                            Year = 1990,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 189,
                            Title = "Good News from Outer Space",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17947,
                            Title = "Mrs. Shummel Exits a Winner",
                            Year = 1988,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24784,
                            Title = "The Pure Product",
                            Year = 1986,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25631,
                            Title = "Freedom Beach",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27829,
                            Title = "Friends",
                            Year = 1984,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27184,
                            Title = "Hearts Do Not in Eyes Shine",
                            Year = 1983,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19561,
                            Title = "Another Orphan",
                            Year = 1982,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7340,
                            Title = "Nebula Awards Showcase 2012",
                            Year = 2012,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11101,
                            Title = "Tor Double #6: Enemy Mine / Another Orphan",
                            Year = 1989,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 190,
                    Name = "Pat Murphy",
                    Nominations = 6,
                    Wins = 2,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 24301,
                            Title = "Crossing the Threshold",
                            Year = 2017,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27961,
                            Title = "Cold Comfort",
                            Year = 2016,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16592,
                            Title = "About Fairies",
                            Year = 2012,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27202,
                            Title = "Inappropriate Behavior",
                            Year = 2004,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6426,
                            Title = "Nadya:  The Wolf Chronicles",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 20575,
                            Title = "An American Childhood",
                            Year = 1993,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27683,
                            Title = "Desert Rain",
                            Year = 1991,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19323,
                            Title = "Bones",
                            Year = 1990,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17928,
                            Title = "Love and Sex Among the Invertebrates",
                            Year = 1990,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 527,
                            Title = "Points of Departure",
                            Year = 1990,
                            Type = BookType.Collection,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 628,
                            Title = "The City, Not Long After",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17944,
                            Title = "Dead Men on TV",
                            Year = 1988,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18537,
                            Title = "Rachel in Love",
                            Year = 1987,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 196,
                            Title = "The Falling Woman",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27182,
                            Title = "In the Islands",
                            Year = 1983,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27183,
                            Title = "The Shadow Hunter",
                            Year = 1982,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16412,
                            Title = "There and Back Again",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27185,
                            Title = "Wild Angel",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27187,
                            Title = "Adventures in Time and Space with Max Merriwell",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6440,
                            Title = "The James Tiptree Award Anthology 1 ",
                            Year = 2005,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6441,
                            Title = "The James Tiptree Award Anthology 2 ",
                            Year = 2006,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6442,
                            Title = "The James Tiptree Award Anthology 3 ",
                            Year = 2007,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 240,
                    Name = "David Gerrold",
                    Nominations = 8,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36015,
                            Title = "Hella",
                            Year = 2020,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27892,
                            Title = "The Further Adventures of Mr. Costello",
                            Year = 2016,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19901,
                            Title = "The Involuntary Human",
                            Year = 2007,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 860,
                            Title = "Child of Earth",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27076,
                            Title = "In the Quake Zone",
                            Year = 2005,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19902,
                            Title = "Dancer in the Dark",
                            Year = 2004,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18683,
                            Title = "The Martian Child:  A Novel About a Single Father Adopting a Son (Based on a True Story)",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18684,
                            Title = "The Martian Child",
                            Year = 1994,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26957,
                            Title = "Chess with a Dragon",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13427,
                            Title = "Enemy Mine",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26956,
                            Title = "Deathbeast",
                            Year = 1978,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34529,
                            Title = "Ascents of Wonder",
                            Year = 1977,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 246,
                            Title = "Moonstar Odyssey",
                            Year = 1977,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34528,
                            Title = "Alternities",
                            Year = 1974,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19419,
                            Title = "Science Fiction Emphasis 1",
                            Year = 1974,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 274,
                            Title = "The Man Who Folded Himself",
                            Year = 1973,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19012,
                            Title = "In the Deadlands",
                            Year = 1972,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26958,
                            Title = "Space Skimmer",
                            Year = 1972,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 282,
                            Title = "When Harlie Was One",
                            Year = 1972,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19011,
                            Title = "With a Finger in My I",
                            Year = 1972,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8690,
                            Title = "The Flying Sorcerers",
                            Year = 1971,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18174,
                            Title = "Protostars",
                            Year = 1971,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11626,
                            Title = "The Galactic Whirlpool",
                            Year = 1980,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19432,
                            Title = "Jumping Off the Planet",
                            Year = 1998,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7028,
                            Title = "Jumping Off the Planet",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7029,
                            Title = "Bouncing Off the Moon",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7030,
                            Title = "Leaping to the Stars ",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17044,
                            Title = "Battle for the Planet of the Apes",
                            Year = 1973,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10624,
                            Title = "Encounter at Farpoint",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9150,
                            Title = "Starhunt (Yesterday's Children)",
                            Year = 1972,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9147,
                            Title = "The Voyage of the Star Wolf",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9148,
                            Title = "The Middle of Nowhere",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9149,
                            Title = "Blood and Fire",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26959,
                            Title = "Under the Eye of God",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26960,
                            Title = "A Covenant of Justice",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17140,
                            Title = "A Matter for Men",
                            Year = 1983,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17141,
                            Title = "A Day for Damnation",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17142,
                            Title = "A Rage for Revenge",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17143,
                            Title = "A Season for Slaughter",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 248,
                    Name = "Arthur Byron Cover",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 253,
                            Title = "Autumn Angels",
                            Year = 1975,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17850,
                            Title = "The Platypus of Doom and Other Nihilists",
                            Year = 1976,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17851,
                            Title = "An East Wind Coming",
                            Year = 1979,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32504,
                            Title = "Flash Gordon",
                            Year = 1980,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32505,
                            Title = "Planetfall",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32506,
                            Title = "Stationfall",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 299,
                    Name = "Harry Harrison",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 9929,
                            Title = "Harry Harrison! Harry Harrison!",
                            Year = 2014,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24369,
                            Title = "50 in 50",
                            Year = 2001,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4271,
                            Title = "There Won't Be War",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24973,
                            Title = "The Lifeship",
                            Year = 1976,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8765,
                            Title = "Hell's Cartographers:  Some Personal Histories of Science Fiction Writers",
                            Year = 1975,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18354,
                            Title = "Astounding: John W. Campbell Memorial Anthology",
                            Year = 1973,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 36424,
                            Title = "Stonehenge",
                            Year = 1972,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4044,
                            Title = "A Transatlantic Tunnel, Hurrah!",
                            Year = 1972,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18274,
                            Title = "By the Falls",
                            Year = 1970,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24880,
                            Title = "In Our Hands, the Stars",
                            Year = 1970,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11388,
                            Title = "One Step from Earth",
                            Year = 1970,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28570,
                            Title = "Spaceship Medic",
                            Year = 1970,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11387,
                            Title = "Captive Universe",
                            Year = 1969,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 36425,
                            Title = "Apeman, Spaceman",
                            Year = 1968,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4046,
                            Title = "The Technicolor┬« Time Machine",
                            Year = 1967,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1996,
                            Title = "Make Room! Make Room!",
                            Year = 1966,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22543,
                            Title = "The Streets of Ashkelon",
                            Year = 1962,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25521,
                            Title = "War with the Robots",
                            Year = 1962,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18108,
                            Title = "Best SF: 1967",
                            Year = 1968,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18109,
                            Title = "Best SF: 1968",
                            Year = 1969,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18111,
                            Title = "Best SF: 1969",
                            Year = 1970,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18112,
                            Title = "Best SF: 1970",
                            Year = 1971,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18114,
                            Title = "Best SF: 1971",
                            Year = 1972,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18115,
                            Title = "Best SF: 1972",
                            Year = 1973,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18117,
                            Title = "Best SF: 1973",
                            Year = 1974,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18118,
                            Title = "Best SF: 1974",
                            Year = 1975,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18119,
                            Title = "Best SF: 75, The Ninth Annual",
                            Year = 1976,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3218,
                            Title = "Bill the Galactic Hero",
                            Year = 1965,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3219,
                            Title = "Bill, the Galactic Hero on the Planet of Robot Slaves",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3220,
                            Title = "Bill, the Galactic Hero on the Planet of the Bottled Brains",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3222,
                            Title = "Bill, the Galactic Hero on the Planet of Tasteless Pleasure",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3221,
                            Title = "Bill, the Galactic Hero on the Planet of Zombie Vampires",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3223,
                            Title = "Bill, the Galactic Hero on the Planet of the Hippies from Hell",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3224,
                            Title = "Bill, the Galactic Hero: The Final Incoherent Adventure",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 310,
                            Title = "Planet of the Damned",
                            Year = 1961,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15067,
                            Title = "Planet of No Return",
                            Year = 1981,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 303,
                            Title = "Deathworld 1",
                            Year = 1960,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4738,
                            Title = "Deathworld 2",
                            Year = 1964,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4739,
                            Title = "Deathworld 3",
                            Year = 1968,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4047,
                            Title = "West of Eden",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4048,
                            Title = "Winter in Eden",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4049,
                            Title = "Return to Eden",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4045,
                            Title = "The Hammer and the Cross",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 22293,
                            Title = "One King's Way",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 22294,
                            Title = "King and Emperor",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7547,
                            Title = "Nebula Award Stories Two",
                            Year = 1967,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21498,
                            Title = "Nova 1",
                            Year = 1970,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21499,
                            Title = "Nova 2",
                            Year = 1972,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21500,
                            Title = "Nova 3",
                            Year = 1973,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21501,
                            Title = "Nova 4",
                            Year = 1974,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18272,
                            Title = "The Best of Harry Harrison",
                            Year = 1976,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2970,
                            Title = "The Stainless Steel Rat",
                            Year = 1961,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2971,
                            Title = "The Stainless Steel Rat's Revenge",
                            Year = 1970,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2972,
                            Title = "The Stainless Steel Rat Saves the World",
                            Year = 1972,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2973,
                            Title = "The Stainless Steel Rat Wants You",
                            Year = 1978,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2974,
                            Title = "The Stainless Steel Rat for President",
                            Year = 1982,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2975,
                            Title = "A Stainless Steel Rat is Born",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2976,
                            Title = "The Stainless Steel Rat Gets Drafted",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2977,
                            Title = "The Stainless Steel Rat Sings the Blues",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2978,
                            Title = "The Stainless Steel Rat Goes to Hell",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2979,
                            Title = "The Stainless Steel Rat Joins the Circus",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2980,
                            Title = "The Stainless Steel Rat Returns",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4050,
                            Title = "Stars and Stripes Forever",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4051,
                            Title = "Stars and Stripes in Peril",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4052,
                            Title = "Stars and Stripes Triumphant",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11384,
                            Title = "Homeworld",
                            Year = 1980,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11385,
                            Title = "Wheelworld",
                            Year = 1981,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11386,
                            Title = "Starworld",
                            Year = 1981,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 305,
                    Name = "James White",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21336,
                            Title = "Un-Birthday Boy",
                            Year = 1996,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21432,
                            Title = "Custom Fitting",
                            Year = 1976,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24968,
                            Title = "The Dream Millennium",
                            Year = 1974,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 30183,
                            Title = "Lifeboat",
                            Year = 1972,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 30159,
                            Title = "Tomorrow Is Too Far",
                            Year = 1971,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 30181,
                            Title = "All Judgment Fled",
                            Year = 1968,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8501,
                            Title = "The Watch Below",
                            Year = 1966,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 831,
                            Title = "The Escape Orbit",
                            Year = 1965,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 309,
                            Title = "Second Ending",
                            Year = 1961,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21214,
                            Title = "Master of Life and Death / The Secret Visitors",
                            Year = 1957,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21601,
                            Title = "The Jewels of Aptor / Second Ending",
                            Year = 1962,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10614,
                            Title = "Hospital Station",
                            Year = 1962,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8500,
                            Title = "Star Surgeon",
                            Year = 1963,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21984,
                            Title = "Major Operation",
                            Year = 1971,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21985,
                            Title = "Ambulance Ship",
                            Year = 1979,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21986,
                            Title = "Sector General",
                            Year = 1983,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21987,
                            Title = "Star Healer",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21988,
                            Title = "Code Blue - Emergency",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21989,
                            Title = "The Genocidal Healer",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21990,
                            Title = "The Galactic Gourmet",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21991,
                            Title = "Final Diagnosis",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21992,
                            Title = "Mind Changer",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21993,
                            Title = "Double Contact",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 346,
                    Name = "Christopher Priest",
                    Nominations = 18,
                    Wins = 7,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 28452,
                            Title = "An American Story",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 398,
                            Title = "The Separation",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 2,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 594,
                            Title = "The Extremes",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 608,
                            Title = "The Prestige",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24486,
                            Title = "The Quiet Woman",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16200,
                            Title = "The Book On the Edge of Forever:  The Facts, the Figures, and the Delusions Behind Harlan Ellison's Never-Published Anthology",
                            Year = 1987,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1073,
                            Title = "The Glamour",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19546,
                            Title = "An Infinite Summer",
                            Year = 1979,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21060,
                            Title = "Palely Loitering",
                            Year = 1979,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21424,
                            Title = "Anticipations",
                            Year = 1978,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22033,
                            Title = "A Dream of Wessex",
                            Year = 1977,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9060,
                            Title = "The Space Machine:  A Scientific Romance",
                            Year = 1976,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 350,
                            Title = "The Inverted World",
                            Year = 1974,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24487,
                            Title = "Real-Time World",
                            Year = 1974,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 458,
                            Title = "Fugue for a Darkening Island",
                            Year = 1972,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24485,
                            Title = "Indoctrinaire",
                            Year = 1970,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20820,
                            Title = "The Watched",
                            Year = 1978,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1067,
                            Title = "The Affirmation",
                            Year = 1981,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3934,
                            Title = "The Islanders",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6101,
                            Title = "The Adjacent",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19302,
                            Title = "The Gradual",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 354,
                    Name = "James Tiptree, Jr.",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 8772,
                            Title = "Meet Me at Infinity",
                            Year = 2000,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6203,
                            Title = "Her Smoke Rose Up Forever",
                            Year = 1990,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7596,
                            Title = "Crown of Stars",
                            Year = 1988,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13902,
                            Title = "Tales of the Quintana Roo",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24195,
                            Title = "Byte Beautiful:  Eight Science Fiction Stories",
                            Year = 1985,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21429,
                            Title = "Out of the Everywhere and Other Extraordinary Visions",
                            Year = 1981,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26664,
                            Title = "Slow Music",
                            Year = 1980,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8771,
                            Title = "Star Songs of an Old Primate",
                            Year = 1978,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 357,
                            Title = "Up the Walls of the World",
                            Year = 1978,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16281,
                            Title = "The Screwfly Solution",
                            Year = 1977,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 21428,
                            Title = "Time-Sharing Angel",
                            Year = 1977,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16303,
                            Title = "Houston, Houston, Do You Read?",
                            Year = 1976,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 18529,
                            Title = "A Momentary Taste of Being",
                            Year = 1975,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7598,
                            Title = "Warm Worlds and Otherwise",
                            Year = 1975,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19155,
                            Title = "The Girl Who Was Plugged In",
                            Year = 1973,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18194,
                            Title = "Love Is the Plan the Plan Is Death",
                            Year = 1973,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26577,
                            Title = "The Women Men Don't See",
                            Year = 1973,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18195,
                            Title = "And I Awoke and Found Me Here on the Cold Hill's Side",
                            Year = 1972,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24751,
                            Title = "The Man Who Walked Home",
                            Year = 1972,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20859,
                            Title = "Painwise",
                            Year = 1972,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18275,
                            Title = "The Last Flight of Dr. Ain",
                            Year = 1969,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2844,
                            Title = "Ten Thousand Light-Years From Home",
                            Year = 1973,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26601,
                            Title = "Beyond the Dead Reef",
                            Year = 1983,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 21405,
                            Title = "The Boy Who Waterskied to Forever",
                            Year = 1982,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18823,
                            Title = "Lirios: A Tale of the Quintana Roo",
                            Year = 1981,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7597,
                            Title = "The Starry Rift",
                            Year = 1986,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7595,
                            Title = "Brightness Falls From the Air",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19406,
                            Title = "The Only Neat Thing to Do",
                            Year = 1985,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11102,
                            Title = "Tor Double #7: Screwtop / The Girl Who Was Plugged In",
                            Year = 1989,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11117,
                            Title = "Tor Double #11: Houston, Houston, Do You Read? / Souls",
                            Year = 1989,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11114,
                            Title = "Tor Double #16: The Color of Neanderthal Eyes / And Strange At",
                            Year = 1990,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 403,
                    Name = "Peter F. Hamilton",
                    Nominations = 4,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 18898,
                            Title = "A Window Into Time",
                            Year = 2016,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17475,
                            Title = "Great North Road",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19353,
                            Title = "Manhattan in Reverse",
                            Year = 2011,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32326,
                            Title = "The Forever Kitten",
                            Year = 2005,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27201,
                            Title = "Footvote",
                            Year = 2004,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 405,
                            Title = "Fallen Dragon",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16173,
                            Title = "Eat Reecebread",
                            Year = 1994,
                            Type = BookType.ShortStory,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18899,
                            Title = "The Secret Throne",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 18900,
                            Title = "The Hunting of the Princes",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23598,
                            Title = "A Voyage Through Air",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9538,
                            Title = "The Abyss Beyond Dreams",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19291,
                            Title = "Night Without Stars",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3427,
                            Title = "Pandora's Star",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3428,
                            Title = "Judas Unchained",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27384,
                            Title = "The Suspect Genome",
                            Year = 2000,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1479,
                            Title = "Mindstar Rising",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1478,
                            Title = "A Quantum Murder",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1086,
                            Title = "The Nano Flower",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2758,
                            Title = "The Reality Dysfunction, Part 1: Emergence",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2759,
                            Title = "The Reality Dysfunction, Part 2: Expansion",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2760,
                            Title = "The Neutronium Alchemist, Part 1: Consolidation",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2761,
                            Title = "The Neutronium Alchemist, Part 2: Conflict",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2762,
                            Title = "The Naked God, Part 1: Flight",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2763,
                            Title = "The Naked God, Part 2: Faith",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20532,
                            Title = "A Second Chance at Eden",
                            Year = 1998,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27496,
                            Title = "Escape Route",
                            Year = 1997,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20533,
                            Title = "The Reality Dysfunction",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20534,
                            Title = "The Neutronium Alchemist",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20535,
                            Title = "The Naked God",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28317,
                            Title = "Salvation",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34674,
                            Title = "Salvation Lost",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2751,
                            Title = "The Dreaming Void",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2752,
                            Title = "The Temporal Void",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2753,
                            Title = "The Evolutionary Void",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 434,
                    Name = "Joan Slonczewski",
                    Nominations = 4,
                    Wins = 2,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3608,
                            Title = "The Highest Frontier",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4828,
                            Title = "The Wall Around Eden",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32742,
                            Title = "Tuberculosis Bacteria Join UN",
                            Year = 2000,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32743,
                            Title = "Still Forms on Foxfield",
                            Year = 1980,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34196,
                            Title = "Microbe",
                            Year = 1995,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 437,
                            Title = "A Door into Ocean",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3609,
                            Title = "Daughter of Elysium",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3610,
                            Title = "The Children Star",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3611,
                            Title = "Brain Plague",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 446,
                    Name = "Paddy Chayefsky",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 449,
                            Title = "Altered States",
                            Year = 1978,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 629,
                    Name = "Jonathan Carroll",
                    Nominations = 15,
                    Wins = 1,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 33892,
                            Title = "Mama Bruise",
                            Year = 2019,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 28321,
                            Title = "Played Your Eyes",
                            Year = 2018,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25002,
                            Title = "The Crow's Dinner",
                            Year = 2017,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 20734,
                            Title = "The Loud Table",
                            Year = 2016,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9570,
                            Title = "Bathing the Lion",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 20606,
                            Title = "The Woman Who Married a Cloud:  Collected Stories",
                            Year = 2012,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 28989,
                            Title = "East of Furious",
                            Year = 2011,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15709,
                            Title = "The Ghost in Love",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 20605,
                            Title = "The Panic Hand",
                            Year = 1995,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 20607,
                            Title = "Uh-Oh City",
                            Year = 1992,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23501,
                            Title = "Black Cocktail",
                            Year = 1990,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23924,
                            Title = "Mr. Fiddlehead",
                            Year = 1989,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23903,
                            Title = "Friend's Best Man",
                            Year = 1987,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1801,
                            Title = "Voice of Our Shadow",
                            Year = 1983,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1790,
                            Title = "The Land of Laughs",
                            Year = 1980,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1667,
                            Title = "Bones of the Moon",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 926,
                            Title = "Sleeping In Flame",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 631,
                            Title = "A Child Across the Sky",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 917,
                            Title = "Outside the Dog Museum",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1668,
                            Title = "After Silence",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 906,
                            Title = "From the Teeth of Angels",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1163,
                            Title = "Kissing the Beehive",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1169,
                            Title = "The Marriage of Sticks",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 691,
                            Title = "The Wooden Sea",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 686,
                            Title = "White Apples",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25975,
                            Title = "Glass Soup",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 739,
                    Name = "Barry Hughart",
                    Nominations = 3,
                    Wins = 2,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 4141,
                            Title = "The Chronicles of Master Li and Number Ten Ox",
                            Year = 1999,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 939,
                            Title = "Bridge of Birds: A Novel of an Ancient China That Never Was",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 2,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4055,
                            Title = "The Story of the Stone",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 742,
                            Title = "Eight Skilled Gentlemen",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 778,
                    Name = "Peter Straub",
                    Nominations = 21,
                    Wins = 7,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 23603,
                            Title = "The Process (Is a Process All Its Own)",
                            Year = 2017,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 18928,
                            Title = "Interior Darkness:  Selected Stories",
                            Year = 2016,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 12194,
                            Title = "Perdido: A Fragment ",
                            Year = 2015,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 26134,
                            Title = "The Ballad of Ballard and Sandrine",
                            Year = 2011,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 2589,
                            Title = "A Dark Matter",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 23451,
                            Title = "Poe's Children:  The New Horror: An Anthology",
                            Year = 2008,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 3582,
                            Title = "In The Night Room",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1182,
                            Title = "Lost Boy Lost Girl",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 23531,
                            Title = "Magic Terror:  Seven Tales",
                            Year = 2000,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1173,
                            Title = "Mr. X",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 23565,
                            Title = "Mr. Clubb and Mr. Cuff",
                            Year = 1998,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1151,
                            Title = "The Hellfire Club",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 24335,
                            Title = "Peter Straub's Ghosts",
                            Year = 1995,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 23530,
                            Title = "Fee",
                            Year = 1994,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 23527,
                            Title = "The Ghost Village",
                            Year = 1992,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 24608,
                            Title = "Houses Without Doors",
                            Year = 1990,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 26080,
                            Title = "Mrs. God",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1134,
                            Title = "Floating Dragon",
                            Year = 1983,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 954,
                            Title = "Shadowland",
                            Year = 1980,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 4623,
                            Title = "Ghost Story",
                            Year = 1979,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 10803,
                            Title = "Julia",
                            Year = 1975,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 7279,
                            Title = "American Fantastic Tales:  Terror and the Uncanny from Poe to the Pulps",
                            Year = 2009,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 7280,
                            Title = "American Fantastic Tales:  Terror and the Uncanny from the 1940's to Now",
                            Year = 2009,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 7186,
                            Title = "The Juniper Tree and Other Blue Rose Stories",
                            Year = 2010,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 921,
                            Title = "Koko",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 7187,
                            Title = "Mystery",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 912,
                            Title = "The Throat",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16134,
                            Title = "Conjunctions 39:  The New Wave Fabulists",
                            Year = 2002,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 779,
                            Title = "The Talisman",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 3572,
                            Title = "Black House",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 839,
                    Name = "G. C. Edmondson",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 836,
                            Title = "The Ship That Sailed the Time Stream",
                            Year = 1970,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21181,
                            Title = "The Ship That Sailed the Time Stream / Stranger Than You Think",
                            Year = 1965,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 944,
                    Name = "Diana Wynne Jones",
                    Nominations = 4,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 13537,
                            Title = "The Islands of Chaldea",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13541,
                            Title = "Freaky Families",
                            Year = 2013,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13539,
                            Title = "Reflections: On the Magic of Writing",
                            Year = 2012,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13540,
                            Title = "Vile Visitors",
                            Year = 2012,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13484,
                            Title = "Earwig and the Witch",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2596,
                            Title = "Enchanted Glass",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28569,
                            Title = "JoBoy",
                            Year = 2009,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13483,
                            Title = "The Game",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13528,
                            Title = "Unexpected Magic: Collected Stories",
                            Year = 2004,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13527,
                            Title = "Believing is Seeing: Seven Stories",
                            Year = 1999,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7606,
                            Title = "The Tough Guide to Fantasyland",
                            Year = 1997,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13516,
                            Title = "Minor Arcana",
                            Year = 1996,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13515,
                            Title = "Everard's Ride",
                            Year = 1995,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13482,
                            Title = "Hexwood",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13486,
                            Title = "Stopping for a Spell: Three Fantasies",
                            Year = 1993,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11776,
                            Title = "A Sudden Wild Magic",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13545,
                            Title = "Yes Dear",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13481,
                            Title = "Black Maria (Aunt Maria)",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13480,
                            Title = "Wild Robert",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13544,
                            Title = "Chair Person",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6632,
                            Title = "A Tale of Time City",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 941,
                            Title = "Archer's Goon",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5287,
                            Title = "Fire and Hemlock",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13485,
                            Title = "Warlock at the Wheel and Other Stories",
                            Year = 1984,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13478,
                            Title = "The Homeward Bounders",
                            Year = 1981,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13479,
                            Title = "The Time of the Ghost",
                            Year = 1981,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13543,
                            Title = "The Four Grannies",
                            Year = 1980,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13542,
                            Title = "Who Got Rid of Angus Flint?",
                            Year = 1978,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13477,
                            Title = "Power of Three",
                            Year = 1976,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7609,
                            Title = "Dogsbody",
                            Year = 1975,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7611,
                            Title = "Eight Days of Luke",
                            Year = 1975,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7608,
                            Title = "The Ogre Downstairs",
                            Year = 1974,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13538,
                            Title = "Witch's Business (Wilkins' Tooth)",
                            Year = 1974,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7607,
                            Title = "Changeover",
                            Year = 1970,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13526,
                            Title = "Stealer of Souls",
                            Year = 2002,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13525,
                            Title = "Mixed Magics: Four Tales of Chrestomanci",
                            Year = 2000,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13519,
                            Title = "Charmed Life",
                            Year = 1977,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13520,
                            Title = "The Magicians of Caprona",
                            Year = 1980,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13521,
                            Title = "Witch Week",
                            Year = 1982,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13522,
                            Title = "The Lives of Christopher Chant",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13523,
                            Title = "Conrad's Fate",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13524,
                            Title = "The Pinhoe Egg",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13511,
                            Title = "Cart and Cwidder",
                            Year = 1975,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13512,
                            Title = "Drowned Ammet",
                            Year = 1977,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13513,
                            Title = "The Spellcoats",
                            Year = 1979,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13514,
                            Title = "The Crown of Dalemark",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7612,
                            Title = "The Dark Lord of Derkholm",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7613,
                            Title = "Year of the Griffin",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5103,
                            Title = "Howl's Moving Castle",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5104,
                            Title = "Castle in the Air",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5105,
                            Title = "House of Many Ways",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 8761,
                            Title = "Deep Secret",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3651,
                            Title = "The Merlin Conspiracy",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1041,
                    Name = "Richard Adams",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3317,
                            Title = "Watership Down",
                            Year = 1972,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1119,
                            Title = "Shardik",
                            Year = 1974,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25863,
                            Title = "Maia",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1060,
                    Name = "James Herbert",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 1183,
                            Title = "Nobody True",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6778,
                            Title = "The Secret of Crickley Hall",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6777,
                            Title = "Once...",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6776,
                            Title = "Others ",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6747,
                            Title = "'48",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6746,
                            Title = "Portent",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6744,
                            Title = "Creed",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6672,
                            Title = "The Jonah",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6743,
                            Title = "Sepulchre",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6716,
                            Title = "The Magic Cottage",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6677,
                            Title = "Moon",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6674,
                            Title = "Shrine",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6671,
                            Title = "The Dark",
                            Year = 1980,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6670,
                            Title = "The Spear",
                            Year = 1978,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6668,
                            Title = "Fluke",
                            Year = 1977,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6665,
                            Title = "The Survivor",
                            Year = 1976,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6598,
                            Title = "The Fog",
                            Year = 1975,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6599,
                            Title = "Haunted",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6600,
                            Title = "The Ghosts of Sleath",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6602,
                            Title = "Ash",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6649,
                            Title = "The Rats",
                            Year = 1974,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6651,
                            Title = "Lair",
                            Year = 1979,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6661,
                            Title = "Domain",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6663,
                            Title = "The City",
                            Year = 1994,
                            Type = BookType.GraphicNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1072,
                    Name = "Jeff Carlson",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 10460,
                            Title = "The Frozen Sky",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1559,
                            Title = "Plague Year",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1211,
                            Title = "Plague War",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1560,
                            Title = "Plague Zone",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1106,
                    Name = "Suzanne Collins",
                    Nominations = 3,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36062,
                            Title = "The Ballad of Songbirds and Snakes",
                            Year = 2020,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2183,
                            Title = "The Hunger Games",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1730,
                            Title = "Catching Fire",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2184,
                            Title = "Mockingjay",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27214,
                            Title = "Gregor the Overlander",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27215,
                            Title = "Gregor and the Prophecy of Bane",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27216,
                            Title = "Gregor and the Curse of the Warmbloods",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27217,
                            Title = "Gregor and the Marks of Secret",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27218,
                            Title = "Gregor and the Code of Claw",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1122,
                    Name = "Kari Sperring",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 5589,
                            Title = "The Grass King's Concubine",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1748,
                            Title = "Living with Ghosts",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34272,
                            Title = "Serpent Rose",
                            Year = 2019,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1138,
                    Name = "Clark Ashton Smith",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 9483,
                            Title = "The Miscellaneous Writings of Clark Ashton Smith",
                            Year = 2011,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 3836,
                            Title = "The Return Of The Sorcerer:  The Best of Clark Ashton Smith",
                            Year = 2008,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 28428,
                            Title = "Red World of Polaris: The Adventures of Captain Volmar",
                            Year = 2003,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24628,
                            Title = "Tales of Zothique",
                            Year = 1995,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 24525,
                            Title = "A Rendezvous in Averoigne:  The Best Fantastic Tales of Clark Ashton Smith",
                            Year = 1988,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1802,
                            Title = "The Emperor of Dreams",
                            Year = 1978,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10658,
                            Title = "Zothique",
                            Year = 1970,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 13322,
                            Title = "The Klarkash-Ton Cycle:  Clark Ashton Smith's Cthulhu Mythos Fiction",
                            Year = 2008,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 9478,
                            Title = "The End of the Story",
                            Year = 2006,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 9479,
                            Title = "The Door to Saturn",
                            Year = 2007,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 9480,
                            Title = "A Vintage from Atlantis",
                            Year = 2007,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 9481,
                            Title = "The Maze of the Enchanter",
                            Year = 2008,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 9482,
                            Title = "The Last Hieroglyph",
                            Year = 2010,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 9475,
                            Title = "The Abyss Triumphant",
                            Year = 2008,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 9477,
                            Title = "The Wine of Summer",
                            Year = 2008,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 9476,
                            Title = "The Flowers of Evil and Others",
                            Year = 2008,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 10598,
                            Title = "Out of Space and Time",
                            Year = 1942,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 10599,
                            Title = "Lost Worlds",
                            Year = 1944,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 28426,
                            Title = "Out of Space and Time: Volume I",
                            Year = 1974,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 28427,
                            Title = "Out of Space and Time: Volume II",
                            Year = 1974,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1142,
                    Name = "Evangeline Walton",
                    Nominations = 3,
                    Wins = 1,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34174,
                            Title = "She Walks in Darkness",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23393,
                            Title = "Above Ker-Is and Other Stories",
                            Year = 2012,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5289,
                            Title = "The Sword is Forged",
                            Year = 1983,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5288,
                            Title = "Witch House",
                            Year = 1945,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1812,
                            Title = "The Mabinogion",
                            Year = 2003,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5119,
                            Title = "Prince of Annwn",
                            Year = 1973,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5122,
                            Title = "The Children of Llyr",
                            Year = 1971,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5120,
                            Title = "The Song of Rhiannon",
                            Year = 1972,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5121,
                            Title = "The Island of the Mighty (The Virgin and the Swine)",
                            Year = 1936,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1181,
                    Name = "Amber Benson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 28905,
                            Title = "The Seven Whistlers",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1879,
                            Title = "Death's Daughter",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4795,
                            Title = "Cat's Claw",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4792,
                            Title = "Serpent's Storm",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4794,
                            Title = "How to be Death",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4793,
                            Title = "The Golden Age of Death",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19573,
                            Title = "The Witches of Echo Park",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19574,
                            Title = "The Last Dream Keeper",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23607,
                            Title = "The End of Magic",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1197,
                    Name = "Matthew Farrer",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 16512,
                            Title = "Strange Flesh",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28133,
                            Title = "Enforcer",
                            Year = 2010,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28130,
                            Title = "Crossfire",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28131,
                            Title = "Legacy",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28132,
                            Title = "Blind",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1260,
                    Name = "John W. Campbell, Jr.",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34667,
                            Title = "Frozen Hell",
                            Year = 2019,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6192,
                            Title = "A New Dawn: The Complete Don A. Stuart Stories ",
                            Year = 2003,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2281,
                            Title = "The Astounding Science Fiction Anthology",
                            Year = 1952,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2137,
                            Title = "Who Goes There?",
                            Year = 1948,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21519,
                            Title = "The Planeteers / The Ultimate Weapon",
                            Year = 1966,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10438,
                            Title = "Prologue to Analog",
                            Year = 1962,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18196,
                            Title = "Analog 1",
                            Year = 1963,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18197,
                            Title = "Analog 2",
                            Year = 1964,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18198,
                            Title = "Analog 3",
                            Year = 1965,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18199,
                            Title = "Analog 4",
                            Year = 1966,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18200,
                            Title = "Analog 5",
                            Year = 1967,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18201,
                            Title = "Analog 6",
                            Year = 1968,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18202,
                            Title = "Analog 7",
                            Year = 1970,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18203,
                            Title = "Analog 8",
                            Year = 1971,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8479,
                            Title = "The Black Star Passes",
                            Year = 1953,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12831,
                            Title = "Islands of Space",
                            Year = 1956,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12832,
                            Title = "Invaders from the Infinite",
                            Year = 1961,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18424,
                            Title = "The Best of John W. Campbell",
                            Year = 1973,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10713,
                            Title = "The Moon is Hell!",
                            Year = 1951,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11317,
                            Title = "The Mightiest Machine",
                            Year = 1965,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11316,
                            Title = "The Ultimate Weapon",
                            Year = 1976,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1274,
                    Name = "Robert Louis Stevenson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 2259,
                            Title = "The Strange Case of Dr. Jekyll and Mr. Hyde",
                            Year = 1886,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1282,
                    Name = "E. M. Forster",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 2272,
                            Title = "The Machine Stops:  And Other Stories",
                            Year = 1909,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1307,
                    Name = "William R. Forstchen",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 8325,
                            Title = "Pillar to the Sky",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14015,
                            Title = "The Crystal Warriors",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14016,
                            Title = "The Crystal Sorcerers",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14012,
                            Title = "The Alexandrian Ring",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14013,
                            Title = "The Assassin Gambit",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14014,
                            Title = "The Napoleon Wager",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14009,
                            Title = "Ice Prophet",
                            Year = 1983,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14010,
                            Title = "The Flame Upon the Ice",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14011,
                            Title = "A Darkness Upon the Ice",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2401,
                            Title = "Honoured Enemy",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14017,
                            Title = "Rally Cry",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14018,
                            Title = "Union Forever",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14019,
                            Title = "Terrible Swift Sword",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14020,
                            Title = "Fateful Lightning",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14021,
                            Title = "Battle Hymn",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14022,
                            Title = "Never Sound Retreat",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14023,
                            Title = "A Band of Brothers",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14024,
                            Title = "Men of War",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14025,
                            Title = "Down to the Sea",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14007,
                            Title = "One Second After",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14008,
                            Title = "One Year After",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20762,
                            Title = "The Final Day",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19865,
                            Title = "The Forgotten War",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1314,
                    Name = "Paul Kearney",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17967,
                            Title = "The Wolf in the Attic",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27193,
                            Title = "The Way to Babylon",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27194,
                            Title = "A Different Kingdom",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27195,
                            Title = "Riding the Unicorn",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2487,
                            Title = "The Ten Thousand",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2488,
                            Title = "Corvus",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2489,
                            Title = "The Kings of Morning",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2485,
                            Title = "Hawkwood and the Kings",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2486,
                            Title = "Century of the Soldier",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2490,
                            Title = "The Mark of Ran",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2491,
                            Title = "This Forsaken Earth",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 26551,
                            Title = "Calgar's Siege",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26554,
                            Title = "Calgar's Fury",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1336,
                    Name = "Justin Cronin",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 2608,
                            Title = "The Passage",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6645,
                            Title = "The Twelve",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 18164,
                            Title = "The City of Mirrors",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1353,
                    Name = "Charles Yu",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 2674,
                            Title = "How to Live Safely in a Science Fictional Universe",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 31686,
                            Title = "America: The Ride",
                            Year = 2018,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26655,
                            Title = "Fable",
                            Year = 2016,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23430,
                            Title = "Bookkeeper, Narrator, Gunslinger",
                            Year = 2014,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24227,
                            Title = "Sorry Please Thank You",
                            Year = 2012,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22196,
                            Title = "Standard Loneliness Package",
                            Year = 2010,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25005,
                            Title = "The Best American Science Fiction and Fantasy 2017",
                            Year = 2017,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1363,
                    Name = "Richard Powers",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 2725,
                            Title = "Generosity",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4408,
                            Title = "Galatea 2.2",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27077,
                            Title = "The Overstory",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1407,
                    Name = "Francis Leslie Ashton",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 2849,
                            Title = "Wrong Side of the Moon",
                            Year = 1951,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1426,
                    Name = "Bradley P. Beaulieu",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 5816,
                            Title = "Lest Our Passage Be Forgotten & Other Stories",
                            Year = 2012,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 20086,
                            Title = "The Burning Light",
                            Year = 2016,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2991,
                            Title = "The Winds of Khalakovo",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5814,
                            Title = "The Straits of Galahesh",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5815,
                            Title = "The Flames of Shadam Khoreh",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32439,
                            Title = "A Wasteland of My God's Own Making",
                            Year = 2019,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32437,
                            Title = "The Doors at Dusk and Dawn",
                            Year = 2017,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32436,
                            Title = "In the Village Where Brightwine Flows",
                            Year = 2017,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32438,
                            Title = "The Tattered Prince and the Demon Veiled",
                            Year = 2017,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19288,
                            Title = "Of Sand and Malice Made",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13766,
                            Title = "Twelve Kings in Sharakhai",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 21677,
                            Title = "With Blood Upon the Sand",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 26983,
                            Title = "A Veil of Spears",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32435,
                            Title = "Beneath the Twisted Trees",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36460,
                            Title = "When Jackals Storm the Walls",
                            Year = 2020,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1439,
                    Name = "Tom Fletcher",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 5575,
                            Title = "The Ravenglass Eye",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9984,
                            Title = "The Thing on the Shore",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3089,
                            Title = "The Leaping",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9983,
                            Title = "Gleam",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34433,
                            Title = "Idle Hands",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1447,
                    Name = "Douglas Coupland",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3110,
                            Title = "Girlfriend in a Coma",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1456,
                    Name = "James Hogg",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3120,
                            Title = "The Private Memoirs and Confessions of a Justified Sinner:  Written by Himself",
                            Year = 1824,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1464,
                    Name = "Marghanita Laski",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3160,
                            Title = "The Victorian Chaise-Longue",
                            Year = 1953,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1474,
                    Name = "Vladimir Nabokov",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3181,
                            Title = "Ada or Ardor: A Family Chronicle",
                            Year = 1969,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 23371,
                            Title = "The Eye",
                            Year = 1965,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6646,
                            Title = "Pale Fire",
                            Year = 1962,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23370,
                            Title = "Invitation to a Beheading",
                            Year = 1959,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36080,
                            Title = "Bend Sinister",
                            Year = 1947,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1485,
                    Name = "Salman Rushdie",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35407,
                            Title = "Quichotte",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28812,
                            Title = "The Duniaz├ít",
                            Year = 2015,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14111,
                            Title = "Two Years Eight Months and Twenty-Eight Nights",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4058,
                            Title = "The Enchantress of Florence",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 21867,
                            Title = "The Ground Beneath Her Feet",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16115,
                            Title = "The Firebird's Nest",
                            Year = 1997,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 21866,
                            Title = "Midnight's Children",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6387,
                            Title = "Haroun and the Sea of Stories",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3193,
                            Title = "The Satanic Verses",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4057,
                            Title = "Grimus",
                            Year = 1975,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1508,
                    Name = "Travis S. Taylor",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3240,
                            Title = "Vorpal Blade",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3241,
                            Title = "Manxome Foe",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3242,
                            Title = "Claws that Catch",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10096,
                            Title = "Back to the Moon",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35741,
                            Title = "On to the Asteroid",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 23503,
                            Title = "One Day on Mars",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 23504,
                            Title = "The Tau Ceti Agenda",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 23505,
                            Title = "One Good Soldier",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 23506,
                            Title = "Trail of Evil",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 23507,
                            Title = "Kill Before Dying",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27489,
                            Title = "Bringers of Hell",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 23508,
                            Title = "Warp Speed",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 23509,
                            Title = "The Quantum Connection",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1514,
                    Name = "Nick Kyme",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 9222,
                            Title = "Grimblades",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3277,
                            Title = "Tales of Heresy",
                            Year = 2009,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4577,
                            Title = "Shadows of Treachery",
                            Year = 2012,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5707,
                            Title = "Vulkan Lives: Unto the Anvil",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17714,
                            Title = "Deathfire",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26942,
                            Title = "Old Earth",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28347,
                            Title = "Born of Flame:  The Hammer and the Anvil",
                            Year = 2018,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 31645,
                            Title = "Heralds of the Siege",
                            Year = 2019,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26537,
                            Title = "Fall of Damnos",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26394,
                            Title = "Salamanders: The Omnibus",
                            Year = 2013,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26393,
                            Title = "Tome of Fire",
                            Year = 2012,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26390,
                            Title = "Salamander",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26391,
                            Title = "Firedrake",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26392,
                            Title = "Nocturne",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15134,
                            Title = "Death & Dishonour",
                            Year = 2010,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15089,
                            Title = "Honourkeeper",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15086,
                            Title = "Oathbreaker",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15221,
                            Title = "The Great Betrayal",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1525,
                    Name = "Terry Goodkind",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3344,
                            Title = "Debt of Bones",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9523,
                            Title = "The Law of Nines",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34109,
                            Title = "The Scribbly Man",
                            Year = 2019,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 12379,
                            Title = "The First Confessor",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 20760,
                            Title = "Death's Mistress",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 26066,
                            Title = "Shroud of Eternity",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31712,
                            Title = "Siege of Stone",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9520,
                            Title = "The Omen Machine",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9521,
                            Title = "The Third Kingdom",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9522,
                            Title = "Severed Souls",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14403,
                            Title = "Warheart",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3321,
                            Title = "Wizard's First Rule",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3338,
                            Title = "Stone of Tears",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3339,
                            Title = "Blood of the Fold",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3340,
                            Title = "Temple of the Winds",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3341,
                            Title = "Soul of the Fire",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3342,
                            Title = "Faith of the Fallen",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3343,
                            Title = "The Pillars of Creation",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3346,
                            Title = "Naked Empire",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3347,
                            Title = "Chainfire",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3348,
                            Title = "Phantom",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3349,
                            Title = "Confessor",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1526,
                    Name = "Gregory Maguire",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 24997,
                            Title = "Hiddensee: A Tale of the Once and Future Nutcracker",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14037,
                            Title = "After Alice",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36362,
                            Title = "Matchless: A Christmas Story",
                            Year = 2009,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6630,
                            Title = "Mirror, Mirror",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25974,
                            Title = "Lost",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6629,
                            Title = "Confessions of an Ugly Stepsister",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3324,
                            Title = "Wicked:  The Life and Times of the Wicked Witch of the West",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3456,
                            Title = "Son of a Witch",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3457,
                            Title = "A Lion Among Men",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3458,
                            Title = "Out of Oz",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1531,
                    Name = "Richard Kadrey",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 33910,
                            Title = "The Grand Dark",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34271,
                            Title = "Ambitious Boys Like You",
                            Year = 2015,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 13194,
                            Title = "Dead Set",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9821,
                            Title = "Metrophage",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17966,
                            Title = "The Everything Box",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22576,
                            Title = "The Wrong Dead Guy",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3371,
                            Title = "Sandman Slim",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3372,
                            Title = "Kill the Dead",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3373,
                            Title = "Aloha from Hell",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9549,
                            Title = "Devil Said Bang",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9550,
                            Title = "Kill City Blues",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9551,
                            Title = "The Getaway God",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13193,
                            Title = "Killing Pretty",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 18882,
                            Title = "The Perdition Score",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23173,
                            Title = "The Kill Society",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28465,
                            Title = "Hollywood Dead",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1558,
                    Name = "Thomas Ligotti",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 19231,
                            Title = "Songs of a Dead Dreamer and Grimscribe",
                            Year = 2015,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 9561,
                            Title = "The Spectral Link",
                            Year = 2014,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17245,
                            Title = "The Conspiracy Against the Human Race",
                            Year = 2011,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 11178,
                            Title = "Teatro Grottesco",
                            Year = 2006,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 4616,
                            Title = "The Shadow at the Bottom of the World",
                            Year = 2005,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 24626,
                            Title = "The Nightmare Factory",
                            Year = 1996,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 24643,
                            Title = "Noctuary",
                            Year = 1994,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 24644,
                            Title = "Grimscribe: His Lives and Works",
                            Year = 1991,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 23941,
                            Title = "The Last Feast of Harlequin",
                            Year = 1990,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 3505,
                            Title = "Songs of a Dead Dreamer",
                            Year = 1986,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1569,
                    Name = "Chet Williamson",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3527,
                            Title = "Reign",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 3516,
                            Title = "Ash Wednesday",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 23922,
                            Title = "'Yore Skin's Jes's Soft 'N Purty...' He Said. (Page 243) ",
                            Year = 1989,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1596,
                    Name = "Douglas Clegg",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3576,
                            Title = "The Hour Before Dark",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 12200,
                            Title = "Mordred, Bastard Son",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32683,
                            Title = "You Come When I Call You",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 32686,
                            Title = "The Nightmare Chronicles",
                            Year = 1999,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 32682,
                            Title = "The Halloween Man",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 32685,
                            Title = "Dark of the Eye",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 32681,
                            Title = "Neverland",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 32684,
                            Title = "Breeder",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 32680,
                            Title = "Goat Dance",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 35241,
                            Title = "Bad Karma",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1619,
                    Name = "Ernest Cline",
                    Nominations = 3,
                    Wins = 1,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 13119,
                            Title = "Armada:  A Novel",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3630,
                            Title = "Ready Player One",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1647,
                    Name = "Anthony Huso",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 7335,
                            Title = "The Last Page",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3786,
                            Title = "Black Bottle",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1662,
                    Name = "John Love",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3879,
                            Title = "Faith",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1673,
                    Name = "Andy Remic",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 14047,
                            Title = "The Dragon Engine",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19489,
                            Title = "Twilight of the Dragons",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4962,
                            Title = "Theme Planet",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3975,
                            Title = "Toxicity",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8563,
                            Title = "Kell's Legend",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 8564,
                            Title = "Soul Stealers",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 8565,
                            Title = "Vampire Warlords",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 8560,
                            Title = "The Iron Wolves",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 8561,
                            Title = "The White Towers",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16855,
                            Title = "A Song for No Man's Land",
                            Year = 2016,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 18866,
                            Title = "Return of Souls",
                            Year = 2016,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 20639,
                            Title = "The Iron Beast",
                            Year = 2016,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1684,
                    Name = "Kim Westwood",
                    Nominations = 3,
                    Wins = 1,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 4066,
                            Title = "The Courier's New Bicycle",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11505,
                            Title = "The Daughters of Moab",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1723,
                    Name = "Douglas Hulick",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 4155,
                            Title = "Among Thieves",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13261,
                            Title = "Sworn in Steel",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1757,
                    Name = "James Phelan",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 4306,
                            Title = "Chasers",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19421,
                            Title = "Survivor",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19422,
                            Title = "Quarantine",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1774,
                    Name = "Lars Kepler",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 4397,
                            Title = "The Hypnotist",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1788,
                    Name = "Mazarkis Williams",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 4454,
                            Title = "The Emperor's Knife",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5581,
                            Title = "Knife Sworn",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5582,
                            Title = "The Tower Broken",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1830,
                    Name = "John Langan",
                    Nominations = 2,
                    Wins = 1,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 19524,
                            Title = "The Fisherman",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 13605,
                            Title = "The Wide, Carnivorous Sky:  and Other Monstrous Geographies",
                            Year = 2013,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 22516,
                            Title = "Renfrew's Course",
                            Year = 2012,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17195,
                            Title = "Creatures:  Thirty Years of Monsters",
                            Year = 2011,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 28870,
                            Title = "Technicolor",
                            Year = 2009,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 35266,
                            Title = "The Wide, Carnivorous Sky",
                            Year = 2009,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 4612,
                            Title = "Mr. Gaunt and Other Uneasy Encounters",
                            Year = 2008,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1867,
                    Name = "Janet Edwards",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 4912,
                            Title = "Earth Girl",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6150,
                            Title = "Earth Star",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11963,
                            Title = "Earth Flight",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1899,
                    Name = "Ann Aguirre",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 6013,
                            Title = "Blue Diablo",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6014,
                            Title = "Hell Fire",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6015,
                            Title = "Shady Lady",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6016,
                            Title = "Devil's Punch",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6017,
                            Title = "Agave Kiss",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13840,
                            Title = "Perdition",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13841,
                            Title = "Havoc",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13842,
                            Title = "Breakout",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27490,
                            Title = "Honor Among Thieves",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32310,
                            Title = "Honor Bound",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 36037,
                            Title = "Honor Lost",
                            Year = 2020,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16677,
                            Title = "Foundation",
                            Year = 2012,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6018,
                            Title = "Enclave",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6019,
                            Title = "Outpost",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6020,
                            Title = "Horde",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5097,
                            Title = "Grimspace",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5098,
                            Title = "Wanderlust",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5099,
                            Title = "Doubleblind",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5100,
                            Title = "Killbox",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5101,
                            Title = "Aftermath",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5102,
                            Title = "Endgame",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1933,
                    Name = "Aaron Johnston",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 12228,
                            Title = "Invasive Procedures",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5328,
                            Title = "Earth Unaware",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5329,
                            Title = "Earth Afire",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7389,
                            Title = "Earth Awakens",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19522,
                            Title = "The Swarm",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 33886,
                            Title = "The Hive",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1971,
                    Name = "Aidan Harte",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 5544,
                            Title = "Irenicon",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5545,
                            Title = "The Warring States",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13262,
                            Title = "Spira Mirabilis",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1974,
                    Name = "Toni L.P. Kelner",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 12319,
                            Title = "Dead But Not Forgotten",
                            Year = 2014,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10016,
                            Title = "Games Creatures Play",
                            Year = 2014,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5551,
                            Title = "An Apple for the Creature",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 5550,
                            Title = "Home Improvement: Undead Edition",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1984,
                    Name = "Snorri Kristjansson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27136,
                            Title = "Kin",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5567,
                            Title = "Swords of Good Men",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11877,
                            Title = "Blood Will Follow",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13267,
                            Title = "Path of Gods",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2003,
                    Name = "Peg Kerr",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 5655,
                            Title = "The Wild Swans",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5656,
                            Title = "Emerald House Rising",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2013,
                    Name = "Richard Parks",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 30110,
                            Title = "The Manor of Lost Time",
                            Year = 2014,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 22260,
                            Title = "Cherry Blossoms on the River of Souls",
                            Year = 2013,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5683,
                            Title = "The Heavenly Fox",
                            Year = 2011,
                            Type = BookType.Novella,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16297,
                            Title = "Four Horsemen, at Their Leisure",
                            Year = 2010,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24287,
                            Title = "On the Banks of the River of Heaven",
                            Year = 2010,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23244,
                            Title = "The Queen's Reason",
                            Year = 2010,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 22647,
                            Title = "The Man Who Carved Skulls",
                            Year = 2007,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31782,
                            Title = "Empty Places",
                            Year = 2005,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31738,
                            Title = "Moon Viewing at Shijo Bridge",
                            Year = 2006,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 8370,
                            Title = "Yamada Monogatari:  Demon Hunter",
                            Year = 2013,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14165,
                            Title = "Yamada Monogatari: To Break the Demon Gate",
                            Year = 2014,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14166,
                            Title = "Yamada Monogatari: The War God's Son",
                            Year = 2015,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19527,
                            Title = "Yamada Monogatari:  The Emperor in Shadow",
                            Year = 2016,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2037,
                    Name = "Marianne de Pierres",
                    Nominations = 7,
                    Wins = 2,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 5811,
                            Title = "Burn Bright",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5812,
                            Title = "Angel Arias",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5813,
                            Title = "Shine Light",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6055,
                            Title = "Nylon Angel",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6056,
                            Title = "Code Noir",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6057,
                            Title = "Crash Deluxe",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7023,
                            Title = "Peacemaker",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14049,
                            Title = "Mythmaker",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5817,
                            Title = "Dark Space",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5818,
                            Title = "Chaos Space",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5819,
                            Title = "Mirror Space",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5820,
                            Title = "Transformation Space",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2050,
                    Name = "Steven Brust",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 26984,
                            Title = "Good Guys",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16522,
                            Title = "The Desecrator",
                            Year = 2011,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5931,
                            Title = "Freedom & Necessity",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5930,
                            Title = "Agyar",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5929,
                            Title = "The Gypsy",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5928,
                            Title = "Cowboy Feng's Space Bar and Grille",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5908,
                            Title = "Brokedown Palace",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14453,
                            Title = "To Reign in Hell",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17782,
                            Title = "When the Bow Breaks",
                            Year = 1998,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16895,
                            Title = "Fireworks in the Rain",
                            Year = 2013,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5932,
                            Title = "The Incrementalists",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19490,
                            Title = "The Skill of Our Hands",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5909,
                            Title = "The Phoenix Guards",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5910,
                            Title = "Five Hundred Years After",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5911,
                            Title = "The Paths of the Dead",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5912,
                            Title = "The Lord of Castle Black",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5913,
                            Title = "Sethra Lavode",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5927,
                            Title = "The Sun, the Moon, and the Stars",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5914,
                            Title = "Jhereg",
                            Year = 1983,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5915,
                            Title = "Yendi",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5916,
                            Title = "Teckla",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5917,
                            Title = "Taltos",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5918,
                            Title = "Phoenix",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5919,
                            Title = "Athyra",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5920,
                            Title = "Orca",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5921,
                            Title = "Dragon",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5922,
                            Title = "Issola",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5923,
                            Title = "Dzur",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5924,
                            Title = "Jhegaala",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5925,
                            Title = "Iorich",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5926,
                            Title = "Tiassa",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9519,
                            Title = "Hawk",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24816,
                            Title = "Vallista",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2074,
                    Name = "Christopher Rice",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 6123,
                            Title = "The Heavens Rise",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 11228,
                            Title = "The Vines",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 26016,
                            Title = "Ramses the Damned:  The Passion of Cleopatra",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 2081,
                    Name = "Ramez Naam",
                    Nominations = 6,
                    Wins = 2,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22834,
                            Title = "Water",
                            Year = 2013,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6147,
                            Title = "Nexus",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8570,
                            Title = "Crux",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11093,
                            Title = "Apex",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2097,
                    Name = "John F. Carr",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21400,
                            Title = "The Science Fiction Yearbook",
                            Year = 1985,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35786,
                            Title = "The Ophidian Conspiracy",
                            Year = 1976,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 36377,
                            Title = "H. Beam Piper: A Biography",
                            Year = 2008,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18041,
                            Title = "The Endless Frontier, Vol. II",
                            Year = 1982,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18014,
                            Title = "Cities in Space",
                            Year = 1991,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18050,
                            Title = "Life Among the Asteroids",
                            Year = 1992,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7503,
                            Title = "Nebula Award Stories Sixteen",
                            Year = 1982,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21141,
                            Title = "There Will Be War",
                            Year = 1983,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2129,
                    Name = "Karen Russell",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 32531,
                            Title = "Orange World and Other Stories",
                            Year = 2019,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28795,
                            Title = "The Bad Graft",
                            Year = 2014,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 8143,
                            Title = "Sleep Donation",
                            Year = 2014,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7826,
                            Title = "Vampires in the Lemon Grove",
                            Year = 2013,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7825,
                            Title = "Swamplandia! ",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7824,
                            Title = "St. Lucy's Home for Girls Raised by Wolves ",
                            Year = 2006,
                            Type = BookType.Collection,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2136,
                    Name = "Jeanette Winterson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21915,
                            Title = "Christmas Days:  12 Stories and 12 Feasts for 12 Days",
                            Year = 2013,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7857,
                            Title = "The Daylight Gate",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 7856,
                            Title = "The Battle of the Sun",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7855,
                            Title = "The Stone Gods",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7854,
                            Title = "Tanglewreck",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7853,
                            Title = "The PowerBook",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7852,
                            Title = "Art & Lies",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7851,
                            Title = "Sexing the Cherry",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9015,
                            Title = "The Passion",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9065,
                            Title = "Oranges Are Not the Only Fruit",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9016,
                            Title = "Weight:  The Myth of Atlas and Heracles",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35482,
                            Title = "Frankissstein: A Love Story",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2149,
                    Name = "Melina Marchetta",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 7889,
                            Title = "Finnikin of the Rock",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7929,
                            Title = "Froi of the Exiles",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7930,
                            Title = "Quintana of Charyn",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2167,
                    Name = "Shannon Hale",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 25109,
                            Title = "Book of a Thousand Days",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7960,
                            Title = "The Goose Girl ",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7961,
                            Title = "Enna Burning ",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7962,
                            Title = "River Secrets ",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7963,
                            Title = "Forest Born ",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2184,
                    Name = "Veronica Schanoes",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 16694,
                            Title = "Ballroom Blitz",
                            Year = 2015,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 8117,
                            Title = "Among the Thorns",
                            Year = 2014,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 8118,
                            Title = "Burning Girls",
                            Year = 2013,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2187,
                    Name = "Kathryn Davis",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 8121,
                            Title = "Duplex",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 8966,
                            Title = "The Thin Place",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16933,
                            Title = "Hell",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 8967,
                            Title = "The Girl Who Trod on A Loaf",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2215,
                    Name = "Terry Richard Bazes",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 8258,
                            Title = "Lizard World",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 2266,
                    Name = "Raymond F. Jones",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21512,
                            Title = "Rat Race",
                            Year = 1966,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8473,
                            Title = "This Island Earth",
                            Year = 1952,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12926,
                            Title = "The Alien",
                            Year = 1951,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12911,
                            Title = "The Secret People",
                            Year = 1956,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10374,
                            Title = "Son of the Stars",
                            Year = 1952,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10385,
                            Title = "Planet of Light",
                            Year = 1953,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10387,
                            Title = "The Year When Stardust Fell",
                            Year = 1958,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2289,
                    Name = "Ambrose G. Bierce",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 8749,
                            Title = "Terror By Night:  Classic Ghost and Horror Stories",
                            Year = 2011,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 12425,
                            Title = "The Complete Short Stories of Ambrose Bierce",
                            Year = 1970,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 35465,
                            Title = "An Occurrence at Owl Creek Bridge",
                            Year = 1890,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 2298,
                    Name = "Julie Phillips",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 8770,
                            Title = "James Tiptree, Jr:  The Double Life of Alice B. Sheldon",
                            Year = 2006,
                            Type = BookType.NonFiction,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2320,
                    Name = "John Peel",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 12068,
                            Title = "Evolution",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8807,
                            Title = "War of the Daleks",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8818,
                            Title = "Legacy of the Daleks",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9166,
                            Title = "Timewyrm: Genesys",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15831,
                            Title = "Independence",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19842,
                            Title = "Objective: Bajor",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20574,
                            Title = "Prisoners of Peace",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20573,
                            Title = "Field Trip",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19866,
                            Title = "Here There Be Dragons",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19864,
                            Title = "The Death of Princes",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2327,
                    Name = "George W. M. Reynolds",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34648,
                            Title = " The Necromancer:  A Romance",
                            Year = 1857,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 8814,
                            Title = "Wagner the Werewolf",
                            Year = 1848,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 2357,
                    Name = "Sally Green",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 8879,
                            Title = "Half Bad",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36691,
                            Title = "Half Wild",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36692,
                            Title = "Half Lost",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36693,
                            Title = "The Smoke Thieves",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36694,
                            Title = "The Demon World",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36695,
                            Title = "The Burning Kingdoms",
                            Year = 2020,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2403,
                    Name = "Benjamin Parzybok",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 9063,
                            Title = "Sherwood Nation",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22560,
                            Title = "Bear and Shifty",
                            Year = 2012,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9062,
                            Title = "Couch",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2423,
                    Name = "Louise Cooper",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36036,
                            Title = "Mirage",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36035,
                            Title = "The Book of Paradox",
                            Year = 1973,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36058,
                            Title = "Blood Summer",
                            Year = 1976,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 36059,
                            Title = "In Memory of Sarah Bailey",
                            Year = 1977,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 9133,
                            Title = "Nemesis ",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9134,
                            Title = "Inferno",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9135,
                            Title = "Infanta",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9136,
                            Title = "Nocturne ",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9137,
                            Title = "Troika",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9138,
                            Title = "Avatar ",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9139,
                            Title = "Revenant ",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9140,
                            Title = "Aisling",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9128,
                            Title = "Rip Tide",
                            Year = 2003,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21916,
                            Title = "The Initiate",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 21917,
                            Title = "The Outcast",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 21918,
                            Title = "The Master",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2427,
                    Name = "Don DeLillo",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21838,
                            Title = "Zero K",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9159,
                            Title = "The Body Artist",
                            Year = 2001,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9158,
                            Title = "Underworld",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9157,
                            Title = "Libra ",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9155,
                            Title = "White Noise ",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21945,
                            Title = "Ratner's Star",
                            Year = 1976,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2478,
                    Name = "Masumi Washington",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 10258,
                            Title = "The Battle Royale Slam Book",
                            Year = 2014,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9456,
                            Title = "The Future Is Japanese",
                            Year = 2012,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9455,
                            Title = "Phantasm Japan:  Fantasies Light and Dark, From and About Japan",
                            Year = 2014,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13777,
                            Title = "Hanzai Japan:  Fantastical, Futuristic Stories of Crime",
                            Year = 2015,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2481,
                    Name = "James Branch Cabell",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 13349,
                            Title = "Figures of Earth",
                            Year = 1921,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10436,
                            Title = "The Silver Stallion",
                            Year = 1926,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10434,
                            Title = "Domnei",
                            Year = 1913,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9491,
                            Title = "Jurgen: A Comedy of Justice",
                            Year = 1919,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10435,
                            Title = "The High Place",
                            Year = 1923,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36034,
                            Title = "Gallantry:  An Eighteenth Century Dizain in Ten Comedies, with an Afterpiece",
                            Year = 1907,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10437,
                            Title = "Something About Eve",
                            Year = 1927,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 13348,
                            Title = "The Cream of the Jest",
                            Year = 1917,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2489,
                    Name = "M. P. Shiel",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 9509,
                            Title = "Prince Zaleski and Cummings King Monk",
                            Year = 1977,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 9508,
                            Title = "Shapes in the Fire",
                            Year = 1896,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 9507,
                            Title = "The Purple Cloud",
                            Year = 1901,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2512,
                    Name = "Anna Kashina",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34049,
                            Title = "Shadowblade",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9715,
                            Title = "Blades of the Old Empire",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9716,
                            Title = "The Guild of Assassins",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34048,
                            Title = "Assassin Queen",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2528,
                    Name = "David Herter",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 16708,
                            Title = "Islands off the Coast of Capitola, 1978",
                            Year = 2015,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9873,
                            Title = "Evening's Empire",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9763,
                            Title = "Ceres Storm",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2558,
                    Name = "John DeChancie",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35348,
                            Title = "Innerverse",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35347,
                            Title = "Living with Aliens",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35345,
                            Title = "The Kruton Interface",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35346,
                            Title = "MagicNet",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 12921,
                            Title = "Crooked House",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 9859,
                            Title = "Starrigger",
                            Year = 1983,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9860,
                            Title = "Red Limit Freeway",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9862,
                            Title = "Paradox Alley",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2579,
                    Name = "Carlos Ruiz Zaf├│n",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 9982,
                            Title = "Marina",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9976,
                            Title = "The Shadow of the Wind",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9977,
                            Title = "The Angel's Game",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9978,
                            Title = "The Prisoner of Heaven",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9979,
                            Title = "The Prince of Mist",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9980,
                            Title = "The Midnight Palace",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9981,
                            Title = "The Watcher in the Shadows",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2580,
                    Name = "Jenni Fagan",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 19691,
                            Title = "The Sunlight Pilgrims",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9985,
                            Title = "The Panopticon",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2618,
                    Name = "Katherine Neville",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 10256,
                            Title = "The Magic Circle",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10254,
                            Title = "The Eight",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10255,
                            Title = "The Fire",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2621,
                    Name = "Yukito Ayatsuji",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 10259,
                            Title = "Another",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 18676,
                            Title = "Another Episode S/O",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 2673,
                    Name = "Paolo Mantegazza",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 10478,
                            Title = "The Year 3000: A Dream",
                            Year = 1897,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2676,
                    Name = "Theodore R. Cogswell",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 31666,
                            Title = "The Specter General",
                            Year = 1952,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11633,
                            Title = "Spock, Messiah!",
                            Year = 1977,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2716,
                    Name = "J. M. Dillard",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 10626,
                            Title = "Emissary",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11680,
                            Title = "Surak's Soul",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10632,
                            Title = "The Expanse",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11581,
                            Title = "Star Trek: The Final Frontier",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11582,
                            Title = "Star Trek: The Undiscovered Country",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11583,
                            Title = "Star Trek: Generations",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11584,
                            Title = "Star Trek: First Contact",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11585,
                            Title = "Star Trek: Insurrection",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11586,
                            Title = "Star Trek: Nemesis",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11678,
                            Title = "Resistance",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11679,
                            Title = "Possession",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11673,
                            Title = "Mindshadow",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11674,
                            Title = "Demons",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11675,
                            Title = "Bloodthirst",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11676,
                            Title = "The Lost Years",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11677,
                            Title = "Recovery",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2737,
                    Name = "Ichiro Sakaki",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 10685,
                            Title = "A Tale of Destiny",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10686,
                            Title = "Song of the Forgiven",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10687,
                            Title = "Requiem for the Infidels",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2748,
                    Name = "Ruth Plumly Thompson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 10744,
                            Title = "The Royal Book of Oz",
                            Year = 1921,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10745,
                            Title = "Kabumpo in Oz",
                            Year = 1922,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10746,
                            Title = "The Cowardly Lion of Oz",
                            Year = 1923,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10747,
                            Title = "Grampa in Oz",
                            Year = 1924,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10748,
                            Title = "The Lost King of Oz",
                            Year = 1925,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10749,
                            Title = "The Hungry Tiger of Oz",
                            Year = 1926,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10750,
                            Title = "The Gnome King of Oz",
                            Year = 1927,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10751,
                            Title = "The Giant Horse of Oz",
                            Year = 1928,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10752,
                            Title = "Jack Pumpkinhead of Oz",
                            Year = 1929,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10753,
                            Title = "The Yellow Knight of Oz",
                            Year = 1930,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10754,
                            Title = "Pirates in Oz",
                            Year = 1931,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10755,
                            Title = "The Purple Prince of Oz",
                            Year = 1932,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10756,
                            Title = "Ojo in Oz",
                            Year = 1933,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10757,
                            Title = "Speedy in Oz",
                            Year = 1934,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10758,
                            Title = "The Wishing Horse of Oz",
                            Year = 1935,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10759,
                            Title = "Captain Salt in Oz",
                            Year = 1936,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10762,
                            Title = "Handy Mandy in Oz",
                            Year = 1937,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10763,
                            Title = "The Silver Princess in Oz",
                            Year = 1938,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10764,
                            Title = "Ozoplaning with the Wizard of Oz",
                            Year = 1939,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2797,
                    Name = "I. O. Evans",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11007,
                            Title = "Science Fiction Through the Ages 1",
                            Year = 1966,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11008,
                            Title = "Science Fiction Through the Ages 2",
                            Year = 1966,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2844,
                    Name = "Sarah Beth Durst",
                    Nominations = 3,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27872,
                            Title = "The Stone Girl's Story",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11198,
                            Title = "Vessel",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 22005,
                            Title = "Drink, Slay, Love",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11197,
                            Title = "Ice",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19945,
                            Title = "The Queen of Blood",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23599,
                            Title = "The Reluctant Queen",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32414,
                            Title = "The Queen of Sorrow",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31584,
                            Title = "The Deepest Blue",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11286,
                            Title = "Into the Wild",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11287,
                            Title = "Out of the Wild",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2846,
                    Name = "Thomas M. K. Stratman",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11201,
                            Title = "Cthulhu's Heirs:  New Cthulhu Mythos Fiction",
                            Year = 1994,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 2881,
                    Name = "Pearl North",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11268,
                            Title = "Libyrinth",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11269,
                            Title = "The Boy from Ilysies",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11270,
                            Title = "The Book of the Night",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2914,
                    Name = "Sylvia Kelso",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11471,
                            Title = "Amberlight",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11472,
                            Title = "Riversend",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11473,
                            Title = "Source",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11469,
                            Title = "Everran's Bane",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11468,
                            Title = "The Moving Water",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11467,
                            Title = "The Red Country",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11470,
                            Title = "The Seagull",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34766,
                            Title = "Three Observations and a Dialogue:  Round and About SF",
                            Year = 2009,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34655,
                            Title = "Spring in Geneva",
                            Year = 2013,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2934,
                    Name = "Cyrano de Bergerac",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11501,
                            Title = "Voyages to the Moon and the Sun",
                            Year = 1657,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2940,
                    Name = "Amie Kaufman",
                    Nominations = 8,
                    Wins = 2,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34051,
                            Title = "Aurora Rising",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15934,
                            Title = "Illuminae",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20473,
                            Title = "Gemina",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27022,
                            Title = "Obsidio",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11519,
                            Title = "These Broken Stars",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11520,
                            Title = "This Shattered World",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11521,
                            Title = "Their Fractured Light",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27021,
                            Title = "Unearthed",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34050,
                            Title = "Undying",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2971,
                    Name = "Carmen Carter",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 14717,
                            Title = "The Devil's Heart",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14718,
                            Title = "The Children of Hamlin",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14709,
                            Title = "Doomsday World",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14716,
                            Title = "Dreams of the Raven",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2985,
                    Name = "Jodi Taylor",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 23994,
                            Title = "The Long and Short of It",
                            Year = 2017,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11652,
                            Title = "Just One Damned Thing After Another",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11653,
                            Title = "A Symphony of Echoes",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11654,
                            Title = "A Second Chance",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11655,
                            Title = "A Trail Through Time",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11810,
                            Title = "No Time Like The Past",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14223,
                            Title = "What Could Possibly Go Wrong?",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14573,
                            Title = "Lies, Damned Lies, and History",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23993,
                            Title = "And the Rest Is History",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27065,
                            Title = "An Argumentation of Historians",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34007,
                            Title = "Hope for the Best",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35769,
                            Title = "Plan for the Worst",
                            Year = 2020,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34612,
                            Title = "Doing Time",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36612,
                            Title = "Hard Time",
                            Year = 2020,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27043,
                            Title = "White Silence",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31460,
                            Title = "Dark Light",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 27044,
                            Title = "The Nothing Girl",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27045,
                            Title = "The Something Girl",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3003,
                    Name = "Chrysostom Trueman",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11757,
                            Title = "The History of a Voyage to the Moon",
                            Year = 1864,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3007,
                    Name = "Max Valier",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11764,
                            Title = "A Daring Trip to Mars",
                            Year = 1928,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3012,
                    Name = "J. Leslie Mitchell",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11770,
                            Title = "Three Go Back",
                            Year = 1932,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3018,
                    Name = "W. C. Morrow",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11778,
                            Title = "Lentala of the South Seas:  The Romantic Tale of a Lost Colony",
                            Year = 1908,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3050,
                    Name = "Keri Arthur",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11845,
                            Title = "Fireborn",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11846,
                            Title = "Wicked Embers",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 21409,
                            Title = "Flameout",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25478,
                            Title = "Ashes Reborn",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3076,
                    Name = "Ambelin Kwaymullina",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11892,
                            Title = "The Interrogation of Ashala Wolf",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11893,
                            Title = "The Disappearance of Ember Crow",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3144,
                    Name = "Terry Nation",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 12123,
                            Title = "The Dalek Pocketbook and Space Travellers Guide",
                            Year = 1965,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3149,
                    Name = "Colin Wilson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36088,
                            Title = "The Personality Surgeon",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12698,
                            Title = "The Space Vampires",
                            Year = 1976,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12154,
                            Title = "The Philosopher's Stone",
                            Year = 1969,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 12699,
                            Title = "The Mind Parasites",
                            Year = 1967,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 22014,
                            Title = "Ritual in the Dark",
                            Year = 1960,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 22015,
                            Title = "Man Without a Shadow",
                            Year = 1963,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 22016,
                            Title = "The God of the Labyrinth",
                            Year = 1970,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 22551,
                            Title = "The Haunted Man: The Strange Genius of David Lindsay",
                            Year = 1979,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3158,
                    Name = "Osamu Dazai",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 12208,
                            Title = "Blue Bamboo:  Tales of Fantasy and Romance",
                            Year = 1945,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3168,
                    Name = "Gael Baudino",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 12240,
                            Title = "Gossamer Axe",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28179,
                            Title = "Dragonsword",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28180,
                            Title = "Duel of Dragons",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28181,
                            Title = "Dragon Death",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28186,
                            Title = "Spires of Spirit",
                            Year = 1997,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28182,
                            Title = "Strands of Starlight",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28183,
                            Title = "Maze of Moonlight",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28184,
                            Title = "Shroud of Shadow",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28185,
                            Title = "Strands of Sunlight",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28187,
                            Title = "O Greenest Branch!",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28188,
                            Title = "The Dove Looked In",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28189,
                            Title = "Branch and Crown",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3177,
                    Name = "Nathan Burgoine",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 12251,
                            Title = "Light ",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3264,
                    Name = "Katya Reimann",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 12491,
                            Title = "The Wanderer",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 12485,
                            Title = "Wind From a Foreign Sky",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 12486,
                            Title = "A Tremor in the Bitter Earth",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 12487,
                            Title = "Prince of Fire and Ashes",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3291,
                    Name = "John Kendrick Bangs",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17163,
                            Title = "The Enchanted Type-Writer",
                            Year = 1899,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 12856,
                            Title = "Olympian Nights",
                            Year = 1902,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3311,
                    Name = "John Taine",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 12982,
                            Title = "Seeds of Life",
                            Year = 1931,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3367,
                    Name = "Dorothy Madlee",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 13366,
                            Title = "Star Ka'at",
                            Year = 1976,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13367,
                            Title = "Star Ka'at World",
                            Year = 1978,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13368,
                            Title = "Star Ka'ats and the Plant People ",
                            Year = 1979,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13369,
                            Title = "Star Ka'ats and the Winged Warriors",
                            Year = 1981,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3397,
                    Name = "Ilona Andrews",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 31838,
                            Title = "Kinsmen Universe",
                            Year = 2018,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18801,
                            Title = "On the Edge",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 18802,
                            Title = "Bayou Moon",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 18803,
                            Title = "Fate's Edge",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 18804,
                            Title = "Steel's Edge",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36295,
                            Title = "Pay Me",
                            Year = 2020,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36294,
                            Title = "A Misunderstanding",
                            Year = 2019,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36292,
                            Title = "Diamond Fire",
                            Year = 2018,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36285,
                            Title = "Burn for Me",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36286,
                            Title = "White Hot",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36290,
                            Title = "Wildfire",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36291,
                            Title = "Sapphire Flames",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36293,
                            Title = "Emerald Blaze",
                            Year = 2020,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23902,
                            Title = "The Innkeeper Chronicles: Volume One",
                            Year = 2017,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36283,
                            Title = "Sweep of the Blade",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36284,
                            Title = "Sweep with Me",
                            Year = 2020,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35804,
                            Title = "Small Magics",
                            Year = 2019,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13594,
                            Title = "Magic Bites",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13595,
                            Title = "Magic Burns",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13596,
                            Title = "Magic Strikes",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13597,
                            Title = "Magic Bleeds",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13598,
                            Title = "Magic Slays",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13599,
                            Title = "Magic Rises",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13600,
                            Title = "Magic Breaks",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13601,
                            Title = "Magic Shifts",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19298,
                            Title = "Magic Binds",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28442,
                            Title = "Magic Triumphs",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3408,
                    Name = "Yasutaka Tsutsui",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 13731,
                            Title = "Paprika",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25033,
                            Title = "The Girl Who Leapt Through Time",
                            Year = 1965,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3458,
                    Name = "Paul Williams",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 13925,
                            Title = "Race, Ethnicity and Nuclear War:  Representations of Nuclear Weapons and Post-Apocalyptic Worlds",
                            Year = 2011,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3468,
                    Name = "Bryan Thomas Schmidt",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35433,
                            Title = "Little Green MenΓÇöAttack!",
                            Year = 2017,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35432,
                            Title = "Galactic Games",
                            Year = 2016,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15936,
                            Title = "Mission: Tomorrow",
                            Year = 2015,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13950,
                            Title = "Shattered Shields",
                            Year = 2014,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27936,
                            Title = "Infinite Stars",
                            Year = 2017,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35434,
                            Title = "Infinite Stars: Dark Frontiers",
                            Year = 2019,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3501,
                    Name = "Mark O. Martin",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 14130,
                            Title = "A Darker Geometry",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3534,
                    Name = "Anna Caltabiano",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 14283,
                            Title = "The Seventh Miss Hatfield",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17515,
                            Title = "The Time of the Clockmaker",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3544,
                    Name = "Anthony Ryan",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20716,
                            Title = "The Waking Fire",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27350,
                            Title = "The Legion of Flame",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32716,
                            Title = "The Empire of Ashes",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34176,
                            Title = "The Wolf's Call",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14375,
                            Title = "Blood Song",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14376,
                            Title = "Tower Lord",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14377,
                            Title = "Queen of Fire",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35510,
                            Title = "A Pilgrimage of Swords",
                            Year = 2019,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3600,
                    Name = "Heather Rose Jones",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 14654,
                            Title = "Daughter of Mystery",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14655,
                            Title = "The Mystic Marriage",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 20385,
                            Title = "Mother of Souls",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3616,
                    Name = "Dan Parkinson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 32794,
                            Title = "Starsong",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14774,
                            Title = "The Covenant of the Forge",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14775,
                            Title = "Hammer and Axe",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14776,
                            Title = "The Swordsheath Scroll",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14740,
                            Title = "The Gates of Thorbardin",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14854,
                            Title = "The Gully Dwarves",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32795,
                            Title = "The Whispers",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32796,
                            Title = "Faces of Infinity",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32797,
                            Title = "Paradox Gate",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32798,
                            Title = "Viper's Spawn",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32799,
                            Title = "The Scavenger",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32800,
                            Title = "Blood Ties",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3633,
                    Name = "Roland J. Green",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 28641,
                            Title = "Voyage to Eneh",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15613,
                            Title = "Women at War",
                            Year = 1995,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25295,
                            Title = "Conan the Valiant",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25296,
                            Title = "Conan the Guardian",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25297,
                            Title = "Conan the Relentless",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25298,
                            Title = "Conan and the Gods of the Mountain",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25299,
                            Title = "Conan at the Demon's Gate",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25300,
                            Title = "Conan and the Mists of Doom",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25301,
                            Title = "Conan and the Death Lord of Thanza",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14882,
                            Title = "Knights of the Crown",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14884,
                            Title = "Knights of the Sword",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14886,
                            Title = "Knights of the Rose",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14888,
                            Title = "The Wayward Knights",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15103,
                            Title = "Clan and Crown",
                            Year = 1982,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15104,
                            Title = "Storms of Victory",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25454,
                            Title = "Jamie the Red",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28633,
                            Title = "Wandor's Ride",
                            Year = 1973,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28635,
                            Title = "Wandor's Journey",
                            Year = 1975,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28637,
                            Title = "Wandor's Voyage",
                            Year = 1979,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28639,
                            Title = "Wandor's Flight",
                            Year = 1981,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3634,
                    Name = "Tina Daniell",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 14938,
                            Title = "Dark Heart",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14939,
                            Title = "The Companions",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14883,
                            Title = "Maquesta Kar-Thon",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3648,
                    Name = "Douglas W. Clark",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 14943,
                            Title = "Saving Solace",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14944,
                            Title = "Protecting Palanthas",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3744,
                    Name = "Nathan Long",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 15583,
                            Title = "Tainted Blood",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15580,
                            Title = "Valnir's Bane",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15581,
                            Title = "The Broken Lance",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15437,
                            Title = "Orcslyer",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15438,
                            Title = "Manslayer",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15439,
                            Title = "Elfslayer",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15440,
                            Title = "Shamanslayer",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15441,
                            Title = "Zombieslayer",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15483,
                            Title = "Bloodborn",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15484,
                            Title = "Bloodforged",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15485,
                            Title = "Bloodsworn",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3790,
                    Name = "Robin D. Laws",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 15694,
                            Title = "Honour of the Grave",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15695,
                            Title = "Sacred Flesh",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15696,
                            Title = "Liar's Peak",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3835,
                    Name = "Edward Gorey",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 15852,
                            Title = "Edward Gorey:  His Book Cover Art and Design",
                            Year = 2015,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 17466,
                            Title = "The Haunted Looking Glass:  Ghost Stories",
                            Year = 1959,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 3863,
                    Name = "Greg Cox",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21099,
                            Title = "Captain to Captain",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20496,
                            Title = "Glass Empires",
                            Year = 2007,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19829,
                            Title = "Devil in the Sky",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19833,
                            Title = "Dragon's Honor",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19974,
                            Title = "The Q Continuum: Q-Space",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19975,
                            Title = "The Q Continuum: Q-Zone",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19976,
                            Title = "The Q Continuum: Q-Strike",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32474,
                            Title = "The Antares Maelstrom",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15980,
                            Title = "Child of Two Worlds",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20125,
                            Title = "Foul Deeds Will Rise",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20126,
                            Title = "No Time Like the Past",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20106,
                            Title = "The Weight of Worlds",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20328,
                            Title = "The Rings of Time",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20003,
                            Title = "Assignment: Eternity",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20103,
                            Title = "The Rise and Fall of Khan Noonien Singh, Volume One",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20104,
                            Title = "The Rise and Fall of Khan Noonien Singh, Volume Two",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20105,
                            Title = "To Reign in Hell: The Exile of Khan Noonien Sing",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20007,
                            Title = "The Black Shore",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25840,
                            Title = "War for the Planet of the Apes",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3879,
                    Name = "Ian Sales",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 16028,
                            Title = "Adrift on the Sea of Rains",
                            Year = 2012,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16029,
                            Title = "The Eye with Which the Universe Beholds Itself",
                            Year = 2013,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16030,
                            Title = "Then Will the Great Ocean Wash Deep Above",
                            Year = 2013,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16031,
                            Title = "All That Outer Space Allows",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3949,
                    Name = "Tom Staicar",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 16358,
                            Title = "Fritz Leiber",
                            Year = 1983,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3963,
                    Name = "Elizabeth Marie Pope",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 16389,
                            Title = "The Perilous Gard",
                            Year = 1974,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16390,
                            Title = "The Sherwood Ring",
                            Year = 1958,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4022,
                    Name = "Cecil Castellucci",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 16722,
                            Title = "The Sound of Useless Wings",
                            Year = 2015,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16721,
                            Title = "We Have Always Lived on Mars",
                            Year = 2013,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16720,
                            Title = "Brother. Prince. Snake.",
                            Year = 2012,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19881,
                            Title = "First Day on Earth",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19884,
                            Title = "Geektastic:  Stories from the Nerd Herd",
                            Year = 2009,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17239,
                            Title = "Moving Target",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19882,
                            Title = "Tin Star",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19883,
                            Title = "Stone in the Sky",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4036,
                    Name = "P. J. Manney",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 16780,
                            Title = "(R)evolution",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16781,
                            Title = "(ID)entity",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4047,
                    Name = "Hideyuki Kikuchi",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 18353,
                            Title = "A Wind Named Amnesia",
                            Year = 1983,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16835,
                            Title = "Vampire Hunter D",
                            Year = 1983,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16864,
                            Title = "Raiser of Gales",
                            Year = 1984,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16865,
                            Title = "Demon Deathchase",
                            Year = 1985,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16866,
                            Title = "Tale of the Dead Town",
                            Year = 1986,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16867,
                            Title = "The Stuff of Dreams",
                            Year = 1986,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16868,
                            Title = "Pilgrimage of the Sacred and the Profane",
                            Year = 1988,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16869,
                            Title = "Mysterious Journey to the North Sea:  Part One",
                            Year = 1988,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16870,
                            Title = "Mysterious Journey to the North Sea:  Part Two",
                            Year = 1988,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16871,
                            Title = "The Rose Princess",
                            Year = 1994,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16872,
                            Title = "Dark Nocturne",
                            Year = 2008,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16873,
                            Title = "Pale Fallen Angel:  Parts One and Two",
                            Year = 1994,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16874,
                            Title = "Pale Fallen Angel:  Parts Three and Four",
                            Year = 1995,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16875,
                            Title = "Twin-Shadowed Knight:  Parts One and Two",
                            Year = 1996,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16876,
                            Title = "Dark Road:  Parts One and Two",
                            Year = 1999,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16877,
                            Title = "Dark Road:  Part Three",
                            Year = 1999,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16878,
                            Title = "Tyrant's Stars:  Parts One and Two",
                            Year = 2000,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16879,
                            Title = "Tyrant's Stars:  Parts Three and Four",
                            Year = 2001,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16880,
                            Title = "Fortress of the Elder God",
                            Year = 2001,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16881,
                            Title = "Mercenary Road",
                            Year = 2003,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16882,
                            Title = "Scenes from an Unholy War",
                            Year = 2003,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16883,
                            Title = "Record of the Blood Battle",
                            Year = 2004,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16884,
                            Title = "White Devil Mountain:  Parts One and Two",
                            Year = 2005,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16885,
                            Title = "Iriya the Berserker",
                            Year = 2007,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 16886,
                            Title = "Throng of Heretics",
                            Year = 2007,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 20163,
                            Title = "Undead Island",
                            Year = 2008,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 22292,
                            Title = "Bedeviled Stagecoach",
                            Year = 2009,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 28158,
                            Title = "Nightmare Village",
                            Year = 2010,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 33938,
                            Title = "The Tiger in Winter",
                            Year = 2011,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 36149,
                            Title = "Noble Front",
                            Year = 2012,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 4054,
                    Name = "P. G. Wodehouse",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 16929,
                            Title = "Laughing Gas",
                            Year = 1936,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4076,
                    Name = "Gennifer Albin",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17006,
                            Title = "The Girl in the High Tower",
                            Year = 2014,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17005,
                            Title = "The Rain Is a Lie",
                            Year = 2013,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17004,
                            Title = "The Department of Alterations",
                            Year = 2012,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17014,
                            Title = "Crewel",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17015,
                            Title = "Altered",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17016,
                            Title = "Unraveled",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4077,
                    Name = "Peter Schweighofer",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17007,
                            Title = "Tales from the Empire",
                            Year = 1997,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17009,
                            Title = "Tales from the New Republic",
                            Year = 1999,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4081,
                    Name = "Judith Reeves-Stevens",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17025,
                            Title = "The Day of Descent",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20036,
                            Title = "The Fall of Terok Nor",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20037,
                            Title = "The War of the Prophets",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20038,
                            Title = "Inferno",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20929,
                            Title = "Collision Course",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20935,
                            Title = "Spectre",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20936,
                            Title = "Dark Victory",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20937,
                            Title = "Preserver",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20934,
                            Title = "Odyssey",
                            Year = 1998,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20931,
                            Title = "The Ashes of Eden",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20932,
                            Title = "The Return",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20933,
                            Title = "Avenger",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20938,
                            Title = "Captain's Peril",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20939,
                            Title = "Captain's Blood",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20940,
                            Title = "Captain's Glory",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20558,
                            Title = "Federation",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20248,
                            Title = "Memory Prime",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20249,
                            Title = "Prime Directive",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4085,
                    Name = "Ryo Suzukaze",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17030,
                            Title = "Before the Fall",
                            Year = 2011,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17031,
                            Title = "Kuklo Unbound",
                            Year = 2012,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4087,
                    Name = "Tamara Vardomskaya",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17033,
                            Title = "Acrobatic Duality",
                            Year = 2015,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4104,
                    Name = "Charlotte Douglas",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17121,
                            Title = "The Battle of Betazed",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4126,
                    Name = "Kelly McCullough",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27293,
                            Title = "Magic, Madness, and Mischief",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27292,
                            Title = "School for Sidekicks",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17228,
                            Title = "The Totally Secret Origin of Foxman: Excerpts from an EPIC Autobiography",
                            Year = 2015,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27286,
                            Title = "Blade in Shadow",
                            Year = 2013,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27280,
                            Title = "Broken Blade",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27281,
                            Title = "Bared Blade",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27282,
                            Title = "Crossed Blades",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27283,
                            Title = "Blade Reforged",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27284,
                            Title = "Drawn Blades",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27285,
                            Title = "Darkened Blade",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27287,
                            Title = "WebMage",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27288,
                            Title = "Cybermancy",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27289,
                            Title = "CodeSpell",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27290,
                            Title = "MythOS",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27291,
                            Title = "SpellCrash",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4146,
                    Name = "John D. Rateliff",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17262,
                            Title = "The History of the Hobbit:  Revised and Expanded Edition",
                            Year = 2007,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4155,
                    Name = "Edith Pattou",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17272,
                            Title = "East",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35261,
                            Title = "West",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4201,
                    Name = "Ryan Oakley",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17376,
                            Title = "Technicolor Ultra Mall",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4203,
                    Name = "Milton J. Davis",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17387,
                            Title = "From Here to Timbuktu",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17388,
                            Title = "Steamfunk!",
                            Year = 2013,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17383,
                            Title = "Changa's Safari",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17384,
                            Title = "Changa's Safari:  Volume 2",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17385,
                            Title = "Changa's Safari:  Volume Three",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17386,
                            Title = "Woman of the Woods",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4275,
                    Name = "K. D. Wentworth",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17771,
                            Title = "Kaleidoscope",
                            Year = 2007,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17768,
                            Title = "Born-Again",
                            Year = 2005,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17769,
                            Title = "Tall One",
                            Year = 1998,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17770,
                            Title = "Burning Bright",
                            Year = 1996,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17778,
                            Title = "The Imperium Game",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17776,
                            Title = "Black on Black",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17777,
                            Title = "Stars Over Stars",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17772,
                            Title = "Moonspeaker",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17773,
                            Title = "House of Moons",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17774,
                            Title = "The Course of Empire",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17775,
                            Title = "The Crucible of Empire",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24871,
                            Title = "L. Ron Hubbard Presents Writers of the Future, Volume XXV",
                            Year = 2009,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24872,
                            Title = "L. Ron Hubbard Presents Writers of the Future, Volume XXVI",
                            Year = 2010,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24873,
                            Title = "L. Ron Hubbard Presents Writers of the Future, Volume XXVII",
                            Year = 2011,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24874,
                            Title = "L. Ron Hubbard Presents Writers of the Future, Volume XXVIII",
                            Year = 2012,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4280,
                    Name = "Dayton Ward",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 19366,
                            Title = "The Last World War",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19367,
                            Title = "Counterstrike:  The Last World War",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21101,
                            Title = "Purgatory's Key",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20496,
                            Title = "Glass Empires",
                            Year = 2007,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20393,
                            Title = "Peaceable Kingdoms",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20395,
                            Title = "Paths of Disharmony",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27579,
                            Title = "Drastic Measures",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20344,
                            Title = "Point of Divergence",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20345,
                            Title = "All That's Left",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21007,
                            Title = "Have Tech, Will Travel",
                            Year = 2002,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21008,
                            Title = "Miracle Workers",
                            Year = 2002,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21011,
                            Title = "Foundations",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21013,
                            Title = "Breakdowns",
                            Year = 2005,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21032,
                            Title = "Grand Designs",
                            Year = 2007,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21054,
                            Title = "Creative Couplings",
                            Year = 2007,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21079,
                            Title = "What's Past",
                            Year = 2010,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 31408,
                            Title = "Available Light",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18770,
                            Title = "A Time to Sow",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18771,
                            Title = "A Time to Harvest",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20342,
                            Title = "Armageddon's Arrow",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21103,
                            Title = "Headlong Flight",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25463,
                            Title = "Hearts and Minds",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 36547,
                            Title = "Agents of Influence",
                            Year = 2020,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20340,
                            Title = "From History's Shadow",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20341,
                            Title = "That Which Divides",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20343,
                            Title = "In the Name of Honor",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17817,
                            Title = "Summon the Thunder",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17819,
                            Title = "Open Secrets",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17821,
                            Title = "Declassified",
                            Year = 2011,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17822,
                            Title = "What Judgments Come",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19090,
                            Title = "In Tempest's Wake",
                            Year = 2012,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4282,
                    Name = "Marco Palmieri",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20497,
                            Title = "Shards and Shadows",
                            Year = 2009,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21700,
                            Title = "Prophecy and Change",
                            Year = 2003,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21699,
                            Title = "The Lives of Dax",
                            Year = 1999,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21697,
                            Title = "The Sky's the Limit",
                            Year = 2007,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21696,
                            Title = "Constellations",
                            Year = 2006,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17821,
                            Title = "Declassified",
                            Year = 2011,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21698,
                            Title = "Distant Shores",
                            Year = 2005,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4333,
                    Name = "Kiera Cass",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 18349,
                            Title = "Happily Ever After",
                            Year = 2015,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18345,
                            Title = "The Selection",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18346,
                            Title = "The Elite",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18347,
                            Title = "The One",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18348,
                            Title = "The Heir",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4350,
                    Name = "Robert Taylor",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 18433,
                            Title = "Idiot's Mate",
                            Year = 1968,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4368,
                    Name = "Jack Nicholls",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 18473,
                            Title = "Dune Time",
                            Year = 2016,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4370,
                    Name = "Steven Millhauser",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 28682,
                            Title = "Enchanted Night",
                            Year = 1999,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 18495,
                            Title = "The Knife Thrower and Other Stories",
                            Year = 1998,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23968,
                            Title = "The Sisterhood of Night",
                            Year = 1994,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23921,
                            Title = "Eisenheim the Illusionist",
                            Year = 1989,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4379,
                    Name = "Ada Palmer",
                    Nominations = 3,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 18590,
                            Title = "Too Like the Lightning",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21278,
                            Title = "Seven Surrenders",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25022,
                            Title = "The Will to Battle",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4422,
                    Name = "Stephanie Burgis",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20676,
                            Title = "Congress of Secrets",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 18958,
                            Title = "Masks and Shadows",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28105,
                            Title = "The Dragon with a Chocolate Heart",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35324,
                            Title = "The Girl with the Dragon Heart",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35325,
                            Title = "The Princess Who Flew with Dragons",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31613,
                            Title = "Spellswept",
                            Year = 2018,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31612,
                            Title = "Snowspelled",
                            Year = 2017,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35326,
                            Title = "Thornbound",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4439,
                    Name = "Eleanor Lerman",
                    Nominations = 2,
                    Wins = 1,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 24465,
                            Title = "The Stargazer's Embassy",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19049,
                            Title = "Radiomen",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4457,
                    Name = "Grant Carrington",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 19154,
                            Title = "His Hour Upon the Stage",
                            Year = 1976,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4463,
                    Name = "Mike Conner",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 19171,
                            Title = "Guide Dog",
                            Year = 1991,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4493,
                    Name = "Melissa F. Olson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 19427,
                            Title = "Boundary Crossed",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19428,
                            Title = "Boundary Lines",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19429,
                            Title = "Boundary Born",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24704,
                            Title = "Midnight Curse",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24705,
                            Title = "Blood Gamble",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19402,
                            Title = "Nightshades",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24703,
                            Title = "Switchback",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28039,
                            Title = "Outbreak",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19424,
                            Title = "Dead Spots",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19425,
                            Title = "Trail of Dead",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19426,
                            Title = "Hunter's Trail",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4498,
                    Name = "Paige Orwin",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 19472,
                            Title = "The Interminables",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31776,
                            Title = "Immortal Architects",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4528,
                    Name = "Richard Chwedyk",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 19693,
                            Title = "Bronte's Egg",
                            Year = 2002,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19941,
                            Title = "The Measure of All Things",
                            Year = 2001,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4555,
                    Name = "Rebecca Campbell",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20110,
                            Title = "The High Lonesome Frontier",
                            Year = 2016,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 23320,
                            Title = "Unearthly Landscape by a Lady",
                            Year = 2015,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4565,
                    Name = "Sara Genge",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 28620,
                            Title = "Sins of the Father",
                            Year = 2010,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20134,
                            Title = "As Women Fight",
                            Year = 2009,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4572,
                    Name = "Mary Soon Lee",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22599,
                            Title = "PauseTime",
                            Year = 2000,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32788,
                            Title = "Lifework",
                            Year = 1999,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 33878,
                            Title = "The Day Before They Came",
                            Year = 1998,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20142,
                            Title = "Universal Grammar",
                            Year = 1997,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4592,
                    Name = "Walter Wangerin, Jr.",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20256,
                            Title = "The Book of the Dun Cow",
                            Year = 1978,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 20257,
                            Title = "The Book of Sorrows",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4594,
                    Name = "Sarah Jude",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20268,
                            Title = "The May Queen Murders",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 4612,
                    Name = "Darko Suvin",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20480,
                            Title = "Positions and Presuppositions in Science Fiction",
                            Year = 1988,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20479,
                            Title = "Metamorphoses of Science Fiction:  On the Poetics and History of a Literary Genre",
                            Year = 1979,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4616,
                    Name = "Mike Sussman",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20496,
                            Title = "Glass Empires",
                            Year = 2007,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4627,
                    Name = "Kirsten Beyer",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27984,
                            Title = "Architects of Infinity",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20556,
                            Title = "A Pocket Full of Lies",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20555,
                            Title = "Atonement",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20554,
                            Title = "Acts of Contrition",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20553,
                            Title = "Protectors",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20552,
                            Title = "The Eternal Tide",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20551,
                            Title = "Children of the Storm",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20549,
                            Title = "Full Circle",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20550,
                            Title = "Unworthy",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20557,
                            Title = "Fusion",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4652,
                    Name = "Ilsa J. Bick",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20712,
                            Title = "Well of Souls:  2336",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21055,
                            Title = "Wounds",
                            Year = 2008,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4655,
                    Name = "Tom Toner",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20717,
                            Title = "The Promise of the Child",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28559,
                            Title = "The Weight of the World",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28561,
                            Title = "The Tropic of Eternity",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4663,
                    Name = "Ithell Colquhoun",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20732,
                            Title = "Goose of Hermogenes",
                            Year = 1961,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4665,
                    Name = "J. G. Hertzler",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20749,
                            Title = "The Left Hand of Destiny: Book One",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20750,
                            Title = "The Left Hand of Destiny: Book Two",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4670,
                    Name = "Robert Picardo",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20772,
                            Title = "The Hologram's Handbook",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4702,
                    Name = "Denny Martin Flinn",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20910,
                            Title = "The Fearful Summons",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4725,
                    Name = "Allyn Gibson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21032,
                            Title = "Grand Designs",
                            Year = 2007,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4750,
                    Name = "Willow Palecek",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21165,
                            Title = "City of Wolves",
                            Year = 2016,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4803,
                    Name = "Alan Schwartz",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21626,
                            Title = "The Key to Irunium / The Wandering Tellurian",
                            Year = 1967,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4804,
                    Name = "Tony Russell Wayman",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21627,
                            Title = "The Last Castle / World of the Sleeper",
                            Year = 1967,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4820,
                    Name = "Dominic Green",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 26949,
                            Title = "Butterfly Bomb",
                            Year = 2009,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28942,
                            Title = "Glister",
                            Year = 2009,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26912,
                            Title = "Shining Armor",
                            Year = 2008,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21663,
                            Title = "The Clockwork Atom Bomb",
                            Year = 2005,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27331,
                            Title = "Send Me a Mentagram",
                            Year = 2003,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 33876,
                            Title = "That Thing Over There",
                            Year = 1998,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4878,
                    Name = "Elizabeth Anne Hull",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21997,
                            Title = "Gateways",
                            Year = 2010,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21996,
                            Title = "Tales from the Planet Earth",
                            Year = 1986,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4906,
                    Name = "Charles Birkin",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22113,
                            Title = "The Smell of Evil",
                            Year = 1965,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 22270,
                            Title = "Devils' Spawn",
                            Year = 1936,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 4912,
                    Name = "Michael Talbot",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22132,
                            Title = "Night Things",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 22133,
                            Title = "The Bog",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 22131,
                            Title = "The Delicate Dependency:  A Novel of the Vampire Life",
                            Year = 1982,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 4930,
                    Name = "Henry Chapman Mercer",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22239,
                            Title = "November Night Tales",
                            Year = 1928,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 4942,
                    Name = "Archie Roy",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22274,
                            Title = "Devil in the Darkness",
                            Year = 1978,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 4970,
                    Name = "D. J. Taylor",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22370,
                            Title = "The Windsor Faction",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4986,
                    Name = "David Farland",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22411,
                            Title = "Against Eternity",
                            Year = 2011,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6584,
                            Title = "The Sum of All Men",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6585,
                            Title = "Brotherhood of the Wolf",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6586,
                            Title = "Wizardborn ",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6587,
                            Title = "The Lair of Bones",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6588,
                            Title = "Sons of the Oak",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6589,
                            Title = "Worldbinder ",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6590,
                            Title = "The Wyrmling Horde",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6591,
                            Title = "Chaosbound ",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6592,
                            Title = "A Tale of Tales",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24877,
                            Title = "L. Ron Hubbard Presents Writers of the Future, Volume 31",
                            Year = 2015,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24878,
                            Title = "L. Ron Hubbard Presents Writers of the Future, Volume 32",
                            Year = 2016,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24879,
                            Title = "L. Ron Hubbard Presents Writers of the Future, Volume 33",
                            Year = 2017,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32443,
                            Title = "L. Ron Hubbard Presents Writers of the Future, Volume 34",
                            Year = 2018,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34349,
                            Title = "L. Ron Hubbard Presents Writers of the Future, Volume 35",
                            Year = 2019,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5004,
                    Name = "Mark Smith",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22499,
                            Title = "The Road to Winter",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5019,
                    Name = "Bracken MacLeod",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22548,
                            Title = "Stranded",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 5021,
                    Name = "Peter Sursi",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22556,
                            Title = "The Seven Samovars",
                            Year = 2012,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5028,
                    Name = "Richard Mathews",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22605,
                            Title = "Aldiss Unbound: The Science Fiction of Brian W. Aldiss",
                            Year = 1977,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22606,
                            Title = "Worlds Beyond the World: The Fantastic Vision of William Morris",
                            Year = 1978,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 22607,
                            Title = "Lightning from a Clear Sky: Tolkien, the Trilogy and the Silmarillion",
                            Year = 1978,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 22608,
                            Title = "The Clockwork Universe of Anthony Burgess",
                            Year = 1978,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22609,
                            Title = "Fantasy: The Liberation of Imagination",
                            Year = 1997,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5043,
                    Name = "Damien Walters Grintalis",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 23062,
                            Title = "A Lie You Give, and Thus I Take",
                            Year = 2014,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 22658,
                            Title = "Always, They Whisper",
                            Year = 2013,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5069,
                    Name = "Brooks Landon",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22750,
                            Title = "Science Fiction After 1900:  From the Steam Man to the Stars",
                            Year = 1997,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5079,
                    Name = "Jeff Frane",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22815,
                            Title = "Fritz Leiber",
                            Year = 1980,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5096,
                    Name = "J. Madison Davis",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22869,
                            Title = "Stanislaw Lem",
                            Year = 1991,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5178,
                    Name = "Claudine Griggs",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 23174,
                            Title = "Helping Hand",
                            Year = 2015,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5181,
                    Name = "K. M. Szpara",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 25058,
                            Title = "Small Changes Over Long Periods of Time",
                            Year = 2017,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23177,
                            Title = "Nothing Is Pixels Here",
                            Year = 2015,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35185,
                            Title = "Transcendent: The Year's Best Transgender Speculative Fiction",
                            Year = 2016,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28500,
                            Title = "You Can Make a Dinosaur, but You CanΓÇÖt Help Me",
                            Year = 2018,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5192,
                    Name = "JY Yang",
                    Nominations = 3,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 32332,
                            Title = "Circus Girl, The Hunter, and Mirror Boy",
                            Year = 2019,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 31496,
                            Title = "Between the Firmaments",
                            Year = 2018,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25042,
                            Title = "Auspicium Melioris Aevi",
                            Year = 2017,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24532,
                            Title = "Waiting on a Bright Moon",
                            Year = 2017,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24956,
                            Title = "The Blood That Pulses in the Veins of One",
                            Year = 2016,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 23307,
                            Title = "Four and Twenty Blackbirds",
                            Year = 2016,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 23251,
                            Title = "Secondhand Bodies",
                            Year = 2016,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24779,
                            Title = "The Black Tides of Heaven",
                            Year = 2017,
                            Type = BookType.Novella,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24780,
                            Title = "The Red Threads of Fortune",
                            Year = 2017,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28094,
                            Title = "The Descent of Monsters",
                            Year = 2018,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32418,
                            Title = "The Ascent to Godhood",
                            Year = 2019,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5199,
                    Name = "Haris A. Durrani",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 23299,
                            Title = "Tethered",
                            Year = 2013,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5236,
                    Name = "Nigel Quinlan",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 23514,
                            Title = "The Maloneys' Magical Weatherbox",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5263,
                    Name = "Nigel Foster",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 23710,
                            Title = "Netherspace",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28123,
                            Title = "Originators",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5312,
                    Name = "Scott Dalrymple",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 24202,
                            Title = "Marcel Proust, Incorporated",
                            Year = 2017,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5321,
                    Name = "Summer Wigmore",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 24389,
                            Title = "The Wind City",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5348,
                    Name = "Michael Shaara",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 24649,
                            Title = "Soldier Boy",
                            Year = 1982,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5373,
                    Name = "Kevin O'Donnell, Jr.",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 25149,
                            Title = "Fire on the Border",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24890,
                            Title = "ORA:CLE",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25148,
                            Title = "War of Omission",
                            Year = 1982,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25141,
                            Title = "Bander Snatch",
                            Year = 1979,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25046,
                            Title = "Mayflies",
                            Year = 1979,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5380,
                    Name = "Andrea Kail",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 24897,
                            Title = "The Sun God at Dawn, Rising from a Lotus Blossom",
                            Year = 2007,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5401,
                    Name = "Brett Ewins",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 24934,
                            Title = "Skreemer",
                            Year = 1989,
                            Type = BookType.GraphicNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5422,
                    Name = "Roberto Quaglia",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 25083,
                            Title = "The Moby Clitoris of His Beloved",
                            Year = 2006,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5460,
                    Name = "Paul Jessup",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 25275,
                            Title = "The Secret in the House of Smiles",
                            Year = 2008,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5461,
                    Name = "Margaret Ronald",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 26020,
                            Title = "And Then, One Day, the Air Was Full of Voices",
                            Year = 2016,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 29021,
                            Title = "The Governess and the Lobster",
                            Year = 2012,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 26151,
                            Title = "Sunlight Society",
                            Year = 2012,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25276,
                            Title = "When the Gentlemen Go By",
                            Year = 2008,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 5477,
                    Name = "Susan Fletcher",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34586,
                            Title = "House of Glass",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 25393,
                            Title = "The Silver Dark Sea",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5494,
                    Name = "Jeffrey Konvtiz",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 25548,
                            Title = "The Sentinel",
                            Year = 1974,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 25549,
                            Title = "The Guardian",
                            Year = 1979,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 5496,
                    Name = "Robert Rankin",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 25557,
                            Title = "The Hollow Chocolate Bunnies of the Apocalypse",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25558,
                            Title = "The Toyminator",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5498,
                    Name = "Gerald Brandt",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 25567,
                            Title = "The Courier",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25568,
                            Title = "The Operative",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25569,
                            Title = "The Rebel",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5527,
                    Name = "Len Deighton",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 25775,
                            Title = "SS-GB",
                            Year = 1978,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5540,
                    Name = "Kirk Mitchell",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 25913,
                            Title = "Never the Twain",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5566,
                    Name = "C. F. Bentley",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 26064,
                            Title = "Harmony",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26065,
                            Title = "Enigma",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5589,
                    Name = "Harvey Welles",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 26218,
                            Title = "Alice & Bob",
                            Year = 2008,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5596,
                    Name = "Andy Hoare",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 26373,
                            Title = "Glory Imperialis",
                            Year = 2017,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26366,
                            Title = "Commissar",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26536,
                            Title = "Hunt for Voldorius",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5613,
                    Name = "Sarah Ash",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 26651,
                            Title = "Lord of Snow and Shadows",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 26652,
                            Title = "Prisoner of Ironsea Tower",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 26653,
                            Title = "Children of the Serpent Gate",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5615,
                    Name = "Christopher Brookmyre",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 26672,
                            Title = "Places in the Darkness",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26674,
                            Title = "Bedlam",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 26673,
                            Title = "Pandaemonium",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 5623,
                    Name = "Muya Agami",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 26710,
                            Title = "The Disappearance of Hatsune Miku",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5628,
                    Name = "Kari Maaren",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 26782,
                            Title = "Weave a Circle Round",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5631,
                    Name = "Joe Pitkin",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 26812,
                            Title = "The Daughters of John Demetrius",
                            Year = 2015,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 31825,
                            Title = "Houseflies",
                            Year = 2012,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 29037,
                            Title = "A Murmuration of Starlings",
                            Year = 2012,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5662,
                    Name = "Hiromi Kawakami",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27196,
                            Title = "Record of a Night Too Brief",
                            Year = 1996,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5693,
                    Name = "Michael Crummey",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27335,
                            Title = "Galore",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5694,
                    Name = "Cynthia Ward",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34763,
                            Title = "Writing the Other: The Practical Approach",
                            Year = 2005,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27349,
                            Title = "The Adventure of the Incognita Countess ",
                            Year = 2017,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34640,
                            Title = "The Adventure of the Dux Bellorum",
                            Year = 2018,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5725,
                    Name = "Robin Shortt",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27602,
                            Title = "Wellside",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5727,
                    Name = "Maria Lewis",
                    Nominations = 3,
                    Wins = 1,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36340,
                            Title = "The Wailing Woman",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32829,
                            Title = "The Witch Who Courted Death",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27604,
                            Title = "Who's Afraid?",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27605,
                            Title = "Who's Afraid Too?",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5739,
                    Name = "Lesley Nneka Arimah",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27706,
                            Title = "What It Means When a Man Falls from the Sky",
                            Year = 2017,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5756,
                    Name = "Beesan Odeh",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27897,
                            Title = "Al-Kahf",
                            Year = 2018,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5809,
                    Name = "Cass Morris",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 28088,
                            Title = "From Unseen Fire",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5817,
                    Name = "Hye-young Pyun",
                    Nominations = 1,
                    Wins = 1,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 28134,
                            Title = "The Hole:  A Novel",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 35842,
                            Title = "City of Ash and Red",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 5841,
                    Name = "Betsy Wollheim",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 28310,
                            Title = "Fantasy: DAW 30th Anniversary",
                            Year = 2002,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28311,
                            Title = "Science Fiction: DAW 30th Anniversary",
                            Year = 2002,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5896,
                    Name = "Francesco Dimitri",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 28782,
                            Title = "The Book of Hidden Things",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5920,
                    Name = "Matthew David Surridge",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 29003,
                            Title = "The Word of Azrael",
                            Year = 2010,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5927,
                    Name = "F. Brett Cox",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 29053,
                            Title = "The End of All Our Exploring:  Stories",
                            Year = 2018,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5938,
                    Name = "John Ridley",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 30099,
                            Title = "Those Who Walk in Darkness",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 30101,
                            Title = "What Fire Cannot Burn",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5954,
                    Name = "Claudia Dey",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 30185,
                            Title = "Heartbreaker",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5979,
                    Name = "Joseph Staten",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 31372,
                            Title = "Contact Harvest",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5981,
                    Name = "Simon Stern",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 31402,
                            Title = "The Valancourt Book of Victorian Christmas Ghost Stories, Volume Three",
                            Year = 2018,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 6009,
                    Name = "Ozgur Mumcu",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 31632,
                            Title = "The Peace Machine",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 6011,
                    Name = "Nick Aires",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 31642,
                            Title = "Alita: Battle Angel - Dr. Ido's Journal",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 6045,
                    Name = "Robert Ames Bennet",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 31928,
                            Title = "The Bowl of Baal",
                            Year = 1916,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 31927,
                            Title = "Thyra: A Romance of the Polar Pit ",
                            Year = 1901,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 6063,
                    Name = "Thorarinn Gunnarsson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 32100,
                            Title = "Make Way for Dragons!",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32101,
                            Title = "Human, Beware!",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32102,
                            Title = "Dragons on the Town",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32103,
                            Title = "Song of the Dwarves",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32104,
                            Title = "Revenge of the Valkyrie",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 6085,
                    Name = "Cherie Dimaline",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 32324,
                            Title = "The Marrow Thieves",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 6095,
                    Name = "Ru Emerson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 32455,
                            Title = "Spell Bound",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32454,
                            Title = "The Princess of Flames",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32456,
                            Title = "To the Haunted Mountains",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32457,
                            Title = "In the Caves of Exile",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32458,
                            Title = "On the Seas of Destiny",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 6096,
                    Name = "Frank A. Javor",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 32490,
                            Title = "The Rim-World Legacy",
                            Year = 1967,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32491,
                            Title = "Scor-Sting",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32492,
                            Title = "The Ice Beast",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 6129,
                    Name = "Laura Lindstedt",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 32720,
                            Title = "Oneiron",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 6130,
                    Name = "Henry Gee",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 32722,
                            Title = "Futures from Nature",
                            Year = 2007,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32744,
                            Title = "Bordeaux Mixture",
                            Year = 2000,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 6152,
                    Name = "R. R. Virdi",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 32850,
                            Title = "Messenger",
                            Year = 2018,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7156,
                    Name = "Simone Heller",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 33902,
                            Title = "When We Were Starless",
                            Year = 2018,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7161,
                    Name = "Helen Dale",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 33920,
                            Title = "Rules",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 33922,
                            Title = "Order",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7168,
                    Name = "Brian Brett",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 33994,
                            Title = "The Fungus Garden",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7177,
                    Name = "Organization for Transformative Works",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34009,
                            Title = "Archive of Our Own",
                            Year = 2018,
                            Type = BookType.Miscellaneous,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy, Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 7179,
                    Name = "Michael Skeet",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34021,
                            Title = "Near Enough to Home",
                            Year = 1998,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7251,
                    Name = "Mame Bougouma Diene",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34448,
                            Title = "Hell Freezes Over",
                            Year = 2015,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7266,
                    Name = "Steven Kotler",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34488,
                            Title = "The Angle Quickest For Flight",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7275,
                    Name = "Heather Child",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34519,
                            Title = "Everything About You",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7288,
                    Name = "Anna Kendall",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34554,
                            Title = "Crossing Over",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34555,
                            Title = "Dark Mist Rising",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34556,
                            Title = "A Bright and Terrible Sword",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7329,
                    Name = "Beth Plutchak",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35456,
                            Title = "Boundaries, Border Crossings, and Reinventing the Future",
                            Year = 2017,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 34704,
                            Title = "Liminal Spaces",
                            Year = 2018,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7332,
                    Name = "Nancy Jane Moore",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34786,
                            Title = "The Weave",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34735,
                            Title = "Changeling",
                            Year = 2004,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7344,
                    Name = "Jody Scott",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34769,
                            Title = "Passing for Human",
                            Year = 1977,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34770,
                            Title = "I, Vampire",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34771,
                            Title = "Devil-May-Care",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7370,
                    Name = "Stephen Kenson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34863,
                            Title = "Born to Run",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34864,
                            Title = "Poison Agendas",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34865,
                            Title = "Fallen Angels",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7469,
                    Name = "James Rollins",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35354,
                            Title = "Altar of Eden",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35353,
                            Title = "Ice Hunt",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35352,
                            Title = "Amazonia",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35351,
                            Title = "Deep Fathom",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35350,
                            Title = "Excavation",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35349,
                            Title = "Subterranean",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7483,
                    Name = "A. J. Hackwith",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35385,
                            Title = "The Library of the Unwritten",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7486,
                    Name = "Kim Liggett",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35391,
                            Title = "The Grace Year",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 35392,
                            Title = "The Unfortunates",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 35393,
                            Title = "The Last Harvest",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 35394,
                            Title = "Blood and Salt",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 35395,
                            Title = "Heart of Ash",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 7492,
                    Name = "Helen Mary Hoover",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35425,
                            Title = "The Winds of Mars",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35431,
                            Title = "The Shepherd Moon",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35427,
                            Title = "Return to Earth",
                            Year = 1980,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35428,
                            Title = "This Time of Darkness",
                            Year = 1980,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35426,
                            Title = "The Lost Star",
                            Year = 1979,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35429,
                            Title = "The Delikon",
                            Year = 1977,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35430,
                            Title = "The Rains of Eridan",
                            Year = 1977,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7513,
                    Name = "Cavan Scott",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35526,
                            Title = "Dooku: Jedi Lost",
                            Year = 2019,
                            Type = BookType.Miscellaneous,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7521,
                    Name = "Shea Ernshaw",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35563,
                            Title = "The Wicked Deep",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7560,
                    Name = "Nell Freudenberger",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35793,
                            Title = "Lost and Wanted",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7570,
                    Name = "Jeremy K. Brown",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35817,
                            Title = "Zero Limit",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7578,
                    Name = "James Maxwell",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35857,
                            Title = "Enchantress",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35858,
                            Title = "The Hidden Relic",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35859,
                            Title = "The Path of the Storm",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35860,
                            Title = "The Lore of the Evermen",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7589,
                    Name = "Laura Esquivel",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35894,
                            Title = "Like Water for Chocolate:  A Novel in Monthly Installments, with Recipes, Romances, and Home Remedies",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7615,
                    Name = "Alexander Belyaev",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36033,
                            Title = "The Amphibian",
                            Year = 1928,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7619,
                    Name = "Danielle Trussoni",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36056,
                            Title = "Angelology",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36057,
                            Title = "Angelopolis",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7683,
                    Name = "Hiroyuki Morioka",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36332,
                            Title = "Seikai: Crest of the Stars, Vol. 1:  Princess of the Empire",
                            Year = 1996,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 36333,
                            Title = "Seikai: Crest of the Stars, Vol. 2:  A Modest War",
                            Year = 1996,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 36334,
                            Title = "Seikai: Crest of the Stars, Vol. 3:  Return to a Strange World",
                            Year = 1996,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7699,
                    Name = "Lincoln Geraghty",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36374,
                            Title = "The Influence of Star Trek on Television, Film, and Culture",
                            Year = 2007,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7725,
                    Name = "Stephen Blackmoore",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36431,
                            Title = "City of the Lost",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36432,
                            Title = "Dead Things",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36433,
                            Title = "Broken Souls",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36434,
                            Title = "Hungry Ghosts",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36435,
                            Title = "Fire Season",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36436,
                            Title = "Ghost Money",
                            Year = 2020,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7751,
                    Name = "Gideon Haberkorn",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36516,
                            Title = "Comics as a Nexus of Cultures:  Essays on the Interplay of Media, Disciple and International Perspectives",
                            Year = 2010,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },

                 new Author
                {
                    ID = 7751,
                    Name = "Gideon Haberkorn",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36516,
                            Title = "Comics as a Nexus of Cultures:  Essays on the Interplay of Media, Disciple and International Perspectives",
                            Year = 2010,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },

                new Author
                {
                    ID = 7761,
                    Name = "Weronika Laszkiewicz",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36531,
                            Title = "Fantasy Literature and Christianity:  A Study of the Mistborn, Coldfire, Fionavar Tapestry and Chronicles of Thomas Covenant Series ",
                            Year = 2018,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7776,
                    Name = "Kimberley McMahon-Coleman",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36566,
                            Title = "Werewolves and Other Shapeshifters in Popular Culture",
                            Year = 2012,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7776,
                    Name = "Kimberley McMahon-Coleman",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36566,
                            Title = "Werewolves and Other Shapeshifters in Popular Culture",
                            Year = 2012,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                }


            };
        }

        public void MyNonParamsMethod()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}

