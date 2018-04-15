using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Specification.Provider.SwaggerSpecification
{
    public class SwaggerExternalDocsStruct
    {
        public string description { get; set; }
        public string url { get; set; }

        public SwaggerExternalDocsStruct(string m_Description, string m_Url)
        {
            this.description = m_Description;
            this.url = m_Url;
        }

        public string ToJsonContext()
        {
            StringBuilder m_Return = new StringBuilder();

            m_Return.Append("{");

            m_Return.AppendFormat("\"description\": \"{0}\",", this.description);
            m_Return.AppendFormat("\"url\": \"{0}\",", this.url);


            m_Return.Append("}");

            return m_Return.ToString();
        }
    }
}
