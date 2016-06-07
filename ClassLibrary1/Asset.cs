using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Asset
    {

        public string Identifier { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

        public Asset(string Identifier, string Name, string Type, string Status)
        {

            this.Identifier = Identifier;
            this.Name = Name;
            this.Type = Type;
            this.Status = Status;

        }

        public virtual string DescribeAsset()
        {

            string tempDescription = String.Format("Identifier:  {0},Name:  {1},Type:  {2},Status:  {3}", Identifier, Name, Type, Status);
            string description = tempDescription.Replace(",", "\r\n");

            return description;

        }

    }
}
