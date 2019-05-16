using Quartz;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConfirmMeWSQuartz
{
    public class ExamppleJob : IJob
    {
        LoggerBgServ _logger = new LoggerBgServ();
        public async Task Execute(IJobExecutionContext context)
        {
            // Call example service
            Service Service = new Service();

            bool isTrue = await Service.TestService();
            if(isTrue)
            {
                _logger.LogError($"The job was executed with {isTrue} as status");
            }
            else
            {
                _logger.LogError($"The job was executed with {isTrue} as status");
            }
        }
    }
}
