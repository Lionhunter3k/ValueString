``` ini

BenchmarkDotNet=v0.11.2, OS=Windows 10.0.17134.648 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914061 Hz, Resolution=255.4891 ns, Timer=TSC
.NET Core SDK=2.1.503
  [Host]     : .NET Core 2.1.7 (CoreCLR 4.6.27129.04, CoreFX 4.6.27129.04), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.1.7 (CoreCLR 4.6.27129.04, CoreFX 4.6.27129.04), 64bit RyuJIT


```
|                                           Method |        Mean |        Error |       StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------------------------------- |------------:|-------------:|-------------:|------------:|------------:|------------:|--------------------:|
|                   FakeRazorWithHeapStringsInFile | 66,259.1 us | 2,743.488 us | 8,046.175 us |           - |           - |           - |           292.51 KB |
|                  FakeRazorWithStackStringsInFile | 69,427.7 us | 3,192.552 us | 9,363.201 us |           - |           - |           - |           271.37 KB |
|              FakeRazorWithHeapStringsInFileAsync | 82,344.3 us | 2,587.530 us | 7,588.777 us |           - |           - |           - |           196.07 KB |
|             FakeRazorWithStackStringsInFileAsync | 72,037.4 us | 2,527.259 us | 6,875.595 us |           - |           - |           - |           196.29 KB |
|                 FakeRazorWithHeapStringsInMemory |    702.3 us |     3.010 us |     2.816 us |    124.0234 |     41.0156 |     41.0156 |           542.42 KB |
|                FakeRazorWithStackStringsInMemory |  1,209.4 us |     7.130 us |     6.669 us |    123.0469 |     41.0156 |     41.0156 |           521.28 KB |
|            FakeRazorWithHeapStringsInMemoryAsync | 15,660.0 us |   145.103 us |   135.730 us |    109.3750 |     31.2500 |     31.2500 |           195.48 KB |
|           FakeRazorWithStackStringsInMemoryAsync | 17,875.1 us |   356.356 us |   743.847 us |     93.7500 |     31.2500 |     31.2500 |           195.48 KB |
|         StackModelFakeRazorWithHeapStringsInFile | 67,595.6 us | 2,646.837 us | 7,720.947 us |    111.1111 |           - |           - |           634.36 KB |
|        StackModelFakeRazorWithStackStringsInFile | 68,352.1 us | 2,052.189 us | 5,986.331 us |    142.8571 |           - |           - |           613.22 KB |
|    StackModelFakeRazorWithHeapStringsInFileAsync | 79,605.9 us | 2,480.672 us | 7,275.381 us |           - |           - |           - |           537.92 KB |
|   StackModelFakeRazorWithStackStringsInFileAsync | 76,260.6 us | 2,916.991 us | 8,600.814 us |    142.8571 |           - |           - |           537.92 KB |
|       StackModelFakeRazorWithHeapStringsInMemory |    802.2 us |     1.269 us |     1.060 us |    131.8359 |     52.7344 |           - |           756.24 KB |
|      StackModelFakeRazorWithStackStringsInMemory |  1,401.5 us |     4.950 us |     4.388 us |    140.6250 |     68.3594 |           - |            735.1 KB |
|  StackModelFakeRazorWithHeapStringsInMemoryAsync | 15,769.4 us |   300.445 us |   308.535 us |    125.0000 |     31.2500 |           - |           537.33 KB |
| StackModelFakeRazorWithStackStringsInMemoryAsync | 19,022.6 us |   376.581 us |   760.713 us |    125.0000 |     31.2500 |           - |           537.33 KB |
