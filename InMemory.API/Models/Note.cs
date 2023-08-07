namespace InMemory.API.Models
{
    public class Note
    {
        public int Id { get; set; }
        public double Point { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
