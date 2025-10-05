namespace Benchwarp.Data;

public class Gate
{
    public Gate(TransitionKey self, TransitionKey sourcetarget)
    {
        Self = self;
        Target = sourcetarget;
        Source = sourcetarget;
    }

    public Gate(TransitionKey self, TransitionKey? source, TransitionKey? target)
    {
        Self = self;
        Target = target;
        Source = source;
    }

    public TransitionKey Self { get; }
    public TransitionKey? Target { get; }
    public TransitionKey? Source { get; }
}
