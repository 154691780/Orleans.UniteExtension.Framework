using Swagger.Assembly.Attributes.CommonlyUsedEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonlyUsed.Toolkit;

namespace Swagger.Assembly.Attributes.ExtendedAttribute
{
    /// <summary>
    /// 方法统一输出参数特性
    /// <para>警告: 使用该特性,出参将统一化处理.</para>
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class MethodUniteOutParamAttribute : Attribute
    {
        public Type OutParam { get; private set; }

        /// <summary>
        /// 方法统一输出参数特性
        /// </summary>
        /// <param name="m_OutParam">统一出参Type类型</param>
        public MethodUniteOutParamAttribute(Type m_OutParam)
        {
            if (m_OutParam.IsNull())
            {
                throw new System.ArgumentNullException("m_OutParam", "统一输出参数不能为Null.");
            }

            this.OutParam = m_OutParam;
        }
    }
}
