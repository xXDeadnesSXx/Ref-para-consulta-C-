using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DCP_OMNI.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Rg { get; set; }
        public string Cpf { get; set; }
        public Cargo Cargo { get; set; }
        public int CargoId { get; set; }//para garantir a integridade relacional do banco


        public Funcionario()
        {
        }

        public Funcionario(int id, string nome, int rg, string cpf, Cargo cargo)
        {
            Id = id;
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
            Cargo = cargo;
        }
    }
}
