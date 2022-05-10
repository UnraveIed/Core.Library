using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class BookDetailsDto
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Publisher { get; set; }
        public int Stock { get; set; }

        public string CategoryName { get; set; }

        public string LibraryName { get; set; }
        public bool IsAvailable { get; set; }
    }
}
