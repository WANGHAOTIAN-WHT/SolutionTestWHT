
using System;
using System.Linq.Expressions;
using SubSonic.DataProviders;
using Solution.DataAccess.DataModel;
using Solution.DataAccess.DbHelper;

namespace Solution.Logic{
	
	public partial class PagePowerSignBll {
		
		#region 单例模式
		
		//定义单例实体
		private static PagePowerSignBll _PagePowerSignBll=null;
		
		/// <summary>
		/// 获取本逻辑类单例
		/// </summary>
		/// <returns></returns>
		public static PagePowerSignBll GetInstence(){
			if(_PagePowerSignBll==null){
				_PagePowerSignBll = new PagePowerSignBll();
			}
			return _PagePowerSignBll;
		}
		
		#endregion


		#region 删除PagePowerSign表指定PagePowerSignPublic_Id字段值的记录
        /// <summary>
        /// 删除PagePowerSign表指定PagePowerSignPublic_Id字段值的记录
        /// </summary>
        /// <param name="id">记录的主键值</param>
        public void DeleteByPagePowerSignPublic_Id(int id)
        {
            PagePowerSign.Delete(x => x.PagePowerSignPublic_Id == id);
        }
        /// <summary>
        /// 删除<>表指定<>字段值的记录
        /// </summary>
        /// <param name="id">记录的主键值</param>
        public void DeleteByPagePowerSignPublic_Id(int[] id)
        {
            if (id == null) return;
            IDataProvider provider = null;

            //将数组转为逗号分隔的字符串
            var str = string.Join(",", id);
            //拼装SQL语句
            var sql = "delete from PagePowerSign where PagePowerSignPublic_Id in (" + str + ")";
            //删除

            var deleteHelper = new DeleteHelper(provider);
            deleteHelper.Delete(sql);
        }
        #endregion


		#region 删除PagePowerSign表指定MenuInfo_Id字段值的记录
        /// <summary>
        /// 删除PagePowerSign表指定MenuInfo_Id字段值的记录
        /// </summary>
        /// <param name="id">记录的主键值</param>
        public void DeleteByMenuInfo_Id(int id)
        {
            PagePowerSign.Delete(x => x.MenuInfo_Id == id);
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
            var sql = "delete from PagePowerSign where MenuInfo_Id in (" + str + ")";
            //删除

            var deleteHelper = new DeleteHelper(provider);
            deleteHelper.Delete(sql);
        }
        #endregion


	}
}

