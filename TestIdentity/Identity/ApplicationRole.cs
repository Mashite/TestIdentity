﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestIdentity.Identity
{
    public class ApplicationRole:IdentityRole
    {
        public string Description { get; set; }
    }
}