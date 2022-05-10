using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class MyBookListDetailDto
    {
        public int ListId { get; set; }
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string CategoryName { get; set; }

        public string LibraryName { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime DateOfUpload { get; set; }
        public DateTime DeliveredTime { get; set; }

        public int UserId { get; set; }

        

        
    }
}
