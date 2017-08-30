
using System;
using System.Linq.Expressions;
using SubSonic.DataProviders;
using Solution.DataAccess.DataModel;
using Solution.DataAccess.DbHelper;

namespace Solution.Logic{
	
	public partial class ErrorLogBll {
		
		#region 单例模式
		
		//定义单例实体
		private static ErrorLogBll _ErrorLogBll=null;
		
		/// <summary>
		/// 获取本逻辑类单例
		/// </summary>
		/// <returns></returns>
		public static ErrorLogBll GetInstence(){
			if(_ErrorLogBll==null){
				_ErrorLogBll = new ErrorLogBll();
			}
			return _ErrorLogBll;
		}
		
		#endregion


	}
}

