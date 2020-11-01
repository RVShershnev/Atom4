using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.Culture.App.Data.Mongo;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Atom.Culture.App.Data.Services
{
    public class ParticipiantsService : IEntityService<Participiant>
    {
        MongoContext mongo;

        public ParticipiantsService(MongoContext mongo)
        {
            this.mongo = mongo;
        }

        public void Create(Participiant item)
        {
            item.LastUpdate = DateTime.Now;
            mongo.Participiants.InsertOne(item);
        }

        public void Update(Participiant item)
        {
            item.LastUpdate = DateTime.Now;
            mongo.Participiants.ReplaceOne(Builders<Participiant>.Filter.Eq(s => s.Id, item.Id), item);
        }

        public void Delete(string id)
        {
            var filter = Builders<Participiant>.Filter.Eq(s => s.Id, id);
            mongo.Participiants.DeleteOne(filter);
        }

        public Participiant Get(string id)
        {
            var filter = Builders<Participiant>.Filter.Eq(s => s.Id, id);
            return mongo.Participiants.Find(filter).FirstOrDefault();
        }

        public Participiant GetFromDataset(string id)
        {
            var pupil = mongo.Pupils.Find(Builders<Pupil>.Filter.Eq(x => x.PupilId, id)).FirstOrDefault();
            var megaRelations = mongo.MegaRelations.Find(Builders<MegaRelation>.Filter.Where(x => x.PupilId.Equals(pupil.PupilId))).ToList().Select(x => x.ServiceId);
            List<Service> services = mongo.Services.Find(Builders<Service>.Filter.Where(x => megaRelations.Contains(x.ServId))).ToList();

            Participiant participiant = new Participiant()
            {
                Id = id,
                Age = pupil.Age,
                Sex = pupil.Sex,
                Services = services
            };

            return participiant;
        }
    }
}
