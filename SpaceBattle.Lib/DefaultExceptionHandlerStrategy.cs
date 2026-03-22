using Hwdtech;

namespace SpaceBattle.Lib;

public class DefaultExceptionHandlerStrategy : IStrategy
{
    public object Execute(params object[] args)
    {
        var command = args[0];
        var exception = args[1] as Exception;
        
        return new ActionCommand(() => { });
    }
}
