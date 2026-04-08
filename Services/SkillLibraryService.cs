using DeathwatchMobile.Models;

namespace DeathwatchMobile.Services;

public sealed class SkillLibraryService
{
    private readonly List<SkillLibraryEntry> _skills = new()
    {
        new SkillLibraryEntry
        {
            Name = "Awareness",
            Characteristic = "Perception",
            Category = "General",
            Summary = "Used to notice threats, clues, hidden movement, and important details.",
            Description = "Use this when a character is actively or passively trying to detect something in the environment.",
            IsTrainedOnly = false
        },
        new SkillLibraryEntry
        {
            Name = "Athletics",
            Characteristic = "Strength",
            Category = "Physical",
            Summary = "Covers climbing, jumping, swimming, and physical exertion.",
            Description = "Useful for movement challenges, rough terrain, and feats of physical effort.",
            IsTrainedOnly = false
        },
        new SkillLibraryEntry
        {
            Name = "Charm",
            Characteristic = "Fellowship",
            Category = "Interaction",
            Summary = "Used to persuade, reassure, and build rapport.",
            Description = "Best for positive social influence rather than threats or deception.",
            IsTrainedOnly = false
        },
        new SkillLibraryEntry
        {
            Name = "Command",
            Characteristic = "Fellowship",
            Category = "Interaction",
            Summary = "Used to issue orders and assert authority.",
            Description = "Useful for battlefield control, leadership moments, and directing NPCs.",
            IsTrainedOnly = false
        },
        new SkillLibraryEntry
        {
            Name = "Dodge",
            Characteristic = "Agility",
            Category = "Combat",
            Summary = "Used to avoid attacks and hazards.",
            Description = "A core defensive skill during combat and dangerous action scenes.",
            IsTrainedOnly = false
        },
        new SkillLibraryEntry
        {
            Name = "Forbidden Lore (Xenos)",
            Characteristic = "Intelligence",
            Category = "Knowledge",
            Summary = "Represents specialized knowledge of alien species and threats.",
            Description = "Useful for identifying xenos, recalling doctrine, and understanding alien dangers.",
            IsTrainedOnly = true
        },
        new SkillLibraryEntry
        {
            Name = "Medicae",
            Characteristic = "Intelligence",
            Category = "Support",
            Summary = "Used for diagnosis, treatment, and battlefield medicine.",
            Description = "Useful for stabilizing allies and evaluating injuries or biological conditions.",
            IsTrainedOnly = true
        },
        new SkillLibraryEntry
        {
            Name = "Scholastic Lore",
            Characteristic = "Intelligence",
            Category = "Knowledge",
            Summary = "Formal education in an academic field.",
            Description = "Represents structured learned knowledge rather than street knowledge or rumor.",
            IsTrainedOnly = true
        },
        new SkillLibraryEntry
        {
            Name = "Scrutiny",
            Characteristic = "Perception",
            Category = "Interaction",
            Summary = "Used to read motives, lies, and suspicious behavior.",
            Description = "Helpful when assessing truthfulness, hidden intent, or subtle emotional tells.",
            IsTrainedOnly = false
        },
        new SkillLibraryEntry
        {
            Name = "Tech-Use",
            Characteristic = "Intelligence",
            Category = "Technical",
            Summary = "Used to operate, repair, bypass, or manipulate machinery and systems.",
            Description = "A core technical skill for interacting with advanced equipment and devices.",
            IsTrainedOnly = true
        }
    };

    public IReadOnlyList<string> GetCategories() => _skills
        .Select(x => x.Category)
        .Distinct()
        .OrderBy(x => x)
        .ToList();

    public IReadOnlyList<SkillLibraryEntry> FilterSkills(string searchText, string category) => _skills
        .Where(x =>
            (string.IsNullOrWhiteSpace(searchText) ||
             x.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
             x.Summary.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
             x.Description.Contains(searchText, StringComparison.OrdinalIgnoreCase)) &&
            (string.IsNullOrWhiteSpace(category) || x.Category == category))
        .OrderBy(x => x.Name)
        .ToList();
}
