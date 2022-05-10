using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Library : IEntity
    {
        public int LibraryId { get; set; }
        public string LibraryName { get; set; }
        public bool IsAvailable { get; set; }
    }
}
