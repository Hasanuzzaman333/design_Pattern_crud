#pragma checksum "D:\Interview-Practice\Extra\in\SampleWeb\SampleWeb\Areas\Student\Views\StudentOperation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56c89057e2d219f020e57c4b86bb77a2d3136ad9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Student_Views_StudentOperation_Index), @"mvc.1.0.view", @"/Areas/Student/Views/StudentOperation/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Student/Views/StudentOperation/Index.cshtml", typeof(AspNetCore.Areas_Student_Views_StudentOperation_Index))]
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
#line 1 "D:\Interview-Practice\Extra\in\SampleWeb\SampleWeb\Areas\Student\Views\_ViewImports.cshtml"
using SampleWeb;

#line default
#line hidden
#line 2 "D:\Interview-Practice\Extra\in\SampleWeb\SampleWeb\Areas\Student\Views\_ViewImports.cshtml"
using SampleWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56c89057e2d219f020e57c4b86bb77a2d3136ad9", @"/Areas/Student/Views/StudentOperation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9584a6a2788b7f73fccaf7c2a1236b7d4f478dc", @"/Areas/Student/Views/_ViewImports.cshtml")]
    public class Areas_Student_Views_StudentOperation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Student/StudentOperation/DeleteStudent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Interview-Practice\Extra\in\SampleWeb\SampleWeb\Areas\Student\Views\StudentOperation\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_CustomLayout.cshtml";

#line default
#line hidden
            BeginContext(96, 2114, true);
            WriteLiteral(@"
<div id=""content-wrapper"">

    <div class=""container-fluid"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a href=""#"">Student</a>
            </li>
            <li class=""breadcrumb-item active"">List</li>
        </ol>        
            <div class=""card mb-3"">
                <div class=""card-header"">
                    <i class=""fas fa-table""></i>
                    Student List
                </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table table-bordered"" id=""studentDataTable"" width=""100%"" cellspacing=""0"">
                            <thead>
                                <tr>
                                    <th>Id</th>
                                    <th>Name</th>
                                    <th>Age</th>
                                    <th>Action</th>
                                </tr>
                            </");
            WriteLiteral(@"thead>                           
                        </table>
                    </div>
                </div>
                <div class=""card-footer small text-muted"">Updated yesterday at 11:59 PM</div>
            </div>
        

            <div class=""card mb-3"">
                <div class=""card-header"">
                    <i class=""fas fa-table""></i>
                    Student List
                </div>
                <div class=""card-body"">
                    <h2>No Student Found!</h2>
                </div>
                <div class=""card-footer small text-muted"">Updated yesterday at 11:59 PM</div>
            </div>       

    </div>
    <footer class=""sticky-footer"">
        <div class=""container my-auto"">
            <div class=""copyright text-center my-auto"">
                <span>Copyright © Your Website 2019</span>
            </div>
        </div>
    </footer>


</div>

<div class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" r");
            WriteLiteral("ole=\"document\">\r\n        <div class=\"modal-content\">\r\n            ");
            EndContext();
            BeginContext(2210, 882, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56c89057e2d219f020e57c4b86bb77a2d3136ad97663", async() => {
                BeginContext(2279, 806, true);
                WriteLiteral(@"
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Delete Item</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <p>Do you want to delete this record?</p>
                    <input type=""hidden"" id=""modalId"" name=""id"" value="""" />
                </div>
                <div class=""modal-footer"">
                    <button type=""submit"" class=""btn btn-danger"">Yes, Delete!</button>
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3092, 44, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(3136, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56c89057e2d219f020e57c4b86bb77a2d3136ad910290", async() => {
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
            EndContext();
            BeginContext(3185, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3187, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56c89057e2d219f020e57c4b86bb77a2d3136ad911470", async() => {
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
            EndContext();
            BeginContext(3232, 2270, true);
            WriteLiteral(@"

<script>

    $(function () {

        $('#studentDataTable').DataTable({

            ""processing"": true,
            ""serverSide"": true,
            //""ajax"": ""/Student/StudentOperation/GetStudent"",

            ajax: {
                    ""url"": ""/Student/StudentOperation/GetStudent"",
                    ""type"": ""GET"",
                    ""datatype"": ""json""
                },
          
            columns: [

                { ""data.data"": ""Id"", ""autoWidth"": false, ""searchable"": true },
                { ""data.data"": ""StudentName"", ""autoWidth"": false, ""searchable"": true },
                { ""data.data"": ""Age"", ""autoWidth"": false, ""searchable"": true },

                //{ ""data.data"": null, ""<a id='btnEdit' class='btn btn-success btn-dt'><i class='fa fa-edit'></i></a><a href='#' id='btnDelete' class='btn btn-danger btn-dt'><i class='fa fa-trash-o'></i></a>""  ""searchable"": true }


                {
                 render: function (data, type, row) {
                       ");
            WriteLiteral(@" 
                        return ""<a id='btnEdit' class='btn btn-success btn-dt'><i class='fa fa-edit'></i></a><a id='btnDelete' class='btn btn-danger btn-dt'><i class='fa fa-trash'></i></a>""
                    },
                   
                }
              ],


    //        ""columndefs"": [
				//	 {
    //             render: function (data, type, row) {
                        
    //                    return ""<a class='btn btn-success btn-dt' href='/student/studentoperation/editstudent/"" + data + ""'><i class='fa fa-edit'></i></a><a href='#' id='btndelete' class='btn btn-danger btn-dt'><i class='fa fa-trash-o'></i></a>""; 
    //                },
    //                targets: 3
    //            }
				//]

        });

         $('#studentDataTable tbody').on('click', '#btnEdit', function () {
        debugger;
        var currentRow = $(this).closest(""tr"");
        var studentId = currentRow.find('td:eq(0)').text();
        //alert(studentId);
        var data = $('#stu");
            WriteLiteral("dentDataTable\').DataTable().row(currentRow).data();\r\n        console.log(data);\r\n\r\n             EditStudent(studentId);\r\n\r\n        });\r\n\r\n        function EditStudent(id) {\r\n            debugger;\r\n             var link = \'");
            EndContext();
            BeginContext(5503, 69, false);
#line 151 "D:\Interview-Practice\Extra\in\SampleWeb\SampleWeb\Areas\Student\Views\StudentOperation\Index.cshtml"
                    Write(Url.Action("EditStudent", "StudentOperation", new { id = "replace" }));

#line default
#line hidden
            EndContext();
            BeginContext(5572, 686, true);
            WriteLiteral(@"';
             link = link.replace(""replace"", id);
             window.location.href = link;          

        }

        $('#studentDataTable tbody').on('click', '#btnDelete', function () {
        debugger;
        var currentRow = $(this).closest(""tr"");
        var studentId = currentRow.find('td:eq(0)').text();
        //alert(studentId);
        var data = $('#studentDataTable').DataTable().row(currentRow).data();
        console.log(data);

        DeleteStudent(studentId);

        });

        function DeleteStudent(id) {
            debugger;
            $(""#modalId"").val(id);
            $("".modal"").show();
        }

    });

</script>

");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591