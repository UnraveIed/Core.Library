using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IResult Add(Customer entity);
        IResult Update(Customer entity);
        IResult Delete(Customer entity);
        IDataResult<Customer> GetById(int id);
        IDataResult<Customer> GetByUserId(int id);
        public IDataResult<List<NewCustomerDto>> NewCustomer();

        IDataResult<Customer> GetByLoginUserId(int id);
    }
}
