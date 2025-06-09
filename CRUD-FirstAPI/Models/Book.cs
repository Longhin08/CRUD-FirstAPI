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
      
        public int Id { get; }
        public string Title { get; } = null!;
        public string Author { get; } = null!;
        public int YearPublished { get; }

    }
}
