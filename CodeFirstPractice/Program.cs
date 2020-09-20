using System;
using CodeFirstPractice.Models;

namespace CodeFirstPractice
{
    class Program
    {
        /*
         A parameter for “shelfMaterial”
            Ensure the material exists in the “ShelfMaterial” table
            if material does not exist, let the user know and exit.
            “shelfMaterial” parameter should be case insensitive.
            “shelfMaterial” parameter should be trimmed.
            When you add the new shelf, ensure the foreign key for “ShelfMaterial” is populated correctly.
         */
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
