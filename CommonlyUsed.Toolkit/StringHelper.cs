using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonlyUsed.Toolkit
{
    /// <summary>
    /// 字符串类型扩展帮助
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// 判断string类型是否为空或null
        /// </summary>
        /// <param name="m_String"></param>
        /// <returns>true: 为空或null; false: 反之;</returns>
        public static bool StrIsNullOrEmpty(this string m_String)
        {
            return string.IsNullOrEmpty(m_String);
        }

        /// <summary>
        /// 判断string类型是否为空
        /// </summary>
        /// <param name="m_String"></param>
        /// <returns>true: 为空或null; false: 反之;</returns>
        public static bool StrIsEmpty(this string m_String)
        {
            return m_String == string.Empty;
        }
    }
}
