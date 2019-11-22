using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaiTap01_CRUD_MVC.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class BaiTap01_CRUD_MVCContext : DbContext
    {
        public BaiTap01_CRUD_MVCContext() : base("name=MyContext")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}