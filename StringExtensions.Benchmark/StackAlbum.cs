using System;
using System.Collections.Generic;
using System.Text;

namespace StringExtensions.Benchmark
{
    using LargeValueString = ValueString<ValueString<ValueString<ValueString512, ValueString512>, ValueString<ValueString512, ValueString512>>, ValueString<ValueString<ValueString512, ValueString512>, ValueString<ValueString512, ValueString512>>>;

    public class StackAlbum
    {
        private LargeValueString _title;
        private LargeValueString _albumArtUrl;
        private LargeValueString _name;

        public int Id { get; set; }

        public ValueStringReference Name { get => _name.Reference; set => _name.Reference = value; }

        public ValueStringReference AlbumArtUrl { get => _albumArtUrl.Reference; set => _albumArtUrl.Reference = value; }

        public ValueStringReference Title { get => _title.Reference; set => _title.Reference = value; }

        public decimal Price { get; set; }
        public StackGenre Genre { get; set; }
        public StackArtist Artist { get; set; }
    }

    public class StackGenre
    {
        private LargeValueString _name;

        public Guid Id { get; set; } = Guid.NewGuid();

        public ValueStringReference Name { get => _name.Reference; set => _name.Reference = value; }
    }

    public class StackArtist
    {
        private LargeValueString _name;

        public Guid Id { get; set; } = Guid.NewGuid();

        public ValueStringReference Name { get => _name.Reference; set => _name.Reference = value; }
    }
}
