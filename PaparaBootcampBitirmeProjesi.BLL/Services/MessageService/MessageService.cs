using AutoMapper;
using FluentValidation.Results;
using PaparaBootcampBitirmeProjesi.BLL.Models.MessageDTO;
using PaparaBootcampBitirmeProjesi.Core.Entities;
using PaparaBootcampBitirmeProjesi.BLL.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaparaBootcampBitirmeProjesi.BLL.Validators.MessageValidator;
using PaparaBootcampBitirmeProjesi.Core.IRepositories;
using PaparaBootcampBitirmeProjesi.Core.Enums;

namespace PaparaBootcampBitirmeProjesi.BLL.Services.MessageService
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository messageRepository;
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public MessageService(IMapper mapper, IMessageRepository messageRepository, IUserRepository userRepository)
        {
            this.messageRepository = messageRepository;
            this.mapper = mapper;
            this.userRepository = userRepository;
        }

        public async Task CreateMessage(CreateMessageDTO createMessage)
        {
            CreateMessageDTOValidator validations = new CreateMessageDTOValidator();
            ValidationResult valResult = validations.Validate(createMessage);
            if (valResult.IsValid)
            {
                var user = userRepository.FindUserById(createMessage.UserId);
                Message message = new Message()
                {
                    User = user,
                    //CreationDate = DateTime.Now
                   // RecevierMail = "asenadeneme@hotmail.com"
                };
                mapper.Map(createMessage, message);
                await messageRepository.Create(message);
            }
        }

        public void DeleteMessage(string id)
        {
            Message message = messageRepository.FindMessageById(id);
            if (message == null)
                throw new ArgumentException("Mesaj id bulunamadı");
            messageRepository.DeleteMessage(message);
        }

        public List<GetInboxMessagesDTO> GetListInbox(string mail)
        {
            List<Message> messages = new List<Message>();
            List<GetInboxMessagesDTO> inboxMessagesDTO = new List<GetInboxMessagesDTO>();
            messages = messageRepository.GetListInbox(mail);

            mapper.Map(messages, inboxMessagesDTO);

            return inboxMessagesDTO;
        }

        public List<GetSendboxMessagesDTO> GetListSendbox(string id)
        {
            List<Message> messages = new List<Message>();
            List<GetSendboxMessagesDTO> sendboxMessagesDTO = new List<GetSendboxMessagesDTO>();
            messages = messageRepository.GetListSendbox(id);

            mapper.Map(messages, sendboxMessagesDTO);

            return sendboxMessagesDTO;
        }

        public GetMessageDetailDTO GetMessageDetails(string id)
        {
            GetMessageDetailDTO getMessageDetail = new GetMessageDetailDTO();
            var message = messageRepository.FindMessageById(id);
            if (message != null)
            {
                messageRepository.UpdateMessage(message);
                return mapper.Map(message, getMessageDetail);
            }
            else
                throw new Exception("Mesaj bulunamadı");
        }
    }
}
