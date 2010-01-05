using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloPerfil.Constantes;

namespace Negocios.ModuloPerfil.Excecoes
{
    /// <summary>
    /// Classe PerfilNaoExcluidoExcecao
    /// </summary>
    public class PerfilNaoExcluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public PerfilNaoExcluidoExcecao()
            : base(PerfilConstantes.PERFIL_NAOEXCLUIDO)
        { }
    }
}