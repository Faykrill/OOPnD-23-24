using SpaceBattle.Lib;
using Hwdtech;
using Hwdtech.Ioc;

namespace SpaceBattle.Service;

public class Program
{
    public static void Main(string[] args)
    {
        new InitScopeBasedIoCImplementationCommand().Execute();
        
        IoC.Resolve<Hwdtech.ICommand>("Scopes.Current.Set", IoC.Resolve<object>("Scopes.Root")).Execute();
        
        new InitDefaultStrategy();
        
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}
