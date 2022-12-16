using Microsoft.EntityFrameworkCore;
using PaparaBootcampBitirmeProjesi.Core.Entities;
using PaparaBootcampBitirmeProjesi.Core.Enums;
using PaparaBootcampBitirmeProjesi.Core.IRepositories;
using PaparaBootcampBitirmeProjesi.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.DAL.Repositories
{
    public class MessageRepository : BaseRepository<Message>, IMessageRepository
    {
        private readonly AppDbContext dbContext;
        public MessageRepository(AppDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void DeleteMessage(Message message)
        {
            message.DeleteDate = DateTime.Now;
            message.Status = Status.Passive;
            dbContext.SaveChanges();
        }

        public Message FindMessageById(string id)
        {
            return table.FirstOrDefault(x => x.MessageId == id && x.Status == Status.Active);
        }

        public List<Message> GetListInbox(string mail)
        {
            return table.Where(x => x.Status == Status.Active && x.RecevierMail==mail).ToList();
        }

        public List<Message> GetListSendbox(string id)
        {
            return table.Where(x => x.Status == Status.Active && x.User.Id == id).ToList();
        }

    }
}
