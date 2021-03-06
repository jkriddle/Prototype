﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honeypot.Domain.Filters
{
    public class UserFilter : BaseFilter
    {
        public UserFilter()
        {
            SortColumn = "Email";
        }

        public string Email { get; set; }
        public Role? Role { get; set; }
    }
}
