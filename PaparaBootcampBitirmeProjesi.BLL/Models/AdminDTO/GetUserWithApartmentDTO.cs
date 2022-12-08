﻿using PaparaBootcampBitirmeProjesi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.Models
{
    public class GetUserWithApartmentDTO
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public Apartment Apartment { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}