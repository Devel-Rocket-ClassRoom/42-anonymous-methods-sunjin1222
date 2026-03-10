using System;
using System.Diagnostics.Metrics;

// README.md를 읽고 아래에 코드를 작성하세요.
CounterFactory counter1 = new CounterFactory();

Console.WriteLine("=== 단순 카운터 ===");
var simple = CounterFactory.CreateSimpleCounter();
for (int i = 0; i < 5; i++)
{
    Console.Write(simple() + " ");
};
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("=== 스텝 카운터 (step=3) ===");
var step = CounterFactory.CreateStepCounter(3);
for (int i = 0; i < 4; i++)
{
    Console.Write(step() + " ");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("=== 범위 카운터 (1~3) ===");
var Bounde = CounterFactory.CreateBoundedCounter(1,3);
for (int i = 0; i < 7; i++)
{
    Console.Write(Bounde() + " ");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("=== 리셋 가능 카운터 ===");
CounterFactory.CreateResettableCounter(out Action reset, out Func<int> next);
Console.Write("호출: ");
for (int i = 0; i < 3; i++)
{
    Console.Write(next() + " ");
}
reset();
Console.Write("\n리셋 후: ");
for (int i = 0; i < 2; i++)
{ 
    Console.Write(next() + " ");
}



class CounterFactory
{

    public static Func<int> CreateSimpleCounter()
    {
        int counter = 0;
        return delegate ()
        {
            counter++;
            return counter;
        };
    }

    public static Func<int> CreateStepCounter(int step)
    {
        int counter = 0;
        return delegate ()
        {
            counter+= step;
            return counter;
        };
    }

    public static Func<int> CreateBoundedCounter(int min, int max)
    {
        int counter = min - 1;

        return delegate ()
        {
            counter++;

            if (counter > max)
                counter = min;

            return counter;
        };

    }

    public static void CreateResettableCounter(out Action reset, out Func<int> next)
    {
        int counter = 0;

        next = delegate ()
        {
            counter++;
            return counter;
        };

        reset = delegate ()
        {
            counter = 0;
        };
    }





}
