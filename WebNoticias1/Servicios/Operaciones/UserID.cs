using BaseDato1;
using BaseDato1.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Operaciones
{
    public class UserID
    {

        private Repository<User> repoUsers = new Repository<User>();

        public int Userinformation(string name, string password)
        {
            var user = repoUsers.Set().FirstOrDefault(c => c.Username == name && c.Password == password);

            if (user != null)
            {
                return user.Id;
            }
            else
            {
                return 0;
            }
        }


    }
}
