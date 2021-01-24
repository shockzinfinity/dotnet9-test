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