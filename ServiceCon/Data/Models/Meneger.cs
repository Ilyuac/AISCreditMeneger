﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceCon.Data.Models
{
    public class Meneger : User
    {
        public Meneger(string login, string name, Gender gender, string email, string password) : base(login, name, gender, email, password)
        {
        }
    }
}
