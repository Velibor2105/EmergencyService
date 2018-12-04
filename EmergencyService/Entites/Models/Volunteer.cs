using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Models
{
    public class Volunteer : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public Guid TerritoryId { get; set; }
        public byte[] Image { get; set; }
        public Guid StateId { get; set; }
    }
}
