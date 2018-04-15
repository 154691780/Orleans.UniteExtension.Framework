using Swagger.Assembly.Attributes.CommonlyUsedEnum;
using Swagger.Assembly.Attributes.ExtendedAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orleans.UniteExtension.Framework.Interfaces.Models.OutputParams
{
    /// <summary>
    /// 标准输出对象
    /// </summary>
    [Serializable]
    [UniteParam(UniteParamDirectionEnum.Out, typeof(OutParam), typeof(OutParam))]
    public class OutParam
    {
        /// <summary>
        /// 账户Id
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// 结果编码
        /// </summary>
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果编码描述信息
        /// </summary>
        public string ResultMessage { get; set; }

        /// <summary>
        /// 返回内容体
        /// </summary>
        public string JosnParamBody { get; set; }

        /// <summary>
        /// 标准输出对象
        /// </summary>
        public OutParam() { }

        /// <summary>
        /// 标准输出对象
        /// </summary>
        /// <param name="m_AccountId"></param>
        public OutParam(string m_AccountId)
        {
            this.AccountId = m_AccountId;
        }
    }
}
