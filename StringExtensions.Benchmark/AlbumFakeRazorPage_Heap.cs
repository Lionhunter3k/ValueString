using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions.Benchmark
{
    public class AlbumFakeRazorPage_Heap : FakeRazorPage<List<Album>>
    {
        private readonly bool shouldAwait;

        public AlbumFakeRazorPage_Heap(List<Album> model, bool shouldAwait) : base(model)
        {
            this.shouldAwait = shouldAwait;
        }

        protected override async Task OnExecuteAsync()
        {
            var currentTime = DateTime.Now.Millisecond;
            var indexOfId = currentTime % Model.Count;
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n" + Model[indexOfId].Id);
            WriteLiteral("\r\n    <title>" + Model[indexOfId].Id);

            WriteLiteral("</title>\r\n    " + Model[indexOfId].Id);

            WriteLiteral(Url.Content("~/Content/Site.css"));

            WriteLiteral("\r\n    <script" + Model[indexOfId].Id);

            WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script" + Model[indexOfId].Id);

            WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script" + Model[indexOfId].Id);

            WriteLiteral(" type=\"text/javascript\"></script>\r\n    " + Model[indexOfId].Id);

            WriteLiteral("\r\n" + Model[indexOfId].Id);
            WriteLiteral("\r\n" + Model[indexOfId].Id);
            WriteLiteral("\r\n    <div id=\"header\">\r\n        <h1><a href=\"/\">ASP.NET MVC MUSIC STORE</a></h1>\r\n        <ul id=\"navlist\">\r\n            <li class=\"first\"><a" + Model[indexOfId].Id);
            WriteLiteral(" id=\"current\">Home</a></li>\r\n            <li><a" + Model[indexOfId].Id);

            WriteLiteral(">Store</a></li>\r\n            <li>" + Model[indexOfId].Id);

            WriteLiteral("</li>\r\n            <li><a" + Model[indexOfId].Id);

            WriteLiteral(">Admin</a></li>\r\n        </ul>\r\n    </div>\r\n\r\n    " + Model[indexOfId].Id);

            WriteLiteral("\r\n\r\n    <div id=\"main\">\r\n        " + Model[indexOfId].Id);
            WriteLiteral("<div id=\"promotion\">\r\n</div>\r\n\r\n<h3><em>Fresh</em> off the grill</h3>\r\n\r\n<ul id=\"album-list\">\r\n" + Model[indexOfId].Id);
            if (shouldAwait)
                await DoSomethingAsync();
            foreach (var album in Model)
            {
                WriteLiteral("        <li><a" + album.Id);
                WriteLiteral("href=\"" + album.Id);
                WriteLiteral(Url.Action("Details", "Store",
                                new { id = album.Id }));
                WriteLiteral("\"" + album.Id);
                WriteLiteral(">\r\n\r\n            <img" + album.Id);
                WriteLiteral(" alt=\"" + album.Id);
                WriteLiteral(album.Title);
                WriteLiteral("\"" + album.Id);
                WriteLiteral(" src=\"" + album.Id);
                WriteLiteral(album.AlbumArtUrl);
                WriteLiteral("\"" + album.Id);
                WriteLiteral(" />\r\n            <span>" + album.Id);
                WriteLiteral(album.Title);
                WriteLiteral("</span> </a>\r\n        </li>\r\n" + album.Id);
            }

            WriteLiteral("</ul>" + Model[indexOfId].Id);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div id=\"footer\">\r\n        built with <a href=\"http://asp.net/mvc\">ASP.NET MVC Core</a>\r\n    </div>\r\n" + Model[indexOfId].Id);


            WriteLiteral("\r\n</html>" + Model[indexOfId].Id);
        }
    }
}
