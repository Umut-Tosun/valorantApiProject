using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace valorantProject.Models.Class
{
    public class Context :DbContext
    {
        public DbSet<Maps> Maps { get; set; }
        public DbSet<Streamers> Streamers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}