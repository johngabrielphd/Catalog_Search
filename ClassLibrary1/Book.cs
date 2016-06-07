using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Book : Asset
    {

        public string ISBN {get; set;}
        public int Pages { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        public Book(string Identifier, string Name, string Status, string ISBN, int Pages, string Author, string Publisher)
            : base(Identifier, Name, "Book", Status)
        {

            this.ISBN = ISBN;
            this.Pages = Pages;
            this.Author = Author;
            this.Publisher = Publisher;

        }

        public override string DescribeAsset()
        {

            string tempDescription = base.DescribeAsset() + String.Format(",ISBN:  {0},Number of Pages:  {1},Author/s:  {2},Publisher:  {3}", ISBN, Pages, Author, Publisher);
            string description = tempDescription.Replace(",", "\r\n");
            return description;

        }

    }
}
