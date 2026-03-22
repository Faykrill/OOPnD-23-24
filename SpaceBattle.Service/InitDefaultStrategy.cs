using Hwdtech;
using Hwdtech.Ioc;
using SpaceBattle.Lib;

namespace SpaceBattle.Service;

public class InitDefaultStrategy
{
    public InitDefaultStrategy()
    {
        IoC.Resolve<Hwdtech.ICommand>("IoC.Register", "Exception.Handler", (object[] args) =>
        {
            try
            {
                IoC.Resolve<ICommand>("Exception.Handler", args);
            }
            catch
            {
                return new SpaceBattle.Lib.DefaultExceptionHandlerStrategy();
            }

            return IoC.Resolve<SpaceBattle.Lib.ICommand>("Exception.Handler", args);
        }).Execute();
    }
}
