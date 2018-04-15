using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Specification.Provider.SwaggerSpecification
{
    public class SwaggerResponsesStruct
    {
        public string code { get; set; }
        public string description { get; set; }
        public string schema { get; set; }

        public SwaggerResponsesStruct(string m_Code, string m_Description, string m_SchemaUrl)
        {
            this.code = m_Code;
            this.description = m_Description;
            this.schema = m_SchemaUrl;
        }

        public string ToJsonContext()
        {
            StringBuilder m_Return = new StringBuilder();

            m_Return.AppendFormat("\"{0}\": {{", this.code);

            m_Return.AppendFormat("\"description\": \"{0}\",", this.description);

            if (!string.IsNullOrEmpty(this.schema))
            {
                m_Return.AppendFormat("\"schema\": {{ \"$ref\": \"{0}\"}},", this.schema);
            }

            m_Return.Append("}");

            return m_Return.ToString();
        }
    }
}
