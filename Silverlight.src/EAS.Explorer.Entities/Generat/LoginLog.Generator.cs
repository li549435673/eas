﻿#region AgileEAS.NET-generated
//------------------------------------------------------------------------------
//     AgileEAS.NET应用开发平台，是基于敏捷并行开发思想以及.NET构件技术而开发的一个应用系统快速开发平台，用于帮助中小软件企业
//建立一条适合快速变化的开发团队，以达到节省开发成本、缩短开发时间，快速适应市场变化的目的。
//     AgileEAS.NET应用开发平台包含基础类库、资源管理平台、运行容器、开发辅助工具等四大部分，资源管理平台为敏捷并行开发提供了
//设计、实现、测试等开发过程的并行，应用系统的各个业务功能子系统，在系统体系结构设计的过程中被设计成各个原子功能模块，各个子
//功能模块按照业务功能组织成单独的程序集文件，各子系统开发完成后，由AgileEAS.NET资源管理平台进行统一的集成部署。
//
//     AgileEAS.NET应用开发平台是一套免费的快速开发工具，可以不受限制的用于各种商业开发之中，开发人员可以参考官方网站和博客园
//等专业网站获取公开的技术资料，也可以向AgileEAS.NET官方团队请求技术支持。
//
// 官方网站：http://www.smarteas.net
// 团队网站：http://www.agilelab.cn
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由AgileEAS.NET数据模型设计工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
#endregion

using System;
using System.Data;
using EAS.Data;
using EAS.Data.Access;
using EAS.Data.ORM;
using System.Runtime.Serialization;

namespace EAS.Explorer.Entities
{
   /// <summary>
   /// 实体对象 LoginLog(登录日志记录)。
   /// </summary>
   [Serializable()]
   [Table("EAS_LOGINLOGS","登录日志记录")]
   partial class LoginLog: DataEntity<LoginLog>
   {
       public LoginLog()
       {
       }
       
       protected LoginLog(SerializationInfo info, StreamingContext context)
           : base(info, context)
       {
       }
       
       #region O/R映射成员

       /// <summary>
       /// 记录ID 。
       /// </summary>
       [Column("ID","记录ID"),DataSize(10,36),PrimaryKey]
       [AutoUI(Width=180,Alignment=UIAlignment.Left,Index=8)]
       public string ID
       {
           get;
           set;
       }

       /// <summary>
       /// 登录ID 。
       /// </summary>
       [Column("LOGINID","登录ID"),DataSize(64)]
       [AutoUI(Width=100,Alignment=UIAlignment.Left)]
       public string LoginID
       {
           get;
           set;
       }

       /// <summary>
       /// 事件 。
       /// </summary>
       [Column("EVENT","事件"),DataSize(128)]
       [AutoUI(Width=120,Alignment=UIAlignment.Right)]
       public string Event
       {
           get;
           set;
       }

       /// <summary>
       /// 时间 。
       /// </summary>
       [Column("EVENTTIME","时间"),DataSize(23,3)]
       [AutoUI(Width=130,Alignment=UIAlignment.Center,Format="yyyy-MM-dd HH:mm:ss")]
       public DateTime EventTime
       {
           get;
           set;
       }

       /// <summary>
       /// 主机 。
       /// </summary>
       [Column("HOSTNAME","主机"),DataSize(64)]
       [AutoUI(Width=100,Alignment=UIAlignment.Left)]
       public string HostName
       {
           get;
           set;
       }

       /// <summary>
       /// IP地址 。
       /// </summary>
       [Column("IPADDRESS","IP地址"),DataSize(64)]
       [AutoUI(Width=100,Alignment=UIAlignment.Left)]
       public string IpAddress
       {
           get;
           set;
       }
       
       #endregion
   }
}
