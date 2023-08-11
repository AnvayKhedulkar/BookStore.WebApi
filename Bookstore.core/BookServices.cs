using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;


namespace Bookstore.core
{
    public class BookServices : IBookServices
    {
        private readonly IMongoCollection<Book> _books;

        public BookServices(IDbClient dbClient)
        {
           _books = dbClient.GetBookscollection();
        }
        public List<Book> GetBooks() =>_books.Find(book => true).ToList();
        
    }
}
