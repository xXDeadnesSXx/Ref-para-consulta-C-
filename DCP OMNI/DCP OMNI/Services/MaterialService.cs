using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCP_OMNI.Data;
using DCP_OMNI.Models;

namespace DCP_OMNI.Services
{
    public class MaterialService
    {
        private readonly DCP_OMNIContext _context;
        public MaterialService(DCP_OMNIContext context)
        {
            _context = context;
        }
        public List<Material> FindAll()
        {
            return _context.Material.OrderBy(x => x.Nome).ToList();
        }
        public Material FindById(int id)
        {
            return _context.Material.FirstOrDefault(obj=>obj.Id==id);
        }
    }
}
