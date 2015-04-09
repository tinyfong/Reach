using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reach.Core;
using Reach.Models;

namespace Reach.Services
{
    public class UserService : CrudService<User>, IUserService
    {
        public UserService()
            : base()
        {

        }

        public override int Create(User item)
        {
            return base.Create(item);
        }


        public bool IsUnique(string userName)
        {
            return repo.Where(x => x.UserName == userName).Count() == 0;
        }

        public void ChangePassword(int id, string password)
        {
            repo.Get(id).Password = password;
            repo.Save();
        }

        public User Get(string userName, string password)
        {
            var user = repo.Where(x => x.UserName == userName).SingleOrDefault();
            if (user == null || password != user.Password)
            {
                return null;
            }

            return user;
        }
    }
}