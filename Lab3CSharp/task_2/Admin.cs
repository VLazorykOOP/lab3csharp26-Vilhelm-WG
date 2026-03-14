namespace Lab3CSharp.task_2;

public class Admin : Employee
{
    protected string Posada;

    public Admin(string name, int age, string pos) : base(name, age)
    {
        Posada = pos;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($" | Посада: {Posada, -10}");
    }
}