namespace DeathwatchMobile.Models;

public sealed class Character
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public int SchemaVersion { get; set; } = 1;

    // Identity
    public string Name { get; set; } = "";
    public string Chapter { get; set; } = "";
    public string Specialty { get; set; } = "";
    public string Demeanor { get; set; } = "";
    public int Rank { get; set; } = 1;
    public string Renown { get; set; } = "Initiate";

    // Characteristics (Base + Advances)
    public StatBlock WS { get; set; } = new();
    public StatBlock BS { get; set; } = new();
    public StatBlock S  { get; set; } = new();
    public StatBlock T  { get; set; } = new();
    public StatBlock Ag { get; set; } = new();
    public StatBlock Int { get; set; } = new();
    public StatBlock Per { get; set; } = new();
    public StatBlock WP { get; set; } = new();
    public StatBlock Fel { get; set; } = new();

    public int StrengthBonus => (S.Total / 10);
    public int ToughnessBonus => (T.Total / 10);

    // Trackers
    public int WoundsMax { get; set; } = 0;
    public int WoundsCurrent { get; set; } = 0;
    public int FateMax { get; set; } = 0;
    public int FateCurrent { get; set; } = 0;

    // Movement (editable; we can add auto-calc later)
    public int MoveHalf { get; set; } = 0;
    public int MoveFull { get; set; } = 0;
    public int MoveCharge { get; set; } = 0;
    public int MoveRun { get; set; } = 0;

    public List<Skill> Skills { get; set; } = new();

    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedUtc { get; set; } = DateTime.UtcNow;

    public int GetCharacteristicTotal(string code) => code switch
    {
        "WS" => WS.Total,
        "BS" => BS.Total,
        "S"  => S.Total,
        "T"  => T.Total,
        "Ag" => Ag.Total,
        "Int" => Int.Total,
        "Per" => Per.Total,
        "WP" => WP.Total,
        "Fel" => Fel.Total,
        _ => 0
    };

    public int SkillTarget(Skill s)
    {
        var baseVal = GetCharacteristicTotal(s.Governing);

        var trainingBonus = s.Training switch
        {
            SkillTraining.Untrained => -20,   // common DW convention
            SkillTraining.Trained => 0,
            SkillTraining.Plus10 => 10,
            SkillTraining.Plus20 => 20,
            _ => 0
        };

        return baseVal + trainingBonus + s.MiscMod;
    }
}

public sealed class StatBlock
{
    public int Base { get; set; } = 0;
    public int Advances { get; set; } = 0;
    public int PowerAssist { get; set; } = 0; // can be + or -
    public int Total => Base + Advances + PowerAssist;

    // Deathwatch-style “bonus” (tens digit)
    public int Bonus => Total / 10;
}

