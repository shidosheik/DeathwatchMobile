namespace DeathwatchMobile.Models;

public sealed class SkillLibraryEntry
{
    public string Name { get; set; } = "";
    public string Characteristic { get; set; } = "";
    public string Category { get; set; } = "";
    public string Summary { get; set; } = "";
    public string Description { get; set; } = "";
    public bool IsTrainedOnly { get; set; }
}
