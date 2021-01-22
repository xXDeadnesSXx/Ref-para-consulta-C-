using DCP_OMNI.Data;
using DCP_OMNI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DCP_OMNI.Services
{
    public class CargoService
    {
        private readonly DCP_OMNIContext _context;
        public CargoService(DCP_OMNIContext context)
        {
            _context = context;
        }
        public List<Cargo> FindAll()
        {
            return _context.Cargo.ToList();
        }
        public void Insert(Cargo obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}