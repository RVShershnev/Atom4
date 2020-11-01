using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atom.CultureShared
{
    public class Group : IRecomendationable
    {
        public List<Person> Persons { get; set; } = new List<Person>();
        public List<IRecomendation> Recomendations { get; set; } = new List<IRecomendation>();
    }
}
