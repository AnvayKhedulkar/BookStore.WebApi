using MongoDB.Bson.Serialization.Attributes;


namespace Bookstore.core
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }

    }
}
