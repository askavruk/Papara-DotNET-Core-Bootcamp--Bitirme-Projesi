using AutoMapper;
using PaparaBootcampBitirmeProjesi.BLL.Models;
using PaparaBootcampBitirmeProjesi.BLL.Models.MessageDTO;
using PaparaBootcampBitirmeProjesi.BLL.Models.UserDTO;
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
            CreateMap<CreateUserDTO, User>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
            CreateMap<User, UpdateUserDTO>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
            CreateMap<User, GetUsersWithApartmentDTO>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());

            CreateMap<CreateMessageDTO, Message>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
            CreateMap<Message, GetMessageDetailDTO>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
            CreateMap<Message, GetInboxMessagesDTO>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
            CreateMap<Message, GetSendboxMessagesDTO>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
        }
    }
}
