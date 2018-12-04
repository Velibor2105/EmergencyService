using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Models
{
    public class Municipality : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid TerritoryId { get; set; }
    }
}
