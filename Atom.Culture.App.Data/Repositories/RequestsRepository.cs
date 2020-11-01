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
    public class RequestsRepository : IRepository<Request>
    {
        MongoContext mongoContext;

        public RequestsRepository(MongoContext mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public Request Get(string id)
        {
            return mongoContext.Requests.Find(Builders<Request>.Filter.Eq(x => x.ApplizationId, id)).FirstOrDefault();
        }

        public IEnumerable<Request> Where(Expression<Func<Request, bool>> expression)
        {
            return mongoContext.Requests.Find(expression).ToList();
        }
    }
}
