using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions.Benchmark
{
    public class StackAlbumFakeRazorPage_Stack : FakeRazorPage<List<StackAlbum>>
    {
        private readonly bool shouldAwait;

        public StackAlbumFakeRazorPage_Stack(List<StackAlbum> model, bool shouldAwait) : base(model)
        {
            this.shouldAwait = shouldAwait;
        }

        protected override async Task OnExecuteAsync()
        {
            var string512 = new ValueString512 { '<', '!', 'D', 'O', 'C', 'T', 'Y', 'P', 'E', ' ', 'h', 't', 'm', 'l', '>', ' ', '\n', '<', 'h', 't', 'm', 'l', '>', ' ', '\n' };
            WriteLiteral(string512.Reference);
            string512 = new ValueString512 { ' ', '\n', ' ', ' ', ' ', ' ', '<', 't', 'i', 't', 'l', 'e', '>' };
            WriteLiteral(string512.Reference);
            string512 = new ValueString512 { '<', '/', 't', 'i', 't', 'l', 'e', '>', ' ', '\n', ' ', ' ', ' ', ' ' };
            WriteLiteral(string512.Reference);
            WriteLiteral(Url.Content("~/Content/Site.css"));
            string512 = new ValueString512 { ' ', '\n', ' ', ' ', ' ', ' ', '<', 's', 'c', 'r', 'i', 'p', 't' };
            WriteLiteral(string512.Reference);
            var string1024 = new ValueString<ValueString512, ValueString512> { ' ', 't', 'y', 'p', 'e', '=', '"', 't', 'e', 'x', 't', '/', 'j', 'a', 'v', 'a', 's', 'c', 'r', 'i', 'p', 't', '"', '>', '<', '/', 's', 'c', 'r', 'i', 'p', 't', '>', ' ', '\n', ' ', ' ', ' ', ' ', '<', 's', 'c', 'r', 'i', 'p', 't' };
            WriteLiteral(string1024.Reference);
            string1024 = new ValueString<ValueString512, ValueString512> { ' ', 't', 'y', 'p', 'e', '=', '"', 't', 'e', 'x', 't', '/', 'j', 'a', 'v', 'a', 's', 'c', 'r', 'i', 'p', 't', '"', '>', '<', '/', 's', 'c', 'r', 'i', 'p', 't', '>', ' ', '\n', ' ', ' ', ' ', ' ' };
            WriteLiteral(string1024.Reference);
            string512 = new ValueString512 { ' ', '\n' };
            WriteLiteral(string512.Reference);
            var string2560 = new ValueString<ValueString<ValueString<ValueString512, ValueString512>, ValueString<ValueString512, ValueString512>>, ValueString512>()
                {' ','\n',' ',' ',' ',' ','<','d','i','v',' ','i','d','=','"','h','e','a','d','e','r','"','>',' ','\n',' ',' ',' ',' ',' ',' ',' ',' ',
                '<','h','1','>','<','a',' ','h','r','e','f','=','"','/','"','>','A','S','P','.','N','E','T',' ','M','V','C',' ','M','U','S','I','C',' ',
                'S','T','O','R','E','<','/','a','>','<','/','h','1','>',' ','\n',' ',' ',' ',' ',' ',' ',' ',' ','<','u','l',' ','i','d','=','"','n','a','v','l','i','s','t','"','>',' ','\n'
                ,' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','<','l','i',' ','c','l','a','s','s','=','"','f','i','r','s','t','"','>','<','a' };
            WriteLiteral(string2560.Reference);
            string1024 = new ValueString<ValueString512, ValueString512> { ' ', 'i', 'd', '=', '"', 'c', 'u', 'r', 'r', 'e', 'n', 't', '"', '>', 'H', 'o', 'm', 'e', '<', '/', 'a', '>', '<', '/', 'l', 'i', '>', ' ', '\n', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '<', 'l', 'i', '>', '<', 'a' };
            WriteLiteral(string1024.Reference);
            string1024 = new ValueString<ValueString512, ValueString512> { '>', 'S', 't', 'o', 'r', 'e', '<', '/', 'a', '>', '<', '/', 'l', 'i', '>', ' ', '\n', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '<', 'l', 'i', '>' };
            WriteLiteral(string1024.Reference);
            string512 = new ValueString512 { '<', '/', 'l', 'i', '>', ' ', '\n', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '<', 'l', 'i', '>', '<', 'a' };
            WriteLiteral(string512.Reference);
            string1024 = new ValueString<ValueString512, ValueString512>{'>','A','d','m','i','n','<','/','a','>','<','/','l','i','>',' ','\n',
                ' ',' ',' ',' ',' ',' ',' ',' ','<','/','u','l','>',' ','\n',' ',' ',' ',' ','<','/','d','i','v','>',' ','\n',' ','\n',' ',' ',' ',' ' };
            WriteLiteral(string1024.Reference);
            string2560 = new ValueString<ValueString<ValueString<ValueString512, ValueString512>, ValueString<ValueString512, ValueString512>>, ValueString512>()
                {' ','\n',' ','\n',' ',' ',' ',' ','<','d','i','v',' ','i','d','=','"','m','a','i','n','"','>',' ','\n',' ',' ',' ',' ',' ',' ',' ',' ' };
            WriteLiteral(string2560.Reference);
            string2560 = new ValueString<ValueString<ValueString<ValueString512, ValueString512>, ValueString<ValueString512, ValueString512>>, ValueString512>()
                {'<','d','i','v',' ','i','d','=','"','p','r','o','m','o','t','i','o','n','"','>',' ','\n','<','/','d','i','v','>',
                ' ','\n',' ','\n','<','h','3','>','<','e','m','>','F','r','e','s','h','<','/','e','m','>',' ','o','f','f',' ','t','h'
                ,'e',' ','g','r','i','l','l','<','/','h','3','>',' ','\n',' ','\n','<','u','l',' ','i','d','=','"','a','l','b','u','m','-','l','i','s','t','"','>',' ','\n' };
            WriteLiteral(string2560.Reference);
            if (shouldAwait)
                await DoSomethingAsync();
            foreach (var album in Model)
            {
                string512 = new ValueString512 { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '<', 'l', 'i', '>', '<', 'a' };
                WriteLiteral(string512.Reference);
                string512 = new ValueString512 { 'h', 'r', 'e', 'f', '=', '"' };
                WriteLiteral(string512.Reference);
                WriteLiteral(Url.Action("Details", "Store",
                                new { id = album.Id }));
                var string32 = new ValueString32 { '"' };
                WriteLiteral(string32.Reference);
                string512 = new ValueString512 { '>', ' ', '\n', ' ', '\n', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '<', 'i', 'm', 'g' };
                WriteLiteral(string512.Reference);
                string512 = new ValueString512 { ' ', 'a', 'l', 't', '=', '"' };

                WriteLiteral(string512.Reference);
                WriteLiteral(album.Title);
                WriteLiteral(string32.Reference);
                string512 = new ValueString512 { ' ', 's', 'r', 'c', '=', '"' };
                WriteLiteral(string512.Reference);
                WriteLiteral(album.AlbumArtUrl);
                WriteLiteral(string32.Reference);
                string512 = new ValueString512 { ' ', '/', '>', ' ', '\n', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '<', 's', 'p', 'a', 'n', '>' };
                WriteLiteral(string512.Reference);
                WriteLiteral(album.Title);
                string1024 = new ValueString<ValueString512, ValueString512> { '<', '/', 's', 'p', 'a', 'n', '>', ' ', '<', '/', 'a', '>', ' ', '\n', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '<', '/', 'l', 'i', '>', ' ', '\n' };
                WriteLiteral(string1024.Reference);
            }
            string512 = new ValueString512 { '<', '/', 'u', 'l', '>' };
            WriteLiteral(string512.Reference);
            string2560 = new ValueString<ValueString<ValueString<ValueString512, ValueString512>, ValueString<ValueString512, ValueString512>>, ValueString512>()
                {' ','\n',' ',' ',' ',' ','<','/','d','i','v','>',' ','\n',' ','\n',' ',' ',' ',' ','<','d','i','v',' ','i',
                'd','=','"','f','o','o','t','e','r','"','>',' ','\n',' ',' ',' ',' ',' ',' ',' ',' ','b','u','i','l','t',
                ' ','w','i','t','h',' ','<','a',' ','h','r','e','f','=','"','h','t','t','p',':','/','/','a','s','p','.',
                'n','e','t','/','m','v','c','"','>','A','S','P','.','N','E','T',' ','M','V','C',' ','C','o','r','e','<',
                '/','a','>',' ','\n',' ',' ',' ',' ','<','/','d','i','v','>',' ','\n' };
            WriteLiteral(string2560.Reference);
        }
    }

    public class AlbumFakeRazorPage_Stack : FakeRazorPage<List<Album>>
    {
        private readonly bool shouldAwait;

        public AlbumFakeRazorPage_Stack(List<Album> model, bool shouldAwait) : base(model)
        {
            this.shouldAwait = shouldAwait;
        }

        protected override async Task OnExecuteAsync()
        {
            var string512 = new ValueString512 { '<', '!', 'D', 'O', 'C', 'T', 'Y', 'P', 'E', ' ', 'h', 't', 'm', 'l', '>', ' ', '\n', '<', 'h', 't', 'm', 'l', '>', ' ', '\n' };
            WriteLiteral(string512.Reference);
            string512 = new ValueString512 {' ', '\n', ' ',' ',' ',' ','<','t','i','t','l','e','>' };
            WriteLiteral(string512.Reference);
            string512 = new ValueString512{'<','/','t','i','t','l','e','>',' ', '\n', ' ',' ',' ',' ' };
            WriteLiteral(string512.Reference);
            WriteLiteral(Url.Content("~/Content/Site.css"));
            string512 = new ValueString512{' ', '\n', ' ',' ',' ',' ','<','s','c','r','i','p','t' };
            WriteLiteral(string512.Reference);
            var string1024 = new ValueString<ValueString512, ValueString512> { ' ', 't', 'y', 'p', 'e', '=', '"', 't', 'e', 'x', 't', '/', 'j', 'a', 'v', 'a', 's', 'c', 'r', 'i', 'p', 't', '"', '>', '<', '/', 's', 'c', 'r', 'i', 'p', 't', '>', ' ', '\n', ' ', ' ', ' ', ' ', '<', 's', 'c', 'r', 'i', 'p', 't' };
            WriteLiteral(string1024.Reference);
            string1024 = new ValueString<ValueString512, ValueString512>{' ','t','y','p','e','=','"','t','e','x','t','/','j','a','v','a','s','c','r','i','p','t','"','>','<','/','s','c','r','i','p','t','>',' ', '\n', ' ',' ',' ',' ' };
            WriteLiteral(string1024.Reference);
            string512 = new ValueString512{' ', '\n' };
            WriteLiteral(string512.Reference);
            var string2560 = new ValueString<ValueString<ValueString<ValueString512, ValueString512>, ValueString<ValueString512, ValueString512>>, ValueString512>()
                {' ','\n',' ',' ',' ',' ','<','d','i','v',' ','i','d','=','"','h','e','a','d','e','r','"','>',' ','\n',' ',' ',' ',' ',' ',' ',' ',' ',
                '<','h','1','>','<','a',' ','h','r','e','f','=','"','/','"','>','A','S','P','.','N','E','T',' ','M','V','C',' ','M','U','S','I','C',' ',
                'S','T','O','R','E','<','/','a','>','<','/','h','1','>',' ','\n',' ',' ',' ',' ',' ',' ',' ',' ','<','u','l',' ','i','d','=','"','n','a','v','l','i','s','t','"','>',' ','\n'
                ,' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','<','l','i',' ','c','l','a','s','s','=','"','f','i','r','s','t','"','>','<','a' };
            WriteLiteral(string2560.Reference);
            string1024 = new ValueString<ValueString512, ValueString512> { ' ', 'i', 'd', '=', '"', 'c', 'u', 'r', 'r', 'e', 'n', 't', '"', '>', 'H', 'o', 'm', 'e', '<', '/', 'a', '>', '<', '/', 'l', 'i', '>', ' ', '\n', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '<', 'l', 'i', '>', '<', 'a' };
            WriteLiteral(string1024.Reference);
            string1024 = new ValueString<ValueString512, ValueString512>{'>','S','t','o','r','e','<','/','a','>','<','/','l','i','>',' ', '\n', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','<','l','i','>' };
            WriteLiteral(string1024.Reference);
            string512 = new ValueString512{'<','/','l','i','>',' ', '\n', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','<','l','i','>','<','a' };
            WriteLiteral(string512.Reference);
            string1024 = new ValueString<ValueString512, ValueString512>{'>','A','d','m','i','n','<','/','a','>','<','/','l','i','>',' ','\n',
                ' ',' ',' ',' ',' ',' ',' ',' ','<','/','u','l','>',' ','\n',' ',' ',' ',' ','<','/','d','i','v','>',' ','\n',' ','\n',' ',' ',' ',' ' };
            WriteLiteral(string1024.Reference);
            string2560 = new ValueString<ValueString<ValueString<ValueString512, ValueString512>, ValueString<ValueString512, ValueString512>>, ValueString512>()
                {' ','\n',' ','\n',' ',' ',' ',' ','<','d','i','v',' ','i','d','=','"','m','a','i','n','"','>',' ','\n',' ',' ',' ',' ',' ',' ',' ',' ' };
            WriteLiteral(string2560.Reference);
            string2560 = new ValueString<ValueString<ValueString<ValueString512, ValueString512>, ValueString<ValueString512, ValueString512>>, ValueString512>()
                {'<','d','i','v',' ','i','d','=','"','p','r','o','m','o','t','i','o','n','"','>',' ','\n','<','/','d','i','v','>',
                ' ','\n',' ','\n','<','h','3','>','<','e','m','>','F','r','e','s','h','<','/','e','m','>',' ','o','f','f',' ','t','h'
                ,'e',' ','g','r','i','l','l','<','/','h','3','>',' ','\n',' ','\n','<','u','l',' ','i','d','=','"','a','l','b','u','m','-','l','i','s','t','"','>',' ','\n' };
            WriteLiteral(string2560.Reference);
            if (shouldAwait)
                await DoSomethingAsync();
            foreach (var album in Model)
            {
                string512 = new ValueString512 {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '<', 'l', 'i', '>', '<', 'a' };
                WriteLiteral(string512.Reference);
                string512 = new ValueString512 { 'h', 'r', 'e', 'f', '=', '"' };
                WriteLiteral(string512.Reference);
                WriteLiteral(Url.Action("Details", "Store",
                                new { id = album.Id }));
                var string32 = new ValueString32 { '"' };
                WriteLiteral(string32.Reference);
                string512 = new ValueString512{'>',' ', '\n', ' ', '\n', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','<','i','m','g' };
                WriteLiteral(string512.Reference);
                string512 = new ValueString512 { ' ', 'a', 'l', 't', '=', '"' };

                WriteLiteral(string512.Reference);
                WriteLiteral(album.Title);
                WriteLiteral(string32.Reference);
                string512 = new ValueString512 { ' ', 's', 'r', 'c', '=', '"' };
                WriteLiteral(string512.Reference);
                WriteLiteral(album.AlbumArtUrl);
                WriteLiteral(string32.Reference);
                string512 = new ValueString512{' ','/','>',' ', '\n', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','<','s','p','a','n','>' };
                WriteLiteral(string512.Reference);
                WriteLiteral(album.Title);
                string1024 = new ValueString<ValueString512, ValueString512>{'<','/','s','p','a','n','>',' ','<','/','a','>',' ', '\n', ' ',' ',' ',' ',' ',' ',' ',' ','<','/','l','i','>',' ', '\n' };
                WriteLiteral(string1024.Reference);
            }
            string512 = new ValueString512 { '<', '/', 'u', 'l', '>' };
            WriteLiteral(string512.Reference);
            string2560 = new ValueString<ValueString<ValueString<ValueString512, ValueString512>, ValueString<ValueString512, ValueString512>>, ValueString512>()
                {' ','\n',' ',' ',' ',' ','<','/','d','i','v','>',' ','\n',' ','\n',' ',' ',' ',' ','<','d','i','v',' ','i',
                'd','=','"','f','o','o','t','e','r','"','>',' ','\n',' ',' ',' ',' ',' ',' ',' ',' ','b','u','i','l','t',
                ' ','w','i','t','h',' ','<','a',' ','h','r','e','f','=','"','h','t','t','p',':','/','/','a','s','p','.',
                'n','e','t','/','m','v','c','"','>','A','S','P','.','N','E','T',' ','M','V','C',' ','C','o','r','e','<',
                '/','a','>',' ','\n',' ',' ',' ',' ','<','/','d','i','v','>',' ','\n' };
            WriteLiteral(string2560.Reference);
        }
    }
}
