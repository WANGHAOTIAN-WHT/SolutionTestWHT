
using System;
using SubSonic.DataProviders;
using Solution.DataAccess.DataModel;
using Solution.DataAccess.DbHelper;

namespace Solution.Logic{
	
	public partial class WebConfigBll {
		
		#region 单例模式
		
		//定义单例实体
		private static WebConfigBll _WebConfigBll=null;
		
		/// <summary>
		/// 获取本逻辑类单例
		/// </summary>
		/// <returns></returns>
		public static WebConfigBll GetInstence(){
			if(_WebConfigBll==null){
				_WebConfigBll = new WebConfigBll();
			}
			return _WebConfigBll;
		}
		
		#endregion


	}
}

