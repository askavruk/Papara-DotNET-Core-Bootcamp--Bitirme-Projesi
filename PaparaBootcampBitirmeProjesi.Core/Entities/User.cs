using Microsoft.AspNetCore.Identity;
using PaparaBootcampBitirmeProjesi.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.Core.Entities
{
    public class User : IdentityUser, IBaseEntity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }

        //IBaseEntity Implementation
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }

        //Relations
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }

        public List<Vehicle> Vehicles { get; set; }
        public List<Message> Messages { get; set; }

    }
}
