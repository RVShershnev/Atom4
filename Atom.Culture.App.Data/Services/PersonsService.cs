using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.Culture.App.Data.Mongo;
using MongoDB.Driver;
using System;
using System.Linq;

namespace Atom.Culture.App.Data.Services
{
    public class PersonsService : IEntityService<Person>
    {
        MongoContext mongo;

        public PersonsService(MongoContext mongo)
        {
            this.mongo = mongo;
        }

        public void Create(Person item)
        {
            item.LastUpdate = DateTime.Now;
            mongo.Persons.InsertOne(item);
        }

        public void Update(Person item)
        {
            item.LastUpdate = DateTime.Now;
            mongo.Persons.ReplaceOne(Builders<Person>.Filter.Eq(s => s.Id, item.Id), item);
        }

        public void Delete(string id)
        {
            var filter = Builders<Person>.Filter.Eq(s => s.Id, id);
            mongo.Persons.DeleteOne(filter);
        }

        public Person Get(string id)
        {
            var filter = Builders<Person>.Filter.Eq(s => s.Id, id);
            return mongo.Persons.Find(filter).FirstOrDefault();
        }

        public Person GetFromDataset(string id)
        {
            var reader = mongo.Readers.Find(Builders<Reader>.Filter.Eq(x => x.ReaderId, id)).FirstOrDefault();
            Person person = null;
            if (reader != null)
            {
                var issues = mongo.Issues.Find(Builders<Issue>.Filter.Eq(x => x.ReaderId, reader.ReaderId)).ToList().Select(x => x.BarCode);
                var instances = mongo.Instances.Find(Builders<Instance>.Filter.Where(x => issues.Contains(x.BarCode))).ToList().Select(x => x.CatalogRecordId);
                var books = mongo.Books.Find(Builders<Book>.Filter.Where(x => instances.Contains(x.DocId))).ToList();
                person = new Person()
                {
                    Id = reader.ReaderId,
                    BirthDate = reader.BirthDate,
                    Books = books
                };
            }
            return person;
        }
    }
}
