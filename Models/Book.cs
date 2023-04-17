namespace Models
{
    public class Book
    {
        public readonly static string INSERT = "INSERT INTO Book (Name, NumberOfPages) VALUES (@Name, @NumberOfPages)";
        public readonly static string SELECT_ALL = "SELECT Id, Name, NumberOfPages FROM Book";

        public int Id { get; set; }
        public string? Name { get; set; }
        public int NumberOfPages { get; set; }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(
                new Book() { 
                    Id = this.Id, 
                    Name = this.Name, 
                    NumberOfPages = this.NumberOfPages
                }
            );
        }
    }
}