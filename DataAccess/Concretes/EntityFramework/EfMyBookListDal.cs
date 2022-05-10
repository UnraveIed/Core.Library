using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfMyBookListDal : EfEntityRepositoryBase<MyBookList, LibraryDbContext>, IMyBookListDal
    {
        public List<MyBookListDetailDto> GetAllByUserId()
        {
            using (var context = new LibraryDbContext())
            {
                var result = from m in context.MyBookLists
                             join b in context.Books on m.BookId equals b.BookId
                             join c in context.Categories on b.CategoryId equals c.CategoryId
                             join l in context.Libraries on b.LibraryId equals l.LibraryId
                             select new MyBookListDetailDto
                             {
                                 BookId = m.BookId,
                                 Author = b.AuthorName,
                                 BookName = b.BookName,
                                 CategoryName = c.CategoryName,
                                 DateOfUpload = m.DateOfUpload,
                                 DeliveredTime = m.DeliveryTime,
                                 LibraryName = l.LibraryName,
                                 ListId = m.ListId,
                                 Publisher = b.Publisher,
                                 UserId = m.UserId
                             };
                return result.ToList();
            }
        }
    }
}
