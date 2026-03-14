namespace Lab3CSharp.task_2;

public class Engineer : Employee
{
    protected string Specialization;

    public Engineer(string name, int age, string spec) : base(name, age)
    {
        Specialization = spec;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($" | Спеціальність: {Specialization}");
    }
}