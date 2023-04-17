using Models;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace Repositories
{
    public class BookRepository : IBookRepository
    {
        private string Conn { get; set; }

        public BookRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool Insert(Book book)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute(Book.INSERT, book);
                status = true;
            }
            return status;
        }

        public List<Book> FindAll()
        {
            using (var db = new SqlConnection(Conn))
            {
                var books = db.Query<Book>(Book.SELECT_ALL);
                return (List<Book>)books;
            }
        }
    }
}