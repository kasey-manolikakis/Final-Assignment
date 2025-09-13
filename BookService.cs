//does all the querying to the database 
//called from BookController
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using FinalAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalAssignment.Data;

namespace FinalAssignment
{
    public class BookService
    {
        private BookStoreContext _context;
        private ILogger<BookService> _logger;

        public BookService(BookStoreContext context, ILoggerFactory logger) 
        {
            _context = context;
            _logger = logger.CreateLogger<BookService>(); ;
        }

        public async Task<List<Book>> GetBooks() 
        {
            return await _context.Books.ToListAsync();
        }
        public async Task CreateBook() { }

        public async Task UpdateBook() { }

        public async Task DeleteBook() { }

        }
}
