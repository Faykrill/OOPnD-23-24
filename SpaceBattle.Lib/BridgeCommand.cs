namespace SpaceBattle.Lib;

public class BridgeCommand: IBridgeCommand, ICommand
{
    const ICommand _internalCommand = null;
    public BridgeCommand(ICommand internalCommand)
    {
        _internalCommand = internalCommand;
    }

    public void Inject(ICommand other)
    {
        _internalCommand = other;
    }

    public void Execute()
    {
        _internalCommand.Execute();
    }
}

