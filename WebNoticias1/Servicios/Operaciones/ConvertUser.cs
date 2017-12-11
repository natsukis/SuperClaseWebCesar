using BaseDato1.Tablas;
using Servicios.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public static class ConvertUser
    {
        public static UserDTO Convert(User user)
        {
            var usuario = new UserDTO()
            {
                Username = user.Username,

                Password = user.Password,

                Id = user.Id,

            };

            return usuario;
        }

        public static User ConvertDTO(UserDTO user)
        {
            var usuario = new User()
            {
                Username = user.Username,

                Password = user.Password,

                Id = user.Id,

            };
        

            return usuario;
        }

}
}
