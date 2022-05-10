using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IManagerService 
    {
        IDataResult<List<Manager>> GetAll();
        IResult Add(Manager entity);
        IResult Update(Manager entity);
        IResult Delete(Manager entity);
        IDataResult<Manager> GetById(int id);
    }
}
