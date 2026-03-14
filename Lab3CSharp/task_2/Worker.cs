namespace Lab3CSharp.task_2;

public class Worker : Employee
{
    protected int Rank;
    
    public Worker(string name, int age, int rank) : base(name, age)
    {
        Rank = rank;
    }
    
    public override void Show()
    {
        base.Show();
        Console.WriteLine($" | Розряд: {Rank}");
    }
}