
namespace Assignment1
{
    internal class Program
    {
        public class Book
        {
            public string Title { get; set; }
            public int Pages { get; set; }
        }

        static void Main(string[] args)
        {
            Q1();
        }

        static void Q1()
        {
            Book book = new Book
            {
                Title = "C# Basics",
                Pages = 464
            };

            object obj = book;

            Console.WriteLine(obj);
        }
    }
}