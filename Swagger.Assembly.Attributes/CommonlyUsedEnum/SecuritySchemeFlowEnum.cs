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
        /// <summary>
        /// password
        /// </summary>
        [Description("password")]
        Password = 0,

        /// <summary>
        /// implicit
        /// </summary>
        [Description("implicit")]
        Implicit = 1,

        /// <summary>
        /// application
        /// </summary>
        [Description("application")]
        Application = 2,

        /// <summary>
        /// accessCode
        /// </summary>
        [Description("accessCode")]
        AccessCode = 3,
    }
}
