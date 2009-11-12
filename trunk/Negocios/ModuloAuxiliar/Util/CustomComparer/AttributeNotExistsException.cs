using System;
using System.Collections.Generic;
using System.Text;

namespace Negocios.ModuloAuxiliar.Util.CustomComparer
{
    class PropertyNotExistsException : Exception
    {
        private String attributeName;

        public String AttributeName
        {
            get { return attributeName; }
        }

        public PropertyNotExistsException(String attributeName)
            : base("The informed Attribute Name not exists")
        {
            this.attributeName = attributeName;
        }
    }
}
