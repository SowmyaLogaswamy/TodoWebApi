namespace TodoApi.Models
{

    //Models is a set of classes that represent the data that the app manages
    public class TodoItem
    {
        public long Id { get; set; } // Id property functions as a unique key in a relational database
        public string? Name { get; set; }
        public bool IsComplete { get; set; }

    }
}
