Console.WriteLine("(1: Papera reale, 2: Papera di gomma, 3: Papera gialla)");
Console.WriteLine("5 per uscire");

Console.WriteLine("Scegliere il tipo di papera da osservare:");
string? duck = Console.ReadLine();
IFlyBehaviorInterface? strategyFly = null;
IQuackBehaviorInterface? strategyQuack = null;

switch (duck)
{
    case "1":
        strategyFly = new FlyWithWings();
        strategyQuack = new Quacks();
        break;
    case "2":
        strategyFly = new FlyNoWay();
        strategyQuack = new MuteQuack();
        break;
    case "3":
        strategyFly = new FlyWithWings();
        strategyQuack = new Squeak();
        break;
    case "5":
        go = false;
        break;
    default:
        Console.WriteLine("Input non valido");
        break;

}
Context context = new Context(strategyFly, strategyQuack);
context.ExecuteStrategy();

