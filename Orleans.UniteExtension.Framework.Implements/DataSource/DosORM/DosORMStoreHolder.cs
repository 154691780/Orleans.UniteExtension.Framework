using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orleans.UniteExtension.Framework.Implements.DataSource.DosORM
{
    /// <summary>
    /// Dos.ORM 对象关系映射框架存储主持者
    /// </summary>
    public class DosORMStoreHolder
    {
        #region 事例代码

        //public static BeehivePrivilegeDBModel.DosORM.Operation.BeehivePrivilegeDbStoreOperator UniqueInstance_BeehivePrivilegeDb
        //{
        //    get { return BeehivePrivilegeDBModel.DosORM.Operation.BeehivePrivilegeDbStoreOperator.UniqueInstance; }
        //}

        ////public static readonly DbSession Context_SyntheticalDb = new DbSession("SyntheticalDbConn");
        //public static readonly DbSession Context_BeehivePrivilegeDb = BeehivePrivilegeDBModel.DosORM.Operation.BeehivePrivilegeDbStoreOperator.UniqueInstance.CurrentDbSession;

        ///// <summary>
        ///// 获取事务
        ///// </summary>
        ///// <returns></returns>
        //public static DbTrans GetBeehivePrivilegeDbTransaction()
        //{
        //    return BeehivePrivilegeDBModel.DosORM.Operation.BeehivePrivilegeDbStoreOperator.UniqueInstance.GetDbTransaction();
        //}

        //[Obsolete("该方法已过时, 请改用DosORMStoreHolder.UniqueInstance_SyntheticalDb属性替代.", true)]
        //public static BeehivePrivilegeDBModel.DosORM.Operation.BeehivePrivilegeDbStoreOperator GetDbStoreOperator()
        //{
        //    return BeehivePrivilegeDBModel.DosORM.Operation.BeehivePrivilegeDbStoreOperator.UniqueInstance;
        //}

        #endregion
    }
}
