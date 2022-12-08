﻿using AutoMapper;
using PaparaBootcampBitirmeProjesi.BLL.Models;
using PaparaBootcampBitirmeProjesi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.AutoMapper
{
    public class Mapping: Profile
    {
        public Mapping()
        {
            CreateMap<CreateUserDTO, User>();
            CreateMap<User, UpdateUserDTO>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
            CreateMap<User, GetUserWithApartmentDTO>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
        }
    }
}
