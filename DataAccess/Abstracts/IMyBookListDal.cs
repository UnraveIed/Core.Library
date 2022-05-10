using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface IMyBookListDal : IEntityRepository<MyBookList>
    {
        List<MyBookListDetailDto> GetAllByUserId();
    }
}
