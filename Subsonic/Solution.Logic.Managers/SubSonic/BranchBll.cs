
using System;
using System.Linq.Expressions;
using SubSonic.DataProviders;
using Solution.DataAccess.DataModel;
using Solution.DataAccess.DbHelper;

namespace Solution.Logic{
	
	public partial class BranchBll {
		
		#region 单例模式
		
		//定义单例实体
		private static BranchBll _BranchBll=null;
		
		/// <summary>
		/// 获取本逻辑类单例
		/// </summary>
		/// <returns></returns>
		public static BranchBll GetInstence(){
			if(_BranchBll==null){
				_BranchBll = new BranchBll();
			}
			return _BranchBll;
		}
		
		#endregion


		#region 删除Branch表指定Manager_Id字段值的记录
        /// <summary>
        /// 删除Branch表指定Manager_Id字段值的记录
        /// </summary>
        /// <param name="id">记录的主键值</param>
        public void DeleteByManager_Id(int id)
        {
            Branch.Delete(x => x.Manager_Id == id);
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
            var sql = "delete from Branch where Manager_Id in (" + str + ")";
            //删除

            var deleteHelper = new DeleteHelper(provider);
            deleteHelper.Delete(sql);
        }
        #endregion


	}
}

