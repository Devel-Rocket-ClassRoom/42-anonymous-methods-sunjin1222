using System;

// README.md를 읽고 아래에 코드를 작성하세요.

/*

// 1. 익명 메서드와 람다식 비교
Calculator anonymous = delegate (int x)
{
    return x * x;
};
Calculator lambda1 = (int x) =>
{
    return x * x;
};
Calculator lambda2 = x => x*x;
Console.WriteLine($"익명 메서드: {anonymous(5)}");
Console.WriteLine($"람다식 (블록): {lambda1(5)}");
Console.WriteLine($"람다식 (표현식): {lambda2(5)}");
delegate int Calculator(int a);


// 2. 매개변수 생략: 익명 메서드만 가능
EventHandler handler1 = delegate
{
    Console.WriteLine("이벤트 처리됨");
};
EventHandler handler2=(a, b) => Console.WriteLine("이벤트 처리됨");

handler1(null, EventArgs.Empty);
handler2(null, EventArgs.Empty);
delegate void EventHandler(object a, EventArgs b);
// 3. 빈 이벤트 핸들러 초기화

GameEvent onScoreChange = delegate { };
GameEvent onGameOver = delegate { };

onScoreChange("점수 변경", 100);
onGameOver("게임 종료", 0);

onScoreChange += delegate (string name, int value)
{
    Console.WriteLine($"[이벤트] {name}: {value}");
};
onScoreChange("점수 변경", 500);
delegate void GameEvent(string eventName, int value);


// 4. 콜백 함수로 사용*/

int[] numbers = { 1, 2, 3, 4, 5 };
int sum = 0;
ProcessData(numbers, delegate (int n)
{
    sum += n;
    Console.WriteLine($"처리 중: {n}, 누적: {sum}");
});
Console.WriteLine($"최종 합계: {sum}");
void ProcessData(int[] data, Action<int> callback)
{
    foreach (int item in data)
    {
        callback(item);
    }
}

