public class MuteQuack : IQuackBehaviorInterface
{
    public void Quack()
    {
        Console.WriteLine("Can't quack!");
    }
}