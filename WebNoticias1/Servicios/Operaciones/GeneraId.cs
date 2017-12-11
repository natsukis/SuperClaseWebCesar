using BaseDato1;
using BaseDato1.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Operaciones
{
    public class GeneraId
    {

        private Repository<User> User = new Repository<User>();

        public int UserId()
        {
            try
            {
                var x = User.Set().Max(c => c.Id);
                return x + 1;
            }
            catch
            {
                return 1;
            }
            
        }

    }
}
