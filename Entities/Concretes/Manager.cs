using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Manager : IEntity
    {
        public int ManagerId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
