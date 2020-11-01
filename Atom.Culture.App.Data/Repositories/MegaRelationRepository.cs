using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.Culture.App.Data.Mongo;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Atom.Culture.App.Data.Repositories
{
    public class MegaRelationRepository : IRepository<MegaRelation>
    {
        MongoContext mongoContext;

        public MegaRelationRepository(MongoContext mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public MegaRelation Get(string id)
        {
            return mongoContext.MegaRelations.Find(Builders<MegaRelation>.Filter.Eq(x => x.EnrollId, id)).FirstOrDefault();
        }

        public IEnumerable<MegaRelation> Where(Expression<Func<MegaRelation, bool>> expression)
        {
            return mongoContext.MegaRelations.Find(expression).ToList();
        }
    }
}
