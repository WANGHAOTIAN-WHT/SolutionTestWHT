
using System;

namespace Solution.DataAccess.DataModel
{

    public class MenuInfoTable
    {
        /// <summary>
        /// 表名
        /// </summary>
        public static string TableName
        {
            get
            {
                return "MenuInfo";
            }
        }
        //新增代码，循环遍历表中的所有字段，创建相应的函数
        /// <summary>
        /// 主键Id
        /// </summary>
        public static string Id
        {
            get
            {
                return "Id";
            }
        }
        /// <summary>
        /// 菜单名称或各个页面功能名称
        /// </summary>
        public static string Name
        {
            get
            {
                return "Name";
            }
        }
        /// <summary>
        /// 各页面URL（主菜单与分类菜单没有URL）
        /// </summary>
        public static string Url
        {
            get
            {
                return "Url";
            }
        }
        /// <summary>
        /// 父ID
        /// </summary>
        public static string ParentId
        {
            get
            {
                return "ParentId";
            }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public static string Sort
        {
            get
            {
                return "Sort";
            }
        }
        /// <summary>
        /// 深度
        /// </summary>
        public static string Depth
        {
            get
            {
                return "Depth";
            }
        }
        /// <summary>
        /// 该菜单是否在菜单栏显示，0=不显示，1=显示
        /// </summary>
        public static string IsDisplay
        {
            get
            {
                return "IsDisplay";
            }
        }
        /// <summary>
        /// 是否是菜单还是页面
        /// </summary>
        public static string IsMenu
        {
            get
            {
                return "IsMenu";
            }
        }


    }

    public class PagePowerSignTable
    {
        /// <summary>
        /// 表名
        /// </summary>
        public static string TableName
        {
            get
            {
                return "PagePowerSign";
            }
        }
        //新增代码，循环遍历表中的所有字段，创建相应的函数
        /// <summary>
        /// 主键Id
        /// </summary>
        public static string Id
        {
            get
            {
                return "Id";
            }
        }
        /// <summary>
        /// 公用页面权限ID
        /// </summary>
        public static string PagePowerSignPublic_Id
        {
            get
            {
                return "PagePowerSignPublic_Id";
            }
        }
        /// <summary>
        /// 权限名称，如：浏览、添加、修改、删除、报表、查询、调动/分配、设置等(名称可以自由定，但建议取有意义的名称)
        /// </summary>
        public static string CName
        {
            get
            {
                return "CName";
            }
        }
        /// <summary>
        /// 权限英文名称，除了在英文版权限设置时显示对应菜单外，还用来在页面程序中区分页面不同位置所调用的权限(在检测页面权限时使用)
        /// </summary>
        public static string EName
        {
            get
            {
                return "EName";
            }
        }
        /// <summary>
        /// 菜单ID
        /// </summary>
        public static string MenuInfo_Id
        {
            get
            {
                return "MenuInfo_Id";
            }
        }


    }

    public class PagePowerSignPublicTable
    {
        /// <summary>
        /// 表名
        /// </summary>
        public static string TableName
        {
            get
            {
                return "PagePowerSignPublic";
            }
        }
        //新增代码，循环遍历表中的所有字段，创建相应的函数
        /// <summary>
        /// 主键Id
        /// </summary>
        public static string Id
        {
            get
            {
                return "Id";
            }
        }
        /// <summary>
        /// 权限中文名称
        /// </summary>
        public static string Cname
        {
            get
            {
                return "Cname";
            }
        }
        /// <summary>
        /// 权限英文名称
        /// </summary>
        public static string Ename
        {
            get
            {
                return "Ename";
            }
        }


    }

