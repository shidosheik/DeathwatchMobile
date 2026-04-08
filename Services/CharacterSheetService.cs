using DeathwatchMobile.Models;

namespace DeathwatchMobile.Services;

public sealed class CharacterSheetService
{
    public string RollStat(string statName, int target, Random rng)
    {
        var roll = rng.Next(1, 101);
        return roll <= target
            ? $"{statName} SUCCESS: {roll} ≤ {target}"
            : $"{statName} FAIL: {roll} > {target}";
    }

    public string RollSkill(Character? character, Skill skill, Random rng)
    {
        if (character is null)
            return string.Empty;

        var target = character.SkillTarget(skill);
        var roll = rng.Next(1, 101);

        return roll <= target
            ? $"{skill.Name} SUCCESS: {roll} ≤ {target}"
            : $"{skill.Name} FAIL: {roll} > {target}";
    }

    public HitLocationResult RollHitLocation(Character? character, Random rng)
    {
        var attackRoll = rng.Next(1, 101);
        var reversed = ReverseD100(attackRoll);
        var location = GetHitLocation(reversed);
        var armor = GetArmorForLocation(character, location);

        return new HitLocationResult(
            attackRoll,
            location,
            armor,
            $"Roll: {attackRoll:00} → Hit Location: {location} → Armor: {armor}");
    }

    private static int ReverseD100(int value)
    {
        if (value == 100)
            return 100;

        var tens = value / 10;
        var ones = value % 10;

        return (ones * 10) + tens;
    }

    private static string GetHitLocation(int reversedRoll)
    {
        if (reversedRoll >= 1 && reversedRoll <= 10) return "Head";
        if (reversedRoll <= 20) return "Right Arm";
        if (reversedRoll <= 30) return "Left Arm";
        if (reversedRoll <= 70) return "Body";
        if (reversedRoll <= 85) return "Right Leg";

        return "Left Leg";
    }

    private static int GetArmorForLocation(Character? character, string location) => location switch
    {
        "Head" => character?.ArmorHead ?? 0,
        "Right Arm" => character?.ArmorRightArm ?? 0,
        "Left Arm" => character?.ArmorLeftArm ?? 0,
        "Body" => character?.ArmorBody ?? 0,
        "Right Leg" => character?.ArmorRightLeg ?? 0,
        "Left Leg" => character?.ArmorLeftLeg ?? 0,
        _ => 0
    };
}

public sealed record HitLocationResult(int AttackRoll, string Location, int ArmorValue, string Message);
