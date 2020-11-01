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
    public class PuppilsRepository : IRepository<Pupil>
    {
        MongoContext mongoContext;

        public PuppilsRepository(MongoContext mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public Pupil Get(string id)
        {
            return mongoContext.Pupils.Find(Builders<Pupil>.Filter.Eq(x => x.PupilId, id)).FirstOrDefault();
        }

        public IEnumerable<Pupil> Where(Expression<Func<Pupil, bool>> expression)
        {
            return mongoContext.Pupils.Find(expression).ToList();
        }
    }
}
