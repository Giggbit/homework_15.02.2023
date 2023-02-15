using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Анализ_стандартных_интерфейсов_homework_15._02._2023
{
    internal class Book : ICloneable, IComparable
    {
        private string name;
        private string genre;
        private int amount_of_pages;

        public Book() { }
        public Book(string name, string genre, int amount_) { 
            this.name = name;   
            this.genre = genre;
            this.amount_of_pages = amount_;
        }

        public object Clone() {
            return new Book(name, genre, amount_of_pages);
        }

        public int CompareTo(object obj) {
            if (obj is Book) 
                return name.CompareTo((obj as Book).name);
            throw new NotImplementedException();
        }

        public void Enter() {
            Console.Write("Enter name of book: ");
            name = Console.ReadLine();
            Console.Write("Enter genre book: ");
            genre = Console.ReadLine();
            Console.Write("Enter pages amount: ");
            string aop = Console.ReadLine();
            amount_of_pages = Convert.ToInt32(aop);
        }
        public void Print() {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Genre: {genre}");
            Console.WriteLine($"Pages: {amount_of_pages}");
        }

    }
}
