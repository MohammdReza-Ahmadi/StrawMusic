using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDataAccess.Models;

public class ChoreHistoryModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public long Id { get; set; }
    public long ChoreId { get; set; }
    public string ChoreText { get; set; }
    public UserModel WhoComplted { get; set; }
    public DateTime DateCompleted { get; set; }
    public ChoreHistoryModel()
    {
            
    }

    public ChoreHistoryModel(Chore chore)
    {
        ChoreId = chore.Id;
        DateCompleted = chore.LastCompleted ?? DateTime.Now;
        WhoComplted = chore.AssignedTo;
        ChoreText = chore.ChoreText;
    }
}