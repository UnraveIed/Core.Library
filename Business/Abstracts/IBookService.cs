using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IBookService
    {
        IDataResult<List<Book>> GetAll();
        IResult Add(Book entity);
        IResult Update(Book entity);
        IResult Delete(Book entity);
        IDataResult<Book> GetById(int id);
        IDataResult<List<Book>> GetByCategoryId(int id);
        IDataResult<List<Book>> GetByBookName(string key);
        IDataResult<List<BookDetailsDto>> GetBookDetails();
        IDataResult<List<BookDetailsDto>> SearchBookName(string bookName);
        IDataResult<List<BookDetailsDto>> OrderByStockDesc();
        IDataResult<List<BookDetailsDto>> OrderByStockAsc();
        IDataResult<List<BookDetailsDto>> BookSearchByCategory(string categoryName);

    }
}
