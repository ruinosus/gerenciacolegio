using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;

namespace Negocios.ModuloBasico.VOs
{
    public class Serializador
    {
        // Serializa o objeto
        public static string Serializar(object objeto)
        {
            StringWriter writer = new StringWriter();
            XmlSerializer serializer = new XmlSerializer(objeto.GetType());
            serializer.Serialize(writer, objeto);

            return writer.ToString();
        }

        // Deserializa o objeto
        public static object Deserializar(string xml, Type tipo)
        {
            StringReader reader = new StringReader(xml);
            XmlSerializer serializer = new XmlSerializer(tipo);
            return serializer.Deserialize(reader);
        }
    }
}
