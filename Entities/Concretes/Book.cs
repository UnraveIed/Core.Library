using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Book : IEntity
    {
        public int BookId { get; set; }
        public int LibraryId { get; set; }
        public int CategoryId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int Stock { get; set; }
        public string Publisher { get; set; }
    }
}
