using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class AudioBook : Asset
    {

        public int Length { get; set; }
        public string Author { get; set; }
        public string Narrator { get; set; }

        public AudioBook(string Identifier, string Name, string Status, int Length, string Author, string Narrator)
            : base(Identifier, Name, "Audio Book", Status)
        {

            this.Length = Length;
            this.Author = Author;
            this.Narrator = Narrator;

        }

        public override string DescribeAsset()
        {

            string tempDescription = base.DescribeAsset() + String.Format(",Length:  {0} minutes,Author/s:  {1},Narrator/s:  {2}", Length, Author, Narrator);
            string description = tempDescription.Replace(",", "\r\n");
            return description;

        }

    }
}
