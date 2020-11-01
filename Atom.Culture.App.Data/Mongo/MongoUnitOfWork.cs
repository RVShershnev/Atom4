using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.Culture.App.Data.Repositories;
using Atom.Culture.App.Data.Services;

namespace Atom.Culture.App.Data.Mongo
{
    public class MongoUnitOfWork : IUnitOfWork
    {
        private IRepository<Book> books;
        private IRepository<Classificator> classificators;
        private IRepository<Event> events;
        private IRepository<Instance> instances;
        private IRepository<Issue> issues;
        private IRepository<Organization> organizations;
        private IRepository<Pupil> pupils;
        private IRepository<Reader> readers;
        private IRepository<Request> requests;
        private IRepository<Service> services;
        private IRepository<MegaRelation> megaRelations;
        private IEntityService<Person> persons;
        private IEntityService<Participiant> participians;
        private MongoContext mongoContext;

        public MongoUnitOfWork(string connectionString, string dbName)
        {
            mongoContext = new MongoContext(connectionString, dbName);
        }

        public IRepository<Book> Books
        {
            get
            {
                if (books == null)
                    books = new BooksRepository(mongoContext);
                return books;
            }
        }

        public IRepository<Classificator> Classificators
        {
            get
            {
                if (classificators == null)
                    classificators = new ClassificatorRepository(mongoContext);
                return classificators;
            }
        }

        public IRepository<Event> Events
        {
            get
            {
                if (events == null)
                    events = new EventsRepository(mongoContext);
                return events;
            }
        }

        public IRepository<Instance> Instances
        {
            get
            {
                if (instances == null)
                    instances = new InstancesRepository(mongoContext);
                return instances;
            }
        }

        public IRepository<Issue> Issues
        {
            get
            {
                if (issues == null)
                    issues = new IssuesRepository(mongoContext);
                return issues;
            }
        }

        public IRepository<Organization> Organizations
        {
            get
            {
                if (organizations == null)
                    organizations = new OrganizationsRepository(mongoContext);
                return organizations;
            }
        }

        public IRepository<Pupil> Pupils
        {
            get
            {
                if (pupils == null)
                    pupils = new PuppilsRepository(mongoContext);
                return pupils;
            }
        }

        public IRepository<Reader> Readers
        {
            get
            {
                if (readers == null)
                    readers = new ReadersRepository(mongoContext);
                return readers;
            }
        }

        public IRepository<Request> Requests
        {
            get
            {
                if (requests == null)
                    requests = new RequestsRepository(mongoContext);
                return requests;
            }
        }


        public IRepository<Service> Services
        {
            get
            {
                if (services == null)
                    services = new ServicesRepository(mongoContext);
                return services;
            }
        }

        public IRepository<MegaRelation> MegaRelations
        {
            get
            {
                if (megaRelations == null)
                    megaRelations = new MegaRelationRepository(mongoContext);
                return megaRelations;
            }
        }

        public IEntityService<Person> Persons
        {
            get
            {
                if (persons == null)
                    persons = new PersonsService(mongoContext);
                return persons;
            }
        }

        public IEntityService<Participiant> Participiants
        {
            get
            {
                if (participians == null)
                    participians = new ParticipiantsService(mongoContext);
                return participians;
            }
        }
    }
}
