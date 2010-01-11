using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAtividadeTurma.Constantes;

namespace Negocios.ModuloAtividadeTurma.Excecoes
{
    /// <summary>
    /// Classe AtividadeTurmaNaoExcluidaExcecao
    /// </summary>
    public class AtividadeTurmaNaoExcluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public AtividadeTurmaNaoExcluidaExcecao()
            : base(AtividadeTurmaConstantes.ATIVIDADETURMA_EXCLUIDA)
        { }
    }
}