using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BluRay : Film
    {

        public BluRay(string Identifier, string Name, string Status, int Length, string Director) : base(Identifier, Name, "BluRay", Status, Length, Director) { }

    }
}
