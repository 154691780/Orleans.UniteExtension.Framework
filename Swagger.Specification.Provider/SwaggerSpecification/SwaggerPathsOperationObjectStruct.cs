using Newtonsoft.Json;
using Swagger.Assembly.Attributes.CommonlyUsedEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Specification.Provider.SwaggerSpecification
{
    public class SwaggerPathsOperationObjectStruct
    {
        /// <summary>
        /// get, put, post, delete, options, head, patch
        /// </summary>
        public HttpModeEnum OperationType { get; set; }
        public string[] tags { get; set; }
        public string summary { get; set; }
        public string description { get; set; }
        //public SwaggerExternalDocsStruct externalDocs { get; set; }
        public string operationId { get; set; }

        //public string[] consumes { get; set; }
        public string consumes { get; set; }

        //public string[] produces { get; set; }
        public string produces { get; set; }

        public List<SwaggerParametersStruct> parameters { get; set; }
        public List<SwaggerResponsesStruct> responses { get; set; }
        //public string[] schemes { get; set; }
        public bool deprecated { get; set; }
        public string security { get; set; }

        public SwaggerPathsOperationObjectStruct()
        {
            this.deprecated = false;
            this.parameters = new List<SwaggerParametersStruct>();
            this.responses = new List<SwaggerResponsesStruct>();
        }

        public string ToJsonContext()
        {
            StringBuilder m_Return = new StringBuilder();

            m_Return.AppendFormat("\"{0}\": {{", OperationType.ToString());

            m_Return.AppendFormat("\"tags\": {0},", JsonConvert.SerializeObject(this.tags));
            m_Return.AppendFormat("\"summary\": \"{0}\",", this.summary);
            m_Return.AppendFormat("\"description\": \"{0}\",", this.description);
            m_Return.AppendFormat("\"operationId\": \"{0}\",", this.operationId);
            m_Return.AppendFormat("\"consumes\": {0},", this.consumes);
            m_Return.AppendFormat("\"produces\": {0},", this.produces);

            #region Parameters

            m_Return.AppendFormat("\"parameters\": [", this.summary);
            StringBuilder m_ParametersStr = new StringBuilder();
            foreach (var m_Item in parameters)
            {
                m_ParametersStr.AppendFormat("{0},", m_Item.ToJsonContext());
            }
            m_Return.Append(m_ParametersStr);
            m_Return.Append("],");

            #endregion

            #region Responses

            m_Return.Append("\"responses\": {");
            StringBuilder m_ResponsesStr = new StringBuilder();
            foreach (var m_Item in responses)
            {
                m_ResponsesStr.AppendFormat("{0},", m_Item.ToJsonContext());
            }
            m_Return.Append(m_ResponsesStr);
            m_Return.Append("},");

            #endregion

            //m_Return.AppendFormat("\"schemes\": {0},", JsonConvert.SerializeObject(this.schemes));
            m_Return.AppendFormat("\"deprecated\": {0},", this.deprecated.ToString().ToLower());
            //m_Return.AppendFormat("\"security\": \"{0}\",", this.security);

            m_Return.Append("}");

            return m_Return.ToString();
        }
    }
}
