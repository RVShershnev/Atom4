using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Atom.Culture.App.Data.Interfaces
{
    public interface IRepository<T>
    {
        T Get(string id);
        IEnumerable<T> Where(Expression<Func<T, bool>> expression);
    }
}
