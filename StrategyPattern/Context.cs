public class Context
{
    private IFlyBehaviorInterface flyStrategy;
    private IQuackBehaviorInterface quackStrategy;

    public Context(IFlyBehaviorInterface flyStrategy, IQuackBehaviorInterface quackStrategy)
    {
        this.flyStrategy = flyStrategy;
        this.quackStrategy = quackStrategy;
    }

    public void SetFly(IFlyBehaviorInterface flyStrategy)
    {
        this.flyStrategy = flyStrategy;
    }

    public void SetQuack(IQuackBehaviorInterface quackStrategy)
    {
        this.quackStrategy = quackStrategy;
    }

    public void ExecuteStrategy()
    {
        flyStrategy.Fly();
        quackStrategy.Quack();
    }
}