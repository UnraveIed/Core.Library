using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concretes
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer entity)
        {
            _customerDal.Add(entity);
            return new SuccessResult("Kullanıcı başarıyla eklendi");
        }


        public IResult Delete(Customer entity)
        {
            _customerDal.Delete(entity);
            return new SuccessResult("Kullanıcı başarıyla silindi");
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.CustomerId == id));
        }

        public IDataResult<Customer> GetByLoginUserId(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.UserId == id && p.IsActive == true));
        }

        public IDataResult<Customer> GetByUserId(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.UserId == id));
        }

        public IDataResult<List<NewCustomerDto>> NewCustomer()
        {
            return new SuccessDataResult<List<NewCustomerDto>>(_customerDal.NewCustomer());
        }

        public IResult Update(Customer entity)
        {
            _customerDal.Update(entity);
            return new SuccessResult("Kullanıcı başarıyla güncellendi");
        }
    }
}
