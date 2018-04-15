using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonlyUsed.Toolkit
{
    /// <summary>
    /// 路径扩展帮助
    /// </summary>
    public class PathHelper
    {
        /// <summary>
        /// 获取当前程序路径
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentAppBasisPath()
        {
            string m_SysPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            return m_SysPath = m_SysPath.Substring(0, m_SysPath.LastIndexOf('\\'));
        }

        /// <summary>
        /// 获取制定路径
        /// </summary>
        /// <returns></returns>
        public static string GetAssignPath(string m_AssignPath)
        {
            return PathHelper.GetAssignPath(PathHelper.GetCurrentAppBasisPath(), m_AssignPath);
        }

        /// <summary>
        /// 获取制定路径
        /// </summary>
        /// <returns></returns>
        public static string GetAssignPath(string m_RootPath, string m_AssignPath)
        {
            return System.IO.Path.Combine(m_RootPath, m_AssignPath);
        }
    }
}
