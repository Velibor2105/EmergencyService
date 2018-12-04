using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Comment : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTime DateOfComment { get; set; }
        public Guid VoluneerId { get; set; }
        public Guid EmergId { get; set; }
    }
}
