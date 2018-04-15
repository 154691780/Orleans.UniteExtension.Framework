using Swagger.Assembly.Attributes.ExampleProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Assembly.Attributes.ExtendedAttribute
{
    /// <summary>
    /// 标记方法中参数的标签
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class ParametersExampleAttribute : Attribute
    {
        public object ParamObj { get; set; }

        public ParametersExampleAttribute(Type m_ExamplesProvider)
        {
            this.ParamObj = ((IExamplesProvider)Activator.CreateInstance(m_ExamplesProvider)).GetExamples();
        }
    }
}
