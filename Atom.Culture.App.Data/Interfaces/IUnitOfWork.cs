using Atom.Culture.App.Data.Models;

namespace Atom.Culture.App.Data.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Book> Books {get;}
        IRepository<Classificator> Classificators { get; }
        IRepository<Event> Events {get;}
        IRepository<Instance> Instances { get;}
        IRepository<Issue> Issues { get;}
        IRepository<Organization> Organizations { get;}
        IRepository<Pupil> Pupils {get;}
        IRepository<Reader> Readers { get;}
        IRepository<Request> Requests { get;}
        IRepository<Service> Services { get;}
        IRepository<MegaRelation> MegaRelations { get;}
        IEntityService<Person> Persons { get; }
        IEntityService<Participiant> Participiants { get; }
    }
}
