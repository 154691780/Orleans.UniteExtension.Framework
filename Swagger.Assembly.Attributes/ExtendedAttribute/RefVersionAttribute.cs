using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonlyUsed.Toolkit;

namespace Swagger.Assembly.Attributes.ExtendedAttribute
{
    /// <summary>
    /// 引用版本特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class RefVersionAttribute : Attribute
    {
        public string RefVersion { get; private set; }

        /// <summary>
        /// 引用版本特性
        /// </summary>
        /// <param name="m_VersionPath">版本路径</param>
        public RefVersionAttribute(string m_VersionPath = "/v1")
        {
            if (!m_VersionPath.StartsWith("/"))
            {
                throw new ArgumentException("版本路径不是以 / 符号开头.", "m_VersionPath");
            }

            this.RefVersion = m_VersionPath;
        }

        //public RefVersionAttribute(Version m_Version)
        //{
        //    if (m_Version.ToString().StrIsNullOrEmpty())
        //    {
        //        throw new ArgumentException("Version参数未做设置.", "m_Version");
        //    }

        //    this.RefVersion = string.Format("/{0}", m_Version);
        //}
    }
}
