using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atom.CultureShared
{
    public interface IRecomendation
    {
        string Id { get; set; }
        string Name { get; set; }
        string Type { get; }
        

    }
}
