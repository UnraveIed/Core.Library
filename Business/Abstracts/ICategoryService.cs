using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IResult Add(Category entity);
        IResult Update(Category entity);
        IResult Delete(Category entity);
        IDataResult<Category> GetById(int id);
        IDataResult<List<Category>> GetByCategoryName(string key);
    }
}
