using DeathwatchMobile.Models;

namespace DeathwatchMobile.Services
{
    public class TalentLibraryService
    {
        public List<TalentDefinition> GetTalents()
        {
            return new List<TalentDefinition>
            {
                new TalentDefinition
                {
                    Name = "Ambidextrous",
                    Prerequisites = "-",
                    Description = "This Talent represents equal dexterity with both hands. When combined with the Two-Weapon Wielder Talent, the character may fight with a weapon in each hand without taking the standard penalties for using his off hand.",
                    Group = "General",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Bulging Biceps",
                    Prerequisites = "Strength 45",
                    Description = "The character can fire heavy weapons without bracing and does not count them as requiring a braced action in circumstances where others normally would.",
                    Group = "Combat",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Crushing Blow",
                    Prerequisites = "Strength 40",
                    Description = "The character gains +2 melee Damage.",
                    Group = "Combat",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Counter Attack",
                    Prerequisites = "Weapon Skill 40",
                    Description = "After successfully parrying an opponent’s melee attack, the character may immediately make a Standard Attack against that same opponent as a Free Action once per Round.",
                    Group = "Combat",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Deadeye Shot",
                    Prerequisites = "Ballistic Skill 30",
                    Description = "When the character takes an Aim action, he may reduce penalties for called shots at the GM’s discretion or gain improved precision with ranged attacks.",
                    Group = "Combat",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Disarm",
                    Prerequisites = "Agility 30",
                    Description = "The character can attempt to disarm an opponent in melee more effectively than normal warriors.",
                    Group = "Combat",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Double Team",
                    Prerequisites = "-",
                    Description = "When the character and an ally engage the same opponent in melee, they gain bonuses for coordinated pressure in close combat.",
                    Group = "Combat",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Ferric Lure",
                    Prerequisites = "Techmarine",
                    Description = "The character can call small unsecured metallic objects to his hand by means of his implanted electromagnetic systems.",
                    Group = "Chapter/Advanced",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Ferric Summons",
                    Prerequisites = "Techmarine or Mechanicus Implants, Ferric Lure",
                    Description = "The character can call an unsecured metal weapon or object to his hand from a greater distance with improved control.",
                    Group = "Chapter/Advanced",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Flesh Render",
                    Prerequisites = "Adeptus Astartes",
                    Description = "When the character inflicts Damage in melee with a weapon that has the Tearing quality, he inflicts additional harm on his target.",
                    Group = "Combat",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Frenzy",
                    Prerequisites = "-",
                    Description = "The character may enter a berserk fury in combat, gaining bonuses to melee ability and strength while sacrificing caution and precision.",
                    Group = "Combat",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Hard Target",
                    Prerequisites = "Agility 40",
                    Description = "The character is difficult to hit while running and moving quickly.",
                    Group = "Defence",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Heightened Senses (Hearing)",
                    Prerequisites = "-",
                    Description = "The character gains a bonus to hearing-based Awareness Tests.",
                    Group = "General",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Heightened Senses (Sight)",
                    Prerequisites = "-",
                    Description = "The character gains a bonus to sight-based Awareness Tests.",
                    Group = "General",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Hip Shooting",
                    Prerequisites = "Ballistic Skill 40, Agility 40",
                    Description = "The character can move at speed and still make ranged attacks more effectively than normal.",
                    Group = "Combat",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Iron Jaw",
                    Prerequisites = "Toughness 40",
                    Description = "The character can more easily recover from Stunning effects.",
                    Group = "Defence",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Killing Strike",
                    Prerequisites = "-",
                    Description = "The character’s unarmed attacks count as more deadly weapons and can be used with terrifying efficiency.",
                    Group = "Combat",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Leap Up",
                    Prerequisites = "Agility 30",
                    Description = "The character can stand from prone as a Free Action.",
                    Group = "General",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Lightning Attack",
                    Prerequisites = "Weapon Skill 50",
                    Description = "The character can unleash a storm of melee blows as a Full Action.",
                    Group = "Combat",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Marksman",
                    Prerequisites = "Ballistic Skill 35",
                    Description = "The character can fire at long range without suffering the usual penalties.",
                    Group = "Combat",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Melee Weapon Training (Universal)",
                    Prerequisites = "-",
                    Description = "The character is trained to use all common melee weapons without penalty.",
                    Group = "Weapon Training",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Nerves of Steel",
                    Prerequisites = "-",
                    Description = "The character may re-roll failed Pinning Tests.",
                    Group = "Defence",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Precise Blow",
                    Prerequisites = "Weapon Skill 40",
                    Description = "The character can place melee strikes with greater accuracy when attempting more specialized attacks.",
                    Group = "Combat",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Quick Draw",
                    Prerequisites = "-",
                    Description = "The character can ready a weapon as a Free Action.",
                    Group = "General",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Rapid Reaction",
                    Prerequisites = "Agility 40",
                    Description = "The character may make an additional Initiative roll and choose the better result.",
                    Group = "General",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Resistance (Psychic Powers)",
                    Prerequisites = "-",
                    Description = "The character gains bonuses when resisting psychic powers and similar effects.",
                    Group = "Defence",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Step Aside",
                    Prerequisites = "Agility 40",
                    Description = "The character gains one additional Dodge Reaction each Round.",
                    Group = "Defence",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Street Fighting",
                    Prerequisites = "-",
                    Description = "The character is skilled in brutal close-quarters techniques and gains bonuses in rough melee engagements.",
                    Group = "Combat",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Strong Minded",
                    Prerequisites = "Willpower 30",
                    Description = "The character can resist mental control and psychic domination with greater determination.",
                    Group = "Defence",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Swift Attack",
                    Prerequisites = "Weapon Skill 35",
                    Description = "The character can make two melee attacks as a Full Action.",
                    Group = "Combat",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "True Grit",
                    Prerequisites = "Toughness 40",
                    Description = "The character reduces Critical Damage suffered from attacks after all other reductions are applied.",
                    Group = "Defence",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Two-Weapon Wielder (Ballistic)",
                    Prerequisites = "Ballistic Skill 35, Agility 35",
                    Description = "The character can fight with a ranged weapon in each hand more effectively.",
                    Group = "Combat",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Two-Weapon Wielder (Melee)",
                    Prerequisites = "Weapon Skill 35, Agility 35",
                    Description = "The character can fight with a melee weapon in each hand more effectively.",
                    Group = "Combat",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Unarmed Master",
                    Prerequisites = "-",
                    Description = "The character is highly trained in unarmed combat and deals improved Damage with such attacks.",
                    Group = "Combat",
                    Source = "Deathwatch Core Rulebook"
                },
                new TalentDefinition
                {
                    Name = "Wall of Steel",
                    Prerequisites = "Weapon Skill 35",
                    Description = "The character gains one additional Parry Reaction each Round.",
                    Group = "Defence",
                    Source = "Deathwatch Core Rulebook"
                }
            };
        }
    }
}