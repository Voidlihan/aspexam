using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Models;

namespace Domain.DataAccess.Data
{
    public class ApplicationContext : DbContext
    {
        public virtual DbSet<Application> Applications { get; set; }
        public ApplicationContext() : base("name=EduConnectionString")
        {

        }
    }
}
