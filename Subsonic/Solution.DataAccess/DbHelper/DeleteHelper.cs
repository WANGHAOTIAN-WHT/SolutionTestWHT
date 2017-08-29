using System;
using SubSonic.DataProviders;
using SubSonic.Query;

namespace Solution.DataAccess.DbHelper
{
    /// <summary>
    /// 记录删除类
    /// </summary>
    public class DeleteHelper
    {
        //定义数据源
        IDataProvider provider = null;
        //获取执行语句
        private string _execSql = "";
        
        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public DeleteHelper(IDataProvider provider)
        {
            //获取数据源
            this.provider = provider;
        }


        #endregion

        #region 方法
        /// <summary>
        /// 删除,通过sql语句进行
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>被删除的记录数</returns>
        public int Delete(String sql)
        {
            try
            {
                //创建执行对象
                var q = new SubSonic.Query.QueryCommand(sql, provider);

                //获取执行语句
                _execSql = sql;

                return q.Provider.ExecuteQuery(q);
            }
            catch (Exception e)
            {
                //return 0;
                throw new Exception("删除数据异常,执行语句" + _execSql, e);
            }
        }

        /// <summary>
        /// (有事务)批量删除,通过sql语句进行删除
        /// </summary>
        /// <param name="sqls">执行sql语句集</param>
        /// <returns>被删除的记录数</returns>
        public int Delete(params String[] sqls)
        {
            try
            {
                //创建事务
                var batch = new BatchQuery(provider);

                //遍历添加
                foreach (String item in sqls)
                {
                    QueryCommand qcmd = new QueryCommand(item, provider);
                    
                    batch.QueueForTransaction(qcmd);
                }

                //获取执行语句
                _execSql = string.Join(",", sqls); 

                //执行事务
                batch.ExecuteTransaction();
                return batch.QueryCount;
            }
            catch (Exception e)
            {
                //return 0;
                throw new Exception("删除数据异常,执行语句" + _execSql, e);
            }

        }
        
        #endregion
    }
}
