using Domain.DataAccess.Data;
using Domain.DataAccess.Interfaces;
using Domain.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataAccess.EF
{
    public class ApplicationRepository : IRepository<Application>
    {
        private readonly ApplicationContext _context;
        public ApplicationRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Application Get(int id)
        {
            return _context.Applications.Find(id);
        }

        public IList<Application> GetAll()
        {
            return _context.Applications.ToList();
        }

        public Application Create(Application entity)
        {
            var customer = _context.Applications.Add(entity);
            return customer;
        }

        public Application Edit(Application entity)
        {
            var customer = _context.Applications.Find(entity.ID);
            if (customer != null)
            {
                customer = entity;
            }
            return customer;
        }

        public Application Delete(int id)
        {
            var customer = _context.Applications.Find(id);
            return _context.Applications.Remove(customer);
        }
    }
}
