
using System;
using SubSonic.DataProviders;
using Solution.DataAccess.DataModel;
using Solution.DataAccess.DbHelper;

namespace Solution.Logic{
	
	public partial class PagePowerSignPublicBll {
		
		#region 单例模式
		
		//定义单例实体
		private static PagePowerSignPublicBll _PagePowerSignPublicBll=null;
		
		/// <summary>
		/// 获取本逻辑类单例
		/// </summary>
		/// <returns></returns>
		public static PagePowerSignPublicBll GetInstence(){
			if(_PagePowerSignPublicBll==null){
				_PagePowerSignPublicBll = new PagePowerSignPublicBll();
			}
			return _PagePowerSignPublicBll;
		}
		
		#endregion


	}
}

