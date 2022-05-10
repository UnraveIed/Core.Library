using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Concretes.ADONET;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfBookDal : EfEntityRepositoryBase<Book, LibraryDbContext>, IBookDal
    {
        AdoBookDal _adoBook = new AdoBookDal();

        public List<BookDetailsDto> BookSearchByCategory(string categoryName)
        {
            return _adoBook.BookSearchByCategory(categoryName);
        }

        public List<BookDetailsDto> GetBookDetails()
        {
            using (var context = new LibraryDbContext())
            {
                var result = from b in context.Books
                             join c in context.Categories on b.CategoryId equals c.CategoryId
                             join l in context.Libraries on b.LibraryId equals l.LibraryId
                             select new BookDetailsDto
                             {
                                 BookId = b.BookId,
                                 Stock = b.Stock,
                                 AuthorName = b.AuthorName,
                                 BookName = b.BookName,
                                 CategoryName = c.CategoryName,
                                 LibraryName = l.LibraryName,
                                 Publisher = b.Publisher,
                                 IsAvailable = l.IsAvailable
                             };
                return result.ToList();
            }
        }

        public List<BookDetailsDto> OrderByStockAsc()
        {
            return _adoBook.OrderByStockAsc();
        }

        public List<BookDetailsDto> OrderByStockDesc()
        {
            return _adoBook.OrderByStockDesc();
        }

        public List<BookDetailsDto> SearchBookName(string bookName)
        {
            
            return _adoBook.SearchBookName(bookName);
        }
    }
}
