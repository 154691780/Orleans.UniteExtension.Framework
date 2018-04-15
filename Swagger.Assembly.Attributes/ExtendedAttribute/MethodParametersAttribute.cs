using Swagger.Assembly.Attributes.CommonlyUsedEnum;
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
    public class MethodParametersAttribute : Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ParametersInEnum In { get; set; }
        public bool Required { get; set; }
        public string Schema { get; set; }

        //public string ParamName { get; set; }
        //public Type ParamType { get; set; }

        public MethodParametersAttribute(Type m_ParamType, string m_ParamName, string m_Description, ParametersInEnum m_In = ParametersInEnum.body, bool m_Required = false, string m_Schema = null)
        {
            this.Description = m_Description;

            //this.ParamName = m_ParamName;
            //this.ParamType = m_ParamType;

            this.Name = m_In.ToString();
            if (m_In == ParametersInEnum.path || m_In == ParametersInEnum.formData || m_In == ParametersInEnum.query)
            {
                this.Name = m_ParamName;
            }

            this.In = m_In;

            this.Required = m_Required;

            this.Schema = m_Schema;
        }

        public MethodParametersAttribute(string m_Description, object m_DefaultValue)
        {
            this.Description = m_Description;


        }
    }
}
