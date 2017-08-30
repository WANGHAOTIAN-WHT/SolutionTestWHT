
using System;
using SubSonic.DataProviders;
using Solution.DataAccess.DataModel;
using Solution.DataAccess.DbHelper;

namespace Solution.Logic{
	
	public partial class MenuInfoBll {
		
		#region 单例模式
		
		//定义单例实体
		private static MenuInfoBll _MenuInfoBll=null;
		
		/// <summary>
		/// 获取本逻辑类单例
		/// </summary>
		/// <returns></returns>
		public static MenuInfoBll GetInstence(){
			if(_MenuInfoBll==null){
				_MenuInfoBll = new MenuInfoBll();
			}
			return _MenuInfoBll;
		}
		
		#endregion


	}
}

