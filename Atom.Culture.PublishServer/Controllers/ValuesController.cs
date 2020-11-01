using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.CultureShared;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson.IO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atom.Culture.PublishServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        IUnitOfWork unitOfWork;

        public ValuesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public string Get()
        {
            return DateTime.Now.ToString();
        }

        // GET api/<ValuesController>/5
        [HttpGet("person/{id}")]
        public string GetPerson(string id)
        {
            // найти пользователя и выдать о нем информацию.
            Atom.CultureShared.Person result = new Atom.CultureShared.Person();
            Atom.Culture.App.Data.Models.Person person = unitOfWork.Persons.GetFromDataset(id);
            var stringresult = Newtonsoft.Json.JsonConvert.SerializeObject(result);
            return stringresult;

            result.Bithday = person.BirthDate;           
            result.Name = "Аноним";
            result.Sex = "Другое";
            result.Email = person.Email;
            result.Id = person.Id;

            
            //var recEvents = RecBooks();
            //var recServices = RecEvents();
                                
        }

        //public Task<IEnumerable<Book>> RecBooks()
        //{
        //    var result = unitOfWork.Books.Where(x => x.Name != "").Skip(100).Take(5);
        //    return result;
        //}
        //public Task<IEnumerable<Event>> RecEvents()
        //{
        //    var result = unitOfWork.Books.Where(x => x.Name != "").Skip(100).Take(5);
        //    return result;
        //}
       
        //public Task<IEnumerable<Service>> RecServices()
        //{
        //    var result = unitOfWork.Books.Where(x => x.Name != "").Skip(100).Take(5);
        //    return result;
        //}



        [HttpGet("group/{id}")]
        public string GetGroup(string ids)
        {
            // найти пользователя и выдать о нем информацию.
            Group group = new Group();
            group.Persons.Add(new Atom.CultureShared.Person() { Age = "11", Email="12121"});
            //person.Age = "19";
            //person.Name = "Roman";
            var result = Newtonsoft.Json.JsonConvert.SerializeObject(group);
            return result;
        }            
    }
}
