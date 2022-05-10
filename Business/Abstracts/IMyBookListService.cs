using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IMyBookListService
    {
        IDataResult<List<MyBookList>> GetAll();
        IResult Add(MyBookList entity);
        IResult Update(MyBookList entity);
        IResult Delete(MyBookList entity);
        IDataResult<List<MyBookList>> GetByBookId(int id);

        IDataResult<List<MyBookListDetailDto>> GetAllByUserId(int id);
    }
}
