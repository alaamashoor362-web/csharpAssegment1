using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment1
{
    class Book
    {
        //        // #region Question 1
        //        //Create a Book class with a Title(string) and Pages(int). Create a Book object and store
        //        //    it in a variable of type object.Print it.

        string Title = "c# Programming";
        int pages = 500;
        static void Main()
        {
            Book book = new Book();
            Console.WriteLine($"Title: {book.Title}, Pages: {book.pages}");

            //#region Questione 2
            //Using the Book class above, print the result of calling ToString(),
            //    Equals() (compare book with itself), GetHashCode(), and GetType() on book.


            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());

            //Qeuestion 3
            // Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it.
            //int pages = "464";

            //solve

            //Compile - time error — you can't put text (string) into an int variable.
            //int pages = 464;

            //Qeuestion 4
            //Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot
            //divide by zero", and then prints "Done" in a finally block.
            int x = 10;
            int y = 0;
            try
            {
                int result = x / y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }

            //Qeuestion 5
            //Declare an int pages = 300; then store it in a double variable without using a cast.

            int pages = 300;
            double pagesDouble = pages;
            Console.WriteLine($"Pages (int): {pages}");
            Console.WriteLine($"Pages (double): {pagesDouble}");


            //Qeuestion 6
            //Declare a double price = 49.99; then convert it into an int using a cast.
            double price = 49.99;
            int priceInt = (int)price;
            Console.WriteLine($"Price (int): {priceInt}");
            //Qeuestion 7
            //Given string pagesText = "464";, convert it into an int using the Convert class.
            string pagesText = "464";
            int pagesInt = Convert.ToInt32(pagesText);
            Console.WriteLine($"Pages (int): {pagesInt}");

            //Qeuestion 8
            //Given string yearText = "2023";, convert it using int.Parse().Then given string
            //badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.

            string yearText = "2023";
            int yearInt = int.Parse(yearText);

            string badText = "abc";
            bool isNumber = int.TryParse(badText, out int badInt);
            if (!isNumber)
            {
                Console.WriteLine("Invalid number");
            }

            //Qeuestion 9
            //Given int pages = 464;, convert it into a string using ToString() and print its type using
            //GetType() to prove it's now a string.

            int page = 465;
            string pagesString = page.ToString();
            Console.WriteLine($"Pages (string): {pagesString}");
            Console.WriteLine($"Type: {pagesString.GetType()}");

            //Qeuestione 10
            //Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            int copies = 100;
            object boxedCopies = copies; // Boxing
            int unboxedCopies = (int)boxedCopies; // Unboxing
            Console.WriteLine($"Copies (original): {copies}");
            Console.WriteLine($"Copies (unboxed): {unboxedCopies}");

            //Qeuestione 11
            //Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value.
            int? year = null;
            Console.WriteLine($"Year has value: {year.HasValue}");
            year = 2023;
            Console.WriteLine($"Year: {year}");


            //Qeuestione 12

            //Declare a string? reviewer = null;. Print whether it is null.
            string? reviewer = null;
            Console.WriteLine($"Reviewer is null: {reviewer is null}");


            //Qeuestione 13
            //Declare a Book? book = null;. Use?.to safely read book.Title without crashing the program, and print the result.
            Book? books = null;
            Console.WriteLine($"Book title: {books?.Title}");

            //Qeuestione 14
            //Using title from the previous question, use ?? to print "Untitled" if title is null.Then
            //use ??= to assign title the value "Untitled" only if it's still null.
            string? title = null;
            Console.WriteLine($"Title: {title ?? "Untitled"}");
            title ??= "Untitled";
            Console.WriteLine($"Title: {title}");


            //Qeuestione 15
            //Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullable string
            //confirmedName using the ! operator.
            string? name = "Ahmed";
            string confirmedName = name!;           

        }

    }
}