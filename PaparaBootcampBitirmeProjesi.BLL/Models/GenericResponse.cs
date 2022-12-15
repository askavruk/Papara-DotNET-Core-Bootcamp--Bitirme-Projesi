using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.Models
{
    public class GenericResponse<T>
    {
        public T Data { get; set; }
        public List<string> ValidationMessages { get; set; }
        
    }
}
