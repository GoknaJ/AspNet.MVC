using AspNet.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.MVC.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            var author1 = new Author { AuthorId = 001, Name = "George R. R. Martine", NumberOfBooks = 1 };
            var author2 = new Author { AuthorId = 002, Name = "J. R. R. Tolkien", NumberOfBooks = 1 };
            var author3 = new Author { AuthorId = 003, Name = "J. K. Rowling", NumberOfBooks = 3 };

            var books = new List<Book>
            {
                new Book { BookId = 1111, Title = "A Game of Thrones", Author = author1 },
                new Book { BookId = 1112, Title = "The Lord of the Rings", Author = author2 },
                new Book { BookId = 1113, Title = "Harry Potter and the Philosopher's Stone", Author = author3 },
                new Book { BookId = 1114, Title = "Harry Potter and the Chamber of Secrets", Author = author3 },
                new Book { BookId = 1115, Title = "Harry Potter and the Prisoner of Azkaban", Author = author3 }
            };

            return View(books);
        }
    }
}
