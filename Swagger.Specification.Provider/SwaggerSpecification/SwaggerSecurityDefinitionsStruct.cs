using Swagger.Assembly.Attributes.CommonlyUsedEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Specification.Provider.SwaggerSpecification
{
    public class SwaggerSecurityDefinitionsStruct
    {
        public SecurityDefinitionsTypeEnum SecurityDefinitionsType { get; set; }
        public SecuritySchemeTypeEnum type { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public SecurityDefInTypeEnum SecurityInType { get; set; }
        public SecuritySchemeFlowEnum flow { get; set; }
        public string authorizationUrl { get; set; }
        public string tokenUrl { get; set; }
        public string scopes { get; set; }

        public SwaggerSecurityDefinitionsStruct(SecurityDefinitionsTypeEnum m_SecurityDefinitionsTypeEnum)
        {
            this.SecurityDefinitionsType = m_SecurityDefinitionsTypeEnum;
        }

        public void SetApiKeyInfo(string m_Name, SecurityDefInTypeEnum m_SecurityInType)
        {
            this.type = SecuritySchemeTypeEnum.apiKey;
            this.name = m_Name;
            this.SecurityInType = m_SecurityInType;
        }

        public void SetPetstoreAuthInfo(SecuritySchemeTypeEnum m_SecuritySchemeType, SecuritySchemeFlowEnum m_SecuritySchemeFlowType, string m_AuthorizationUrl, string m_TokenUrl, string m_Scopes = "{ \"write: pets\": \"modify pets in your account\", \"read: pets\": \"read your pets\",}")
        {
            this.type = m_SecuritySchemeType;
            this.flow = m_SecuritySchemeFlowType;
            this.authorizationUrl = m_AuthorizationUrl;
            this.tokenUrl = m_TokenUrl;
            this.scopes = m_Scopes;
        }

        public string ToJsonContext()
        {
            StringBuilder m_Return = new StringBuilder();

            switch (this.SecurityDefinitionsType)
            {
                case SecurityDefinitionsTypeEnum.petstore_auth:
                    m_Return.Append("\"petstore_auth\": {");
                    m_Return.AppendFormat("\"type\": \"{0}\",", type.ToString());
                    if (!string.IsNullOrEmpty(this.authorizationUrl))
                    {
                        m_Return.AppendFormat("\"authorizationUrl\": \"{0}\",", this.authorizationUrl);
                    }
                    else
                    {
                        m_Return.AppendFormat("\"tokenUrl\": \"{0}\",", this.tokenUrl);
                    }
                    m_Return.AppendFormat("\"flow\": \"{0}\",", flow.ToString());
                    m_Return.AppendFormat("\"scopes\": {0},", this.scopes);
                    m_Return.Append("}");
                    break;
                case SecurityDefinitionsTypeEnum.api_key:
                    m_Return.Append("\"api_key\": {");
                    m_Return.Append("\"type\": \"apiKey\",");
                    m_Return.AppendFormat("\"name\": \"{0}\",", this.name);
                    m_Return.AppendFormat("\"in\": \"{0}\",", this.SecurityInType.ToString());
                    m_Return.Append("}");
                    break;
                default:
                    break;
            }


            return m_Return.ToString();
        }
    }
}
