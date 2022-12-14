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
        List<Message> GetListInbox();
        List<Message> GetListSendbox();

        void AddMessage(Message message);

        void DeleteMessage(Message message);

        void UpdateMessage(Message message);
    }
}
