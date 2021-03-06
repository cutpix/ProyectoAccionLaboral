﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AccionLaboral.Models
{
    public class Role : IdentityRole
    {
        public Role()
        {

        }

        public Role(string roleName, string alias)
            : base(roleName)
        {
            this.Alias = alias;
        }
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int RoleId { get; set; }
        public string Alias { get; set; }
        //[Required]
        //public string Name { get; set; }


        //public ICollection<Privilege> Privileges { get; set; }
        //public ICollection<User> Users { get; set; }


    }

    public class ApplicationUserRole : IdentityUserRole
    {
        public ApplicationUserRole()
            : base()
        { }

        public Role Role { get; set; }
    }
}