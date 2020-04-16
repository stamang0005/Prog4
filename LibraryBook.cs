using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    public class LibraryBook
    {
        private int _copyright;//validation
        private bool _checkedout;//bool type
        public const int Year = 2018;//backing field 

        //initialized with book, author, publisher, copyrightyear, number)
        public LibraryBook(string book, string author, string publisher, int year, string number)
        {
            BookName = book;
            AuthorName = author;
            Publisher = publisher;
            CopyrightYear = year;
            Number = number;

        }

        public string BookName
        {
            get;
            //precondition not applicable.
            //postcondtion: return title
            set;
        }

        public string AuthorName
        {
            //postcondition: author returned.
            get;
            //postcondition specified for author.
            set;
        }

        public string Publisher
        {
            get;
            //postcondtion returned publisher
            //postcondtion specified for publisher.
            set;
        }

        public int CopyrightYear
        {
            //precondtion not applicable
            //postcondition return copyright
            get { return _copyright; }

            //precondtion value >0
            //set to copyright year
            set
            {
                if (value > 0)
                    _copyright = value;
                else
                    _copyright = Year;
            }
        }
        public string Number
        {
            //precondition not applicable
            //return call number
            get;
            //vakue set to call  number
            set;
        }


        //returning properties as string
        public override string ToString()
        {
            return $"Book Name: {BookName} {Environment.NewLine}" +
                $"Author Name: {AuthorName} {Environment.NewLine}" +
                $"Publisher: {Publisher} {Environment.NewLine}" +
                $"Copyright Year: {CopyrightYear}{Environment.NewLine}" +
                $"Call Number: {Number}{Environment.NewLine}";
        }
    }
  

    //}
}
