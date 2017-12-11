using BaseDato1.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Model
{
   public class NewsDto
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public UserDTO CreatedUser { get; set; }

        public UserDTO UpdatedUser { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public int Id { get; set; }

        public virtual UserDTO Usuario { get; set; }


    }
}
