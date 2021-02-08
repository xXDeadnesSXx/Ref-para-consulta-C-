using DCP_OMNI.Data;
using DCP_OMNI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public Cargo FindById(int id)
        {
            return _context.Cargo.FirstOrDefault(obj => obj.Id == id);
        }
        public void Insert(Cargo obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        public void Remove(int id)
        {
            var obj = _context.Cargo.Find(id);
            _context.Cargo.Remove(obj);
            _context.SaveChanges();
        }
    }
}