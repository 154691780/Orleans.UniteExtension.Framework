using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Specification.Provider.SwaggerSpecification
{
    /// <summary>
    /// Swagger文档主要结构
    /// </summary>
    public class SwaggerPrimaryStruct
    {
        public string swagger { get; set; }
        public SwaggerInfoStruct info { get; set; }
        public string host { get; set; }
        public string basePath { get; set; }

        /// <summary>
        /// 存放tags. 就存字符串,前后加 '{', '}' 号.
        /// </summary>
        public Dictionary<string, SwaggerTagsStruct> tags { get; set; }

        public string[] schemes { get; set; }

        public Dictionary<string, SwaggerPathsStruct> paths { get; set; }

        public SwaggerSecurityDefinitionsStruct securityDefinitions { get; set; }
        public Dictionary<string, string> definitions { get; set; }
        public SwaggerExternalDocsStruct externalDocs { get; set; }

        public SwaggerPrimaryStruct()
        {
            this.swagger = "2.0";
            //this.tags = new SwaggerTagsStruct[] { };
            this.tags = new Dictionary<string, SwaggerTagsStruct>();
            this.schemes = new string[] { };
            this.paths = new Dictionary<string, SwaggerPathsStruct>();

            this.definitions = new Dictionary<string, string>();

            //this.definitions.Add("InParam", string.Format(DefInParamDefinitions.InParam, "{{\\\"m_SysId\\\":\\\"MasterSysIdentifier\\\",\\\"m_UserId\\\":\\\"admin\\\",\\\"m_Password\\\":\\\"888888\\\"}}"));
            //this.definitions.Add("InParam", $"{DefInParamDefinitions.InParam1}{{\\\"m_SysId\\\":\\\"MasterSysIdentifier\\\",\\\"m_UserId\\\":\\\"admin\\\",\\\"m_Password\\\":\\\"888888\\\"}}{DefInParamDefinitions.InParam2}");

            //this.definitions.Add("ResultSuccess", DefInParamDefinitions.OutParamResult_Success);
            //this.definitions.Add("ResultFailure", DefInParamDefinitions.OutParamResult_Failure);
            //this.definitions.Add("OutParamSuccess", DefInParamDefinitions.OutParam_Success);
            //this.definitions.Add("OutParamFailure", DefInParamDefinitions.OutParam_Failure);
        }

        public string ToJsonContext()
        {
            StringBuilder m_Return = new StringBuilder();

            m_Return.Append("{");

            m_Return.AppendFormat("\"swagger\": \"{0}\",", this.swagger);
            m_Return.AppendFormat("\"info\": {0},", this.info.ToJsonContext());
            m_Return.AppendFormat("\"host\": \"{0}\",", this.host);
            m_Return.AppendFormat("\"basePath\": \"{0}\",", this.basePath);
            m_Return.AppendFormat("\"tags\": {0},", JsonConvert.SerializeObject(this.tags.Values.ToArray()));
            m_Return.AppendFormat("\"schemes\": {0},", JsonConvert.SerializeObject(this.schemes));

            m_Return.Append("\"paths\": {");
            foreach (var m_Item in this.paths.Values)
            {
                m_Return.AppendFormat("{0},", m_Item.ToJsonContext());
            }
            m_Return.Append("},");

            m_Return.AppendFormat("\"securityDefinitions\": {{{0}}},", this.securityDefinitions.ToJsonContext());

            m_Return.Append("\"definitions\": {");
            foreach (var m_Item in this.definitions.Values)
            {
                m_Return.AppendFormat("{0},", m_Item);
            }
            m_Return.Append("},");

            m_Return.AppendFormat("\"externalDocs\": {0},", this.externalDocs.ToJsonContext());

            m_Return.Append("}");

            return m_Return.ToString();
        }
    }
}
