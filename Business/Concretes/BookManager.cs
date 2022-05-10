using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business.Concretes
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public IResult Add(Book entity)
        {
            _bookDal.Add(entity);
            return new SuccessResult("Kitap başarıyla eklendi");
        }

        public IResult Delete(Book entity)
        {
            _bookDal.Delete(entity);
            return new SuccessResult("Kitap başarıyla silindi");
        }

        public IDataResult<Book> GetById(int id)
        {
            return new SuccessDataResult<Book>(_bookDal.Get(p=>p.BookId==id));
        }

        public IDataResult<List<Book>> GetByCategoryId(int id)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(p => p.CategoryId == id));
        }

        public IResult Update(Book entity)
        {
            _bookDal.Update(entity);
            return new SuccessResult("Kitap başarıyla güncellendi");
        }

        public IDataResult<List<Book>> GetAll()
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll());
        }

        public IDataResult<List<Book>> GetByBookName(string key)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(p => p.BookName.ToLower().Contains(key.ToLower())));

        }

        public IDataResult<List<BookDetailsDto>> GetBookDetails()
        {
            return new SuccessDataResult<List<BookDetailsDto>>(_bookDal.GetBookDetails().Where(p=> p.IsAvailable == true).ToList());
        }

        public IDataResult<List<BookDetailsDto>> SearchBookName(string bookName)
        {
            return new SuccessDataResult<List<BookDetailsDto>>(_bookDal.SearchBookName(bookName));
        }

        public IDataResult<List<BookDetailsDto>> OrderByStockDesc()
        {
            return new SuccessDataResult<List<BookDetailsDto>>(_bookDal.OrderByStockDesc());
        }

        public IDataResult<List<BookDetailsDto>> OrderByStockAsc()
        {
            return new SuccessDataResult<List<BookDetailsDto>>(_bookDal.OrderByStockAsc());
        }

        public IDataResult<List<BookDetailsDto>> BookSearchByCategory(string categoryName)
        {
            return new SuccessDataResult<List<BookDetailsDto>>(_bookDal.BookSearchByCategory(categoryName));
        }
    }
}
