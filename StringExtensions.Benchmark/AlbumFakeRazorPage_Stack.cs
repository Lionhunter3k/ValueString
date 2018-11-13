using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions.Benchmark
{
    public class AlbumFakeRazorPage_Stack : FakeRazorPage<List<Album>>
    {
        static readonly char[] _1 = "<!DOCTYPE html>\r\n<html>\r\n".ToCharArray();

        static readonly char[] _2 = "\r\n    <title>".ToCharArray();

        static readonly char[] _3 = "</title>\r\n    ".ToCharArray();

        static readonly char[] _4 = "\r\n    <script".ToCharArray();

        static readonly char[] _5 = " type=\"text/javascript\"></script>\r\n    <script".ToCharArray();

        static readonly char[] _6 = " type=\"text/javascript\"></script>\r\n    ".ToCharArray();

        static readonly char[] _7 = "\r\n".ToCharArray();

        static readonly char[] _8 = "\r\n    <div id=\"header\">\r\n        <h1><a href=\"/\">ASP.NET MVC MUSIC STORE</a></h1>\r\n        <ul id=\"navlist\">\r\n            <li class=\"first\"><a".ToCharArray();

        static readonly char[] _9 = " id=\"current\">Home</a></li>\r\n            <li><a".ToCharArray();

        static readonly char[] _10 = ">Store</a></li>\r\n            <li>".ToCharArray();

        static readonly char[] _11 = "</li>\r\n            <li><a".ToCharArray();

        static readonly char[] _12 = ">Admin</a></li>\r\n        </ul>\r\n    </div>\r\n\r\n    ".ToCharArray();

        static readonly char[] _13 = "\r\n\r\n    <div id=\"main\">\r\n        ".ToCharArray();

        static readonly char[] _14 = "<div id=\"promotion\">\r\n</div>\r\n\r\n<h3><em>Fresh</em> off the grill</h3>\r\n\r\n<ul id=\"album-list\">\r\n".ToCharArray();

        static readonly char[] _15 = "        <li><a".ToCharArray();

        static readonly char[] _16 = "href=\"".ToCharArray();

        static readonly char[] _17 = "\"".ToCharArray();

        static readonly char[] _18 = ">\r\n\r\n            <img".ToCharArray();

        static readonly char[] _19 = " alt=\"".ToCharArray();

        static readonly char[] _20 = " src=\"".ToCharArray();

        static readonly char[] _21 = " />\r\n            <span>".ToCharArray();

        static readonly char[] _22 = "</span> </a>\r\n        </li>\r\n".ToCharArray();

        static readonly char[] _23 = "</ul>".ToCharArray();

        static readonly char[] _24 = "\r\n    </div>\r\n\r\n    <div id=\"footer\">\r\n        built with <a href=\"http://asp.net/mvc\">ASP.NET MVC Core</a>\r\n    </div>\r\n".ToCharArray();

        static readonly char[] _25 = "\r\n</html>".ToCharArray();

        public AlbumFakeRazorPage_Stack(List<Album> model) : base(model)
        {
        }

        protected override async Task OnExecuteAsync()
        {
            var string512 = new ValueString512();
            foreach(var @char in _1)
            {
                string512.Add(@char);
            }
            WriteLiteral(string512.Reference);
            string512 = new ValueString512();
            foreach (var @char in _2)
            {
                string512.Add(@char);
            }
            WriteLiteral(string512.Reference);
            string512 = new ValueString512();
            foreach (var @char in _3)
            {
                string512.Add(@char);
            }
            WriteLiteral(string512.Reference);

            WriteLiteral(Url.Content("~/Content/Site.css"));
            string512 = new ValueString512();
            foreach (var @char in _4)
            {
                string512.Add(@char);
            }
            WriteLiteral(string512.Reference);
            var string1024 = new ValueString<ValueString512, ValueString512>();
            foreach (var @char in _5)
            {
                string1024.Add(@char);
            }
            WriteLiteral(string1024.Reference);
            string1024 = new ValueString<ValueString512, ValueString512>();
            foreach (var @char in _6)
            {
                string1024.Add(@char);
            }
            WriteLiteral(string1024.Reference);
            string512 = new ValueString512();
            foreach (var @char in _7)
            {
                string512.Add(@char);
            }
            WriteLiteral(string512.Reference);
            var string2560 = new ValueString<ValueString<ValueString<ValueString512, ValueString512>, ValueString<ValueString512, ValueString512>>, ValueString512>();
            foreach (var @char in _8)
            {
                string2560.Add(@char);
            }
            WriteLiteral(string2560.Reference);
            string1024 = new ValueString<ValueString512, ValueString512>();
            foreach (var @char in _9)
            {
                string1024.Add(@char);
            }
            WriteLiteral(string1024.Reference);
            string1024 = new ValueString<ValueString512, ValueString512>();
            foreach (var @char in _10)
            {
                string1024.Add(@char);
            }
            WriteLiteral(string1024.Reference);
            string512 = new ValueString512();
            foreach (var @char in _11)
            {
                string512.Add(@char);
            }
            WriteLiteral(string512.Reference);
            string1024 = new ValueString<ValueString512, ValueString512>();
            foreach (var @char in _12)
            {
                string1024.Add(@char);
            }
            WriteLiteral(string1024.Reference);
            string1024 = new ValueString<ValueString512, ValueString512>();
            foreach (var @char in _12)
            {
                string1024.Add(@char);
            }
            WriteLiteral(string1024.Reference);
            string2560 = new ValueString<ValueString<ValueString<ValueString512, ValueString512>, ValueString<ValueString512, ValueString512>>, ValueString512>();
            foreach (var @char in _13)
            {
                string2560.Add(@char);
            }
            WriteLiteral(string2560.Reference);
            string2560 = new ValueString<ValueString<ValueString<ValueString512, ValueString512>, ValueString<ValueString512, ValueString512>>, ValueString512>();
            foreach (var @char in _14)
            {
                string2560.Add(@char);
            }
            WriteLiteral(string2560.Reference);
            foreach (var album in Model)
            {
                string512 = new ValueString512();
                foreach (var @char in _15)
                {
                    string512.Add(@char);
                }
                WriteLiteral(string512.Reference);
                string512 = new ValueString512();
                foreach (var @char in _16)
                {
                    string512.Add(@char);
                }
                WriteLiteral(string512.Reference);
                WriteLiteral(Url.Action("Details", "Store",
                                new { id = album.Id }));
                var string32 = new ValueString32();
                foreach (var @char in _17)
                {
                    string32.Add(@char);
                }
                WriteLiteral(string32.Reference);
                string512 = new ValueString512();
                foreach (var @char in _18)
                {
                    string512.Add(@char);
                }
                WriteLiteral(string512.Reference);
                string512 = new ValueString512();
                foreach (var @char in _19)
                {
                    string512.Add(@char);
                }
                WriteLiteral(string512.Reference);
                WriteLiteral(album.Title);
                WriteLiteral(string32.Reference);
                string512 = new ValueString512();
                foreach (var @char in _20)
                {
                    string512.Add(@char);
                }
                WriteLiteral(string512.Reference);
                WriteLiteral(album.AlbumArtUrl);
                WriteLiteral(string32.Reference);
                string512 = new ValueString512();
                foreach (var @char in _21)
                {
                    string512.Add(@char);
                }
                WriteLiteral(string512.Reference);
                WriteLiteral(album.Title);
                string1024 = new ValueString<ValueString512, ValueString512>();
                foreach (var @char in _22)
                {
                    string1024.Add(@char);
                }
                WriteLiteral(string1024.Reference);
            }
            string512 = new ValueString512();
            foreach (var @char in _22)
            {
                string512.Add(@char);
            }
            WriteLiteral(string512.Reference);
            string2560 = new ValueString<ValueString<ValueString<ValueString512, ValueString512>, ValueString<ValueString512, ValueString512>>, ValueString512>();
            foreach (var @char in _23)
            {
                string2560.Add(@char);
            }
            WriteLiteral(string2560.Reference);
            string2560 = new ValueString<ValueString<ValueString<ValueString512, ValueString512>, ValueString<ValueString512, ValueString512>>, ValueString512>();
            foreach (var @char in _24)
            {
                string2560.Add(@char);
            }
            WriteLiteral(string2560.Reference);
        }
    }
}
