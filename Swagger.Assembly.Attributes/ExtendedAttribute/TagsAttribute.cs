using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Assembly.Attributes.ExtendedAttribute
{
    /// <summary>
    /// 标签特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class TagsAttribute : Attribute
    {
        public string[] TagsName { get; private set; }
        public string Description { get; private set; }

        /// <summary>
        /// 标签特性
        /// </summary>
        /// <param name="m_Description">标签描述</param>
        /// <param name="m_TagsName">标签名称</param>
        public TagsAttribute(string m_Description, params string[] m_TagsName)
        {
            this.TagsName = m_TagsName;
            this.Description = m_Description;
        }
    }
}
