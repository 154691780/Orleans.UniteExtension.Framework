using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonlyUsed.Toolkit
{
    /// <summary>
    /// Object类型扩展帮助
    /// </summary>
    public static class ObjectHelper
    {
        /// <summary>
        /// 判断对象是否为null
        /// </summary>
        /// <param name="m_Object"></param>
        /// <returns></returns>
        public static bool IsNull<T>(this T m_Object)
        {
            return m_Object == null;
        }
    }
}
