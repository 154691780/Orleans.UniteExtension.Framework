using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Assembly.Attributes.CommonlyUsedEnum
{
    /// <summary>
    /// SecuritySchemeFlowEnum枚举
    /// </summary>
    public enum SecuritySchemeFlowEnum : uint
    {
        [Description("password")]
        password = 0,

        /// <summary>
        /// implicit
        /// </summary>
        [Description("implicit")]
        Implicit = 1,

        [Description("application")]
        application = 2,

        [Description("accessCode")]
        accessCode = 3,
    }
}
