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
    public class MyBookListManager : IMyBookListService
    {
        private IMyBookListDal _myBookListDal;

        public MyBookListManager(IMyBookListDal myBookListDal)
        {
            _myBookListDal = myBookListDal;
        }

        public IResult Add(MyBookList entity)
        {
            _myBookListDal.Add(entity);
            return new SuccessResult("Kitap başarıyla listene eklendi");
        }

        public IResult Delete(MyBookList entity)
        {
            _myBookListDal.Delete(entity);
            return new SuccessResult("Kitap başarıyla iade edildi");
        }

        public IDataResult<List<MyBookList>> GetAll()
        {
            return new SuccessDataResult<List<MyBookList>>(_myBookListDal.GetAll());
        }

        public IDataResult<List<MyBookListDetailDto>> GetAllByUserId(int id)
        {
            return new SuccessDataResult<List<MyBookListDetailDto>>(_myBookListDal.GetAllByUserId().Where(p => p.UserId == id).ToList());
        }

        public IDataResult<List<MyBookList>> GetByBookId(int id)
        {
            return new SuccessDataResult<List<MyBookList>>(_myBookListDal.GetAll(p=> p.BookId == id));
        }


        public IResult Update(MyBookList entity)
        {
            _myBookListDal.Update(entity);
            return new SuccessResult("Kitap başarıyla iade edildi");
        }
    }
}
