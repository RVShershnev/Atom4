using Atom.Culture.App.Data.Models;
using MongoDB.Driver;

namespace Atom.Culture.App.Data.Mongo
{
    public class MongoContext
    {
        private IMongoDatabase db = null;

        public MongoContext(string connectionString, string dbName)
        {
            var client = new MongoClient(connectionString);
            if (client != null)
                db = client.GetDatabase(dbName);
            var books = db.GetCollection<Book>("Books");
        }

        public IMongoCollection<Event> Events
        {
            get
            {
                return db.GetCollection<Event>("Events");
            }
        }

        public IMongoCollection<Book> Books
        {
            get
            {
                return db.GetCollection<Book>("Books");
            }
        }

        public IMongoCollection<Service> Services
        {
            get
            {
                return db.GetCollection<Service>("Services");
            }
        }

        public IMongoCollection<Organization> Organizations
        {
            get
            {
                return db.GetCollection<Organization>("Organizations");
            }
        }

        public IMongoCollection<Issue> Issues
        {
            get
            {
                return db.GetCollection<Issue>("Issues");
            }
        }

        public IMongoCollection<Instance> Instances
        {
            get
            {
                return db.GetCollection<Instance>("Instances");
            }
        }

        public IMongoCollection<Reader> Readers
        {
            get
            {
                return db.GetCollection<Reader>("Readers");
            }
        }

        public IMongoCollection<Pupil> Pupils
        {
            get
            {
                return db.GetCollection<Pupil>("Pupils");
            }
        }

        public IMongoCollection<Request> Requests
        {
            get
            {
                return db.GetCollection<Request>("Requests");
            }
        }

        public IMongoCollection<Classificator> Classificators
        {
            get
            {
                return db.GetCollection<Classificator>("Classificators");
            }
        }

        public IMongoCollection<MegaRelation> MegaRelations
        {
            get
            {
                return db.GetCollection<MegaRelation>("MegaRelations");
            }
        }

        public IMongoCollection<Person> Persons
        {
            get
            {
                return db.GetCollection<Person>("Persons");
            }
        }

        public IMongoCollection<Participiant> Participiants
        {
            get
            {
                return db.GetCollection<Participiant>("Participiants");
            }
        }
    }
}
