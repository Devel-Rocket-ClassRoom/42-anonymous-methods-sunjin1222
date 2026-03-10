using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
DataProcessor processor = new DataProcessor(numbers);

Console.WriteLine("=== 원본 배열 출력 ===");
processor.ForEach(item => Console.Write($"{item} "));
Console.WriteLine();


Console.WriteLine("=== 2배로 변환 ===");
int[] doubled = processor.Transform(item => item * 2);
foreach (var item in doubled)
{
    Console.Write(item + " ");
}
Console.WriteLine();

Console.WriteLine("=== 짝수만 필터링 ===");
List<int> evens = processor.Filter(item => item % 2 == 0);
evens.ForEach(item => Console.Write($"{item} "));
Console.WriteLine();

Console.WriteLine("=== 합계 계산 ===");
int sum = processor.Reduce((acc, item) => acc + item, 0);
Console.WriteLine("합계: " + sum);


class DataProcessor
{

    private int[] ints;

    public DataProcessor(int[] data)
    {
        this.ints = data;
    }
    public void ForEach(Action<int> action)
    {
        for (int i = 0; i < ints.Length; i++)
        {
            Console.Write($"{ints[i]} "); 
        }
    }
    public int[] Transform(Func<int, int> transformer)
    {
        int[] result = new int[ints.Length];
        for (int i = 0; i < ints.Length; i++)
        {
            result[i] = transformer(ints[i]);
        }
        return result;
    }
    public List<int> Filter(Func<int, bool> predicate)
    {
        List<int> result = new List<int>();
        foreach (var item in ints)
        {
            if (predicate(item))
            {
                result.Add(item);
            }
        }
        return result;
    }
    public int Reduce(Func<int, int, int> reducer, int initialValue)
    {
        int accumulator = initialValue;
        foreach (var item in ints)
        {
            accumulator = reducer(accumulator, item);
        }
        return accumulator;
    }



}