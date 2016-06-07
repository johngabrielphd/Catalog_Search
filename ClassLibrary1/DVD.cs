using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DVD : Film
    {

        public DVD(string Identifier, string Name, string Status, int Length, string Director) : base(Identifier, Name, "DVD", Status, Length, Director) { }

    }
}
