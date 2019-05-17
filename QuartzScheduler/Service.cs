using System;
using System.Threading.Tasks;

namespace QuartzScheduler
{
    public class Service
    {
     
        LoggerBgServ _logger = new LoggerBgServ();
        double balance;
    
        public async Task<bool> TestService()
        {
            try
            {
               
                Console.WriteLine("Logged into console");

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
            }
            return false;
        }
    }



}
