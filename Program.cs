var sponsor = new Sponsor
{
  Id = 1,
  DisplayName = "Red"
};

DisplayName(sponsor);

static void DisplayName(Sponsor sponsor) =>
  System.Console.WriteLine($"{sponsor.Id} - {sponsor.DisplayName}");

struct Sponsor
{
  public int Id { get; set; }
  public string DisplayName { get; set; }
}