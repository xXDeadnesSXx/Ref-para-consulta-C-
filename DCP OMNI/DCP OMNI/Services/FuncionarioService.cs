using DCP_OMNI.Data;
using DCP_OMNI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
        public Funcionario FindById(int id)
        {//include faz um join para exibir o cargo, caso contrário só seria exibido o Id
            return _context.Funcionario.Include(obj=>obj.Cargo).FirstOrDefault(obj=>obj.Id==id);
        }
        public void Insert(Funcionario obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        public void Remove(int id)
        {
            var obj = _context.Funcionario.Find(id);
            _context.Funcionario.Remove(obj);
            _context.SaveChanges();
        }
    }
}
