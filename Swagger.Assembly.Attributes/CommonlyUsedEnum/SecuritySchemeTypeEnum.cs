using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Assembly.Attributes.CommonlyUsedEnum
{
    /// <summary>
    /// SecuritySchemeType枚举
    /// </summary>
    public enum SecuritySchemeTypeEnum : uint
    {
        oauth2 = 0,
        basic = 1,
        apiKey = 2,
    }
}
