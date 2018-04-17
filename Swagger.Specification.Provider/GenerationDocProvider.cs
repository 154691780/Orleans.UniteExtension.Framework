using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swagger.Assembly.Attributes.ExtendedAttribute;
using System.Collections.Concurrent;
using CommonlyUsed.Toolkit;
using Swagger.Specification.Provider.SwaggerSpecification;
using Newtonsoft.Json;

namespace Swagger.Specification.Provider
{
    /// <summary>
    /// 生成服务供应商
    /// </summary>
    public class GenerationDocProvider //: IServiceProvider
    {
        //public object GetService(Type serviceType)
        //{
        //    return serviceType;
        //}

        public static ConcurrentDictionary<string, MethodInfo> AssemblyMethodCacheDicy { get; private set; }

        static GenerationDocProvider()
        {
            GenerationDocProvider.AssemblyMethodCacheDicy = new ConcurrentDictionary<string, MethodInfo>();
        }

        public static void CreationAssemblyMethodCache(string m_AssemblyFullName)
        {
            var m_LoadAssembly = System.Reflection.Assembly.LoadFrom(m_AssemblyFullName);

            foreach (var m_Item in m_LoadAssembly.GetTypes().SelectMany(o => o.GetMethods()))
            {
                var m_IsRouteAttribute = m_Item.GetCustomAttributes().SingleOrDefault(o => o.GetType() == typeof(RouteAttribute));
                if (m_IsRouteAttribute != null)
                {
                    var m_RefVersionAttribute = m_Item.GetCustomAttribute<RefVersionAttribute>();
                    string m_RefVersionStr = m_RefVersionAttribute.RefVersion;

                    var m_HttpModeAttribute = m_Item.GetCustomAttribute<HttpModeAttribute>();
                    string m_HttpModeStr = m_HttpModeAttribute.HttpMode.ToString();

                    string m_RoutePath = (m_IsRouteAttribute as RouteAttribute).RoutePath;

                    // Key格式[/RefVersionAttribute/HttpModeAttribute/RouteAttribute]
                    string m_RouteKey = string.Format("{0}/{1}{2}", m_RefVersionStr, m_HttpModeStr, m_RoutePath);
                    var m_IsAdd = AssemblyMethodCacheDicy.ExtendedTryAdd(m_RouteKey, m_Item);

                    System.Diagnostics.Debug.WriteLine(string.Format("RouteKey是否加入成功:{0};  RouteKey: [ {1} ]; MethodName: {2}", m_IsAdd, m_RouteKey, m_Item.Name));
                }
            }
        }

