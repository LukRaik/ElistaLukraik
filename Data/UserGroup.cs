﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UserGroup
    {
        public int Id { get; set; }

        public List<User> User { get; set; }

        public string GroupName { get; set; }
    }
}
