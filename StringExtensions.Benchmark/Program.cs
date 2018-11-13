using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.IO;
using System.Threading.Tasks;

namespace StringExtensions.Benchmark
{
    [MemoryDiagnoser]
    public class FakeRazorBenchmark
    {
        static readonly string directory = Directory.GetCurrentDirectory();


        public async Task FakeRazorWithHeapStringsInFile()
        {
            var albums = DataGenerator.CreateData();
            var razorPage = new AlbumFakeRazorPage_Heap(albums);
            using (var fileStream = new FileStream(Path.Combine(directory, Guid.NewGuid().ToString()), FileMode.CreateNew))
            using (var streamWriter = new StreamWriter(fileStream))
            {
                razorPage.Execute(streamWriter);
                await streamWriter.FlushAsync();
                await fileStream.FlushAsync();
            }
        }


        public async Task FakeRazorWithStackStringsInFile()
        {
            var albums = DataGenerator.CreateData();
            var razorPage = new AlbumFakeRazorPage_Stack(albums);
            using (var fileStream = new FileStream(Path.Combine(directory, Guid.NewGuid().ToString()), FileMode.CreateNew))
            using (var streamWriter = new StreamWriter(fileStream))
            {
                razorPage.Execute(streamWriter);
                await streamWriter.FlushAsync();
                await fileStream.FlushAsync();
            }
        }

        [Benchmark]
        public async Task FakeRazorWithHeapStringsInMemory()
        {
            var albums = DataGenerator.CreateData();
            var razorPage = new AlbumFakeRazorPage_Heap(albums);
            using (var memoryStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                razorPage.Execute(streamWriter);
                await streamWriter.FlushAsync();
            }
            using (var memoryStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                razorPage.Execute(streamWriter);
                await streamWriter.FlushAsync();
            }
        }

        [Benchmark]
        public async Task FakeRazorWithStackStringsInMemory()
        {
            var albums = DataGenerator.CreateData();
            var razorPage = new AlbumFakeRazorPage_Stack(albums);
            using (var memoryStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                razorPage.Execute(streamWriter);
                await streamWriter.FlushAsync();
            }
            using (var memoryStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                razorPage.Execute(streamWriter);
                await streamWriter.FlushAsync();
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
