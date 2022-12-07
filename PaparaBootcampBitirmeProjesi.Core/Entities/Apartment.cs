using PaparaBootcampBitirmeProjesi.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.Core.Entities
{
    public class Apartment : IBaseEntity
    {
        public int Id { get; set; }
        public int ApartmentNo { get; set; }
        public string Block { get; set; }
        public string Type { get; set; }
        public int Floor { get; set; }
        public string Resident { get; set; }
        public bool IsFull { get; set; } 

        //IBaseEntity Implementation
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }

        //Reletions
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
