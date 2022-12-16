using PaparaBootcampBitirmeProjesi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.Core.IRepositories
{
    public interface IMessageRepository : IBaseRepository<Message>
    {
        List<Message> GetListInbox(string mail);
        List<Message> GetListSendbox(string id);

        public Message FindMessageById(string id);

        void DeleteMessage(Message message);
    }
}
