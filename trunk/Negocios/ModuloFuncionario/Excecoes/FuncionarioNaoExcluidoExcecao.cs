using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloFuncionario.Constantes;

namespace Negocios.ModuloFuncionario.Excecoes
{
    /// <summary>
    /// Classe FuncionarioNaoExcluidoExcecao
    /// </summary>
    public class FuncionarioNaoExcluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public FuncionarioNaoExcluidoExcecao()
            : base(FuncionarioConstantes.FUNCIONARIO_NAOEXCLUIDO)
        { }
    }
}