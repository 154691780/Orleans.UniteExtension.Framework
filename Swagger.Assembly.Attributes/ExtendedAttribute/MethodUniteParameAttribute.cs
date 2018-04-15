using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Assembly.Attributes.ExtendedAttribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class MethodUniteParameAttribute : Attribute
    {
        public Type UniteParame { get; set; }
        public string UniteParameJsonContext { get; set; }

        public MethodUniteParameAttribute() { }

        //public MethodUniteParameAttribute(Type m_UniteParame, string m_UPJsonContext)
        //{
        //    this.UniteParame = m_UniteParame;
        //    this.UniteParameJsonContext = m_UPJsonContext;
        //}
    }
}
