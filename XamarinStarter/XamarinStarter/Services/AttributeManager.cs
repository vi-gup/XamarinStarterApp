using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace XamarinStarter.Services
{
    public class AttributeManager
    {
        HttpClient client = new HttpClient() { BaseAddress = new Uri("http://hrcomapiv2.azurewebsites.net") };

        async public Task<bool> GetAttributeCount()
        {
            try
            {
                var response = await client.GetAsync("api/routewithdetails/1");


                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}