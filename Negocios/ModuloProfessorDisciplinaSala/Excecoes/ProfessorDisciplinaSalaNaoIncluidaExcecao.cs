using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloProfessorDisciplinaSala.Constantes;

namespace Negocios.ModuloProfessorDisciplinaSala.Excecoes
{
    /// <summary>
    /// Classe ProfessorDisciplinaSalaNaoIncluidaExcecao
    /// </summary>
    public class ProfessorDisciplinaSalaNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ProfessorDisciplinaSalaNaoIncluidaExcecao()
            : base(ProfessorDisciplinaSalaConstantes.PROFESSORDISCIPLINASALA_NAOINCLUIDA)
        { }
    }
}