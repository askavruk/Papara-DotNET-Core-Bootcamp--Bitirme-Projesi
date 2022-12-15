using PaparaBootcampBitirmeProjesi.BLL.Models.MessageDTO;
using PaparaBootcampBitirmeProjesi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.Services.MessageService
{
    public interface IMessageService
    {
        List<GetInboxMessagesDTO> GetListInbox(string mail);
        List<GetSendboxMessagesDTO> GetListSendbox(string mail);

        GetMessageDetailDTO GetMessageDetails(string id);

        Task CreateMessage(CreateMessageDTO createMessage);

        void DeleteMessage(string id);
    }
}
