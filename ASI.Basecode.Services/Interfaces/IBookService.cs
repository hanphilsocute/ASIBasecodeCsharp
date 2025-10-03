using ASI.Basecode.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Services.Interfaces
{
    public interface IBookService
    {
        void AddBook(Book book);

        List<Book> ViewBooks();

        Book GetBookById(int id);
        void UpdateBook(Book book);
        void DeleteBook(int id);
    }
}
