using Proyecto04.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proyecto04.DATE
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("DefaultConnection")
        {

        }

        public DbSet<DBclientesYULY> Proyecto04 { get; set; }


    }
}
