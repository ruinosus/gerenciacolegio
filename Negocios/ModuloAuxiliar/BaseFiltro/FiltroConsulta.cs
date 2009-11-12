using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Negocios.ModuloAuxiliar.BaseFiltro
{
    [Serializable()]
    public class FiltroConsulta : ISerializable
    {
        protected List<string> campos;

        public FiltroConsulta()
        {
            campos = new List<string>();
        }

        public FiltroConsulta(SerializationInfo info, StreamingContext ctxt)
        {
            campos = (List<string>)info.GetValue("campos", typeof(List<string>));
        }

        /// <summary>
        /// Indexador utilizado para verificar se o campo foi requisitado na consulta
        /// </summary>
        /// <param name="campo">Nome do campo fisicamente no banco</param>
        /// <returns>Retorna true caso o campo fora requisitado</returns>
        /// <example>nivelEstruturaFiltroConsulta["id_nivel_estrutura_nivest"]</example>
        public bool this[string campo]
        {
            get { return campos.Contains(campo); }
        }

        /// <summary>
        /// Executa a opereação requisitada, caso adicionaRemove for true será executado
        /// um adicionar campo, caso false um remover campo será executado
        /// </summary>
        /// <param name="adicionaRemove">Informa qual operação será executada</param>
        /// <param name="campo">Nome do campo fisicamente no banco</param>
        protected void ExecutarOperacao(bool adicionaRemove, string campo)
        {
            switch (adicionaRemove)
            {
                case true:
                    AdicionarCampo(campo);
                    break;
                case false:
                    RemoverCampo(campo);
                    break;
            }
        }

        /// <summary>
        /// Adiciona um novo campo
        /// </summary>
        /// <param name="campo">Nome do campo fisicamente no banco</param>
        protected void AdicionarCampo(string campo)
        {
            if (!String.IsNullOrEmpty(campo))
            {
                if (!campos.Contains(campo))
                    campos.Add(campo);
            }
        }

        /// <summary>
        /// Remove um campo
        /// </summary>
        /// <param name="campo">Nome do campo fisicamente no banco</param>
        protected void RemoverCampo(string campo)
        {
            if (campos.Contains(campo))
                campos.Remove(campo);
        }

        /// <summary>
        /// Retorna a lista de todos os campos requisitados na consulta
        /// </summary>
        /// <returns>Um string contendo todos os campos separados por vírgula</returns>
        public string GetCampos()
        {
            StringBuilder campos = new StringBuilder();

            foreach (string campo in this.campos)
            {
                campos.Append(campo + ", ");
            }

            return campos.ToString().Remove(campos.ToString().LastIndexOf(','));
        }

        /// <summary>
        /// Retorna a lista de todos os campos requisitados na consulta
        /// </summary>
        /// <param name="prefixo">Prefixo que deve ser adicionado aos campos</param>
        /// <returns>Um string contendo todos os campos separados por vírgula</returns>
        public string GetCampos(string prefixo)
        {
            StringBuilder campos = new StringBuilder();

            foreach (string campo in this.campos)
            {
                campos.Append(prefixo + "." + campo + ", ");
            }

            return campos.ToString().Remove(campos.ToString().LastIndexOf(','));

        }

        #region ISerializable Members

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("campos", campos);
        }

        #endregion
    }
}