using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.Culture.App.Data.Mongo;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Atom.Culture.App.Data.Repositories
{
    public class ReadersRepository : IRepository<Reader>
    {
        MongoContext mongoContext;

        public ReadersRepository(MongoContext mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public Reader Get(string id)
        {
            return mongoContext.Readers.Find(Builders<Reader>.Filter.Eq(x => x.ReaderId, id)).FirstOrDefault();
        }

        public IEnumerable<Reader> Where(Expression<Func<Reader, bool>> expression)
        {
            return mongoContext.Readers.Find(expression).ToList();
        }
    }
}
