using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonlyUsed.Toolkit
{
    /// <summary>
    /// 日期类型扩展帮助
    /// </summary>
    public static class DateTimeHelper
    {
        /// <summary>
        /// 获取日期类型yyyy-MM-dd格式的数据
        /// </summary>
        /// <param name="m_DateTime"></param>
        /// <returns></returns>
        public static DateTime GetShortDate(this DateTime m_DateTime)
        {
            return DateTime.Parse(m_DateTime.ToString("yyyy-MM-dd"));
        }

        /// <summary>
        /// 获取日期类型yyyy-MM-dd格式字符串返回
        /// </summary>
        /// <param name="m_DateTime"></param>
        /// <returns></returns>
        public static string GetShortString(this DateTime m_DateTime)
        {
            return m_DateTime.ToString("yyyy-MM-dd");
        }
    }
}
