﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using CubeDemo;
    using NewLife;
    
    #line 1 "..\..\Areas\School\Views\Student\_List_Toolbar_Batch.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/School/Views/Student/_List_Toolbar_Batch.cshtml")]
    public partial class _Areas_School_Views_Student__List_Toolbar_Batch_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_School_Views_Student__List_Toolbar_Batch_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\School\Views\Student\_List_Toolbar_Batch.cshtml"
  
    var user = ViewBag.User as IUser ?? User.Identity as IUser;
    var fact = ViewBag.Factory as IEntityFactory;
    var set = ViewBag.PageSetting as PageSetting;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Areas\School\Views\Student\_List_Toolbar_Batch.cshtml"
Write(Html.ActionLink("生成模拟数据", "MakeData", null, new { @class = "btn btn-purple btn-sm" }));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
