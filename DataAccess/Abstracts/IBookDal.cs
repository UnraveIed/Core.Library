using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface IBookDal : IEntityRepository<Book>
    {
        List<BookDetailsDto> GetBookDetails();
        List<BookDetailsDto> SearchBookName(string bookName);
        List<BookDetailsDto> OrderByStockDesc();
        List<BookDetailsDto> OrderByStockAsc();
        List<BookDetailsDto> BookSearchByCategory(string categoryName);
    }
}
