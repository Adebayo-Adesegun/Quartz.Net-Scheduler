﻿using Quartz;
using System;
using System.Threading.Tasks;

namespace QuartzScheduler
{
    public class ExamppleJob : IJob
    {
   
        public async Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine("Executing Job1");
        }
    }
}
