#pragma checksum "D:\IBL\Upload_ProfilePhoto\Upload_ProfilePhoto\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3b0590dad05522e91f50f241250ed34d19327a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\IBL\Upload_ProfilePhoto\Upload_ProfilePhoto\Views\_ViewImports.cshtml"
using Upload_ProfilePhoto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IBL\Upload_ProfilePhoto\Upload_ProfilePhoto\Views\_ViewImports.cshtml"
using Upload_ProfilePhoto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b0590dad05522e91f50f241250ed34d19327a5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3121bbdba93c290780f1dd34fb07597c8957030", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Upload_ProfilePhoto.Models.Comman>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/toastr.js/toastr.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/toastr.js/toastr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\IBL\Upload_ProfilePhoto\Upload_ProfilePhoto\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_UserLayout.cshtml";
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>

    .imgstyle {
        height: 50px;
        width: 50px;
        margin: 2px 0px 0px;
    }

    .likeclass {
        color: red !important;
    }

    .unlikeclass {
        color: #212529;
    }
</style>
<main>
    <div class=""main-section"">
        <div class=""container"">
            <div class=""main-section-data"">
                <div class=""row"">
                    <div class=""col-lg-3 col-md-4 pd-left-none no-pd"">
                        <div class=""main-left-sidebar no-margin"">
                            <div class=""user-data full-width"">
                                <div class=""user-profile"" id=""userprofile"">
                                </div>
                                <ul class=""user-fw-status"">
                                    <li>
                                        <h4>Following</h4>
                                        <span>34</span>
                                    </li>
                                    <li>
             ");
            WriteLiteral(@"                           <h4>Followers</h4>
                                        <span>155</span>
                                    </li>
                                    <li>
                                        <a href=""https://localhost:44329/Home/Profile""");
            BeginWriteAttribute("title", " title=\"", 1433, "\"", 1441, 0);
            EndWriteAttribute();
            WriteLiteral(@">View Profile</a>
                                    </li>
                                </ul>
                            </div><!--user-data end-->
                        </div><!--main-left-sidebar end-->
                    </div>
                    <div class=""col-lg-6 col-md-8 no-pd"">
                        <div class=""main-ws-sec"">
                            <div class=""posts-section"" id=""myimages"">

                            </div><!--posty end-->
                            <!--post-bar end-->
                        </div><!--posts-section end-->
                    </div><!--main-ws-sec end-->
                </div>
            </div>
        </div><!-- main-section-data end-->
    </div>
</main>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a3b0590dad05522e91f50f241250ed34d19327a57045", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3b0590dad05522e91f50f241250ed34d19327a58159", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3b0590dad05522e91f50f241250ed34d19327a59198", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        showprofiles();
        GetAllLiker();
        CurrentPrifile();
    });
    function showprofiles() {
        $.ajax({
            type: 'Get',
            url: '/Home/GetAllPicture',
            dataType: 'json',
            success: function (result) {
                $.each(result, function (i, l) {
                    $(""#myimages"").append('<div class=""post-bar""><div class=""post_topbar""><div class=""usy-dt""><img class=""imgstyle"" src=""https://localhost:44329/ProfilePhoto/' + l.currentProfile + '"" alt=""""><div class=""usy-name""><h3>' + l.first_Name + ' ' + l.last_Name + '</h3><span><img src=""https://localhost:44329/temp/images/clock.png"" alt="""">3 min ago</span></div></div></div><img src=""https://localhost:44329/ProfilePhoto/' + l.pictureName + '"" /><div class=""job-status-bar""><ul class=""like-com""><li><a  id=""likeid' + l.picureid + '"" class=""unlikeclass""  onclick=""LikeProce(' + l.picureid + ')""><i class=""fas fa-heart""></i> Like</a><img src=""ht");
            WriteLiteral(@"tps://localhost:44329/temp/images/liked-img.png"" alt=""""><span id=""' + l.picureid + '""></span></li><li  onclick=""MessageBox('+l.picureid+')""><a class=""com"" id=""MessageBox""><i class=""fas fa-comment-alt""></i> Comment 15</a></li></ul></div><div id=""commentsection'+l.picureid+'"" style=""display: none;"" class=""comment-section""><hr style=""border-top: 3px solid #e5e5e5 !important;""><div class=""comment-sec""><ul><li><div class=""comment-list""><div class=""bg-img""><img src=""https://localhost:44329/temp/images/resources/bg-img3.png"" alt=""""></div><div class=""comment""><h3>John Doe</h3><span><img src=""https://localhost:44329/temp/images/clock.png"" alt=""""> 3 min ago</span><p>Very Nice Pic.</p><a href=""#"" title=""""><i class=""fa fa-reply-all""></i>Reply</a></div></div></li></ul></div><div class=""post-comment""><div class=""cm_img""><img src=""https://localhost:44329/temp/images/resources/bg-img4.png"" alt=""""></div><div class=""comment_box""><form><input type=""hidden"" id=""txtpictureid'+l.picureid+'"" value=""'+l.picureid+'"" /><input type=""te");
            WriteLiteral(@"xt"" id=""txtComment'+l.picureid+'"" placeholder=""Post a comment""  style=""width: 320px;""><button type=""button"" onclick=""SendComment('+l.picureid+')"">Send</button></form></div></div></div>')
                })

            }
        });
    }
    function CurrentPrifile() {
        $.ajax({
            type: 'Get',
            url: '/Home/LoggedUserProfile',
            dataType: 'json',
            success: function (result) {
                $(""#userprofile"").append('<div class=""username-dt""><div class=""usr-pic""><img style=""height:110px; width:110px;"" src=""https://localhost:44329/ProfilePhoto/' + result.currentProfile + '"" alt=""""></div></div><div class=""user-specs""><h3>' + result.first_Name + '' + result.last_Name + '</h3><span>' + result.email + '</span></div>')

            }
        });
    }
    function LikeProce(id) {
        var likestf;
        $('#likeid' + id).toggleClass('likeclass unlikeclass');
        var yourClass = $('#likeid' + id).prop(""class"");
        if (yourClass == ""l");
            WriteLiteral(@"ikeclass"") {
            likestf = true;
        }
        else if (yourClass == ""unlikeclass"") {
            likestf = false;
        }
        $.ajax({
            async: true,
            type: ""POST"",
            url: '/Home/Like',
            data: {
                pictureid: id,
                like: likestf
            },
            success: function (result) {
                GetAllLiker();
                if (result != 0) {
                    // Notification(result);
                }

            },
            error: function () {
            }
        });

    }
    function GetAllLiker() {
        $.ajax({
            type: 'Get',
            url: '/Home/GetAllLIker',
            dataType: 'json',
            success: function (result) {
                $.each(result, function (i, l) {
                    $('#' + l.pictureId).text(l.totalLIkes);
                    if (l.currUserLike) {
                        var yourClass = $('#likeid' + l.pictureId).prop(""");
            WriteLiteral(@"class"");
                        $('#likeid' + l.pictureId).removeClass(yourClass).addClass('likeclass');
                    }
                })

            }
        });
    }
    //function Notification(id) {
    //    $.ajax({
    //        async: true,
    //        type: ""POST"",
    //        url: '/Home/Notification',
    //        data: {
    //            pictureid: id,
    //        },
    //        success: function (result) {

    //        },
    //        error: function () {
    //        }
    //    });
    //}

   
    function MessageBox(id) {
        $(""#commentsection""+id).toggle();
    }
    function SendComment(id) {
        var Comment = $('#txtComment'+id).val(); 
        var Pictureid = $('#txtpictureid'+id).val();
         $.ajax({
            async: true,
            type: ""POST"",
            url: '/Home/SendComment',
            data: {
                comments: Comment,
                pictureid: Pictureid
            },
            success");
            WriteLiteral(": function (result) {\r\n                GetAllLiker();\r\n                if (result != 0) {\r\n                    // Notification(result);\r\n                }\r\n\r\n            },\r\n            error: function () {\r\n            }\r\n        });\r\n    }\r\n</script>\r\n");
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Upload_ProfilePhoto.Models.Comman> Html { get; private set; }
    }
}
#pragma warning restore 1591