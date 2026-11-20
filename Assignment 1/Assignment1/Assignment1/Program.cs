
namespace Assignment1
{
    internal class Program
    {
        public class Book
        {
            public string Title { get; set; }
            public int Pages { get; set; }
        }
        //        #region
        //        static void Main(string[] args)
        //        {
        //            Q1();
        //        }

        //        static void Q1()
        //        {
        //            Book book = new Book
        //            {
        //                Title = "C# Basics",
        //                Pages = 464
        //            };

        //            object obj = book;

        //            Console.WriteLine(obj);
        //        }
        //    }
        //}
        //q2 
        //    static void Q2()
        //    {
        //        Book book = new Book
        //        {
        //            Title = "C# Basics",
        //            Pages = 464
        //        };

        //        Console.WriteLine(book.ToString());
        //        Console.WriteLine(book.Equals(book));
        //        Console.WriteLine(book.GetHashCode());
        //        Console.WriteLine(book.GetType());
        //    }
        //}
        //q3 
        //    static void Q3()
        //    {
        //        int pages = 464;

        //        Console.WriteLine(pages);
        //    }
        //}

        //q4 
        //static void Q4()
        //{
        //    try
        //    {
        //        int x = 10;
        //        int y = 0;

        //        Console.WriteLine(x / y);
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Cannot divide by zero");
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Done");
        //    }
        //} }

        //q5
        //static void Q5()
        //{
        //    int pages = 300;

        //    double totalPages = pages;

        //    Console.WriteLine(totalPages);
        //}

        //q6
        static void Q6()
        {
            double price = 49.99;

            int newPrice = (int)price;

            Console.WriteLine(newPrice);
        }