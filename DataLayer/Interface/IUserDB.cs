﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface IUserDB
    {
        UserMaster GetUserByUserNameAndPassword(string userName, string password);
    }
}
