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
   /// 实体对象 ModuleGroup(模块分组信息)。
   /// </summary>
   [Serializable()]
   [Table("EAS_MODULEGROUPS","模块分组信息")]
   partial class ModuleGroup: DataEntity<ModuleGroup>
   {
       public ModuleGroup()
       {
       }
       
       protected ModuleGroup(SerializationInfo info, StreamingContext context)
           : base(info, context)
       {
       }
       
       #region O/R映射成员

       /// <summary>
       /// 模块GUID 。
       /// </summary>
       [Column("OBJECTID","模块GUID"),DataSize(36),PrimaryKey]
       [AutoUI(Width=80,Alignment=UIAlignment.Left)]
       public string ObjectID
       {
           get;
           set;
       }

       /// <summary>
       /// 分组ID 。
       /// </summary>
       [Column("GROUPID","分组ID"),DataSize(36),PrimaryKey]
       [AutoUI(Width=80,Alignment=UIAlignment.Left)]
       public string GroupID
       {
           get;
           set;
       }
       
       #endregion
   }
}
