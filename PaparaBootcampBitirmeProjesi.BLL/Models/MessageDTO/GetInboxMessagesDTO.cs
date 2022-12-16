using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.Models.MessageDTO
{
    public class GetInboxMessagesDTO
    {
        public string MessageId { get; set; }
        public string SenderMail { get; set; }
        public string RecevierMail { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
