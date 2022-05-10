using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, LibraryDbContext>, ICustomerDal
    {
        public List<NewCustomerDto> NewCustomer()
        {
            using (var context = new LibraryDbContext())
            {
                var result = from c in context.Customers
                             join u in context.Users on c.UserId equals u.UserId
                             select new NewCustomerDto
                             {
                                 CustomerId = c.CustomerId,
                                 Surname = c.Surname,
                                 Name = c.Name,
                                 Email = c.Email,
                                 UserName = u.UserName,
                                 Password = u.Password
                             };
                return result.ToList();
            }
        }
    }
}
