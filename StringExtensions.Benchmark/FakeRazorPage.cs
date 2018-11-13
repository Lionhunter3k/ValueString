using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions.Benchmark
{
    public abstract class FakeRazorPage<TModel>
    {
        protected TModel Model { get; }

        private TextWriter currentOutputStream;

        public FakeRazorPage(TModel model)
        {
            Model = model;
        }

        public Task ExecuteAsync(TextWriter outputStream)
        {
            this.currentOutputStream = outputStream;
            return OnExecuteAsync();
        }

        protected Task DoSomethingAsync()
        {
            return Task.Delay(100);
        }

        protected abstract Task OnExecuteAsync();

        protected void WriteLiteral(string text)
        {
            currentOutputStream.Write(text);
        }

        protected void WriteLiteral(ValueStringReference text)
        {
            currentOutputStream.Write(text.Buffer);
        }
    }
}
