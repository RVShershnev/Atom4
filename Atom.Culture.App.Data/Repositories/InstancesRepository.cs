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
    public class InstancesRepository : IRepository<Instance>
    {
        MongoContext mongoContext;

        public InstancesRepository(MongoContext mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public Instance Get(string id)
        {
            return mongoContext.Instances.Find(Builders<Instance>.Filter.Eq(x => x.CopyId, id)).FirstOrDefault();
        }

        public IEnumerable<Instance> Where(Expression<Func<Instance, bool>> expression)
        {
            return mongoContext.Instances.Find(expression).ToList();
        }
    }
}
