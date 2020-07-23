using Domain.DataAccess.Interfaces;
using Domain.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataAccess.Data
{
    public interface IUnitOfWork
    {
        IRepository<Application> Applications { get; set; }
        void Save();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
