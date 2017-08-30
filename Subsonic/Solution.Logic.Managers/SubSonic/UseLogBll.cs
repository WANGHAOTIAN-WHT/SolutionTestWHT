
using System;
using System.Linq.Expressions;
using SubSonic.DataProviders;
using Solution.DataAccess.DataModel;
using Solution.DataAccess.DbHelper;

namespace Solution.Logic{
	
	public partial class UseLogBll {
		
		#region 单例模式
		
		//定义单例实体
		private static UseLogBll _UseLogBll=null;
		
		/// <summary>
		/// 获取本逻辑类单例
		/// </summary>
		/// <returns></returns>
		public static UseLogBll GetInstence(){
			if(_UseLogBll==null){
				_UseLogBll = new UseLogBll();
			}
			return _UseLogBll;
		}
		
		#endregion


		#region 删除UseLog表指定Manager_Id字段值的记录
        /// <summary>
        /// 删除UseLog表指定Manager_Id字段值的记录
        /// </summary>
        /// <param name="id">记录的主键值</param>
        public void DeleteByManager_Id(int id)
        {
            UseLog.Delete(x => x.Manager_Id == id);
        }
        /// <summary>
        /// 删除<>表指定<>字段值的记录
        /// </summary>
        /// <param name="id">记录的主键值</param>
        public void DeleteByManager_Id(int[] id)
        {
            if (id == null) return;
            IDataProvider provider = null;

            //将数组转为逗号分隔的字符串
            var str = string.Join(",", id);
            //拼装SQL语句
            var sql = "delete from UseLog where Manager_Id in (" + str + ")";
            //删除

            var deleteHelper = new DeleteHelper(provider);
            deleteHelper.Delete(sql);
        }
        #endregion


		#region 删除UseLog表指定MenuInfo_Id字段值的记录
        /// <summary>
        /// 删除UseLog表指定MenuInfo_Id字段值的记录
        /// </summary>
        /// <param name="id">记录的主键值</param>
        public void DeleteByMenuInfo_Id(int id)
        {
            UseLog.Delete(x => x.MenuInfo_Id == id);
        }
        /// <summary>
        /// 删除<>表指定<>字段值的记录
        /// </summary>
        /// <param name="id">记录的主键值</param>
        public void DeleteByMenuInfo_Id(int[] id)
        {
            if (id == null) return;
            IDataProvider provider = null;

            //将数组转为逗号分隔的字符串
            var str = string.Join(",", id);
            //拼装SQL语句
            var sql = "delete from UseLog where MenuInfo_Id in (" + str + ")";
            //删除

            var deleteHelper = new DeleteHelper(provider);
            deleteHelper.Delete(sql);
        }
        #endregion


	}
}

