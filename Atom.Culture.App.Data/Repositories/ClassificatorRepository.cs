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
    public class ClassificatorRepository : IRepository<Classificator>
    {
        MongoContext mongoContext;

        public ClassificatorRepository(MongoContext mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public Classificator Get(string id)
        {
            return mongoContext.Classificators.Find(Builders<Classificator>.Filter.Eq(x => x.ClassificatorId, id)).FirstOrDefault();
        }

        public IEnumerable<Classificator> Where(Expression<Func<Classificator, bool>> expression)
        {
            return mongoContext.Classificators.Find(expression).ToList();
        }
    }
}
