using Swagger.Assembly.Attributes.CommonlyUsedEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Assembly.Attributes.ExtendedAttribute
{
    /// <summary>
    /// 统一参数特性
    /// <para>只对统一 In / Out 参数类做标记.</para>
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public class UniteParamAttribute : Attribute
    {
        public UniteParamDirectionEnum UniteParamDirection { get; private set; }
        public Type ParamType { get; private set; }
        public Type ParamExampleType { get; private set; }

        /// <summary>
        /// 统一参数特性
        /// </summary>
        /// <param name="m_UniteParamDirectionEnum">In/Out</param>
        /// <param name="m_ParamType">统一参数类型对象</param>
        /// <param name="m_ParamExampleType">统一参数用例类型对象</param>
        public UniteParamAttribute(UniteParamDirectionEnum m_UniteParamDirectionEnum, Type m_ParamType, Type m_ParamExampleType)
        {
            this.UniteParamDirection = m_UniteParamDirectionEnum;
            this.ParamType = m_ParamType;
            this.ParamExampleType = m_ParamExampleType;
        }
    }
}
