using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Project_SocialWorkerApp.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base(nameOrConnectionString: "con")
        {

        }

        public System.Data.Entity.DbSet<Project_SocialWorkerApp.Models.StudentReferralsModel> StudentReferralsModels { get; set; }

        //public Dbset<>
    }
}