using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering1
{
    internal class Produkt
    {
        public string Tittle { get; private set; }
        public int År { get; private set; }
        public string Beskivelse { get; private set; }
        public string Skaper { get; private set; }
        public string MainCast { get; private set; }

        public Produkt()
        {
        }

        public Produkt(string title, int år, string besrivelse, string skaper, string maincast)
        {
            Tittle = title;
            År = år;
            Beskivelse = besrivelse;
            Skaper = skaper;
            MainCast = maincast;
        }

        public void Run(List<Produkt> list)
        {
            Console.WriteLine("are you talking about a book or a movie");
            Console.WriteLine("press the number you want");
            Console.WriteLine("1. Movie");
            Console.WriteLine("2. Book");
            Console.WriteLine("any other to exit");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    list.Add(MakeFilm());
                    Console.WriteLine();
                    break;
                case "2":
                    list.Add(MakeBook());
                    Console.WriteLine();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }

            foreach (var item in list)
            {
                Console.WriteLine($"title:{item.Tittle}");
                Console.WriteLine($"year: {item.År}");
                Console.WriteLine($"plot: {item.Beskivelse}");
                Console.WriteLine($"Creator: {item.Skaper}");
                Console.WriteLine($"Main Character: {item.MainCast}");
                Console.WriteLine();
            }

            Produkt MakeBook()
            {
                Console.WriteLine("Title of book?");
                var title = Console.ReadLine();
                Console.WriteLine("when was it published?");
                var published = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("tell me something about the plot.");
                var plot = Console.ReadLine();
                Console.WriteLine("who wrote this book?");
                var author = Console.ReadLine();
                Console.WriteLine("what is the name of the main character?");
                var MC = Console.ReadLine();

                return new Produkt(title, published, plot, author, MC);
            }

            Produkt MakeFilm()
            {
                Console.WriteLine("Title of movie?");
                var title = Console.ReadLine();
                Console.WriteLine("when was it released?");
                var published = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("tell me something about the plot.");
                var plot = Console.ReadLine();
                Console.WriteLine("who is the director?");
                var author = Console.ReadLine();
                Console.WriteLine("what is the name of the main character?");
                var MC = Console.ReadLine();

                return new Produkt(title, published, plot, author, MC);
            }
        }
    }
}
