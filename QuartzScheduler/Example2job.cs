using Quartz;
using System;
using System.Threading.Tasks;

namespace QuartzScheduler
{
    public class Example2job : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine("Executing Job2");
        }
    }
}
