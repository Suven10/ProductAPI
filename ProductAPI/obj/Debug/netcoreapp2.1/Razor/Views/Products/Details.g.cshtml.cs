#pragma checksum "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d80944106dc2946d8f143efb535bb263dafd17e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Details.cshtml", typeof(AspNetCore.Views_Products_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d80944106dc2946d8f143efb535bb263dafd17e", @"/Views/Products/Details.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductAPI.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(201, 47, false);
#line 14 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(248, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(292, 43, false);
#line 17 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(335, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(379, 47, false);
#line 20 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(426, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(470, 43, false);
#line 23 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(513, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(557, 40, false);
#line 26 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(597, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(641, 36, false);
#line 29 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(677, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(721, 44, false);
#line 32 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(765, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(809, 40, false);
#line 35 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(849, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(893, 41, false);
#line 38 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(934, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(978, 37, false);
#line 41 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(1015, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1059, 41, false);
#line 44 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1100, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1144, 37, false);
#line 47 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1181, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1225, 46, false);
#line 50 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProdStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1271, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1315, 42, false);
#line 53 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProdStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1357, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1401, 43, false);
#line 56 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitQty));

#line default
#line hidden
            EndContext();
            BeginContext(1444, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1488, 39, false);
#line 59 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.UnitQty));

#line default
#line hidden
            EndContext();
            BeginContext(1527, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1571, 45, false);
#line 62 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1616, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1660, 41, false);
#line 65 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1701, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1745, 43, false);
#line 68 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Taxable));

#line default
#line hidden
            EndContext();
            BeginContext(1788, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1832, 39, false);
#line 71 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Taxable));

#line default
#line hidden
            EndContext();
            BeginContext(1871, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1915, 46, false);
#line 74 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GuTaxGrpId));

#line default
#line hidden
            EndContext();
            BeginContext(1961, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2005, 42, false);
#line 77 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.GuTaxGrpId));

#line default
#line hidden
            EndContext();
            BeginContext(2047, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2091, 39, false);
#line 80 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sku));

#line default
#line hidden
            EndContext();
            BeginContext(2130, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2174, 35, false);
#line 83 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sku));

#line default
#line hidden
            EndContext();
            BeginContext(2209, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2253, 45, false);
#line 86 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CostPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2298, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2342, 41, false);
#line 89 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.CostPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2383, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2427, 44, false);
#line 92 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MinStock));

#line default
#line hidden
            EndContext();
            BeginContext(2471, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2515, 40, false);
#line 95 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.MinStock));

#line default
#line hidden
            EndContext();
            BeginContext(2555, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2599, 46, false);
#line 98 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(2645, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2689, 42, false);
#line 101 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(2731, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2775, 46, false);
#line 104 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateUser));

#line default
#line hidden
            EndContext();
            BeginContext(2821, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2865, 42, false);
#line 107 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreateUser));

#line default
#line hidden
            EndContext();
            BeginContext(2907, 67, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2974, "\"", 3007, 1);
#line 112 "E:\Personal\Projects\C#\ProductAPI\ProductAPI\Views\Products\Details.cshtml"
WriteAttributeValue("", 2989, Model.GuProductId, 2989, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3008, 65, true);
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductAPI.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591