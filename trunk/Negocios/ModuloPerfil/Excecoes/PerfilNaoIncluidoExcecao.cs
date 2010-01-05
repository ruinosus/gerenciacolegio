using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloPerfil.Constantes;

namespace Negocios.ModuloPerfil.Excecoes
{
    /// <summary>
    /// Classe PerfilNaoIncluidoExcecao
    /// </summary>
    public class PerfilNaoIncluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public PerfilNaoIncluidoExcecao()
            : base(PerfilConstantes.PERFIL_NAOINCLUIDO)
        { }
    }
}