using System.Threading.Tasks;

/// <summary>
/// Top Level Statements
/// </summary>
System.Console.WriteLine($"Hello, {args[0]}"); // 실행 > 구성 > Default > 인수 에서 args[0] 지정 가능 -> 하지만 터미널에서 직접 실행할 경우, 인수가 없어서 에러가 나기 때문에...
// dotnet run -- "shockz" 와 같은 형태로 실행
await Task.Delay(1000); // Main() 이 async / await 가 기본이라는 것

var sponsor = new Sponsor { Id = 1, DisplayName = "Red" };
//sponsor.DisplayName = "RedPlus"; // mutable -> init -> immutable
DisplayName(sponsor);
static void DisplayName(Sponsor sponsor) => System.Console.WriteLine($"{sponsor.Id} - {sponsor.DisplayName}");

//var subscriber = new Subscriber { Title = "Visual", Duration = 2 };
var subscriber = new Subscriber("Visual", 2, true);
System.Console.WriteLine(subscriber);
var vip = subscriber with { Title = "VIP" };
System.Console.WriteLine(vip);
var (title, duration, isAvailable) = subscriber; // class 에서 구현할 경우는 Deconstruct() 를 구현해야 하지만 record에서는 바로 가능
System.Console.WriteLine($"{title} - {duration} - {isAvailable}");

// [2] init accessors
class Sponsor
{
  public int Id { get; init; }
  public string DisplayName { get; init; } // 초기화 전용 setter
}

// [3] records -> 각각은 다 immutable
// deconstruct 제공, init 제공 등이 class 에 추가된 형태
//record Subscriber
//{
//  public string Title { get; init; } // init 사용을 권장
//  public int Duration { get; init; }
//}
record Subscriber(string Title, int Duration, bool isAvailable); // syntax sugar (간편구문)
record Visual(string Title, int Duration, bool isAvailable) : Subscriber(Title, Duration, isAvailable);
record Studio : Subscriber
{
  public Studio(string Title, int Duration, bool isAvailable) : base(Title, Duration, isAvailable) { }
}
record Code : Subscriber
{
  public Code(string Title, int Duration, bool isAvailable) : base(Title, Duration, isAvailable) { }
}

