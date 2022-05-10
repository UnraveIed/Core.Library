using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concretes
{
    public class MyBookList : IEntity
    {
        [Key]
        public int ListId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime DeliveryTime { get; set; }
        public DateTime DateOfUpload { get; set; }
        public bool IsDelivered { get; set; }
    }
}
