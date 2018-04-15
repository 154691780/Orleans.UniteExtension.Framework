using Swagger.Assembly.Attributes.CommonlyUsedEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Assembly.Attributes.ExtendedAttribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class ProducesAttribute : Attribute
    {
        public MIMEType[] Produces { get; set; }

        public ProducesAttribute(params MIMEType[] m_Produces)
        {
            this.Produces = m_Produces;
        }

        public override string ToString()
        {
            StringBuilder m_Return = new StringBuilder();

            m_Return.Append("[");
            foreach (var m_Item in Produces)
            {
                m_Return.AppendFormat("\"{0}/{1}\",", m_Item == MIMEType.form_data ? "multipart" : "application", m_Item);
            }
            m_Return.Append("]");

            return m_Return.ToString();
        }
    }
}
