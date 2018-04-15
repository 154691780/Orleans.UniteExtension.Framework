using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orleans.UniteExtension.Framework.Interfaces.Models.OutputParams
{
    /// <summary>
    /// 标准输出对象, 带传递参数.
    /// <para/>
    /// Transfer为传递参数属性.
    /// </summary>
    [Serializable]
    public class OutParamTransfer<T> : OutParam
    {
        public T Transfer { get; set; }

        public OutParamTransfer(string m_AccountId) : base(m_AccountId) { }

        public OutParamTransfer(string m_AccountId, T m_Transfer) : this(m_AccountId)
        {
            this.Transfer = m_Transfer;
        }
    }
}
