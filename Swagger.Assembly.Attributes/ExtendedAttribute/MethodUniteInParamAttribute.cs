using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonlyUsed.Toolkit;

namespace Swagger.Assembly.Attributes.ExtendedAttribute
{
    /// <summary>
    /// 方法统一输入参数特性
    /// <para>警告: 使用该特性,入参将统一化处理.</para>
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class MethodUniteInParamAttribute : Attribute
    {
        public Type InParam { get; private set; }

        /// <summary>
        /// 方法统一输入参数特性
        /// </summary>
        /// <param name="m_InParam">统一入参Type类型</param>
        public MethodUniteInParamAttribute(Type m_InParam)
        {
            if (m_InParam.IsNull())
            {
                throw new System.ArgumentNullException("m_InParam", "统一输入参数不能为Null.");
            }

            this.InParam = m_InParam;
        }
    }
}
