using Hwdtech;
using Hwdtech.Ioc;
using SpaceBattle.Lib;

namespace SpaceBattle.Service;

public class InitDefaultStrategy
{
    public InitDefaultStrategy()
    {
        var registerCommand = IoC.Resolve<Hwdtech.ICommand>("IoC.Register", "Exception.Handler", (object[] args) =>
        {
            try
            {
                return IoC.Resolve<Hwdtech.ICommand>("Exception.Handler", args);
            }
            catch
            {
                return new SpaceBattle.Lib.DefaultExceptionHandlerStrategy();
            }
        });
        
        registerCommand.Execute();
    }
}
