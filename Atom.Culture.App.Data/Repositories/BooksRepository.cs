using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.Culture.App.Data.Mongo;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Atom.Culture.App.Data
{
    public class BooksRepository : IRepository<Book>
    {
        MongoContext mongoContext;

        public BooksRepository(MongoContext mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public Book Get(string id)
        {
            return mongoContext.Books.Find(Builders<Book>.Filter.Eq(x => x.DocId, id)).FirstOrDefault();
        }

        public IEnumerable<Book> Where(Expression<Func<Book, bool>> expression)
        {
            return mongoContext.Books.Find(expression).ToList();
        }
    }
}
