
using System;
using System.Linq.Expressions;
using SubSonic.DataProviders;
using Solution.DataAccess.DataModel;
using Solution.DataAccess.DbHelper;

namespace Solution.Logic{
	
	public partial class EmailSendHistoryBll {
		
		#region 单例模式
		
		//定义单例实体
		private static EmailSendHistoryBll _EmailSendHistoryBll=null;
		
		/// <summary>
		/// 获取本逻辑类单例
		/// </summary>
		/// <returns></returns>
		public static EmailSendHistoryBll GetInstence(){
			if(_EmailSendHistoryBll==null){
				_EmailSendHistoryBll = new EmailSendHistoryBll();
			}
			return _EmailSendHistoryBll;
		}
		
		#endregion


		#region 删除EmailSendHistory表指定SendUsers_Id字段值的记录
        /// <summary>
        /// 删除EmailSendHistory表指定SendUsers_Id字段值的记录
        /// </summary>
        /// <param name="id">记录的主键值</param>
        public void DeleteBySendUsers_Id(int id)
        {
            EmailSendHistory.Delete(x => x.SendUsers_Id == id);
        }
        /// <summary>
        /// 删除<>表指定<>字段值的记录
        /// </summary>
        /// <param name="id">记录的主键值</param>
        public void DeleteBySendUsers_Id(int[] id)
        {
            if (id == null) return;
            IDataProvider provider = null;

            //将数组转为逗号分隔的字符串
            var str = string.Join(",", id);
            //拼装SQL语句
            var sql = "delete from EmailSendHistory where SendUsers_Id in (" + str + ")";
            //删除

            var deleteHelper = new DeleteHelper(provider);
            deleteHelper.Delete(sql);
        }
        #endregion


		#region 删除EmailSendHistory表指定RecUsers_Id字段值的记录
        /// <summary>
        /// 删除EmailSendHistory表指定RecUsers_Id字段值的记录
        /// </summary>
        /// <param name="id">记录的主键值</param>
        public void DeleteByRecUsers_Id(int id)
        {
            EmailSendHistory.Delete(x => x.RecUsers_Id == id);
        }
        /// <summary>
        /// 删除<>表指定<>字段值的记录
        /// </summary>
        /// <param name="id">记录的主键值</param>
        public void DeleteByRecUsers_Id(int[] id)
        {
            if (id == null) return;
            IDataProvider provider = null;

            //将数组转为逗号分隔的字符串
            var str = string.Join(",", id);
            //拼装SQL语句
            var sql = "delete from EmailSendHistory where RecUsers_Id in (" + str + ")";
            //删除

            var deleteHelper = new DeleteHelper(provider);
            deleteHelper.Delete(sql);
        }
        #endregion


		#region 删除EmailSendHistory表指定RecUserLevel_Id字段值的记录
        /// <summary>
        /// 删除EmailSendHistory表指定RecUserLevel_Id字段值的记录
        /// </summary>
        /// <param name="id">记录的主键值</param>
        public void DeleteByRecUserLevel_Id(int id)
        {
            EmailSendHistory.Delete(x => x.RecUserLevel_Id == id);
        }
        /// <summary>
        /// 删除<>表指定<>字段值的记录
        /// </summary>
        /// <param name="id">记录的主键值</param>
        public void DeleteByRecUserLevel_Id(int[] id)
        {
            if (id == null) return;
            IDataProvider provider = null;

            //将数组转为逗号分隔的字符串
            var str = string.Join(",", id);
            //拼装SQL语句
            var sql = "delete from EmailSendHistory where RecUserLevel_Id in (" + str + ")";
            //删除

            var deleteHelper = new DeleteHelper(provider);
            deleteHelper.Delete(sql);
        }
        #endregion


		#region 删除EmailSendHistory表指定Template_Id字段值的记录
        /// <summary>
        /// 删除EmailSendHistory表指定Template_Id字段值的记录
        /// </summary>
        /// <param name="id">记录的主键值</param>
        public void DeleteByTemplate_Id(int id)
        {
            EmailSendHistory.Delete(x => x.Template_Id == id);
        }
        /// <summary>
        /// 删除<>表指定<>字段值的记录
        /// </summary>
        /// <param name="id">记录的主键值</param>
        public void DeleteByTemplate_Id(int[] id)
        {
            if (id == null) return;
            IDataProvider provider = null;

            //将数组转为逗号分隔的字符串
            var str = string.Join(",", id);
            //拼装SQL语句
            var sql = "delete from EmailSendHistory where Template_Id in (" + str + ")";
            //删除

            var deleteHelper = new DeleteHelper(provider);
            deleteHelper.Delete(sql);
        }
        #endregion


	}
}

