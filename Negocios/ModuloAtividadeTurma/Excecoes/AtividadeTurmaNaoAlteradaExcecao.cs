using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAtividadeTurma.Constantes;

namespace Negocios.ModuloAtividadeTurma.Excecoes
{
    /// <summary>
    /// Classe AtividadeTurmaNaoAlteradaExcecao
    /// </summary>
    public class AtividadeTurmaNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public AtividadeTurmaNaoAlteradaExcecao()
            : base(AtividadeTurmaConstantes.ATIVIDADETURMA_ALTERADA)
        { }
    }
}