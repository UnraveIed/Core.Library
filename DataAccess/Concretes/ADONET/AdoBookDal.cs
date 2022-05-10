using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concretes.ADONET
{
    public class AdoBookDal : IBookDal
    {
        public void Add(Book entity)
        {
            using (SqlCommand cmd =
                new SqlCommand(@"Insert into Books (LibraryId,CategoryId,BookName,AuthorName,Publisher,Stock) 
                values (@LibraryId,@CategoryId,@BookName,@AuthorName,@Publisher,@Stock)"))
            {
                cmd.Parameters.AddWithValue("@LibraryId", SqlDbType.Int).Value = entity.LibraryId;
                cmd.Parameters.AddWithValue("@CategoryId", SqlDbType.Int).Value = entity.CategoryId;
                cmd.Parameters.AddWithValue("@BookName", SqlDbType.NVarChar).Value = entity.BookName;
                cmd.Parameters.AddWithValue("@AuthorName", SqlDbType.NVarChar).Value = entity.AuthorName;
                cmd.Parameters.AddWithValue("@Publisher", SqlDbType.NVarChar).Value = entity.Publisher;
                cmd.Parameters.AddWithValue("@Stock", SqlDbType.Int).Value = entity.Stock;
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public List<BookDetailsDto> SearchBookName(string bookName)
        {
            var bookList = new List<BookDetailsDto>();
            SqlCommand cmd = new SqlCommand(@"sp_BookNameSearch");
            cmd.Parameters.AddWithValue("@BookName",SqlDbType.NVarChar).Value=bookName;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                var book = new BookDetailsDto
                {
                    BookId = int.Parse(reader[0].ToString()),
                    BookName = reader[1].ToString(),
                    AuthorName = reader[2].ToString(),
                    Publisher = reader[3].ToString(),
                    Stock = int.Parse(reader[4].ToString()),
                    CategoryName = reader[5].ToString(),
                    LibraryName = reader[6].ToString(),
                    IsAvailable = Convert.ToBoolean(reader[7])
                };
                bookList.Add(book);
            }
            return bookList;
        }

        public void Delete(Book entity)
        {
            using (SqlCommand cmd =
                new SqlCommand(@"delete from Books where BookId=@BookId"))
            {
                cmd.Parameters.AddWithValue("@BookId", SqlDbType.Int).Value = entity.BookId;
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public Book Get(Expression<Func<Book, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll(Expression<Func<Book, bool>> filter = null)
        {
            var bookList = new List<Book>();
            SqlCommand cmd = new SqlCommand(@"select * from Books");
            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            
            while (reader.Read())
            {
                var book= new Book{
                    BookId=int.Parse(reader[0].ToString()),
                    LibraryId=int.Parse(reader[1].ToString()),
                    CategoryId=int.Parse(reader[2].ToString()),
                    BookName= reader[3].ToString(),
                    AuthorName= reader[4].ToString(),
                    Publisher= reader[5].ToString(),
                    Stock=int.Parse(reader[6].ToString())
                };
                bookList.Add(book);
            }
            return bookList;
        }

        public List<BookDetailsDto> GetBookDetails()
        {
            var bookDetailList = new List<BookDetailsDto>();
            SqlCommand cmd = new SqlCommand(@"sp_BookDetailsDto");
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                var book = new BookDetailsDto
                {
                    BookId = int.Parse(reader[0].ToString()),
                    BookName = reader[1].ToString(),
                    AuthorName = reader[2].ToString(),
                    Publisher = reader[3].ToString(),
                    Stock = int.Parse(reader[4].ToString()),
                    CategoryName = reader[5].ToString(),
                    LibraryName = reader[6].ToString(),
                    IsAvailable = Convert.ToBoolean(reader[7])
                };
                bookDetailList.Add(book);
            }
            return bookDetailList;
        }

        public void Update(Book entity)
        {
            using (SqlCommand cmd =
                new SqlCommand(@"update Books set 
                                    LibraryId=@LibraryId, CategoryId=@CategoryId, BookName=@BookName, AuthorName=@AuthorName, Publisher=@Publisher, Stock=@Stock 
                                        where BookId=@BookId"))
            {

                cmd.Parameters.AddWithValue("@BookId", SqlDbType.Int).Value = entity.BookId;
                cmd.Parameters.AddWithValue("@LibraryId", SqlDbType.Int).Value = entity.LibraryId;
                cmd.Parameters.AddWithValue("@CategoryId", SqlDbType.Int).Value = entity.CategoryId;
                cmd.Parameters.AddWithValue("@BookName", SqlDbType.NVarChar).Value = entity.BookName;
                cmd.Parameters.AddWithValue("@AuthorName", SqlDbType.NVarChar).Value = entity.AuthorName;
                cmd.Parameters.AddWithValue("@Publisher", SqlDbType.NVarChar).Value = entity.Publisher;
                cmd.Parameters.AddWithValue("@Stock", SqlDbType.Int).Value = entity.Stock;
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public List<BookDetailsDto> OrderByStockDesc()
        {
            var bookList = new List<BookDetailsDto>();
            SqlCommand cmd = new SqlCommand(@"sp_BookOrderStockDesc");
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            
            while (reader.Read())
            {
                var book = new BookDetailsDto
                {
                    BookId = int.Parse(reader[0].ToString()),
                    BookName = reader[1].ToString(),
                    AuthorName = reader[2].ToString(),
                    Publisher = reader[3].ToString(),
                    Stock = int.Parse(reader[4].ToString()),
                    CategoryName = reader[5].ToString(),
                    LibraryName = reader[6].ToString(),
                    IsAvailable = Convert.ToBoolean(reader[7])
                };
                bookList.Add(book);
            }
            return bookList;
        }

        public List<BookDetailsDto> OrderByStockAsc()
        {
            var bookList = new List<BookDetailsDto>();
            SqlCommand cmd = new SqlCommand(@"sp_BookOrderStockAsc");
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);

            while (reader.Read())
            {
                var book = new BookDetailsDto
                {
                    BookId = int.Parse(reader[0].ToString()),
                    BookName = reader[1].ToString(),
                    AuthorName = reader[2].ToString(),
                    Publisher = reader[3].ToString(),
                    Stock = int.Parse(reader[4].ToString()),
                    CategoryName = reader[5].ToString(),
                    LibraryName = reader[6].ToString(),
                    IsAvailable = Convert.ToBoolean(reader[7])
                };
                bookList.Add(book);
            }
            return bookList;
        }

        public List<BookDetailsDto> BookSearchByCategory(string categoryName)
        {
            var bookList = new List<BookDetailsDto>();
            SqlCommand cmd = new SqlCommand(@"sp_BookSearchByCategory");
            cmd.Parameters.AddWithValue("@CategoryName", SqlDbType.NVarChar).Value = categoryName;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);

            while (reader.Read())
            {
                var book = new BookDetailsDto
                {
                    BookId = int.Parse(reader[0].ToString()),
                    BookName = reader[1].ToString(),
                    AuthorName = reader[2].ToString(),
                    Publisher = reader[3].ToString(),
                    Stock = int.Parse(reader[4].ToString()),
                    CategoryName = reader[5].ToString(),
                    LibraryName = reader[6].ToString(),
                    IsAvailable = Convert.ToBoolean(reader[7])
                };
                bookList.Add(book);
            }
            return bookList;
        }
    }
}
