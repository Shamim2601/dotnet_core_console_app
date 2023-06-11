// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using MongoDB.Driver;

MongoClient client = new MongoClient("mongodb+srv://1805060:shaMIM2601@cluster0.7tgmx7t.mongodb.net/?retryWrites=true&w=majority");

// var MoviesCollection = client.GetDatabase("sample_mflix").GetCollection<Movie>("movies");

// MoviesCollection.InsertOne(new Movie("matha nosto"));

var SessionCollection = client.GetDatabase("sample_mflix").GetCollection<Session>("sessions");

// SessionCollection.InsertOne(new Session("shamim", "4riejjdjfkjrdoidhjeyriuyhtrejrjy983yr943r8efdh"));

FilterDefinition<Session> filter = Builders<Session>.Filter.Eq("user_id", "shamim");
List<Session> results = SessionCollection.Find(filter).ToList();

foreach(Session result in results){
    Console.WriteLine(result.jwt);
}

// SessionCollection.DeleteOne(filter);