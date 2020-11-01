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
    public class EventsRepository : IRepository<Event>
    {
        MongoContext mongoContext;

        public EventsRepository(MongoContext mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public Event Get(string id)
        {
            return mongoContext.Events.Find(Builders<Event>.Filter.Eq(x => x.EvId, id)).FirstOrDefault();
        }

        public IEnumerable<Event> Where(Expression<Func<Event, bool>> expression)
        {
            return mongoContext.Events.Find(expression).ToList();
        }
    }
}
