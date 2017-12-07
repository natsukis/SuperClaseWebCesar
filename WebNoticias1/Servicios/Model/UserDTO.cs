using BaseDato1.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Model
{
   public class UserDTO
    {
        
        public string Username { get; set; }

        public string Password { get; set; }

        public int Id { get; set; }
        public virtual ICollection<News> New { get; set; }
        
    }
}
