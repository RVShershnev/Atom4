using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.Culture.App.Data.Mongo;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Atom.Culture.App.Data.Repositories
{
    public class IssuesRepository : IRepository<Issue>
    {
        MongoContext mongoContext;

        public IssuesRepository(MongoContext mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public Issue Get(string id)
        {
            return mongoContext.Issues.Find(Builders<Issue>.Filter.Eq(x => x.IssueId, id)).FirstOrDefault();
        }

        public IEnumerable<Issue> Where(Expression<Func<Issue, bool>> expression)
        {
            return mongoContext.Issues.Find(expression).ToList();
        }
    }
}
