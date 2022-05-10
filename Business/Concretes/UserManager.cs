using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User entity)
        {
            _userDal.Add(entity);
            return new SuccessResult("Kullanıcı başarıyla eklendi");
        }

        public IResult CheckUser(User user)
        {
            //if(_userDal.Get())
            //{
            //    
            //}
            //else if(_userDal.Get(p => p.Password.Contains(user.Password)) == null)
            //{
            //    
            //}
            //else
            //{
            //    return new SuccessResult();
            //}
            return new SuccessResult();
        }

        public IResult Delete(User entity)
        {
            _userDal.Delete(entity);
            return new SuccessResult("Kullanıcı başarıyla silindi");
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.UserId == id));
        }

        public IDataResult<User> GetByPassword(string key)
        {

            return new SuccessDataResult<User>(_userDal.Get(p => p.Password == key));
        }

        public IDataResult<User> GetByUserName(string key)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.UserName == key));
        }

        public IResult Update(User entity)
        {
            _userDal.Update(entity);
            return new SuccessResult("Kullanıcı başarıyla güncellendi");
        }

        public IResult checkLogin(string userName, string password)
        {
            if (GetByUserName(userName).Data == null)
            {
                return new ErrorResult("Kullanici adi bulunamadi");
            }
            else if (GetByPassword(password).Data == null)
            {
                return new ErrorResult("Sifre bulunamadi");
            }
            else
            {
                return new SuccessResult();
            }
        }

        
    }
}
