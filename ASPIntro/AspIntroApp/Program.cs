using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace AspIntroApp
{
    /*
    =========================================================================

    Program is an entry point for our application, it will create a host and trigger
    app with the help of startup class 

    for more, visit:
    https://jakeydocs.readthedocs.io/en/latest/fundamentals/startup.html

    for now ignore implementation details

    =========================================================================
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
