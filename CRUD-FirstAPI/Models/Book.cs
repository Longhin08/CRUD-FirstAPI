namespace CRUD_FirstAPI.Models
{
    public class Book
    {
        public Book(int id, string title, string author, int yearPublished)
        {
            Id = id;
            Title = title;
            Author = author;
            YearPublished = yearPublished;
        }
      
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public int YearPublished { get; set; }

    }
}
