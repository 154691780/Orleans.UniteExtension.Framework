using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Assembly.Attributes.CommonlyUsedEnum
{
    /// <summary>
    /// MIME类型枚举
    /// </summary>
    public enum MIMEType : uint
    {
        /// <summary>
        /// application/json类型
        /// </summary>
        [Description("application/json")]
        application_json = 0,

        /// <summary>
        /// application/xml类型
        /// </summary>
        [Description("application/xml")]
        application_xml = 1,

        /// <summary>
        /// application/x-www-form-urlencoded类型
        /// <para>例: foo=1&bar=swagger</para>
        /// </summary>
        [Description("application/x-www-form-urlencoded")]
        x_www_form_urlencoded = 2,

        /// <summary>
        /// "multipart/form-data类型
        /// <para>例: form-data; name="submit-name"</para>
        /// </summary>
        [Description("multipart/form-data")]
        form_data = 3,

        /// <summary>
        /// text_plain类型
        /// <para>例: text/plain; charset=utf-8"</para>
        /// </summary>
        [Description("text/plain; charset=utf-8")]
        text_plain = 4,
    }
}
