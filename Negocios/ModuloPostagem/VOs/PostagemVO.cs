using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAuxuliar.Enuns;
using Negocios.ModuloControleAcesso.VOs;

namespace Negocios.ModuloPostagem.VOs
{
    /// <summary>
    /// Summary description for PostagemVO
    /// </summary>
    public class PostagemVO
    {
        #region Construtores
        public PostagemVO()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion

        #region Atributos
        private int id;
        private string preview;
        private string titulo;
        private string subTitulo;
        private string corpo;
        private byte[] imagem;
        private StatusPostagem statusPostagem;
        private LocalPostagem localPostagem;
        private TipoPostagem tipoPostagem;
        private DateTime dataCriacao;
        private DateTime dataInicioVigencia;
        private DateTime dataFinalVigencia;
        private UsuarioSistemaVO usuario;
        

        #endregion

        #region Propriedades
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Preview
        {
            get { return this.preview; }
            set { this.preview = value; }
        }

        public string Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }

        public string SubTitulo
        {
            get { return this.subTitulo; }
            set { this.subTitulo = value; }
        }

        public string Corpo
        {
            get { return this.corpo; }
            set { this.corpo = value; }
        }

        public byte[] Imagem
        {
            get { return imagem; }
            set { imagem = value; }
        }

        public StatusPostagem StatusPostagem
        {
            get { return this.statusPostagem; }
            set { this.statusPostagem = value; }
        }

        public LocalPostagem LocalPostagem
        {
            get { return this.localPostagem; }
            set { this.localPostagem = value; }
        }

        public TipoPostagem TipoPostagem
        {
            get { return this.tipoPostagem; }
            set { this.tipoPostagem = value; }
        }

        public DateTime DataCriacao
        {
            get { return this.dataCriacao; }
            set { this.dataCriacao = value; }
        }

        public DateTime DataInicioVigencia
        {
            get { return this.dataInicioVigencia; }
            set { this.dataInicioVigencia = value; }
        }

        public DateTime DataFinalVigencia
        {
            get { return this.dataFinalVigencia; }
            set { this.dataFinalVigencia = value; }
        }

        public UsuarioSistemaVO Usuario
        {
            get
            {
                if (usuario == null)
                    usuario = new UsuarioSistemaVO();
                return this.usuario;
            }
            set { this.usuario = value; }
        }

        #endregion
    }
}