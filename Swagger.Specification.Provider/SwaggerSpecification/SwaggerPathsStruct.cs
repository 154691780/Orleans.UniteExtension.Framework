using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Specification.Provider.SwaggerSpecification
{
    /// <summary>
    /// 配合paths属性使用
    /// </summary>
    public class SwaggerPathsStruct
    {
        public string PathUrl { get; set; }
        public List<SwaggerPathsOperationObjectStruct> Operation { get; set; }

        public SwaggerPathsStruct()
        {
            this.Operation = new List<SwaggerPathsOperationObjectStruct>();
        }

        public string ToJsonContext()
        {
            StringBuilder m_Return = new StringBuilder();

            m_Return.AppendFormat("\"{0}\": {{", this.PathUrl);

            foreach (var m_Item in Operation)
            {
                m_Return.AppendFormat("{0},", m_Item.ToJsonContext());
            }

            m_Return.Append("}");

            return m_Return.ToString();
        }
    }
}
