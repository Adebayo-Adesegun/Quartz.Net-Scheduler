using Quartz;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConfirmMeWSQuartz
{
    public class EmailJob : IJob
    {
        LoggerBgServ _logger = new LoggerBgServ();
        public async Task Execute(IJobExecutionContext context)
        {
            //call paystack service
            Service Service = new Service();
            bool isTrue = await Service.TestService();

            _logger.LogError($"The job was exscuted with {isTrue} as status");
        }
    }
}
