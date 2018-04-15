using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Specification.Provider.SwaggerSpecification
{
    /// <summary>
    /// 配合Info的contact属性使用
    /// </summary>
    public class SwaggerInfoContactStruct
    {
        public string email { get; set; }

        public SwaggerInfoContactStruct(string m_Email)
        {
            this.email = m_Email;
        }

        public string ToJsonContext()
        {
            StringBuilder m_Return = new StringBuilder();

            m_Return.Append("{");

            m_Return.AppendFormat("\"email\": \"{0}\",", this.email);

            m_Return.Append("}");

            return m_Return.ToString();
        }
    }
}
