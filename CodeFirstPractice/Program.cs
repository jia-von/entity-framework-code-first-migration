using System;
using CodeFirstPractice.Models;

namespace CodeFirstPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ShelvesContext context = new ShelvesContext())
            {
                Console.WriteLine("Please enter name a shelf: ");
                context.CreateShelf(Console.ReadLine().Trim().ToLower());
            }
        }
    }
}
