using DCP_OMNI.Data;
using DCP_OMNI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DCP_OMNI.Services
{
    public class FuncionarioService
    {
        private readonly DCP_OMNIContext _context;
        public FuncionarioService(DCP_OMNIContext context)
        {
            _context = context;
        }
        public List<Funcionario> FindAll()
        {//lista todos os funcionarios
            return _context.Funcionario.OrderBy(x=>x.CargoId).ToList();
        }
        public void Insert(Funcionario obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
