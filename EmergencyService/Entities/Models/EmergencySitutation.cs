using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class EmergencySitutation : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string AddressOfEmergSituation { get; set; }
        public Guid MunicipalityId { get; set; }
        public string Descripton { get; set; }
        public DateTime DateOfEmerg { get; set; }
        public string ExactLocation { get; set; }
        public Guid TerritoryId { get; set; }
        public string LevelOfEmrg { get; set; }
        public byte[] ImageFromLocation { get; set; }
        public Guid StateId { get; set; }
        public Guid VolunteerId { get; set; }
    }
}
