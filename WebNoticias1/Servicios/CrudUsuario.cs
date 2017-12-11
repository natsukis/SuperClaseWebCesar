using BaseDato1;
using BaseDato1.Tablas;
using Servicios.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class CrudUsuario
    {

        private Repository<User> repoUser = new Repository<User>();
        private Repository<News> repoNews = new Repository<News>();

        public void Create(UserDTO usuario)
        {

            var auxUser = new User();

            /*   if (usuario.New != null)
               {
                   foreach (var x in usuario.New)
                   {

                       auxUser.New.Add(new News()
                       {
                           Title = x.Title,

                           Description = x.Description,

                           CreatedDate = x.CreatedDate,
                           UpdateDate = x.UpdateDate,

                           Id = x.Id
                       });

                   }

               }*/
            var newUser = new User()
            {
                Username = usuario.Username,

                Password = usuario.Password,

               // Id = usuario.Id,

            };

            repoUser.Persist(newUser);

            repoUser.SaveChanges();

        }





        public UserDTO Read(string username, string password)
        {
            var user = repoUser.Set().FirstOrDefault(c => c.Username == username && c.Password==password);

            if (user != null)
            {

                var readUser = new UserDTO()
                {

                    Username = user.Username,

                    Password = user.Password,
                };

                foreach (var news in user.New)
                {
                    readUser.New.Add(new NewsDto
                    {
                        Title = news.Title,

                        Description = news.Description,
                        CreatedUser = ConvertUser.Convert(news.CreatedUser),

                        UpdatedUser =  ConvertUser.Convert(news.UpdatedUser),

                        CreatedDate = news.CreatedDate,
                        UpdateDate = news.UpdateDate,

                        Id = news.Id
                    });
                }

                return readUser;
            }
            else
            {
                return null;
            }

        }

        public void Update(int id, UserDTO user)
        {

            var auxUser = new User();

            if (user.New != null)
            {
                foreach (var x in user.New)
                {

                    auxUser.New.Add(new News()
                    {
                        Title = x.Title,

                        Description = x.Description,
                        CreatedUser =  ConvertUser.ConvertDTO(x.CreatedUser),

                        UpdatedUser =  ConvertUser.ConvertDTO(x.UpdatedUser),

                        CreatedDate = x.CreatedDate,
                        UpdateDate = x.UpdateDate,

                        Id = x.Id

                    });

                }
            }

            var userUpdate = repoUser.Set().FirstOrDefault(c => c.Id == id);

            userUpdate.Username = user.Username;

            userUpdate.Password = user.Password;

            userUpdate.New = auxUser.New;

            repoUser.SaveChanges();

        }

        public int Delete(int id)
        {

            var userDelete = repoUser.Set().FirstOrDefault(c => c.Id == id);

            if (userDelete == null)
            {
                return 0;
            }

            var auxDelete = repoNews.Set().Where(c => c.Id == id);

            if (auxDelete != null)
            {
                foreach (var news1 in auxDelete)
                {

                    repoNews.Remove(news1);

                }
                repoNews.SaveChanges();
            }

            repoUser.Remove(userDelete);

            repoUser.SaveChanges();

            return 1;

        }


    }
}
