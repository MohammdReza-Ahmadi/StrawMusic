using MongoDataAccess.Models;
using MongoDB.Driver;

namespace MongoDataAccess.DataAccess;

public class ChoreDataAccess
{
    private const string ConnectionString = "mongodb://127.0.0.1:27017";
    private const string DatabaseName = "choredb";
    private const string ChoreCollection = "chore_chart";
    private const string UserCollection = "users";
    private const string ChoreHistoryCollection = "chore_history";
    private IMongoCollection<T> ConnectToMongo<T>(in string collection)
    {
        var client = new MongoClient(ConnectionString);
        var db = client.GetDatabase(DatabaseName);
        return db.GetCollection<T>(collection);
    }

    private async Task<List<UserModel>> GetAllUser()
    {
        var usersCollection = ConnectToMongo<UserModel>(UserCollection);
        var results = await usersCollection.FindAsync(_ => true);
        return  results.ToList();
    }

    public async Task<List<Chore>> GetAllChores()
    {
        var choreCollection = ConnectToMongo<Chore>(ChoreCollection);
        var results = await choreCollection.FindAsync(_ => true);
        return  results.ToList();
    }

    public async Task<List<Chore>> GetAllChoresForAUser(UserModel user)
    {
        var choreCollection = ConnectToMongo<Chore>(ChoreCollection);
        var results = await choreCollection.FindAsync(c => c.AssignedTo.Id == user.Id);
        return  results.ToList();
    }

    public Task CreateUser(UserModel user)
    {
        var usersCollection = ConnectToMongo<UserModel>(UserCollection);
        return usersCollection.InsertOneAsync(user);
    }

    public Task CreateChore(Chore chore)
    {
        var choreCollection = ConnectToMongo<Chore>(ChoreCollection);
        return choreCollection.InsertOneAsync(chore);
    }

    public Task UpdateChore(Chore chore)
    {
        var choreCollection = ConnectToMongo<Chore>(ChoreCollection);
        var filter = Builders<Chore>.Filter.Eq("Id", chore.Id);
        return choreCollection.ReplaceOneAsync(filter, chore, new ReplaceOptions {IsUpsert = true});
    }

    public Task DeleteChore(Chore chore)
    {
        var choreCollection = ConnectToMongo<Chore>(ChoreCollection);
        return choreCollection.DeleteOneAsync(c=>c.Id == chore.Id);
    }
}