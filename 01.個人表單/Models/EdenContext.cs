using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _01.個人表單.Models {
    public class EdenContext : DbContext{
        public EdenContext() : base("name=EdenContext") {
        }
        public DbSet<Infos> InfosList { get; set; }
    }
}