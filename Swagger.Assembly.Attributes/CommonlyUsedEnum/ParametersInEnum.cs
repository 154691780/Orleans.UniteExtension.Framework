using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Assembly.Attributes.CommonlyUsedEnum
{
    /// <summary>
    /// 方法中ParametersIn枚举
    /// </summary>
    public enum ParametersInEnum : uint
    {
        /// <summary>
        /// body类型
        /// </summary>
        [Description("body")]
        body = 0,

        /// <summary>
        /// query类型
        /// </summary>
        [Description("query")]
        query = 1,

        /// <summary>
        /// formData类型
        /// </summary>
        [Description("formData")]
        formData = 2,

        /// <summary>
        /// header类型
        /// </summary>
        [Description("header")]
        header = 3,

        /// <summary>
        /// path类型
        /// </summary>
        [Description("path")]
        path = 4,
    }
}
