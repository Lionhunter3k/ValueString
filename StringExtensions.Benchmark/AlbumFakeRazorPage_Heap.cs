using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions.Benchmark
{
    public class AlbumFakeRazorPage_Heap : FakeRazorPage<List<Album>>
    {
        public AlbumFakeRazorPage_Heap(List<Album> model) : base(model)
        {
        }

        protected override async Task OnExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            WriteLiteral("\r\n    <title>");

            WriteLiteral("</title>\r\n    ");

            WriteLiteral(Url.Content("~/Content/Site.css"));

            WriteLiteral("\r\n    <script");

            WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");

            WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");

            WriteLiteral(" type=\"text/javascript\"></script>\r\n    ");

            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <div id=\"header\">\r\n        <h1><a href=\"/\">ASP.NET MVC MUSIC STORE</a></h1>\r\n        <ul id=\"navlist\">\r\n            <li class=\"first\"><a");
            WriteLiteral(" id=\"current\">Home</a></li>\r\n            <li><a");

            WriteLiteral(">Store</a></li>\r\n            <li>");

            WriteLiteral("</li>\r\n            <li><a");

            WriteLiteral(">Admin</a></li>\r\n        </ul>\r\n    </div>\r\n\r\n    ");

            WriteLiteral("\r\n\r\n    <div id=\"main\">\r\n        ");
            WriteLiteral("<div id=\"promotion\">\r\n</div>\r\n\r\n<h3><em>Fresh</em> off the grill</h3>\r\n\r\n<ul id=\"album-list\">\r\n");
            foreach (var album in Model)
            {
                WriteLiteral("        <li><a");
                WriteLiteral("href=\"");
                WriteLiteral(Url.Action("Details", "Store",
                                new { id = album.Id }));

                WriteLiteral("\"");
                WriteLiteral(">\r\n\r\n            <img");
                WriteLiteral(" alt=\"");
                WriteLiteral(album.Title);
                WriteLiteral("\"");
                WriteLiteral(" src=\"");
                WriteLiteral(album.AlbumArtUrl);
                WriteLiteral("\"");
                WriteLiteral(" />\r\n            <span>");
                WriteLiteral(album.Title);
                WriteLiteral("</span> </a>\r\n        </li>\r\n");
            }

            WriteLiteral("</ul>");
            WriteLiteral("\r\n    </div>\r\n\r\n    <div id=\"footer\">\r\n        built with <a href=\"http://asp.net/mvc\">ASP.NET MVC Core</a>\r\n    </div>\r\n");


            WriteLiteral("\r\n</html>");
        }
    }
}
