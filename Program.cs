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
var subscriber = new Subscriber("Visual", 2);
System.Console.WriteLine(subscriber);
var vip = subscriber with { Title = "VIP" };
System.Console.WriteLine(vip);

// [2] init accessors
class Sponsor
{
  public int Id { get; init; }
  public string DisplayName { get; init; } // 초기화 전용 setter
}

// [3] records
//record Subscriber
//{
//  public string Title { get; init; } // init 사용을 권장
//  public int Duration { get; init; }
//}
record Subscriber(string Title, int Duration); // syntax sugar (간편구문)
