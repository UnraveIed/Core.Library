using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        public List<NewCustomerDto> NewCustomer();
    }
}
