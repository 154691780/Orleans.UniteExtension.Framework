using Orleans.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Orleans.UniteExtension.Framework.Implements.LogManagement
{
    /// <summary>
    /// Orleans日志扩展
    /// </summary>
    public static class LoggerExtensions
    {
        public static void AutoError(this Logger m_Logger, string m_Message = "", int m_Code = 0, [CallerMemberName] string m_CallerName = "")
        {
            m_Logger.Error(m_Code, $"{m_CallerName}: {m_Message}");
        }

        public static void AutoWarn(this Logger m_Logger, string m_Message = "", int m_Code = 0, [CallerMemberName] string m_CallerName = "")
        {
            m_Logger.Warn(m_Code, $"{m_CallerName}: {m_Message}");
        }

        public static void AutoInfo(this Logger m_Logger, string m_Message = "", int m_Code = 0, [CallerMemberName] string m_CallerName = "")
        {
            m_Logger.Info(m_Code, $"{m_CallerName}: {m_Message}");
        }

        public static void AutoVerbose(this Logger m_Logger, string m_Message = "", int m_Code = 0, [CallerMemberName] string m_CallerName = "")
        {
            m_Logger.Verbose(m_Code, $"{m_CallerName}: {m_Message}");
        }

        public static void AutoVerbose2(this Logger m_Logger, string m_Message = "", int m_Code = 0, [CallerMemberName] string m_CallerName = "")
        {
            m_Logger.Verbose2(m_Code, $"{m_CallerName}: {m_Message}");
        }

        public static void AutoVerbose3(this Logger m_Logger, string m_Message = "", int m_Code = 0, [CallerMemberName] string m_CallerName = "")
        {
            m_Logger.Verbose3(m_Code, $"{m_CallerName}: {m_Message}");
        }
    }
}
