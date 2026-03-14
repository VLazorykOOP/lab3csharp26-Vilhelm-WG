namespace Lab3CSharp.task_2;

public class Employee
{
    protected string Name;
    protected int Age;

    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Тип: {this.GetType().Name, -8}, Назва: {Name, -6}, Вік: {Age, -3}");
    }
}