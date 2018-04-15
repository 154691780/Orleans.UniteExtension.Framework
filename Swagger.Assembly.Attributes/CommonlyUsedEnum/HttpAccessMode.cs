using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Assembly.Attributes.CommonlyUsedEnum
{
    public enum HttpAccessMode : uint
    {
        /// <summary>
        /// get访问方式
        /// </summary>
        [Description("get")]
        get = 0,

        /// <summary>
        /// post访问方式
        /// </summary>
        [Description("post")]
        post = 1,

        /// <summary>
        /// put访问方式
        /// </summary>
        [Description("put")]
        put = 2,

        /// <summary>
        /// delete访问方式
        /// </summary>
        [Description("delete")]
        delete = 3,

        /// <summary>
        /// options访问方式
        /// </summary>
        [Description("options")]
        options = 4,

        /// <summary>
        /// head访问方式
        /// </summary>
        [Description("head")]
        head = 5,

        /// <summary>
        /// patch访问方式
        /// </summary>
        [Description("patch")]
        patch = 6,
    }
}
