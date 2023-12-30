using MongoDb_Demo.Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace MongoDb_Demo.DbLib;

public class DbContext
{
    private const string CONNECTION_STRING = "mongodb://localhost:27017";
    private const string DB_NAME = "books_db";
    private const string COLLECTION_NAME = "books";
    
    private IMongoCollection<BsonDocument> _books;

    public DbContext()
    {
        var client = new MongoClient(CONNECTION_STRING);
        var db = client.GetDatabase(DB_NAME);
        _books = db.GetCollection<BsonDocument>(COLLECTION_NAME);
    }

    public IEnumerable<Book> GetAll()
    {
        var books = _books.Find(new BsonDocument()).ToList();
        foreach (var book in books)
        {
            yield return BsonSerializer.Deserialize<Book>(book);
        }
    }
}