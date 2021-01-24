/// <summary>
/// Top Level Statements
/// </summary>
System.Console.WriteLine($"Hello, {args[0]}"); // 실행 > 구성 > Default > 인수 에서 args[0] 지정 가능
var sponsor = new Sponsor
{
  Id = 1,
  DisplayName = "Red"
};

//sponsor.DisplayName = "RedPlus"; // mutable -> init -> immutable

DisplayName(sponsor);

static void DisplayName(Sponsor sponsor) =>
  System.Console.WriteLine($"{sponsor.Id} - {sponsor.DisplayName}");

struct Sponsor
{
  public int Id { get; init; }
  public string DisplayName { get; init; } // 초기화 전용 setter
}