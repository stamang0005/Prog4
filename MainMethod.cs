using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            LibraryBook BookContent1 =
                new LibraryBook("The City of God", "Augustine", "Cambridge University Press", 1998, "123-456-7890");
            LibraryBook BookContent2 =
                new LibraryBook("the masks of God", "Joseph Campbell", "Penguin Books", 1976, "111-111-1111");
            LibraryBook BookContent3 =
                new LibraryBook("Arrow of God", "Chinua Achebe", "Anchor books", 1974, "222-222-2222");
            LibraryBook BookContent4 =
                new LibraryBook("God made them all", "James Herriot", "St. Martin's Press", 1981, "333-333-3333");
            LibraryBook BookContent5 =
                new LibraryBook("Fist of God", "Frederick Forsyth", "Bantam Books", 1994, "444-444-4444");

            LibraryBook[] libraryBooks = new LibraryBook[5];

            //book array
            libraryBooks[0] = BookContent1;
            libraryBooks[1] = BookContent2;
            libraryBooks[2] = BookContent3;
            libraryBooks[3] = BookContent4;
            libraryBooks[4] = BookContent5;

            DisplayBook(libraryBooks);

            //pre and post condition use to output books properties to display.
            void DisplayBook(LibraryBook[] arr)
            {

                foreach (LibraryBook books in arr)
                {
                    Console.WriteLine(books);//displays book
                   
                }
               

            }
      
        }
    }
}
