using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    internal abstract class Worker
    {
        protected string Name { get; set; }
        protected uint Age { get; set; }
        protected double Salary { get; set; }   

        public Worker (string name, uint age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
        public void Print()
        { }
    }

    internal class President : Worker
    {
        public President(string name, uint age, double salary) : base (name, age, salary) { }
        public new void  Print ()
        {
            Console.WriteLine("This is the president");
            Console.WriteLine($"His name is {Name ?? ""}, he`s/she`s age is {Age}, he`s/she`s salary is {Salary}\n"); 
        }
    }

    internal class Manager : Worker
    {
        public Manager(string name, uint age, double salary) : base(name, age, salary) { }
        public new void Print()
        {
            Console.WriteLine("This is the manager");
            Console.WriteLine($"His name is {Name ?? ""}, he`s/she`s age is {Age}, he`s/she`s salary is {Salary}\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            President Baiden = new President("Joe Baiden", 99, 1000000);
            Baiden.Print();

            Manager Oleg = new Manager("Oleg", 35, 10000);
            Oleg.Print();
        }
    }
}
