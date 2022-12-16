using PaparaBootcampBitirmeProjesi.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.Core.Entities
{
    public class Vehicle : IBaseEntity
    {
        public string VehicleId { get; set; } = Guid.NewGuid().ToString();
        public string Brand { get; set; }
        public string Model { get; set; }
        public string? LicensePlate { get; set; }

        //IBaseEntity Implementation
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; } = Status.Active;

        //Relations
        public User User { get; set; }
    }
}
