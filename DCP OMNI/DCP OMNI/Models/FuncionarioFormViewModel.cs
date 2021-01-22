using System;
using System.Collections.Generic;
//Essa viewmodel é importante para poder compor a view com o componete select
//de cargos
namespace DCP_OMNI.Models
{
    public class FuncionarioFormViewModel
    {
        public Funcionario Funcionario { get; set; }
        public ICollection<Cargo> Cargos { get; set; } = new List<Cargo>();
    }
}
