using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Specification.Provider.SwaggerSpecification
{
    /// <summary>
    /// 配合Info的license属性使用
    /// </summary>
    public class SwaggerInfoLicenseStruct
    {
        public string name { get; set; }
        public string url { get; set; }

        public string ToJsonContext()
        {
            StringBuilder m_Return = new StringBuilder();

            m_Return.Append("{");

            m_Return.AppendFormat("\"name\": \"{0}\",", this.name);
            m_Return.AppendFormat("\"url\": \"{0}\",", this.url);

            m_Return.Append("}");

            return m_Return.ToString();
        }
    }
}
