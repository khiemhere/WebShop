﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webShopSolution.Data.Enums;

namespace webShopSolution.Data.Entities
{
    public class Contact
    {
        public long Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string Message { set; get; }
        public Status Status { set; get; }
    }
}
