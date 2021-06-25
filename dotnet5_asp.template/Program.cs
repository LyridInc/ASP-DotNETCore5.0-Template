using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace dotnet5_asp.template
{
    class Program
    {
        public static void Main(string[] args)
        {
            dotenv.net.DotEnv.Load();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    string port = Environment.GetEnvironmentVariable("PORT") ?? "3000";
                    string url = String.Concat("http://0.0.0.0:", port);
                    webBuilder.UseStartup<Startup>().UseUrls(url);
                });
    }
}
