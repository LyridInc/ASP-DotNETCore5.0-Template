using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace YOUR_APP_NAME.YOUR_MODULE_NAME
{
    class Program
    {
        public static void Main(string[] args)
        {
            dotenv.net.DotEnv.Config(false);
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    string port = Environment.GetEnvironmentVariable("PORT") ?? "3000";
                    string url = String.Concat("http://0.0.0.0:", port);

                    webBuilder.UseStartup<YOUR_FUNCTION_NAME>().UseUrls(url);
                });
    }
}
