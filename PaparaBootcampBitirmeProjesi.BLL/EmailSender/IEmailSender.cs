using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.EmailSender
{
    public interface IEmailSender
    {
        void SendEmail(string email, string subject, string message);
    }
}
