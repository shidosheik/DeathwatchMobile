using DeathwatchMobile.Models;

namespace DeathwatchMobile.Services;

public sealed class CharacterSkillService
{
    public IEnumerable<Skill> FilterSkills(
        Character? character,
        string search,
        string governing,
        string sort,
        bool trainedOnly)
    {
        if (character?.Skills is null)
            return Enumerable.Empty<Skill>();

        IEnumerable<Skill> query = character.Skills;

        if (!string.IsNullOrWhiteSpace(search))
        {
            var trimmed = search.Trim();
            query = query.Where(x => x.Name.Contains(trimmed, StringComparison.OrdinalIgnoreCase));
        }

        if (!string.IsNullOrWhiteSpace(governing))
            query = query.Where(x => x.Governing == governing);

        if (trainedOnly)
            query = query.Where(x => x.Training != SkillTraining.Untrained);

        return sort switch
        {
            "target" => query.OrderByDescending(character.SkillTarget).ThenBy(x => x.Name),
            "governing" => query.OrderBy(x => x.Governing).ThenBy(x => x.Name),
            "training" => query.OrderByDescending(x => x.Training).ThenBy(x => x.Name),
            _ => query.OrderBy(x => x.Name)
        };
    }
}
