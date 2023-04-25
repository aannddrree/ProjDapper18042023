namespace Models
{
    public class Book
    {
        public readonly static string INSERT = "INSERT INTO Book (Name, NumberOfPages, IdAuthor) VALUES (@Name, @NumberOfPages, @IdAuthor)";
        public readonly static string SELECT_ALL = "select b.id, b.Name, b.NumberOfPages, b.IdAuthor, a.Description from Book b INNER JOIN Author a on b.IdAuthor = a.IdAuthor";

        public int Id { get; set; }
        public string? Name { get; set; }
        public int NumberOfPages { get; set; }
        public Author Author { get; set; }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(
                new Book() { 
                    Id = this.Id, 
                    Name = this.Name, 
                    NumberOfPages = this.NumberOfPages,
                    Author = this.Author
                }
            );
        }
    }
}