using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCP_OMNI.Data;

namespace DCP_OMNI.Services
{
    public class MaterialService
    {
        private readonly DCP_OMNIContext _context;
        public MaterialService(DCP_OMNIContext context)
        {
            _context = context;
        }
    }
}
