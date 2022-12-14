using PaparaBootcampBitirmeProjesi.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.Models.MessageDTO
{
    public class GetMessageDetailDTO
    {
        public string MessageId { get; set; }
        public string SenderMail { get; set; }
        public string RecevierMail { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public MessageStatus MessageStatus { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
