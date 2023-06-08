using System;
using System.Threading.Tasks;

namespace Quartz
{
    internal class HelloJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            await Console.Out.WriteLineAsync($"Executing background job => {DateTime.Now}");
        }
    }
}
