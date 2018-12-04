using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Territory : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Area { get; set; }
        public uint Population { get; set; }
    }
}
