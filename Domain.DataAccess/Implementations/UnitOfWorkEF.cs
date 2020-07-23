using Domain.DataAccess.Data;
using Domain.DataAccess.Interfaces;
using Domain.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataAccess.Implementations
{
    public class UnitOfWorkEF : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        public IRepository<Application> Applications { get; set; }
        public UnitOfWorkEF(IRepository<Application> applications, ApplicationContext context)
        {
            _context = context;
            Applications = applications;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void BeginTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            if (_context.Database.CurrentTransaction != null)
            {
                _context.Database.CurrentTransaction.Commit();
            }
        }

        public void Rollback()
        {
            if (_context.Database.CurrentTransaction != null)
            {
                _context.Database.CurrentTransaction.Rollback();
            }
        }
    }
}
