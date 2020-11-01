﻿using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.Culture.PublishServer.Services;
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
        MlService _MlService;
        IUnitOfWork unitOfWork;

        public ValuesController(IUnitOfWork unitOfWork, MlService mlService)
        {
            this.unitOfWork = unitOfWork;
            this._MlService = mlService;
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

            var nameBook = ""; // из базы.
            var newNameBooks = _MlService.BookModel(nameBook);

            List<Culture.App.Data.Models.Book> recomendationBooks; // = из базы.

            var recomendation = new List<IRecomendation>();

            foreach(var item in newNameBooks)
            {
                var book = new CultureShared.Book();
                book.Name = "тест";

                recomendation.Add(book);

            }    
            
            // случайный набор

            return stringresult;
            
            result.Bithday = person.BirthDate;           
            result.Name = "Аноним";
            result.Sex = "Другое";
            result.Email = person.Email;
            result.Id = person.Id;

        }

       


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
