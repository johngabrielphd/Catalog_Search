using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Software : Asset
    {

        public int Size { get; set; }
        public string Requirements { get; set; }

        public Software(string Identifier, string Name, string Status, int Size, string Requirements)
            : base(Identifier, Name, "Software", Status)
        {

            this.Size = Size;
            this.Requirements = Requirements;

        }

        public override string DescribeAsset()
        {

            string tempDescription = base.DescribeAsset() + String.Format(",Size:  {0} MB,System Requirements:  {1}", Size, Requirements);
            string description = tempDescription.Replace(",", "\r\n");
            return description;

        }

    }
}
