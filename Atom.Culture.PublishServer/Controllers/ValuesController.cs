using Atom.Culture.App.Data.Interfaces;
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
        static Random random = new Random();
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

            var stringresult = Newtonsoft.Json.JsonConvert.SerializeObject(result);

            Atom.Culture.App.Data.Models.Person personFromDataSet = unitOfWork.Persons.GetFromDataset("2569");
            if (personFromDataSet == null)
            {
                // Сказать, что такого читателя не существует 
            }
            var nameBook = GetTheBestBookFromPerson(personFromDataSet); // из базы.
            List<Book> recomendationBooks;
            if (nameBook == null)
            {
                // Сказать, что он ещё не читал книги и дать рандомные
                recomendationBooks = GetRandomBooks();
            }

            var newNameBooks = _MlService.BookModel(nameBook);

<<<<<<< HEAD
            List<Culture.App.Data.Models.Book> recomendationBooks; // = из базы.

            var recomendation = new List<IRecomendation>();
=======
>>>>>>> 4a8657912c19cc200f19c82a18121ae489dcdab0


            foreach (var item in newNameBooks)
            {
<<<<<<< HEAD
                var book = new CultureShared.Book();
                book.Name = "тест";

                recomendation.Add(book);

            }    
            
            // случайный набор

=======
                var Recomendation = new Recomendation();


            }
>>>>>>> 4a8657912c19cc200f19c82a18121ae489dcdab0
            return stringresult;

            result.Bithday = personFromDataSet.BirthDate;
            result.Name = "Аноним";
            result.Sex = "Другое";
            result.Email = personFromDataSet.Email;
            result.Id = personFromDataSet.Id;


<<<<<<< HEAD
        }

       
=======
            //var recEvents = RecBooks();
            //var recServices = RecEvents();

        }

        private List<Book> GetRandomBooks()
        {
            int booksCount = random.Next(3, 6);
            var allBooks = unitOfWork.Books.Where(x => true);
            return allBooks.Skip(random.Next(0, allBooks.Count() - booksCount)).Take(booksCount).ToList();
        }

        private string GetTheBestBookFromPerson(Culture.App.Data.Models.Person personFromDataSet)
        {
            string result = null;
            if (personFromDataSet.Books.Count >= 0)
            {
                result = personFromDataSet.Books.ElementAt(random.Next(0, personFromDataSet.Books.Count)).Name;
            }
            return result;
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

>>>>>>> 4a8657912c19cc200f19c82a18121ae489dcdab0


        [HttpGet("group/{id}")]
        public string GetGroup(string ids)
        {
            // найти пользователя и выдать о нем информацию.
            Group group = new Group();
            group.Persons.Add(new Atom.CultureShared.Person() { Age = "11", Email = "12121" });
            //person.Age = "19";
            //person.Name = "Roman";
            var result = Newtonsoft.Json.JsonConvert.SerializeObject(group);
            return result;
        }
    }
}
