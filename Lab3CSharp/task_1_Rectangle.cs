namespace Lab3CSharp;

public class task_1_Rectangle
{
    protected int a, b;
    protected int c;

    public int A
    {
        get => a;
        set => a = value;
    }

    public int B
    {
        get => b;
        set => b = value;
    }

    public int C
    {
        get => c;
    }

    public task_1_Rectangle(int sideA, int sideB, int color)
    {
        a = sideA;
        b = sideB;
        c = color;
    }
}