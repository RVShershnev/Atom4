using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atom.CultureShared
{
    [Serializable]
    public class Activity : IRecomendation
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Source { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
        public long Price { get; set; }
        public int CountPeople { get; set; }
        public string[] Tags { get; set; }

    }
}
