using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAtividade.Constantes;

namespace Negocios.ModuloAtividade.Excecoes
{
    /// <summary>
    /// Classe AtividadeNaoExcluidaExcecao
    /// </summary>
    public class AtividadeNaoExcluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public AtividadeNaoExcluidaExcecao()
            : base(AtividadeConstantes.ATIVIDADE_NAOEXCLUIDA)
        { }
    }
}