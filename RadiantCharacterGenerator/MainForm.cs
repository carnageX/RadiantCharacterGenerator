using System;
using System.Drawing;
using MenustripRenderer;
using System.Windows.Forms;
using System.Collections.Generic;
using GenerateRandomSkyrimCharacter;

namespace RadiantCharacterGenerator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private string race;
		private string primarySkill;
		private string style;
		private string affliction;
		private string previousCharacterGen = "Previous Character:\nNone";
		private List<string> armor = new List<string>(); //0 to 2
		private List<string> weapon = new List<string>(); //0 to 13
		private List<string> miscSkills = new List<string>(); //0 to 10
		private int generateCount = 0;
		
		public MainForm()
		{
			InitializeComponent();
			
			//uses custom class to remove border below menustrip
			this.mainMenu.Renderer = new MySR(); 
			
			labelRaceDisplay.Hide();
			labelStyleDisplay.Hide();
			labelPrimarySkillDisplay.Hide();
			labelAfflictionDisplay.Hide();
			labelHoverInfo.Text = this.previousCharacterGen;

			listSkills.Items.Clear();
			listWeapons.Items.Clear();
			listArmorType.Items.Clear();
		}

		void ButtonGenerateClick(object sender, EventArgs e)
		{
			CharacterGenerator charGen = new CharacterGenerator();
			
			SetPreviousCharacter();
			
			listSkills.Items.Clear();
			listWeapons.Items.Clear();
			listArmorType.Items.Clear();

			this.race = charGen.GetRace();
			this.style = charGen.GetStyle();
			this.armor = charGen.GetArmor();
			this.weapon = charGen.GetWeapons();
			this.miscSkills = charGen.GetMisc();
			this.primarySkill = this.GetPrimarySkill();
			this.affliction = charGen.GetAffliction();
			
			//fill labels
			labelRaceDisplay.Text = this.race;
			labelStyleDisplay.Text = this.style;
			labelPrimarySkillDisplay.Text = this.primarySkill;
			labelAfflictionDisplay.Text = this.affliction;

			listSkills = listPopulate(listSkills, this.miscSkills);
			listArmorType = listPopulate(listArmorType, this.armor);
			listWeapons = listPopulate(listWeapons, this.weapon);
			
			labelHoverInfo.Text = this.previousCharacterGen;
			
			//display labels
			labelRaceDisplay.Show();
			labelStyleDisplay.Show();
			labelPrimarySkillDisplay.Show();
			labelAfflictionDisplay.Show();
		}
		
		string GetPrimarySkill()
		{
			string primary = String.Empty;

			if(this.style == "Warrior")
			{
				primary = "Block";
			}
			else if(this.style == "Mage")
			{
				primary = "Conjuration";
			}
			else if(this.style == "Stealth")
			{
				primary = "Sneak";
			}
			else if(this.style == "Random")
			{
				primary = "See Skill List below.";
			}
			return primary;
		}

		ListBox listPopulate(ListBox items, List<string> strings)
		{
			foreach (string s in strings)
			{
				items.Items.Add(s);
			}
			return items;
		}

		#region mouse hover infos
		private void labelRace_MouseEnter(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelHoverInfo.Text = "A random race is chosen.  Available races are: Altmer, Argonian, Bosmer," +
				"Breton, Dunmer, Imperial, Khajiit, ord, Orsimer, or Redguard";
		}

		private void labelRace_MouseLeave(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelHoverInfo.Text = this.previousCharacterGen;
		}

		private void labelRaceDisplay_MouseEnter(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelHoverInfo.Text = "A random race is chosen.  Available races are: Altmer, Argonian, Bosmer," +
				"Breton, Dunmer, Imperial, Khajiit, ord, Orsimer, or Redguard";
		}

		private void labelRaceDisplay_MouseLeave(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelHoverInfo.Text = this.previousCharacterGen;
		}

		private void labelStyle_MouseEnter(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelHoverInfo.Text = "Warrior, Stealth, Mage, or Random.  Each has a \"primary\" skill assigned.";
		}

		private void labelStyle_MouseLeave(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelHoverInfo.Text = this.previousCharacterGen;
		}

		private void labelStyleDisplay_MouseEnter(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelHoverInfo.Text = "Warrior, Stealth, Mage, or Random.  Each has a \"primary\" skill assigned.";
		}

		private void labelStyleDisplay_MouseLeave(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelHoverInfo.Text = this.previousCharacterGen;
		}

		private void labelArmorType_MouseEnter(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelHoverInfo.Text = "Available armor types are: Heavy Armor, Light Armor, and None.";
		}

		private void labelArmorType_MouseLeave(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelHoverInfo.Text = this.previousCharacterGen;
		}

		private void listArmorType_MouseEnter(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelHoverInfo.Text = "Available armor types are: Heavy Armor, Light Armor, and None.";
		}

		private void listArmorType_MouseLeave(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelHoverInfo.Text = this.previousCharacterGen;
		}

		private void labelPrimarySkill_MouseEnter(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelHoverInfo.Text = "Primary skills for each style are assigned as follows:\nWarrior: Block\nStealth: Sneak\nMage: Conjuration.";
		}

		private void labelPrimarySkill_MouseLeave(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelHoverInfo.Text = this.previousCharacterGen;
		}

		private void labelPrimarySkillDisplay_MouseEnter(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelHoverInfo.Text = "Primary skills for each style are assigned as follows:\nWarrior: Block\nStealth: Sneak\nMage: Conjuration.";
		}

		private void labelPrimarySkillDisplay_MouseLeave(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelHoverInfo.Text = this.previousCharacterGen;
		}

		private void labelWeapon_MouseEnter(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelHoverInfo.Text = "Two categories will be chosen from: melee and range.  Melee includes: unarmed, one-handed, and two-handed weapons."
				+ "Range includes both bows and magic.";
		}

		private void labelWeapon_MouseLeave(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelHoverInfo.Text = this.previousCharacterGen;
		}

		private void listWeapons_MouseEnter(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelHoverInfo.Text = "Two categories will be chosen from: melee and range.  Melee includes: unarmed, one-handed, and two-handed weapons."
				+ "Range includes both bows and magic.";
		}
		
		private void listWeapons_MouseLeave(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelHoverInfo.Text = this.previousCharacterGen;
		}

		private void labelSkillList_MouseEnter(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelHoverInfo.Text = "Miscellaneous skills may also be randomly selected in addition to the primary skill.";
		}

		private void labelSkillList_MouseLeave(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelHoverInfo.Text = this.previousCharacterGen;
		}

		private void listSkills_MouseEnter(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelHoverInfo.Text = "Miscellaneous skills may also be randomly selected in addition to the primary skill.";
		}


		private void listSkills_MouseLeave(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelHoverInfo.Text = this.previousCharacterGen;
		}
		
		private void imageSkyrim_MouseEnter(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelHoverInfo.Text = "FUS ROH DAH!";
		}

		private void imageSkyrim_MouseLeave(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelHoverInfo.Text = this.previousCharacterGen;
		}
		
		void LabelAfflictionMouseHover(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelHoverInfo.Text = "Affliction that can be chosen by player.  Candidates are: " +
				"Lycanthropy, Vampirism, or None.  If an affliction is gained " +
				"while 'None' is generated (or the opposite affliction is " +
				"contracted), player must start over.\n\nVampire Lord or " +
				"standard vampirism both count toward Vampirism affliction";
		}

		void LabelAfflictionMouseLeave(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelHoverInfo.Text = this.previousCharacterGen;
		}
		
		void LabelAfflictionDisplayMouseHover(object sender, EventArgs e)
		{
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelHoverInfo.Text = "Affliction that can be chosen by player.  Candidates are: " +
				"Lycanthropy, Vampirism, or None.  If an affliction is gained " +
				"while 'None' is generated (or the opposite affliction is " +
				"contracted), player must start over.\n\nVampire Lord or " +
				"standard vampirism both count toward Vampirism affliction";
		}
		
		void LabelAfflictionDisplayMouseLeave(object sender, EventArgs e)
		{
			this.labelHoverInfo.Text = this.previousCharacterGen;
			labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		}
		#endregion

		private void generateCharacterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ButtonGenerateClick(sender, e);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		void ButtonCopyClipboardClick(object sender, EventArgs e)
		{
			if(this.generateCount > 0)
			{
				string clipboardText = SetText();
				Clipboard.SetText(clipboardText);
			}
			else
			{
				MessageBox.Show("Generate a character build before copying!", 
				                "Error! Nothing to copy!", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Exclamation, 
				                MessageBoxDefaultButton.Button1);
			}
		}
		
		private void SetPreviousCharacter()
		{
			if(this.generateCount >= 1)
			{
				this.previousCharacterGen = "Previous character build:\n";
				this.previousCharacterGen += SetText();
				labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			}
			this.generateCount++;
		}

		private string SetText()
		{
			string outString = String.Empty;
			outString += "Race: " + this.race;
			outString += "\nStyle: " + this.style;
			outString += "\nArmor: ";
			for (int i = 0; i < this.armor.Count; i++) 
			{
				outString += "\n" + this.armor[i];
			}
			outString += "\nPrimary Skill: " + this.primarySkill;
			outString += "\nWeapon(s): ";
			for (int i = 0; i < this.weapon.Count; i++) 
			{
				outString += "\n" + this.weapon[i];
			}
			outString += "\nMisc Skill(s): ";
			for (int i = 0; i < this.miscSkills.Count; i++) 
			{
				outString += "\n" + this.miscSkills[i];
			}
			outString += "\nAffliction: " + this.affliction;
			return outString;
		}
		
		void CopyToClipboardToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.ButtonCopyClipboardClick(sender, e);
		}
		
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			AboutScreen about = new AboutScreen();
			about.ShowDialog(this);
		}
	}//class
}//namespace
