using MongoDB.Bson;

namespace MongoDbWithEFApi.Entities;

public class Summary
{
    protected Summary(){}

    public Summary( string? title)
    {
        this.Title = title;
    }

    public ObjectId Id { get; set; }
    public string? Title { get; set;}
}
