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
    public class OrganizationsRepository : IRepository<Organization>
    {
        MongoContext mongoContext;

        public OrganizationsRepository(MongoContext mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public Organization Get(string id)
        {
            return mongoContext.Organizations.Find(Builders<Organization>.Filter.Eq(x => x.OrgId, id)).FirstOrDefault();
        }

        public IEnumerable<Organization> Where(Expression<Func<Organization, bool>> expression)
        {
            return mongoContext.Organizations.Find(expression).ToList();
        }
    }
}
