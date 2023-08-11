
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Bookstore.core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Book> _books;
        public DbClient(IOptions<BookstoreDbConfig> bookstioreDbconfig)
        {
            var client = new MongoClient(bookstioreDbconfig.Value.Connection_String);
            var database = client.GetDatabase(bookstioreDbconfig.Value.Database_Name);
            _books = database.GetCollection<Book>(bookstioreDbconfig.Value.Books_Collection_Name);
        }
        public IMongoCollection<Book> GetBookscollection() => _books;
    }
}
