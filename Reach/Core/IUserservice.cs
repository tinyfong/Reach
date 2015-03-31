﻿using Reach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reach.Core
{
    public interface IUserservice:ICrudService<User>
    {
        bool IsUnique(string login);
        void ChangePassword(int id, string password);
        User Get(string Login, string password);
    }
}