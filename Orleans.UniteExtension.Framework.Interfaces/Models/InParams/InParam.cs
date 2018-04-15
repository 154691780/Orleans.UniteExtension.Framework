using Swagger.Assembly.Attributes.CommonlyUsedEnum;
using Swagger.Assembly.Attributes.ExtendedAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orleans.UniteExtension.Framework.Interfaces.Models.InParams
{
    /// <summary>
    /// 标准输入对象
    /// </summary>
    [Serializable]
    [UniteParam(UniteParamDirectionEnum.In, typeof(InParam), typeof(InParam))]
    public class InParam
    {
        /// <summary>
        /// 序列号
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// 授权Token
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public DateTime TimeStamp { get; set; }

        /// <summary>
        /// 实际参数对象
        /// <para>接收后可用Josn转为内存实体</para>
        /// </summary>
        public object JosnParamBody { get; set; }
    }
}
