using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDataAccess.Models;

public class UserModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public long Id { get; set; }    
    public string FirstName { get; set; }    
    public string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}";
}