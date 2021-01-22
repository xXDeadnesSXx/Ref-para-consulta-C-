using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DCP_OMNI.Models
{
    public class Cargo
    {
        public int Id { get; set; }
        public string Tipo { get; set; }

        public Cargo()
        {
        }
        public Cargo(int id, string tipo)
        {
            Id = id;
            Tipo = tipo;
        }
    }

}