    public class BranchTable
    {
        /// <summary>
        /// 表名
        /// </summary>
        public static string TableName
        {
            get
            {
                return "Branch";
            }
        }
        //新增代码，循环遍历表中的所有字段，创建相应的函数
        /// <summary>
        /// 主键Id
        /// </summary>
        public static string Id
        {
            get
            {
                return "Id";
            }
        }
        /// <summary>
        /// 部门ID，内容为001001001，即每低一级部门，编码增加三位小数
        /// </summary>
        public static string Code
        {
            get
            {
                return "Code";
            }
        }
        /// <summary>
        /// 部门名称
        /// </summary>
        public static string Name
        {
            get
            {
                return "Name";
            }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public static string Notes
        {
            get
            {
                return "Notes";
            }
        }
        /// <summary>
        /// 父ID
        /// </summary>
        public static string ParentId
        {
            get
            {
                return "ParentId";
            }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public static string Sort
        {
            get
            {
                return "Sort";
            }
        }
        /// <summary>
        /// 深度
        /// </summary>
        public static string Depth
        {
            get
            {
                return "Depth";
            }
        }
        /// <summary>
        /// 修改人员id
        /// </summary>
        public static string Manager_Id
        {
            get
            {
                return "Manager_Id";
            }
        }
        /// <summary>
        /// 修改人员姓名
        /// </summary>
        public static string Manager_CName
        {
            get
            {
                return "Manager_CName";
            }
        }
        /// <summary>
        /// 修改时间
        /// </summary>
        public static string UpdateDate
        {
            get
            {
                return "UpdateDate";
            }
        }


    }

    public class PositionTable
    {
        /// <summary>
        /// 表名
        /// </summary>
        public static string TableName
        {
            get
            {
                return "Position";
            }
        }
        //新增代码，循环遍历表中的所有字段，创建相应的函数
        /// <summary>
        /// 主键Id
        /// </summary>
        public static string Id
        {
            get
            {
                return "Id";
            }
        }
        /// <summary>
        /// 职位名称
        /// </summary>
        public static string Name
        {
            get
            {
                return "Name";
            }
        }
        /// <summary>
        /// 部门自编号ID
        /// </summary>
        public static string Branch_Id
        {
            get
            {
                return "Branch_Id";
            }
        }
        /// <summary>
        /// 部门编号
        /// </summary>
        public static string Branch_Code
        {
            get
            {
                return "Branch_Code";
            }
        }
        /// <summary>
        /// 部门名称
        /// </summary>
        public static string Branch_Name
        {
            get
            {
                return "Branch_Name";
            }
        }
        /// <summary>
        /// 菜单操作权限，有操作权限的菜单ID列表：|1|2|3|4|5|
        /// </summary>
        public static string PagePower
        {
            get
            {
                return "PagePower";
            }
        }
        /// <summary>
        /// 页面功能操作权限，各个页面有操作权限的菜单ID和页面权限标志ID列表：|1,1|2,1|2,2|2,4|
        /// </summary>
        public static string ControlPower
        {
            get
            {
                return "ControlPower";
            }
        }
        /// <summary>
        /// 是否有操作绑定指定部门的权限，0=无，1=有
        /// </summary>
        public static string IsSetBranchPower
        {
            get
            {
                return "IsSetBranchPower";
            }
        }
        /// <summary>
        /// 绑定部门的编号
        /// </summary>
        public static string SetBranchCode
        {
            get
            {
                return "SetBranchCode";
            }
        }
        /// <summary>
        /// 修改人员id
        /// </summary>
        public static string Manager_Id
        {
            get
            {
                return "Manager_Id";
            }
        }
        /// <summary>
        /// 修改人员姓名
        /// </summary>
        public static string Manager_CName
        {
            get
            {
                return "Manager_CName";
            }
        }
        /// <summary>
        /// 修改时间
        /// </summary>
        public static string UpdateDate
        {
            get
            {
                return "UpdateDate";
            }
        }


    }

    public class ManagerTable
    {
        /// <summary>
        /// 表名
        /// </summary>
        public static string TableName
        {
            get
            {
                return "Manager";
            }
        }
        //新增代码，循环遍历表中的所有字段，创建相应的函数
        /// <summary>
        /// 主键Id
        /// </summary>
        public static string Id
        {
            get
            {
                return "Id";
            }
        }
        /// <summary>
        /// 登陆账号
        /// </summary>
        public static string LoginName
        {
            get
            {
                return "LoginName";
            }
        }
        /// <summary>
        /// 登陆密码
        /// </summary>
        public static string LoginPass
        {
            get
            {
                return "LoginPass";
            }
        }
        /// <summary>
        /// 最后登陆时间
        /// </summary>
        public static string LoginTime
        {
            get
            {
                return "LoginTime";
            }
        }
        /// <summary>
        /// 最后登陆IP
        /// </summary>
        public static string LoginIp
        {
            get
            {
                return "LoginIp";
            }
        }
        /// <summary>
        /// 登陆次数
        /// </summary>
        public static string LoginCount
        {
            get
            {
                return "LoginCount";
            }
        }
        /// <summary>
        /// 注册时间
        /// </summary>
        public static string CreateTime
        {
            get
            {
                return "CreateTime";
            }
        }
        /// <summary>
        /// 资料最后修改日期
        /// </summary>
        public static string UpdateTime
        {
            get
            {
                return "UpdateTime";
            }
        }
        /// <summary>
        /// 所属部门ID
        /// </summary>
        public static string Branch_Id
        {
            get
            {
                return "Branch_Id";
            }
        }
        /// <summary>
        /// 所属部门编号，用户只能正式归属于一个部门
        /// </summary>
        public static string Branch_Code
        {
            get
            {
                return "Branch_Code";
            }
        }
        /// <summary>
        /// 部门名称
        /// </summary>
        public static string Branch_Name
        {
            get
            {
                return "Branch_Name";
            }
        }
        /// <summary>
        /// 用户职位ID
        /// </summary>
        public static string Position_Id
        {
            get
            {
                return "Position_Id";
            }
        }
        /// <summary>
        /// 职位名称
        /// </summary>
        public static string Position_Name
        {
            get
            {
                return "Position_Name";
            }
        }
        /// <summary>
        /// 账号是否启用，1=true(启用)，0=false（禁用）
        /// </summary>
        public static string Enable
        {
            get
            {
                return "Enable";
            }
        }
        /// <summary>
        /// 用户中文名称
        /// </summary>
        public static string CName
        {
            get
            {
                return "CName";
            }
        }
        /// <summary>
        /// 用户英文名称
        /// </summary>
        public static string EName
        {
            get
            {
                return "EName";
            }
        }
        /// <summary>
        /// 头像图片路径
        /// </summary>
        public static string PhotoImg
        {
            get
            {
                return "PhotoImg";
            }
        }
        /// <summary>
        /// 性别（0=未知，1=男，2=女）
        /// </summary>
        public static string Sex
        {
            get
            {
                return "Sex";
            }
        }
        /// <summary>
        /// 出生日期
        /// </summary>
        public static string Birthday
        {
            get
            {
                return "Birthday";
            }
        }
        /// <summary>
        /// 籍贯
        /// </summary>
        public static string NativePlace
        {
            get
            {
                return "NativePlace";
            }
        }
        /// <summary>
        /// 民族
        /// </summary>
        public static string NationalName
        {
            get
            {
                return "NationalName";
            }
        }
        /// <summary>
        /// 个人--学历
        /// </summary>
        public static string Record
        {
            get
            {
                return "Record";
            }
        }
        /// <summary>
        /// 毕业学校
        /// </summary>
        public static string GraduateCollege
        {
            get
            {
                return "GraduateCollege";
            }
        }
        /// <summary>
        /// 毕业专业
        /// </summary>
        public static string GraduateSpecialty
        {
            get
            {
                return "GraduateSpecialty";
            }
        }
        /// <summary>
        /// 个人--联系电话
        /// </summary>
        public static string Tel
        {
            get
            {
                return "Tel";
            }
        }
        /// <summary>
        /// 个人--移动电话
        /// </summary>
        public static string Mobile
        {
            get
            {
                return "Mobile";
            }
        }
        /// <summary>
        /// 个人--联系邮箱
        /// </summary>
        public static string Email
        {
            get
            {
                return "Email";
            }
        }
        /// <summary>
        /// 个人--QQ
        /// </summary>
        public static string Qq
        {
            get
            {
                return "Qq";
            }
        }
        /// <summary>
        /// 个人--Msn
        /// </summary>
        public static string Msn
        {
            get
            {
                return "Msn";
            }
        }
        /// <summary>
        /// 个人--通讯地址
        /// </summary>
        public static string Address
        {
            get
            {
                return "Address";
            }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public static string Content
        {
            get
            {
                return "Content";
            }
        }
        /// <summary>
        /// 修改人员id
        /// </summary>
        public static string Manager_Id
        {
            get
            {
                return "Manager_Id";
            }
        }
        /// <summary>
        /// 修改人中文名称
        /// </summary>
        public static string Manager_CName
        {
            get
            {
                return "Manager_CName";
            }
        }


    }

    public class LoginLogTable
    {
        /// <summary>
        /// 表名
        /// </summary>
        public static string TableName
        {
            get
            {
                return "LoginLog";
            }
        }
        //新增代码，循环遍历表中的所有字段，创建相应的函数
        /// <summary>
        /// 主键Id
        /// </summary>
        public static string Id
        {
            get
            {
                return "Id";
            }
        }
        /// <summary>
        /// 登陆日期
        /// </summary>
        public static string AddDate
        {
            get
            {
                return "AddDate";
            }
        }
        /// <summary>
        /// 登陆用户ID
        /// </summary>
        public static string Manager_Id
        {
            get
            {
                return "Manager_Id";
            }
        }
        /// <summary>
        /// 用户中文名称
        /// </summary>
        public static string Manager_CName
        {
            get
            {
                return "Manager_CName";
            }
        }
        /// <summary>
        /// 登陆IP
        /// </summary>
        public static string Ip
        {
            get
            {
                return "Ip";
            }
        }
        /// <summary>
        /// 操作内容
        /// </summary>
        public static string Notes
        {
            get
            {
                return "Notes";
            }
        }


    }

    public class UseLogTable
    {
        /// <summary>
        /// 表名
        /// </summary>
        public static string TableName
        {
            get
            {
                return "UseLog";
            }
        }
        //新增代码，循环遍历表中的所有字段，创建相应的函数
        /// <summary>
        /// 主键Id
        /// </summary>
        public static string Id
        {
            get
            {
                return "Id";
            }
        }
        /// <summary>
        /// 操作时间
        /// </summary>
        public static string AddDate
        {
            get
            {
                return "AddDate";
            }
        }
        /// <summary>
        /// 登陆用户ID
        /// </summary>
        public static string Manager_Id
        {
            get
            {
                return "Manager_Id";
            }
        }
        /// <summary>
        /// 用户中文名称
        /// </summary>
        public static string Manager_CName
        {
            get
            {
                return "Manager_CName";
            }
        }
        /// <summary>
        /// 登陆IP
        /// </summary>
        public static string Ip
        {
            get
            {
                return "Ip";
            }
        }
        /// <summary>
        /// 菜单ID（用户操作页面）
        /// </summary>
        public static string MenuInfo_Id
        {
            get
            {
                return "MenuInfo_Id";
            }
        }
        /// <summary>
        /// 菜单名称或各个页面功能名称
        /// </summary>
        public static string MenuInfo_Name
        {
            get
            {
                return "MenuInfo_Name";
            }
        }
        /// <summary>
        /// 操作内容
        /// </summary>
        public static string Notes
        {
            get
            {
                return "Notes";
            }
        }


    }

    public class ErrorLogTable
    {
        /// <summary>
        /// 表名
        /// </summary>
        public static string TableName
        {
            get
            {
                return "ErrorLog";
            }
        }
        //新增代码，循环遍历表中的所有字段，创建相应的函数
        /// <summary>
        /// 主键Id
        /// </summary>
        public static string Id
        {
            get
            {
                return "Id";
            }
        }
        /// <summary>
        /// 出错时间
        /// </summary>
        public static string ErrTime
        {
            get
            {
                return "ErrTime";
            }
        }
        /// <summary>
        /// 浏览器版本
        /// </summary>
        public static string BrowserVersion
        {
            get
            {
                return "BrowserVersion";
            }
        }
        /// <summary>
        /// 浏览器
        /// </summary>
        public static string BrowserType
        {
            get
            {
                return "BrowserType";
            }
        }
        /// <summary>
        /// IP
        /// </summary>
        public static string Ip
        {
            get
            {
                return "Ip";
            }
        }
        /// <summary>
        /// 异常页面
        /// </summary>
        public static string PageUrl
        {
            get
            {
                return "PageUrl";
            }
        }
        /// <summary>
        /// 异常消息
        /// </summary>
        public static string ErrMessage
        {
            get
            {
                return "ErrMessage";
            }
        }
        /// <summary>
        /// 异常源
        /// </summary>
        public static string ErrSource
        {
            get
            {
                return "ErrSource";
            }
        }
        /// <summary>
        /// 堆栈轨迹
        /// </summary>
        public static string StackTrace
        {
            get
            {
                return "StackTrace";
            }
        }
        /// <summary>
        /// 帮助连接
        /// </summary>
        public static string HelpLink
        {
            get
            {
                return "HelpLink";
            }
        }
        /// <summary>
        /// 错误类型，0=后台，1=前台，......
        /// </summary>
        public static string Type
        {
            get
            {
                return "Type";
            }
        }


    }

    public class EmailSendHistoryTable
    {
        /// <summary>
        /// 表名
        /// </summary>
        public static string TableName
        {
            get
            {
                return "EmailSendHistory";
            }
        }
        //新增代码，循环遍历表中的所有字段，创建相应的函数
        /// <summary>
        /// 站内信ID
        /// </summary>
        public static string Id
        {
            get
            {
                return "Id";
            }
        }
        /// <summary>
        /// 发送者编号ID，0=系统管理员
        /// </summary>
        public static string SendUsers_Id
        {
            get
            {
                return "SendUsers_Id";
            }
        }
        /// <summary>
        /// 发送者账号
        /// </summary>
        public static string SendUsers_Name
        {
            get
            {
                return "SendUsers_Name";
            }
        }
        /// <summary>
        /// 发送者邮箱
        /// </summary>
        public static string SendUsers_Email
        {
            get
            {
                return "SendUsers_Email";
            }
        }
        /// <summary>
        /// 接受者编号ID，0=所有人
        /// </summary>
        public static string RecUsers_Id
        {
            get
            {
                return "RecUsers_Id";
            }
        }
        /// <summary>
        /// 接收者账号
        /// </summary>
        public static string RecUsers_Name
        {
            get
            {
                return "RecUsers_Name";
            }
        }
        /// <summary>
        /// 接收者邮箱
        /// </summary>
        public static string RecUsers_Email
        {
            get
            {
                return "RecUsers_Email";
            }
        }
        /// <summary>
        /// 接受者编号ID，0=所有人
        /// </summary>
        public static string RecUserLevel_Id
        {
            get
            {
                return "RecUserLevel_Id";
            }
        }
        /// <summary>
        /// 接受者账号
        /// </summary>
        public static string RecUserLevel_Name
        {
            get
            {
                return "RecUserLevel_Name";
            }
        }
        /// <summary>
        /// 邮件主题
        /// </summary>
        public static string EmailSubject
        {
            get
            {
                return "EmailSubject";
            }
        }
        /// <summary>
        /// 邮件内容
        /// </summary>
        public static string EmailContent
        {
            get
            {
                return "EmailContent";
            }
        }
        /// <summary>
        /// 站内信发送时间
        /// </summary>
        public static string SendDate
        {
            get
            {
                return "SendDate";
            }
        }
        /// <summary>
        /// 发送状态：0：发送失败；1发送成功
        /// </summary>
        public static string Status
        {
            get
            {
                return "Status";
            }
        }
        /// <summary>
        /// 发送状态名称
        /// </summary>
        public static string StatusName
        {
            get
            {
                return "StatusName";
            }
        }
        /// <summary>
        /// 异常信息
        /// </summary>
        public static string ErrorMsg
        {
            get
            {
                return "ErrorMsg";
            }
        }
        /// <summary>
        /// 模板ID
        /// </summary>
        public static string Template_Id
        {
            get
            {
                return "Template_Id";
            }
        }
        /// <summary>
        /// 模板名称
        /// </summary>
        public static string Template_Name
        {
            get
            {
                return "Template_Name";
            }
        }


    }

    public class WebConfigTable
    {
        /// <summary>
        /// 表名
        /// </summary>
        public static string TableName
        {
            get
            {
                return "WebConfig";
            }
        }
        //新增代码，循环遍历表中的所有字段，创建相应的函数
        /// <summary>
        /// 主键Id
        /// </summary>
        public static string Id
        {
            get
            {
                return "Id";
            }
        }
        /// <summary>
        /// 基本信息--网站名称
        /// </summary>
        public static string WebName
        {
            get
            {
                return "WebName";
            }
        }
        /// <summary>
        /// 基本信息--网站地址
        /// </summary>
        public static string WebDomain
        {
            get
            {
                return "WebDomain";
            }
        }
        /// <summary>
        /// 基本信息--管理员邮箱
        /// </summary>
        public static string WebEmail
        {
            get
            {
                return "WebEmail";
            }
        }
        /// <summary>
        /// 日志--系统登陆日志保留时间，0=无限制，N（数字）= X月
        /// </summary>
        public static string LoginLogReserveTime
        {
            get
            {
                return "LoginLogReserveTime";
            }
        }
        /// <summary>
        /// 日志--系统操作日志保留时间，0=无限制，N（数字）= X月
        /// </summary>
        public static string UseLogReserveTime
        {
            get
            {
                return "UseLogReserveTime";
            }
        }
        /// <summary>
        /// 邮件设置--SMTP服务器
        /// </summary>
        public static string EmailSmtp
        {
            get
            {
                return "EmailSmtp";
            }
        }
        /// <summary>
        /// 邮件设置--登录用户名
        /// </summary>
        public static string EmailUserName
        {
            get
            {
                return "EmailUserName";
            }
        }
        /// <summary>
        /// 邮件设置--登录密码
        /// </summary>
        public static string EmailPassWord
        {
            get
            {
                return "EmailPassWord";
            }
        }
        /// <summary>
        /// 邮件设置--邮件域名
        /// </summary>
        public static string EmailDomain
        {
            get
            {
                return "EmailDomain";
            }
        }


    }

}