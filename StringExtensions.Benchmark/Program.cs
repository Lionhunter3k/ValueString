using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace StringExtensions.Benchmark
{
    [MemoryDiagnoser]
    public class FakeRazorBenchmark
    {
        static readonly string directory = Directory.GetCurrentDirectory();

        [Benchmark]
        public async Task FakeRazorWithHeapStringsInFile()
        {
            var albums = DataGenerator.CreateData();
            var razorPage = new AlbumFakeRazorPage_Heap(albums, false);
            using (var fileStream = new FileStream(Path.Combine(directory, Guid.NewGuid().ToString()), FileMode.CreateNew))
            using (var streamWriter = new StreamWriter(fileStream))
            {
                await razorPage.ExecuteAsync(streamWriter);
                await streamWriter.FlushAsync();
                await fileStream.FlushAsync();
            }
        }

        [Benchmark]
        public async Task FakeRazorWithStackStringsInFile()
        {
            var albums = DataGenerator.CreateData();
            var razorPage = new AlbumFakeRazorPage_Stack(albums, false);
            using (var fileStream = new FileStream(Path.Combine(directory, Guid.NewGuid().ToString()), FileMode.CreateNew))
            using (var streamWriter = new StreamWriter(fileStream))
            {
                await razorPage.ExecuteAsync(streamWriter);
                await streamWriter.FlushAsync();
                await fileStream.FlushAsync();
            }
        }

        [Benchmark]
        public async Task FakeRazorWithHeapStringsInFileAsync()
        {
            var albums = DataGenerator.CreateData();
            var razorPage = new AlbumFakeRazorPage_Heap(albums, true);
            using (var fileStream = new FileStream(Path.Combine(directory, Guid.NewGuid().ToString()), FileMode.CreateNew))
            using (var streamWriter = new StreamWriter(fileStream))
            {
                await razorPage.ExecuteAsync(streamWriter);
                await streamWriter.FlushAsync();
                await fileStream.FlushAsync();
            }
        }

        [Benchmark]
        public async Task FakeRazorWithStackStringsInFileAsync()
        {
            var albums = DataGenerator.CreateData();
            var razorPage = new AlbumFakeRazorPage_Stack(albums, true);
            using (var fileStream = new FileStream(Path.Combine(directory, Guid.NewGuid().ToString()), FileMode.CreateNew))
            using (var streamWriter = new StreamWriter(fileStream))
            {
                await razorPage.ExecuteAsync(streamWriter);
                await streamWriter.FlushAsync();
                await fileStream.FlushAsync();
            }
        }

        [Benchmark]
        public async Task FakeRazorWithHeapStringsInMemory()
        {
            var albums = DataGenerator.CreateData();
            var razorPage = new AlbumFakeRazorPage_Heap(albums, false);
            using (var memoryStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                await razorPage.ExecuteAsync(streamWriter);
                await memoryStream.FlushAsync();
            }
        }

        [Benchmark]
        public async Task FakeRazorWithStackStringsInMemory()
        {
            var albums = DataGenerator.CreateData();
            var razorPage = new AlbumFakeRazorPage_Stack(albums, false);
            using (var memoryStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                await razorPage.ExecuteAsync(streamWriter);
                await memoryStream.FlushAsync();
            }
        }

        [Benchmark]
        public async Task FakeRazorWithHeapStringsInMemoryAsync()
        {
            var albums = DataGenerator.CreateData();
            var razorPage = new AlbumFakeRazorPage_Heap(albums, true);
            using (var memoryStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                await razorPage.ExecuteAsync(streamWriter);
                await memoryStream.FlushAsync();
            }
        }

        [Benchmark]
        public async Task FakeRazorWithStackStringsInMemoryAsync()
        {
            var albums = DataGenerator.CreateData();
            var razorPage = new AlbumFakeRazorPage_Stack(albums, true);
            using (var memoryStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                await razorPage.ExecuteAsync(streamWriter);
                await memoryStream.FlushAsync();
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var summary = BenchmarkRunner.Run<FakeRazorBenchmark>();
        }
    }
}
