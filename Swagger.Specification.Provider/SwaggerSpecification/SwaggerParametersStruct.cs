using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Specification.Provider.SwaggerSpecification
{
    public class SwaggerParametersStruct
    {
        public string In { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string schema { get; set; }

        public string SchemaRefName { get; set; }

        public SwaggerParametersStruct(Type m_Type)
        {

        }

        public string ToJsonContext()
        {
            StringBuilder m_Return = new StringBuilder();

            m_Return.Append("{");

            m_Return.AppendFormat("\"in\": \"{0}\",", this.In.ToString());
            m_Return.AppendFormat("\"name\": \"{0}\",", this.name);
            m_Return.AppendFormat("\"description\": \"{0}\",", this.description);
            m_Return.AppendFormat("\"required\": {0},", this.required.ToString().ToLower());

            if (!string.IsNullOrEmpty(this.schema))
            {
                m_Return.AppendFormat("\"schema\": {{ \"$ref\": \"{0}\"}}", this.schema);
            }

            m_Return.Append("}");

            return m_Return.ToString();
        }
    }
}
