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

        public User CreatedUser { get; set; }

        public User UpdatedUser { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public int Id { get; set; }

        public virtual User Usuario { get; set; }


    }
}
