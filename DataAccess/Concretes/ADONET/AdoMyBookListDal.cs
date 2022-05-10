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
    public class AdoMyBookListDal : IMyBookListDal
    {
        public void Add(MyBookList entity)
        {
            using (SqlCommand cmd=new SqlCommand(@"sp_MyBookAdd"))
            {
                cmd.Parameters.AddWithValue("@BookId", SqlDbType.Int).Value = entity.BookId;
                cmd.Parameters.AddWithValue("@DeliveryTime", SqlDbType.DateTime).Value = entity.DeliveryTime;
                cmd.Parameters.AddWithValue("@DateOfUpload", SqlDbType.DateTime).Value = entity.DateOfUpload;
                cmd.Parameters.AddWithValue("@IsDelivered", SqlDbType.Bit).Value = entity.IsDelivered;
                cmd.Parameters.AddWithValue("@UserId", SqlDbType.Int).Value = entity.UserId;
                cmd.CommandType = CommandType.StoredProcedure;
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public List<MyBookList> SearchBookName(string bookName)
        {
            var bookList = new List<MyBookList>();
            SqlCommand cmd = new SqlCommand(@"sp_MyBookGetAll");
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                var books = new MyBookList
                {
                    ListId = int.Parse(reader[0].ToString()),
                    BookId = int.Parse(reader[1].ToString()),
                    DeliveryTime = Convert.ToDateTime(reader[2]),
                    DateOfUpload = Convert.ToDateTime(reader[3]),
                    IsDelivered = Convert.ToBoolean(reader[4]),
                    UserId = int.Parse(reader[5].ToString())
                };
                bookList.Add(books);
            }
            return bookList;
        }

        public void Delete(MyBookList entity)
        {
            using (SqlCommand cmd=new SqlCommand(@"sp_MyBookDelete"))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = entity.ListId;
                cmd.CommandType = CommandType.StoredProcedure;
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public MyBookList Get(Expression<Func<MyBookList, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<MyBookList> GetAll(Expression<Func<MyBookList, bool>> filter = null)
        {
            var bookList = new List<MyBookList>();
            SqlCommand cmd = new SqlCommand(@"sp_MyBookGetAll");
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                var books = new MyBookList
                {
                    ListId = int.Parse(reader[0].ToString()),
                    BookId = int.Parse(reader[1].ToString()),
                    DeliveryTime = Convert.ToDateTime(reader[2]),
                    DateOfUpload = Convert.ToDateTime(reader[3]),
                    IsDelivered = Convert.ToBoolean(reader[4]),
                    UserId = int.Parse(reader[5].ToString())
                };
                bookList.Add(books);
            }
            return bookList;
        }

        public List<MyBookListDetailDto> GetAllByUserId()
        {
            var myBookList = new List<MyBookListDetailDto>();
            SqlCommand cmd = new SqlCommand(@"sp_MyBookListDetailDto");
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                var books = new MyBookListDetailDto
                {
                    ListId = int.Parse(reader[0].ToString()),
                    BookId = int.Parse(reader[1].ToString()),
                    BookName = reader[2].ToString(),
                    CategoryName = reader[3].ToString(),
                    LibraryName = reader[4].ToString(),
                    Author = reader[5].ToString(),
                    Publisher = reader[6].ToString(),
                    DateOfUpload = Convert.ToDateTime(reader[7]),
                    DeliveredTime = Convert.ToDateTime(reader[8]),
                    UserId = int.Parse(reader[9].ToString())
                };
                myBookList.Add(books);
            }
            return myBookList;
        }

        public void Update(MyBookList entity)
        {
            using (SqlCommand cmd = new SqlCommand(@"sp_MyBookUpdate"))
            {
                cmd.Parameters.AddWithValue("@ListId", SqlDbType.Int).Value = entity.ListId;
                cmd.Parameters.AddWithValue("@BookId", SqlDbType.Int).Value = entity.BookId;
                cmd.Parameters.AddWithValue("@DeliveryTime", SqlDbType.DateTime).Value = entity.DeliveryTime;
                cmd.Parameters.AddWithValue("@DateOfUpload", SqlDbType.DateTime).Value = entity.DateOfUpload;
                cmd.Parameters.AddWithValue("@IsDelivered", SqlDbType.Bit).Value = entity.IsDelivered;
                cmd.Parameters.AddWithValue("@UserId", SqlDbType.Int).Value = entity.UserId;
                cmd.CommandType = CommandType.StoredProcedure;
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }
    }
}
