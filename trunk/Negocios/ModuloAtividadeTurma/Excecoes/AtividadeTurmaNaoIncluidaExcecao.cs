using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAtividadeTurma.Constantes;

namespace Negocios.ModuloAtividadeTurma.Excecoes
{
    /// <summary>
    /// Classe AtividadeTurmaNaoIncluidaExcecao
    /// </summary>
    public class AtividadeTurmaNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public AtividadeTurmaNaoIncluidaExcecao()
            : base(AtividadeTurmaConstantes.ATIVIDADETURMA_NAOINCLUIDA)
        { }
    }
}