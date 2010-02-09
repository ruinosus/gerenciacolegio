using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using Negocios.ModuloBasico.Excecoes;


namespace Negocios.ModuloBasico.VOs
{
    [Serializable]
    public class Conexao
    {
        public string Caminho{ get; set; }
        public string Usuario{ get; set; }
        public string Senha { get; set; }
        public string Banco { get; set; }

        public Conexao()
        {
            if (File.Exists("c://config.xml"))
            {
                SoapFormatter sXML = new SoapFormatter();
                FileStream f = new FileStream("config.xml", FileMode.Open, FileAccess.Read);

                Conexao c = (Conexao)sXML.Deserialize(f);
                this.Banco = c.Banco;
                this.Usuario = c.Usuario;
                this.Senha = c.Senha;
                this.Caminho = c.Caminho;

                
                f.Close();
            }
            else
            {
                throw new ArquivoConfiguracaoNaoEncontradoExcecao();
            }


        }

        public override string ToString()
        {
            return "Database="+Banco+";Data Source="+Caminho+";User Id="+Usuario+";Password="+Senha;
        }

    }
}
