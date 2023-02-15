using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Анализ_стандартных_интерфейсов_homework_15._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] book = new Book[3];
            book[0] = new Book("D", "J", 12);
            book[1] = new Book("B", "J", 13);
            book[2] = new Book("A", "J", 14);

            foreach(Book b in book) { 
                b.Print();
            }

            Array.Sort(book);
            Console.WriteLine("New massive:");
            foreach(Book b in book) {
                b.Print();
            }


        }
    }
}
