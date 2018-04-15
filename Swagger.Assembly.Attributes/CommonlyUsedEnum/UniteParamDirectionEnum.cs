using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Assembly.Attributes.CommonlyUsedEnum
{
    /// <summary>
    /// 统一参数方向枚举
    /// </summary>
    public enum UniteParamDirectionEnum : uint
    {
        /// <summary>
        /// 输入参数
        /// </summary>
        [Description("In")]
        In = 0,

        /// <summary>
        /// 输出参数
        /// </summary>
        [Description("Out")]
        Out = 1,
    }
}
