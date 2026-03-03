namespace DeathwatchMobile.Models;

public sealed class Skill
{
    public string Name { get; set; } = "";
    public string Governing { get; set; } = "Per"; // WS/BS/S/T/Ag/Int/Per/WP/Fel
    public SkillTraining Training { get; set; } = SkillTraining.Untrained;

    // Optional: situational modifiers (gear, talents, etc.)
    public int MiscMod { get; set; } = 0;

    public string Notes { get; set; } = "";
}