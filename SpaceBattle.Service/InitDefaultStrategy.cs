using Hwdtech;
using Hwdtech.Ioc;

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
                return new DefaultExceptionHandlerStrategy();
            }

            return IoC.Resolve<ICommand>("Exception.Handler", args);
        }).Execute();
    }
}
