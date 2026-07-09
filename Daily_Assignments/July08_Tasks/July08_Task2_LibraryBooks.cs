//Om Prashant Gond IT SSGMCE Task 2 Jul8
using System;
using System.Collections.Generic;

class July08_Task2_LibraryBooks
{
    public void Run()
    {
        // Initial list of available books in the library
        List<string> books = new List<string>()
        {
            "C Programming",
            "Java Fundamentals",
            "Database Systems",
            "HTML & CSS Guide"
        };

        // 1. Display all books
        Console.WriteLine(" Available Books ");
        foreach (string book in books)
        {
            Console.WriteLine($"- {book}");
        }
        Console.WriteLine($"Total books available: {books.Count}\n");

        // 2. Add one new book
        string newBook = "C# Mastery";
        Console.WriteLine($"[Action] Adding new book: \"{newBook}\"");
        books.Add(newBook);

        // 3. Remove one old book
        string oldBook = "HTML & CSS Guide";
        Console.WriteLine($"[Action] Removing old book: \"{oldBook}\"\n");
        books.Remove(oldBook);

        // 4. Display the updated list along with the total number of books
        Console.WriteLine("--- Updated List of Available Books ---");
        foreach (string book in books)
        {
            Console.WriteLine($"- {book}");
        }
        Console.WriteLine($"Total books available: {books.Count}");
    }
}