        public static string GenerationDocument(string m_AssemblyFullName)
        {
            var m_SwaggerOutputStruct = new SwaggerPrimaryStruct
            {
                swagger = "2.0",
                info = new SwaggerInfoStruct
                {
                    description = "这是 `Beehive主权限系统` 的Swagger测试服务站点. 对于此示例, 您可以使用站点所展示的测试方法做既定接口功能验证测试.",
                    version = "1.0.0",
                    title = "YaoQ.Beehive.PrivilegeSystemBackstage (Swagger Pages)",
                    termsOfService = "#",
                    //public string swagger { get; set; }
                    contact = new SwaggerInfoContactStruct("heng.luo@yzamc.com"),
                    license = new SwaggerInfoLicenseStruct
                    {
                        name = "Apache 2.0",
                        url = "http://www.apache.org/licenses/LICENSE-2.0.html",
                    },
                },
                host = "127.0.0.1:9186",   // "10.21.10.167:9186",
                basePath = "/v1",   ///v1
                schemes = new string[] { "http" },
                //securityDefinitions = m_SwaggerSecurityDefinitionsStruct,
                externalDocs = new SwaggerExternalDocsStruct("了解更多Swagger . . .", "http://swagger.io"),
            };

            foreach (var m_Item in GenerationDocProvider.AssemblyMethodCacheDicy)
            {
                SwaggerPathsStruct m_SwaggerPathsStruct = new SwaggerPathsStruct();
                SwaggerPathsOperationObjectStruct m_SwaggerPathsOperationObjectStruct = new SwaggerPathsOperationObjectStruct();

                #region Codes . . .

                var m_RouteAttribute = m_Item.Value.GetCustomAttribute<RouteAttribute>();
                m_SwaggerPathsStruct.PathUrl = m_RouteAttribute.RoutePath;

                var m_TagsAttribute = m_Item.Value.GetCustomAttribute<TagsAttribute>();
                m_SwaggerPathsOperationObjectStruct.tags = m_TagsAttribute.TagsName;

                var m_HttpModeAttribute = m_Item.Value.GetCustomAttribute<HttpModeAttribute>();
                m_SwaggerPathsOperationObjectStruct.OperationType = m_HttpModeAttribute.HttpMode;

                var m_MethonDetailAttribute = m_Item.Value.GetCustomAttribute<MethonDetailAttribute>();
                m_SwaggerPathsOperationObjectStruct.summary = m_MethonDetailAttribute.Summary;
                m_SwaggerPathsOperationObjectStruct.description = m_MethonDetailAttribute.Description;
                //m_SwaggerPathsOperationObjectStruct.operationId = m_MethodDescAttribute.OperationId;

                var m_ConsumesAttribute = m_Item.Value.GetCustomAttribute<ConsumesMIMEAttribute>();
                m_SwaggerPathsOperationObjectStruct.consumes = m_ConsumesAttribute.ToJsonString();

                var m_ProducesAttribute = m_Item.Value.GetCustomAttribute<ProducesMIMEAttribute>();
                m_SwaggerPathsOperationObjectStruct.produces = m_ProducesAttribute.ToJsonString();

                var m_MethodUniteParameAttribute = m_Item.Value.GetCustomAttribute<MethodUniteInParamAttribute>();
                //if (m_MethodUniteParameAttribute != null)   // 存在统一输入参数特性配置
                //{
                //    SwaggerParametersStruct m_SwaggerParametersStruct = new SwaggerParametersStruct(null)
                //    {
                //        name = "body",
                //        In = "body",
                //        description = "统一的POST请求参数.",
                //        required = true,
                //        schema = $"#/definitions/{m_SwaggerPathsOperationObjectStruct.operationId}_InParam",

                //        SchemaRefName = $"{m_SwaggerPathsOperationObjectStruct.operationId}_InParam",
                //    };

                //    var m_ParametersExampleAttribute = m_Item.Value.GetCustomAttribute<ParametersExampleAttribute>();
                //    if (m_ParametersExampleAttribute != null)
                //    {
                //        string m_ParamJsonStr = JsonConvert.SerializeObject(m_ParametersExampleAttribute.ParamObj).Replace("\"", "\\\"");

                //        string m_TempStr = $"{Orleans.Swagger.AttributeLabel.DefInParamDefinitions.InParam1}{m_ParamJsonStr}{Orleans.Swagger.AttributeLabel.DefInParamDefinitions.InParam2}";
                //        m_TempStr = m_TempStr.Replace("InParam", m_SwaggerParametersStruct.SchemaRefName);
                //        m_TempStr = m_TempStr.Replace(Orleans.Swagger.AttributeLabel.DefInParamDefinitions.PlaceholderMothodName, m_Item.Name);

                //        if (!m_SwaggerOutputStruct.definitions.ContainsKey(m_SwaggerParametersStruct.SchemaRefName))
                //        {
                //            m_SwaggerOutputStruct.definitions.Add(m_SwaggerParametersStruct.SchemaRefName, m_TempStr);
                //        }
                //    }

                //    m_SwaggerPathsOperationObjectStruct.parameters.Add(m_SwaggerParametersStruct);
                //}
                //else
                //{
                //    #region Codes . . .

                //    foreach (var m_ParmeItem in m_Item.Value.GetCustomAttributes<MethodParametersAttribute>())
                //    {
                //        Orleans.Swagger.AttributeLabel.SwaggerParametersStruct m_SwaggerParametersStruct = new Orleans.Swagger.AttributeLabel.SwaggerParametersStruct(null)
                //        {
                //            name = m_ParmeItem.Name,
                //            In = m_ParmeItem.In.ToString(),
                //            description = m_ParmeItem.Description,
                //            required = m_ParmeItem.Required,
                //            //schema = "#/definitions/InParam",
                //        };

                //        m_SwaggerPathsOperationObjectStruct.parameters.Add(m_SwaggerParametersStruct);
                //    }

                //    #endregion
                //}


                #endregion

            }

            return "";
        }
    }
}
