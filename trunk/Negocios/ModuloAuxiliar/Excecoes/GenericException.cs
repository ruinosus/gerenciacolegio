using System;

namespace Negocios.ModuloAuxiliar.Excecoes
{
    public class GenericException : Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem.
        /// </summary>
        public GenericException(String msg)
            : base(msg)
        { }

    }
}