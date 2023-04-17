using Models;
using Services;

namespace Controllers
{
    public class BookController
    {
        private BookService bookService;

        public BookController()
        {
            bookService = new BookService();
        }
        
        public bool Insert(Book book)
        {
            return bookService.Insert(book);
        }

        public List<Book> FindAll()
        {
            return bookService.FindAll();
        }
    }
}