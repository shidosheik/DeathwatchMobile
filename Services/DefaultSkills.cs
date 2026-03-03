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

        // =====================
        // SKILLS [TRAINED]
        // =====================

        new Skill { Name="Acrobatics", Governing="Ag", Training=SkillTraining.Untrained },
        new Skill { Name="Blather", Governing="Fel", Training=SkillTraining.Untrained },
        new Skill { Name="Chem-Use", Governing="Int", Training=SkillTraining.Untrained },

        new Skill { Name="Demolition", Governing="Int", Training=SkillTraining.Untrained },

        new Skill { Name="Interrogation", Governing="WP", Training=SkillTraining.Untrained },
        new Skill { Name="Invocation", Governing="WP", Training=SkillTraining.Untrained },
        new Skill { Name="Lip Reading", Governing="Per", Training=SkillTraining.Untrained },
        new Skill { Name="Literacy", Governing="Int", Training=SkillTraining.Untrained },

        new Skill { Name="Medicae", Governing="Int", Training=SkillTraining.Untrained },

        new Skill { Name="Psyniscience", Governing="Per", Training=SkillTraining.Untrained },
        new Skill { Name="Security", Governing="Ag", Training=SkillTraining.Untrained },

        new Skill { Name="Shadowing", Governing="Ag", Training=SkillTraining.Untrained },
        new Skill { Name="Sleight of Hand", Governing="Ag", Training=SkillTraining.Untrained },

        new Skill { Name="Survival", Governing="Int", Training=SkillTraining.Untrained },
        new Skill { Name="Tech-Use", Governing="Int", Training=SkillTraining.Untrained },
        new Skill { Name="Tracking", Governing="Int", Training=SkillTraining.Untrained },

        // =====================
        // CIPHERS
        // =====================

        new Skill { Name="Ciphers (Chapter Runes)", Governing="Int", Training=SkillTraining.Trained },

        // =====================
        // COMMON LORE
        // =====================

        new Skill { Name="Common Lore (Adeptus Astartes)", Governing="Int", Training=SkillTraining.Trained },
        new Skill { Name="Common Lore (Deathwatch)", Governing="Int", Training=SkillTraining.Trained },
        new Skill { Name="Common Lore (Imperium)", Governing="Int", Training=SkillTraining.Trained },
        new Skill { Name="Common Lore (War)", Governing="Int", Training=SkillTraining.Trained },

        // =====================
        // DRIVE
        // =====================

        new Skill { Name="Drive (Ground Vehicles)", Governing="Ag", Training=SkillTraining.Trained },

        // =====================
        // FORBIDDEN LORE
        // =====================

        new Skill { Name="Forbidden Lore (Xenos)", Governing="Int", Training=SkillTraining.Trained },

        // =====================
        // NAVIGATION
        // =====================

        new Skill { Name="Navigation (Surface)", Governing="Int", Training=SkillTraining.Trained },

        // =====================
        // SCHOLASTIC LORE
        // =====================

        new Skill { Name="Scholastic Lore (Codex Astartes)", Governing="Int", Training=SkillTraining.Trained },

        // =====================
        // SECRET TONGUE
        // =====================

        // (No visible subsection in your screenshot, add if needed)

        // =====================
        // SPEAK LANGUAGE
        // =====================

        new Skill { Name="Speak Language (High Gothic)", Governing="Int", Training=SkillTraining.Trained },
        new Skill { Name="Speak Language (Low Gothic)", Governing="Int", Training=SkillTraining.Trained },

        // =====================
        // TACTICS
        // =====================

        // Add if you want Assault/Defensive/Void later
     
        // =====================
        // TRADE
        // =====================

        // Add specific trades later if needed

    };
}