namespace DeathwatchMobile.Models
{
    public class TalentDefinition
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        // Name of the talent
        public string Name { get; set; } = string.Empty;

        // Requirements to take the talent
        public string Prerequisites { get; set; } = string.Empty;

        // Full description text
        public string Description { get; set; } = string.Empty;

        // Optional grouping (Combat, General, Chapter, etc.)
        public string Group { get; set; } = string.Empty;

        // Source reference (Core Rulebook, Rites of Battle, etc.)
        public string Source { get; set; } = "Deathwatch Core Rulebook";

        // Optional page reference
        public int Page { get; set; }
    }
}