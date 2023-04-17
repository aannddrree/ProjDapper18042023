using Models;
using Repositories;

namespace Services
{
    public class BookService
    {

        private IBookRepository bookRepository;

        public BookService()
        {
            bookRepository = new BookRepository();
        }

        public bool Insert(Book book)
        {
            return bookRepository.Insert(book);
        }

        public List<Book> FindAll()
        {
            return bookRepository.FindAll();
        }
    }
}