using System;
using System.Net.Http;
using System.Threading.Tasks;
using ApiLibrary.Models;

namespace ApiLibrary
{
    public static class ActivityProcessor
    {
        public static async Task<ActivityModel> LoadActivity()
        {
            string url = "https://www.boredapi.com/api/activity/";

            using (HttpResponseMessage response = await APIConsumer.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    ActivityModel activity = await response.Content.ReadAsAsync<ActivityModel>();
                    return activity;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }
    }
}