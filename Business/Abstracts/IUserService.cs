using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IResult Add(User entity);
        IResult Update(User entity);
        IResult Delete(User entity);
        IDataResult<User> GetById(int id);
        IDataResult<User> GetByUserName(string key);
        IResult CheckUser(User user);
        IDataResult<User> GetByPassword(string key);
        IResult checkLogin(string userName, string password);
    }
}
