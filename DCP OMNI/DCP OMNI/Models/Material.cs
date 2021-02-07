using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DCP_OMNI.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int Estoque { get; set; }
    }
}
