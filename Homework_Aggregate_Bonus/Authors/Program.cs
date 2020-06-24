using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Authors
{
    class Program
    {
        static void Main(string[] args)
        {

            Action<string> lines = x => Console.WriteLine(x);

            var source = new AuthorRepo();
            var authors = source.GetAuthors();

            
            // implement Select, Any, All, Distinct, SingleOrDefault with Aggregate

            // select via aggregate
            //authors.Select(a => a.Name);
            var authorNames = authors.Aggregate("", (acc, author) => acc += author.Name + "*").Split("*").ToList();
            //authorNames.ForEach(Console.WriteLine);
            Console.WriteLine(authorNames.First());
            lines("--------------");



            // any via aggregate
            //authors.Any(a => a.Name.EndsWith("i");
            var doesAnyEndWithI = authors.Aggregate(false, (acc, author) => author.Name.EndsWith("i") ? acc = true: acc);
            Console.WriteLine(doesAnyEndWithI);
            lines("--------------");



            //all via aggregate
            //authors.All(a => a.Name.Length > 3);
            var areAllLongerThan3 = authors.Aggregate(true, (acc, author) => author.Name.Length > 14 ? acc : acc = false);
            Console.WriteLine(areAllLongerThan3);
            lines("--------------");



            //distinct via aggregate
            //authors.Distinct();
            var removeDuplicates = authors.Aggregate(new List<Author>(), (acc, author) =>
            acc.Aggregate(new List<int>(), (acc, author) => acc.Append(author.ID).ToList()).Contains(author.ID) ?
            acc : acc.Append(author).ToList());
            Console.WriteLine(removeDuplicates.Count);
            Console.WriteLine(authors.Count);
            lines("--------------");
           


            //singleordefault via aggregate
            //authors.SingleOrDefault(author => author.Name == "Weronika Laszkiewicz");

            var authorWithSpecificName = authors.Aggregate( (acc, author) => author.Name == acc.Name ?
            throw new InvalidOperationException("Sequence contains more than one matching element") :
            author.Name == "Weronika Laszkiewicz" ?
            acc = author : acc);
            Console.WriteLine(authorWithSpecificName.Name);

            //var authorWithSpecificName1 = authors.Aggregate( (acc, author) => author.Name == acc.Name ?
            //throw new InvalidOperationException("Sequence contains more than one matching element") :
            //author.Name == "Kimberley McMahon-Coleman" ?
            //acc = author : acc);
            //Console.WriteLine(authorWithSpecificName1.Name);

            //try
            //{
            //    var authorWithSpecificName2 = authors.Aggregate((acc, author) => author.Name == acc.Name ?
            //   throw new InvalidOperationException("Sequence contains more than one matching element") :
            //   author.Name == "Kimberley McMahon-Coleman" ?
            //   acc = author : acc);
            //    Console.WriteLine(authorWithSpecificName2.Name);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //};


            Console.ReadLine();
        }

       
    }
}
