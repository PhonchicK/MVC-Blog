﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Blog.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Description { get; set; }
    }
}