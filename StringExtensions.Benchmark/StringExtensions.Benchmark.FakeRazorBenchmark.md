``` ini

BenchmarkDotNet=v0.11.2, OS=Windows 10.0.17134.648 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914061 Hz, Resolution=255.4891 ns, Timer=TSC
.NET Core SDK=2.1.503
  [Host]     : .NET Core 2.1.7 (CoreCLR 4.6.27129.04, CoreFX 4.6.27129.04), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.1.7 (CoreCLR 4.6.27129.04, CoreFX 4.6.27129.04), 64bit RyuJIT


```
|                                 Method |        Mean |        Error |         StdDev |      Median | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|--------------------------------------- |------------:|-------------:|---------------:|------------:|------------:|------------:|------------:|--------------------:|
|         FakeRazorWithHeapStringsInFile | 59,934.5 us | 2,779.931 us |  8,109.1880 us | 60,710.4 us |           - |           - |           - |           153.77 KB |
|        FakeRazorWithStackStringsInFile | 69,695.0 us | 2,023.337 us |  5,902.1678 us | 70,546.2 us |           - |           - |           - |           132.63 KB |
|    FakeRazorWithHeapStringsInFileAsync | 77,069.0 us | 2,439.516 us |  7,192.9684 us | 78,089.4 us |           - |           - |           - |            57.33 KB |
|   FakeRazorWithStackStringsInFileAsync | 79,685.1 us | 8,245.299 us | 24,182.0349 us | 71,102.9 us |           - |           - |           - |            57.33 KB |
|       FakeRazorWithHeapStringsInMemory |    645.5 us |     1.161 us |      0.9063 us |    645.7 us |     66.4063 |           - |           - |           275.65 KB |
|      FakeRazorWithStackStringsInMemory |  1,151.4 us |     3.379 us |      3.1610 us |  1,150.5 us |     60.5469 |      1.9531 |           - |           254.51 KB |
|  FakeRazorWithHeapStringsInMemoryAsync | 15,577.2 us |    53.651 us |     50.1853 us | 15,581.2 us |     62.5000 |           - |           - |            56.73 KB |
| FakeRazorWithStackStringsInMemoryAsync | 15,560.6 us |   117.027 us |    109.4669 us | 15,557.7 us |     62.5000 |           - |           - |            56.73 KB |
