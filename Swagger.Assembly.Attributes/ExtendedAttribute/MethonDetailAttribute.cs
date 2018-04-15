using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonlyUsed.Toolkit;

namespace Swagger.Assembly.Attributes.ExtendedAttribute
{
    /// <summary>
    /// 方法明细特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class MethonDetailAttribute : Attribute
    {
        public string Summary { get; private set; }
        public string Description { get; private set; }
        public string OperationId { get; private set; }
        public bool Deprecated { get; private set; }

        /// <summary>
        /// 方法明细特性
        /// </summary>
        /// <param name="m_Summary">方法概要</param>
        /// <param name="m_Description">方法描述</param>
        /// <param name="m_OperationId">方法操作Id</param>
        /// <param name="m_Deprecated">是否弃用方法. 默认:false</param>
        public MethonDetailAttribute(string m_Summary, string m_Description, string m_OperationId = "", bool m_Deprecated = false)
        {
            if (m_Summary.StrIsNullOrEmpty())
            {
                throw new System.ArgumentNullException("m_Summary", "概要参数不能为Empty或Null.");
            }

            this.Summary = m_Summary;
            this.Description = m_Description;
            this.OperationId = m_OperationId;
            this.Deprecated = m_Deprecated;
        }
    }
}
