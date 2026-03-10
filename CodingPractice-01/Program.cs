using System;
using System.Reflection;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");



// 1. 명명된 메서드를 대리자에 할당
/*

Calculator calc = delegate (int a)
{
    return a * a;
};

Console.WriteLine(calc(5));


delegate int Calculator(int a);

// 2. 반환 타입이 있는 익명 메서드
Transformer square = delegate (int x)
{
    return x * x;
};
Transformer cube = delegate (int x)
{
    return x * x * x;
};

Console.WriteLine($"3의 제곱: {square(3)}");
Console.WriteLine($"3의 제곱: {cube(3)}");

delegate int Transformer(int a);

// 3. 반환 타입이 없는 익명 메서드

Printer message = delegate (string message)
{
    Console.WriteLine($"[메시지] {message}");
};

message("안녕하세요");
message("익명 메서드를 사용 중입니다.");


delegate void Printer(string s);

// 4. Func와 Action 델리게이트 사용

Func<int, int> doubler = delegate (int x)
{
    return x * 2;
};

Action<string> logger = delegate (string msg)
{
    Console.WriteLine($"[LOG] {msg}");
};

Console.WriteLine(doubler(10));
logger("작업 시작");

// 5. 매개변수 생략
SimpleDelegate handler = delegate
{
    Console.WriteLine("매개변수를 사용하지 않습니다.");
};
handler(100, "테스트");

delegate void SimpleDelegate(int a, string s);

*/
// 6. 이벤트 핸들러에서의 매개변수 생략

EventHandler onClick = delegate
{
    Console.WriteLine("클릭 이벤트 발생!");
};

onClick(null, EventArgs.Empty);

delegate void EventHandler(object sender, EventArgs e);



