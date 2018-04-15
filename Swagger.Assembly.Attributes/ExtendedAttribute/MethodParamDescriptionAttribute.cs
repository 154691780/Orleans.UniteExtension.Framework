using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Assembly.Attributes.ExtendedAttribute
{
    /// <summary>
    /// 方法参数描述特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class MethodParamDescriptionAttribute : Attribute
    {
        public string[] DescriptionArray { get; private set; }

        /// <summary>
        /// 方法参数描述特性
        /// </summary>
        /// <param name="m_DescriptionParams">参数描述可变参数</param>
        public MethodParamDescriptionAttribute(params string[] m_DescriptionParams)
        {
            if (m_DescriptionParams == null || m_DescriptionParams.Length == 0)
            {
                throw new System.ArgumentException("参数描述信息不能为Null.", "m_DescriptionParams");
            }

            this.DescriptionArray = m_DescriptionParams;
        }
    }
}
