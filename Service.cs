using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConfirmMeWSQuartz
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
