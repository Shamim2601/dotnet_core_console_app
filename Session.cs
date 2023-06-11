using MongoDB.Bson;
public class Session {
    public ObjectId _id { get; set; }
    public string user_id{ get; set; } = null!;
    public string jwt{ get; set; } = null!;

    // public List<string> items { get; set; } = null!;

    public Session(string user_id, string jwt){
        this.user_id = user_id;
        this.jwt = jwt;
    }

}