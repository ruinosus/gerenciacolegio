using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAlunoAtividade.Constantes;

namespace Negocios.ModuloAlunoAtividade.Excecoes
{
    /// <summary>
    /// Classe AlunoAtividadeNaoIncluidoExcecao
    /// </summary>
    public class AlunoAtividadeNaoIncluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public AlunoAtividadeNaoIncluidoExcecao()
            : base(AlunoAtividadeConstantes.ALUNOATIVIDADE_NAOINCLUIDO)
        { }
    }
}