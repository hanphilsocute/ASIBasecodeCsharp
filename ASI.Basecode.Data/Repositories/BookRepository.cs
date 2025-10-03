using ASI.Basecode.Data.Interfaces;
using ASI.Basecode.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly AsiBasecodeDBContext _dbContext;

        public BookRepository(AsiBasecodeDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Book> ViewBooks()
        {
            return _dbContext.Books.ToList();
        }

        public void AddBook(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }

        public Book GetById(int id)
        {
            return _dbContext.Books.FirstOrDefault(b => b.Id == id);
        }

        public void UpdateBook(Book book)
        {
            _dbContext.Books.Update(book);
            _dbContext.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var entity = _dbContext.Books.FirstOrDefault(b => b.Id == id);
            if (entity != null)
            {
                _dbContext.Books.Remove(entity);
                _dbContext.SaveChanges();
            }
        }
    }
}
