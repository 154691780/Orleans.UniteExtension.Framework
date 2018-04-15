using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Specification.Provider.SwaggerSpecification
{
    /// <summary>
    /// 配合Info属性使用
    /// </summary>
    public class SwaggerInfoStruct
    {
        public string description { get; set; }
        public string version { get; set; }
        public string title { get; set; }
        public string termsOfService { get; set; }
        //public string swagger { get; set; }
        public SwaggerInfoContactStruct contact { get; set; }
        public SwaggerInfoLicenseStruct license { get; set; }

        public string ToJsonContext()
        {
            StringBuilder m_Return = new StringBuilder();

            m_Return.Append("{");

            m_Return.AppendFormat("\"description\": \"{0}\",", this.description);
            m_Return.AppendFormat("\"version\": \"{0}\",", this.version);
            m_Return.AppendFormat("\"title\": \"{0}\",", this.title);
            m_Return.AppendFormat("\"termsOfService\": \"{0}\",", this.termsOfService);
            m_Return.AppendFormat("\"contact\": {0},", this.contact.ToJsonContext());
            m_Return.AppendFormat("\"license\": {0},", this.license.ToJsonContext());

            m_Return.Append("}");

            return m_Return.ToString();
        }
    }
}
