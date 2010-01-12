using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.ModuloBasico.VOs
{
    public class Memoria : Singleton<Memoria>
    {

        public Matricula Matricula{ get; set; }
        public Aluno Aluno { get; set; }
        public Funcionario Funcionario{ get; set; }
    }
}
