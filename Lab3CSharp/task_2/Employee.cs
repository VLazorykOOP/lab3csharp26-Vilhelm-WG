namespace Lab3CSharp.task_2;

public class Employee
{
    protected string Name;
    protected int Age;

    public Employee(int age, string name)
    {
        Name = name;
        Age = age;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Тип: {this.GetType().Name, -15}, Назва: {Name, -10}, Вік: {Age, -3}");
    }
}