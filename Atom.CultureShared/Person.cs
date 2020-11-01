using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atom.CultureShared
{
    public class Person : IExperiencable, IRecomendationable
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Bithday { get; set; }
        public string Sex { get; set; }
        public string[] Tags { get; set; }

        public List<IRecomendation> Experience { get; set; }
        public List<IRecomendation> Recomendations { get; set; }
    }
}
