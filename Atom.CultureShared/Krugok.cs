using System;
using System.Collections.Generic;
using System.Text;

namespace Atom.CultureShared
{
    public class Krugok : IRecomendation
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Type => "Кружок";
    }
}
