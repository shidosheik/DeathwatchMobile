using DeathwatchMobile.Models;

namespace DeathwatchMobile.Services;

public class TalentLibraryService
{
    public List<TalentDefinition> GetTalents()
    {
        return new List<TalentDefinition>
        {
            new()
            {
                Name = "Ferric Summons",
                Prerequisites = "Techmarine or Mechanicus Implants, Ferric Lure",
                Description = "The character can call an unsecured metal object to his hand...",
                Group = ""
            },
            new()
            {
                Name = "Flesh Render",
                Prerequisites = "Adeptus Astartes",
                Description = "When inflicting Damage with a melee weapon that has the Tearing quality...",
                Group = ""
            },
            new()
            {
                Name = "Two-Weapon Wielder (Ballistic/Melee)",
                Prerequisites = "Ballistic Skill 35 or Weapon Skill 35, Agility 35",
                Description = "The character may spend a Full Action to attack with both weapons...",
                Group = "Talent Group"
            }
        };
    }
}