``` ini

BenchmarkDotNet=v0.11.2, OS=Windows 10.0.15063.674 (1703/CreatorsUpdate/Redstone2)
Intel Core i7-4790 CPU 3.60GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
Frequency=3507515 Hz, Resolution=285.1021 ns, Timer=TSC
.NET Core SDK=2.1.403
  [Host]     : .NET Core 2.1.5 (CoreCLR 4.6.26919.02, CoreFX 4.6.26919.02), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.1.5 (CoreCLR 4.6.26919.02, CoreFX 4.6.26919.02), 64bit RyuJIT


```
|                           Method |     Mean |    Error |   StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|--------------------------------- |---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
| FakeRazorWithHeapStringsInMemory | 729.6 us | 16.48 us | 15.42 us |     13.6719 |           - |           - |            56.15 KB |
