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
    public class ServicesRepository : IRepository<Service>
    {
        MongoContext mongoContext;

        public ServicesRepository(MongoContext mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public Service Get(string id)
        {
            return mongoContext.Services.Find(Builders<Service>.Filter.Eq(x => x.ServId, id)).FirstOrDefault();
        }

        public IEnumerable<Service> Where(Expression<Func<Service, bool>> expression)
        {
            return mongoContext.Services.Find(expression).ToList();
        }
    }
}
