using Business.Concretes;
using DataAccess.Concretes.ADONET;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new MyBookListManager(new AdoMyBookListDal());
            var category = new BookManager(new AdoBookDal());

            book.Add(new MyBookList
            {
                BookId = 6003,
                UserId = 2,
                IsDelivered = true,
                DateOfUpload=DateTime.Now,
                DeliveryTime=DateTime.Now.AddMonths(1),
                ListId=1
            });

            //category.Update(new Book
            //{
            //    BookId=6003,
            //    LibraryId = 2,
            //    CategoryId = 2,
            //    AuthorName = "DenemeAdo1",
            //    BookName = "DenemeAdo1",
            //    Publisher = "DenemeAdo1",
            //    Stock = 15
            //});

            //category.Delete(new Book { BookId = 6002 });

            //foreach (var item in category.GetBookDetails().Data)
            //{
            //    Console.WriteLine(item.BookName);
            //}

            //foreach (var item in book.GetAllByUserId(2).Data)
            //{
            //    Console.WriteLine(item.BookName);
            //}

        }
    }
}
