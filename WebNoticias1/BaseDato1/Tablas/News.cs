using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDato1.Tablas
{
   public class News
    {
        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(2000)]
        public string Description { get; set; }

        [Required]
        public User CreatedUser { get; set; }
        
        public User UpdatedUser { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public int Id { get; set; }

        public virtual User Usuario { get; set; }


    }
}
