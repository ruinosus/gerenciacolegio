using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloProfessorDisciplinaSala.Constantes;

namespace Negocios.ModuloProfessorDisciplinaSala.Excecoes
{
    /// <summary>
    /// Classe ProfessorDisciplinaSalaNaoAlteradaExcecao
    /// </summary>
    public class ProfessorDisciplinaSalaNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ProfessorDisciplinaSalaNaoAlteradaExcecao()
            : base(ProfessorDisciplinaSalaConstantes.PROFESSORDISCIPLINASALA_NAOALTERADA)
        { }
    }
}