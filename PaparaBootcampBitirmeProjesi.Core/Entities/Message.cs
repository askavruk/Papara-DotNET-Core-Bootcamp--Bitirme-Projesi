using PaparaBootcampBitirmeProjesi.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.Core.Entities
{
    public class Message : IBaseEntity
    {
        public Message()
        {
            Users = new List<User>();
        }
        public string MessageId { get; set; }
        public string SenderMail { get; set; }
        public string RecevierMail { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }

        //IBaseEntity Implementation
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; } = Status.Active;

        //Relations
        public List<User> Users { get; set; }
    }
}
