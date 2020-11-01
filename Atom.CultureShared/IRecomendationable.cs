using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atom.CultureShared
{
    public interface IRecomendationable
    {
        List<IRecomendation> Recomendations { get; set; }
    }
}
