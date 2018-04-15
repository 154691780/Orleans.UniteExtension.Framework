using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Specification.Provider.SwaggerSpecification
{
    /// <summary>
    /// 配合tags属性使用
    /// </summary>
    public class SwaggerTagsStruct
    {
        public string name { get; set; }
        public string description { get; set; }
        //public SwaggerExternalDocsStruct externalDocs { get; set; }

        public string ToJsonContext()
        {
            StringBuilder m_Return = new StringBuilder();

            m_Return.Append("{");

            m_Return.AppendFormat("\"name\": \"{0}\",", this.name);
            m_Return.AppendFormat("\"description\": \"{0}\",", this.description);
            //m_Return.AppendFormat("\"externalDocs\": \"{0}\",", this.externalDocs);

            m_Return.Append("}");

            return m_Return.ToString();
        }
    }
}
