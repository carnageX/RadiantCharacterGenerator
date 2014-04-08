using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace GenerateRandomSkyrimCharacter
{
    class CharacterGenerator
    {
        private enum Race
        {
            Altmer,
            Argonian,
            Bosmer,
            Breton,
            Dunmer,
            Imperial,
            Khajiit,
            Nord,
            Orsimer,
            Redguard
        }
        private enum Skills
        {
            None,
            Alchemy,
            Alteration,
            Archery,
            Block,
            Conjuration,
            DestructionFireSpells,
            DestructionFrostSpells,
            DestructionShockSpells,
            Enchanting,
            HeavyArmor,
            Illusion,
            LightArmor,
            Lockpicking,
            OneHandedDaggers,
            OneHandedMaces,
            OneHandedSwords,
            OneHandedWarAxes,
            Pickpocket,
            Restoration,
            Smithing,
            Sneak,
            Speech,
            TwoHandedBattleaxes,
            TwoHandedGreatswords,
            TwoHandedWarhammers
        }
        private enum MeleeWeapons
        {
            None,
            OneHandedDaggers,
            OneHandedMaces,
            OneHandedSwords,
            OneHandedWarAxes,
            TwoHandedBattleaxes,
            TwoHandedGreatswords,
            TwoHandedWarhammers
        }
        private enum RangeWeapons
        {
            None,
            Archery,
            DestructionFireSpells,
            DestructionFrostSpells,
            DestructionShockSpells,
        }
        private enum Affliction
        {
        	None,
        	Lycanthropy,
        	Vampirism
        }
        private const int NUMBER_OF_RACES = 9;
        private const int NUMBER_OF_SKILLS = 25;
        private const int NUMBER_OF_MELEE_WEAPONS = 8;
        private const int NUMBER_OF_RANGE_WEAPONS = 5;
        private const int NUMBER_OF_AFFLICTIONS = 3;
        private Random rand = new Random();
        private Race race;
        private List<Skills> skills = new List<Skills>();
        private string style = string.Empty;
        private Affliction affliction;

        public CharacterGenerator()
        {
            GenerateRace();
            GenerateSkills();
            GenerateAffliction();
        }

        public string GetRace()
        {
            return GetRaceName(this.race);
        }

        public List<string> GetSkills()
        {
            List<string> skills = new List<string>();

            foreach (Skills s in this.skills)
            {
                skills.Add(GetSkillName(s));
            }

            return skills;
        }

        public List<string> GetWeapons()
        {
            List<string> weapons = new List<string>();
            foreach (Skills s in this.skills)
            {
                if (IsWeapon(s))
                {
                    weapons.Add(GetSkillName(s));
                }
            }
            return weapons;
        }

        public List<string> GetArmor()
        {
            List<string> armor = new List<string>();
            foreach (Skills s in this.skills)
            {
                if (IsArmor(s))
                {
                    armor.Add(GetSkillName(s));
                }
            }
            
            if(armor.Count == 0)
            {
            	armor.Add("None");
            }
            return armor;
        }

        public List<string> GetMisc()
        {
            List<string> armor = new List<string>();
            foreach (Skills s in this.skills)
            {
                if (!IsArmor(s) && !IsWeapon(s))
                {
                    armor.Add(GetSkillName(s));
                }
            }
            return armor;
        }

        public string GetStyle()
        {
            return this.style;
        }
        
        public string GetAffliction()
        {
        	return GetAfflictionName(this.affliction);
        }

        private void GenerateRace()
        {
            this.race = (Race)this.rand.Next(NUMBER_OF_RACES);
        }

        private void GenerateSkills()
        {
            GenerateStyle();
            GenerateWeapons();
            GenerateMiscSkills();
        }

        private void GenerateStyle()
        {
            int randNum = this.rand.Next(4);

            switch (randNum)
            {
                case 0:
                    this.style = "Warrior";
                    AddSkill(Skills.HeavyArmor);
                    AddSkill(Skills.Block);
                    break;
                case 1:
                    this.style = "Stealth";
                    AddSkill(Skills.LightArmor);
                    AddSkill(Skills.Sneak);
                    break;
                case 2:
                    this.style = "Mage";
                    AddSkill(Skills.Alteration);
                    AddSkill(Skills.Conjuration);
                    break;
                case 3:
                    this.style = "Random";
                    GenerateRandomSkill();
                    GenerateRandomSkill();
                    break;
            }
        }

        private void GenerateWeapons()
        {
            GenerateMeleeWeapons();
            GenerateRangeWeapons();
        }

        private void GenerateMeleeWeapons()
        {
            MeleeWeapons wep = (MeleeWeapons)rand.Next(NUMBER_OF_MELEE_WEAPONS);

            switch (wep)
            {
                case MeleeWeapons.None:
                    break;
                case MeleeWeapons.OneHandedDaggers:
                    AddSkill(Skills.OneHandedDaggers);
                    break;
                case MeleeWeapons.OneHandedMaces:
                    AddSkill(Skills.OneHandedMaces);
                    break;
                case MeleeWeapons.OneHandedSwords:
                    AddSkill(Skills.OneHandedSwords);
                    break;
                case MeleeWeapons.OneHandedWarAxes:
                    AddSkill(Skills.OneHandedWarAxes);
                    break;
                case MeleeWeapons.TwoHandedBattleaxes:
                    AddSkill(Skills.TwoHandedBattleaxes);
                    break;
                case MeleeWeapons.TwoHandedGreatswords:
                    AddSkill(Skills.TwoHandedGreatswords);
                    break;
                case MeleeWeapons.TwoHandedWarhammers:
                    AddSkill(Skills.TwoHandedWarhammers);
                    break;
            }
        }

        private void GenerateRangeWeapons()
        {
            RangeWeapons wep = (RangeWeapons)rand.Next(NUMBER_OF_RANGE_WEAPONS);

            switch (wep)
            {
                case RangeWeapons.None:
                    break;
                case RangeWeapons.Archery:
                    AddSkill(Skills.Archery);
                    break;
                case RangeWeapons.DestructionFireSpells:
                    AddSkill(Skills.DestructionFireSpells);
                    break;
                case RangeWeapons.DestructionFrostSpells:
                    AddSkill(Skills.DestructionFrostSpells);
                    break;
                case RangeWeapons.DestructionShockSpells:
                    AddSkill(Skills.DestructionShockSpells);
                    break;
            }
        }

        private void GenerateMiscSkills()
        {
            int randNum = this.rand.Next(6);

            for (int i = 0; i < randNum; i++)
            {
                GenerateRandomSkill();
            }
        }
        
        private void GenerateAffliction()
        {
        	this.affliction = (Affliction)this.rand.Next(NUMBER_OF_AFFLICTIONS);
        }

        private void GenerateRandomSkill()
        {
            Skills skill = (Skills)rand.Next(NUMBER_OF_SKILLS);
            AddSkill(skill);
        }

        private void AddSkill(Skills skill)
        {
            if (skill != Skills.None && !skills.Contains(skill))
            {
                this.skills.Add(skill);
            }
        }

        private static string GetRaceName(Race race)
        {
            string raceName = string.Empty;
            switch (race)
            {
                case Race.Altmer:
                    raceName = "Altmer";
                    break;
                case Race.Argonian:
                    raceName = "Argonian";
                    break;
                case Race.Bosmer:
                    raceName = "Bosmer";
                    break;
                case Race.Breton:
                    raceName = "Breton";
                    break;
                case Race.Dunmer:
                    raceName = "Dunmer";
                    break;
                case Race.Imperial:
                    raceName = "Imperial";
                    break;
                case Race.Khajiit:
                    raceName = "Khajiit";
                    break;
                case Race.Nord:
                    raceName = "Nord";
                    break;
                case Race.Orsimer:
                    raceName = "Orsimer";
                    break;
                case Race.Redguard:
                    raceName = "Redguard";
                    break;
            }
            return raceName;
        }

        private static string GetSkillName(Skills skill)
        {
            string skillName = string.Empty;
            switch (skill)
            {
                case Skills.None:
                    break;
                case Skills.Alchemy:
                    skillName = "Alchemy";
                    break;
                case Skills.Alteration:
                    skillName = "Alteration";
                    break;
                case Skills.Archery:
                    skillName = "Archery";
                    break;
                case Skills.Block:
                    skillName = "Block";
                    break;
                case Skills.Conjuration:
                    skillName = "Conjuration";
                    break;
                case Skills.DestructionFireSpells:
                    skillName = "Destruction: Fire Spells";
                    break;
                case Skills.DestructionFrostSpells:
                    skillName = "Destruction: Frost Spells";
                    break;
                case Skills.DestructionShockSpells:
                    skillName = "Destruction: Shock Spells";
                    break;
                case Skills.Enchanting:
                    skillName = "Enchanting";
                    break;
                case Skills.HeavyArmor:
                    skillName = "Heavy Armor";
                    break;
                case Skills.Illusion:
                    skillName = "Illusion";
                    break;
                case Skills.LightArmor:
                    skillName = "Light Armor";
                    break;
                case Skills.Lockpicking:
                    skillName = "Lockpicking";
                    break;
                case Skills.OneHandedDaggers:
                    skillName = "One-Handed: Daggers";
                    break;
                case Skills.OneHandedMaces:
                    skillName = "One-Handed: Maces";
                    break;
                case Skills.OneHandedSwords:
                    skillName = "One-Handed: Swords";
                    break;
                case Skills.OneHandedWarAxes:
                    skillName = "One-Handed: War Axes";
                    break;
                case Skills.Pickpocket:
                    skillName = "Pickpocket";
                    break;
                case Skills.Restoration:
                    skillName = "Restoration";
                    break;
                case Skills.Smithing:
                    skillName = "Smithing";
                    break;
                case Skills.Sneak:
                    skillName = "Sneak";
                    break;
                case Skills.Speech:
                    skillName = "Speech";
                    break;
                case Skills.TwoHandedBattleaxes:
                    skillName = "Two-Handed: Battleaxes";
                    break;
                case Skills.TwoHandedGreatswords:
                    skillName = "Two-Handed: Greatswords";
                    break;
                case Skills.TwoHandedWarhammers:
                    skillName = "Two-Handed: Warhammers";
                    break;
            }
            return skillName;
        }
        
        private static string GetAfflictionName(Affliction disease)
        {
        	string afflictionName = String.Empty;
        	
        	switch(disease)
        	{
        		case Affliction.None:
        			afflictionName = "None";
        			break;
        		case Affliction.Lycanthropy:
        			afflictionName = "Lycanthropy";
        			break;
        		case Affliction.Vampirism:
        			afflictionName = "Vampirism";
        			break;
        	}
        	return afflictionName;
        }

        private bool IsWeapon(Skills skill)
        {
            bool isWeapon = false;
            switch (skill)
            {
                case Skills.Archery:
                case Skills.DestructionFireSpells:
                case Skills.DestructionFrostSpells:
                case Skills.DestructionShockSpells:
                case Skills.OneHandedDaggers:
                case Skills.OneHandedMaces:
                case Skills.OneHandedSwords:
                case Skills.OneHandedWarAxes:
                case Skills.TwoHandedBattleaxes:
                case Skills.TwoHandedGreatswords:
                case Skills.TwoHandedWarhammers:
                    isWeapon = true;
                    break;
                case Skills.None:
                case Skills.Alchemy:
                case Skills.Alteration:
                case Skills.Block:
                case Skills.Conjuration:
                case Skills.Enchanting:
                case Skills.HeavyArmor:
                case Skills.Illusion:
                case Skills.LightArmor:
                case Skills.Lockpicking:
                case Skills.Pickpocket:
                case Skills.Restoration:
                case Skills.Smithing:
                case Skills.Sneak:
                case Skills.Speech:
                    break;
            }
            return isWeapon;
        }

        private bool IsArmor(Skills skill)
        {
            bool isArmor = false;
            if (skill == Skills.HeavyArmor || skill == Skills.LightArmor)
            {
                isArmor = true;
            }
            return isArmor;
        }
    }
}
