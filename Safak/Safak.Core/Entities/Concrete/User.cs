﻿using Safak.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Safak.Core.Entities.Conrete
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string LastName { get; set; }
    }
}
