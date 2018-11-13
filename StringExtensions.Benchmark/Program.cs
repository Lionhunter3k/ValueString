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
                await razorPage.ExecuteAsync(streamWriter);
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
                await razorPage.ExecuteAsync(streamWriter);
                await streamWriter.FlushAsync();
                await fileStream.FlushAsync();
            }
        }

        [Benchmark]
        public async Task<byte[]> FakeRazorWithHeapStringsInMemory()
        {
            var albums = DataGenerator.CreateData();
            var razorPage = new AlbumFakeRazorPage_Heap(albums);
            using (var memoryStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                await razorPage.ExecuteAsync(streamWriter);
                await memoryStream.FlushAsync();
                return memoryStream.ToArray();
            }
        }

        [Benchmark]
        public async Task<byte[]> FakeRazorWithStackStringsInMemory()
        {
            var albums = DataGenerator.CreateData();
            var razorPage = new AlbumFakeRazorPage_Stack(albums);
            using (var memoryStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                await razorPage.ExecuteAsync(streamWriter);
                await memoryStream.FlushAsync();
                return memoryStream.ToArray();
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
