using Orleans.UniteExtension.Framework.Interfaces.Models.InParams;
using Orleans.UniteExtension.Framework.Interfaces.Models.OutputParams;
using Swagger.Assembly.Attributes.CommonlyUsedEnum;
using Swagger.Assembly.Attributes.ExtendedAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orleans.UniteExtension.Framework.Interfaces.GrainInterfaces.Samples
{
    public interface SampleInterfaces : IGrainWithStringKey
    {
        [Tags("样例接口标签", "SampleInterfaceTag1", "SampleInterfaceTag2")]
        [RefVersion("/v1")]
        [Route("/OrlApi/TestMothen")]
        [HttpMode(HttpModeEnum.post)]
        [MethonDetail("测试方法", "测试用方法.")]
        [ConsumesMIME(MIMETypeEnum.Application_Json)]
        [ProducesMIME(MIMETypeEnum.Application_Json)]
        [MethodUniteInParam(typeof(InParam))]
        [MethodUniteOutParam(typeof(OutParam))]
        [MethodParamDescription("Param1(string)", "Param2(int)", "Param3(bool)", "Param4(object)", "Param5(decimal)")]
        //[ParametersExample(typeof(AS_PUserPrivilegeConfigExample))]
        [MethodResponses("200", "默认'成功'返回代码.")]
        [MethodResponses("202", "已接受.已经接受请求,但未处理完成.")]
        [MethodResponses("204", "无内容.服务器成功处理,但未返回内容.")]
        [MethodResponses("400", "客户端请求的语法错误,服务器无法理解.")]
        [MethodResponses("401", "请求要求用户的身份认证.")]
        [MethodResponses("403", "服务器理解请求客户端的请求,但是拒绝执行此请求.")]
        [MethodResponses("405", "客户端请求中的方法被禁止.")]
        [MethodResponses("408", "服务器等待客户端发送的请求时间过长,超时.")]
        [MethodResponses("413", "由于请求的实体过大,服务器无法处理,因此拒绝请求.")]
        [MethodResponses("500", "内部服务器错误.")]
        [MethodResponses("501", "服务器不支持请求的功能,无法完成请求.")]
        Task<bool> TestMothen(string m_Param1, int m_Param2, bool m_Param3, object m_Param4, decimal m_Param5);
    }
}
