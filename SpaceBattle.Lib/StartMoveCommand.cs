using Hwdtech;
using Hwdtech.Ioc;

namespace SpaceBattle.Lib;

public class StartMoveCommand : ICommand
{
    private IMoveStartable _startable;

    public StartMoveCommand(IMoveStartable startable)
    {
        _startable = startable;
    }

    public void Execute()
    {
        _startable.InitialValues.ToList().ForEach(value => IoC.Resolve<object>(
            "Game.IUObject.SetProperty",
            _startable.Target,
            value.Key,
            value.Value
        ));

        string cmdName = _startable.Command;

        var cmd = IoC.Resolve<ICommand>($"Game.Command.{cmdName}", _startable.Target);
        var bridgeCmd = IoC.Resolve<ICommand>("Game.Command.Inject", cmd);
        IoC.Resolve<object>("Game.IUObject.SetProperty", _startable.Target, "command", bridgeCmd);
        IoC.Resolve<IQueue>("Game.Queue").Push(bridgeCmd);
    }
}

