using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Film : Asset
    {

        public int Length { get; set; }
        public string Director { get; set; }

        public Film(string Identifier, string Name, string Type, string Status, int Length, string Director)
            : base(Identifier, Name, Type, Status)
        {

            this.Length = Length;
            this.Director = Director;

        }

        public override string DescribeAsset()
        {

            string tempDescription = base.DescribeAsset() + String.Format(",Length:  {0} minutes,Director:  {1}", Length, Director);
            string description = tempDescription.Replace(",", "\r\n");
            return description;

        }

    }
}
