using MongoDB.Bson;
public class Movie {
    public ObjectId _id { get; set; }
    public string title{ get; set; } = null!;

    // public List<string> items { get; set; } = null!;

    public Movie(string title){
        this.title = title;
    }

}