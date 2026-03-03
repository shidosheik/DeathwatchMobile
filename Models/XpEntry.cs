namespace DeathwatchMobile.Models;

public sealed class XpEntry
{
    public DateTime Date { get; set; } = DateTime.UtcNow;
    public int Amount { get; set; }   // + earned, - spent
    public string Reason { get; set; } = "";
}