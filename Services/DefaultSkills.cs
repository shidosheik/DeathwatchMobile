using DeathwatchMobile.Models;

namespace DeathwatchMobile.Services;

public static class DefaultSkills
{
    public static List<Skill> Create() => new()
    {
        new Skill { Name="Awareness", Governing="Per", Training=SkillTraining.Trained },
        new Skill { Name="Barter", Governing="Fel", Training=SkillTraining.Untrained },
        new Skill { Name="Carouse", Governing="T", Training=SkillTraining.Untrained },
        new Skill { Name="Charm", Governing="Fel", Training=SkillTraining.Untrained },
        new Skill { Name="Climb", Governing="S", Training=SkillTraining.Trained },
        new Skill { Name="Command", Governing="Fel", Training=SkillTraining.Untrained },
        new Skill { Name="Concealment", Governing="Ag", Training=SkillTraining.Trained },
        new Skill { Name="Contortionist", Governing="Ag", Training=SkillTraining.Untrained },
        new Skill { Name="Deceive", Governing="Fel", Training=SkillTraining.Untrained },
        new Skill { Name="Disguise", Governing="Fel", Training=SkillTraining.Untrained },
        new Skill { Name="Dodge", Governing="Ag", Training=SkillTraining.Untrained },
        new Skill { Name="Evaluate", Governing="Int", Training=SkillTraining.Untrained },
        new Skill { Name="Gamble", Governing="Int", Training=SkillTraining.Untrained },
        new Skill { Name="Inquiry", Governing="Fel", Training=SkillTraining.Untrained },
        new Skill { Name="Logic", Governing="Int", Training=SkillTraining.Untrained },
        new Skill { Name="Scrutiny", Governing="Per", Training=SkillTraining.Untrained },
        new Skill { Name="Search", Governing="Per", Training=SkillTraining.Untrained },
        new Skill { Name="Silent Move", Governing="Ag", Training=SkillTraining.Trained },
        new Skill { Name="Swim", Governing="S", Training=SkillTraining.Untrained },

        new Skill { Name="Medicae", Governing="Int", Training=SkillTraining.Untrained },
        new Skill { Name="Tech-Use", Governing="Int", Training=SkillTraining.Untrained },
        // add more as you like
    };
}