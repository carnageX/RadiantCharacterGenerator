/*
 * Created by SharpDevelop.
 * User: cbennet
 * Date: 12/17/2012
 * Time: 3:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace RadiantCharacterGenerator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelRace = new System.Windows.Forms.Label();
			this.labelStyle = new System.Windows.Forms.Label();
			this.labelArmorType = new System.Windows.Forms.Label();
			this.labelPrimarySkill = new System.Windows.Forms.Label();
			this.labelWeapon = new System.Windows.Forms.Label();
			this.buttonGenerate = new System.Windows.Forms.Button();
			this.labelSkillList = new System.Windows.Forms.Label();
			this.listSkills = new System.Windows.Forms.ListBox();
			this.groupChar = new System.Windows.Forms.GroupBox();
			this.labelAfflictionDisplay = new System.Windows.Forms.Label();
			this.labelAffliction = new System.Windows.Forms.Label();
			this.listWeapons = new System.Windows.Forms.ListBox();
			this.listArmorType = new System.Windows.Forms.ListBox();
			this.labelPrimarySkillDisplay = new System.Windows.Forms.Label();
			this.labelStyleDisplay = new System.Windows.Forms.Label();
			this.labelRaceDisplay = new System.Windows.Forms.Label();
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generateCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupInfo = new System.Windows.Forms.GroupBox();
			this.labelHoverInfo = new System.Windows.Forms.Label();
			this.imageSkyrim = new System.Windows.Forms.Panel();
			this.buttonCopyClipboard = new System.Windows.Forms.Button();
			this.captionCopyButton = new System.Windows.Forms.ToolTip(this.components);
			this.groupChar.SuspendLayout();
			this.mainMenu.SuspendLayout();
			this.groupInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelRace
			// 
			this.labelRace.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.labelRace.Location = new System.Drawing.Point(6, 18);
			this.labelRace.Name = "labelRace";
			this.labelRace.Size = new System.Drawing.Size(40, 15);
			this.labelRace.TabIndex = 0;
			this.labelRace.Text = "Race: ";
			this.labelRace.MouseEnter += new System.EventHandler(this.labelRace_MouseEnter);
			this.labelRace.MouseLeave += new System.EventHandler(this.labelRace_MouseLeave);
			// 
			// labelStyle
			// 
			this.labelStyle.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.labelStyle.Location = new System.Drawing.Point(6, 33);
			this.labelStyle.Name = "labelStyle";
			this.labelStyle.Size = new System.Drawing.Size(40, 17);
			this.labelStyle.TabIndex = 1;
			this.labelStyle.Text = "Style: ";
			this.labelStyle.MouseEnter += new System.EventHandler(this.labelStyle_MouseEnter);
			this.labelStyle.MouseLeave += new System.EventHandler(this.labelStyle_MouseLeave);
			// 
			// labelArmorType
			// 
			this.labelArmorType.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.labelArmorType.Location = new System.Drawing.Point(6, 80);
			this.labelArmorType.Name = "labelArmorType";
			this.labelArmorType.Size = new System.Drawing.Size(66, 23);
			this.labelArmorType.TabIndex = 2;
			this.labelArmorType.Text = "Armor Type: ";
			this.labelArmorType.MouseEnter += new System.EventHandler(this.labelArmorType_MouseEnter);
			this.labelArmorType.MouseLeave += new System.EventHandler(this.labelArmorType_MouseLeave);
			// 
			// labelPrimarySkill
			// 
			this.labelPrimarySkill.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.labelPrimarySkill.Location = new System.Drawing.Point(6, 50);
			this.labelPrimarySkill.Name = "labelPrimarySkill";
			this.labelPrimarySkill.Size = new System.Drawing.Size(66, 19);
			this.labelPrimarySkill.TabIndex = 3;
			this.labelPrimarySkill.Text = "Primary Skill: ";
			this.labelPrimarySkill.MouseEnter += new System.EventHandler(this.labelPrimarySkill_MouseEnter);
			this.labelPrimarySkill.MouseLeave += new System.EventHandler(this.labelPrimarySkill_MouseLeave);
			// 
			// labelWeapon
			// 
			this.labelWeapon.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.labelWeapon.Location = new System.Drawing.Point(6, 114);
			this.labelWeapon.Name = "labelWeapon";
			this.labelWeapon.Size = new System.Drawing.Size(56, 23);
			this.labelWeapon.TabIndex = 5;
			this.labelWeapon.Text = "Weapon: ";
			this.labelWeapon.MouseEnter += new System.EventHandler(this.labelWeapon_MouseEnter);
			this.labelWeapon.MouseLeave += new System.EventHandler(this.labelWeapon_MouseLeave);
			// 
			// buttonGenerate
			// 
			this.buttonGenerate.BackColor = System.Drawing.SystemColors.Control;
			this.buttonGenerate.Location = new System.Drawing.Point(279, 332);
			this.buttonGenerate.Name = "buttonGenerate";
			this.buttonGenerate.Size = new System.Drawing.Size(119, 32);
			this.buttonGenerate.TabIndex = 0;
			this.buttonGenerate.Text = "Generate Character";
			this.buttonGenerate.UseVisualStyleBackColor = false;
			this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerateClick);
			// 
			// labelSkillList
			// 
			this.labelSkillList.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.labelSkillList.Location = new System.Drawing.Point(6, 301);
			this.labelSkillList.Name = "labelSkillList";
			this.labelSkillList.Size = new System.Drawing.Size(60, 23);
			this.labelSkillList.TabIndex = 7;
			this.labelSkillList.Text = "Misc Skills:";
			this.labelSkillList.MouseEnter += new System.EventHandler(this.labelSkillList_MouseEnter);
			this.labelSkillList.MouseLeave += new System.EventHandler(this.labelSkillList_MouseLeave);
			// 
			// listSkills
			// 
			this.listSkills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
			this.listSkills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listSkills.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.listSkills.FormattingEnabled = true;
			this.listSkills.Items.AddRange(new object[] {
									"skill1",
									"skill2",
									"skill3",
									"skill4",
									"skill5",
									"skill6"});
			this.listSkills.Location = new System.Drawing.Point(74, 305);
			this.listSkills.Name = "listSkills";
			this.listSkills.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.listSkills.Size = new System.Drawing.Size(159, 132);
			this.listSkills.TabIndex = 9;
			this.listSkills.TabStop = false;
			this.listSkills.MouseEnter += new System.EventHandler(this.listSkills_MouseEnter);
			this.listSkills.MouseLeave += new System.EventHandler(this.listSkills_MouseLeave);
			// 
			// groupChar
			// 
			this.groupChar.BackColor = System.Drawing.Color.Transparent;
			this.groupChar.Controls.Add(this.labelAfflictionDisplay);
			this.groupChar.Controls.Add(this.labelAffliction);
			this.groupChar.Controls.Add(this.listWeapons);
			this.groupChar.Controls.Add(this.listArmorType);
			this.groupChar.Controls.Add(this.labelWeapon);
			this.groupChar.Controls.Add(this.labelPrimarySkill);
			this.groupChar.Controls.Add(this.labelPrimarySkillDisplay);
			this.groupChar.Controls.Add(this.labelStyleDisplay);
			this.groupChar.Controls.Add(this.labelRaceDisplay);
			this.groupChar.Controls.Add(this.listSkills);
			this.groupChar.Controls.Add(this.labelRace);
			this.groupChar.Controls.Add(this.labelSkillList);
			this.groupChar.Controls.Add(this.labelArmorType);
			this.groupChar.Controls.Add(this.labelStyle);
			this.groupChar.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.groupChar.Location = new System.Drawing.Point(12, 27);
			this.groupChar.Name = "groupChar";
			this.groupChar.Size = new System.Drawing.Size(243, 486);
			this.groupChar.TabIndex = 10;
			this.groupChar.TabStop = false;
			this.groupChar.Text = "Random Character Stats";
			// 
			// labelAfflictionDisplay
			// 
			this.labelAfflictionDisplay.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.labelAfflictionDisplay.Location = new System.Drawing.Point(74, 450);
			this.labelAfflictionDisplay.Name = "labelAfflictionDisplay";
			this.labelAfflictionDisplay.Size = new System.Drawing.Size(100, 23);
			this.labelAfflictionDisplay.TabIndex = 18;
			this.labelAfflictionDisplay.Text = "randAffliction";
			this.labelAfflictionDisplay.MouseLeave += new System.EventHandler(this.LabelAfflictionDisplayMouseLeave);
			this.labelAfflictionDisplay.MouseHover += new System.EventHandler(this.LabelAfflictionDisplayMouseHover);
			// 
			// labelAffliction
			// 
			this.labelAffliction.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.labelAffliction.Location = new System.Drawing.Point(6, 450);
			this.labelAffliction.Name = "labelAffliction";
			this.labelAffliction.Size = new System.Drawing.Size(56, 23);
			this.labelAffliction.TabIndex = 17;
			this.labelAffliction.Text = "Affliction: ";
			this.labelAffliction.MouseLeave += new System.EventHandler(this.LabelAfflictionMouseLeave);
			this.labelAffliction.MouseHover += new System.EventHandler(this.LabelAfflictionMouseHover);
			// 
			// listWeapons
			// 
			this.listWeapons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
			this.listWeapons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listWeapons.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.listWeapons.FormattingEnabled = true;
			this.listWeapons.Items.AddRange(new object[] {
									"weaponSet1"});
			this.listWeapons.Location = new System.Drawing.Point(74, 114);
			this.listWeapons.Name = "listWeapons";
			this.listWeapons.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.listWeapons.Size = new System.Drawing.Size(159, 184);
			this.listWeapons.TabIndex = 16;
			this.listWeapons.TabStop = false;
			this.listWeapons.MouseEnter += new System.EventHandler(this.listWeapons_MouseEnter);
			this.listWeapons.MouseLeave += new System.EventHandler(this.listWeapons_MouseLeave);
			// 
			// listArmorType
			// 
			this.listArmorType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
			this.listArmorType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listArmorType.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.listArmorType.FormattingEnabled = true;
			this.listArmorType.Items.AddRange(new object[] {
									"armorSet1",
									"armorSet2"});
			this.listArmorType.Location = new System.Drawing.Point(74, 80);
			this.listArmorType.Name = "listArmorType";
			this.listArmorType.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.listArmorType.Size = new System.Drawing.Size(159, 28);
			this.listArmorType.TabIndex = 15;
			this.listArmorType.TabStop = false;
			this.listArmorType.MouseEnter += new System.EventHandler(this.listArmorType_MouseEnter);
			this.listArmorType.MouseLeave += new System.EventHandler(this.listArmorType_MouseLeave);
			// 
			// labelPrimarySkillDisplay
			// 
			this.labelPrimarySkillDisplay.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.labelPrimarySkillDisplay.Location = new System.Drawing.Point(74, 50);
			this.labelPrimarySkillDisplay.Name = "labelPrimarySkillDisplay";
			this.labelPrimarySkillDisplay.Size = new System.Drawing.Size(100, 19);
			this.labelPrimarySkillDisplay.TabIndex = 11;
			this.labelPrimarySkillDisplay.Text = "randomSkill";
			this.labelPrimarySkillDisplay.MouseEnter += new System.EventHandler(this.labelPrimarySkillDisplay_MouseEnter);
			this.labelPrimarySkillDisplay.MouseLeave += new System.EventHandler(this.labelPrimarySkillDisplay_MouseLeave);
			// 
			// labelStyleDisplay
			// 
			this.labelStyleDisplay.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.labelStyleDisplay.Location = new System.Drawing.Point(42, 33);
			this.labelStyleDisplay.Name = "labelStyleDisplay";
			this.labelStyleDisplay.Size = new System.Drawing.Size(100, 17);
			this.labelStyleDisplay.TabIndex = 11;
			this.labelStyleDisplay.Text = "randomStyle";
			this.labelStyleDisplay.MouseEnter += new System.EventHandler(this.labelStyleDisplay_MouseEnter);
			this.labelStyleDisplay.MouseLeave += new System.EventHandler(this.labelStyleDisplay_MouseLeave);
			// 
			// labelRaceDisplay
			// 
			this.labelRaceDisplay.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.labelRaceDisplay.Location = new System.Drawing.Point(42, 18);
			this.labelRaceDisplay.Name = "labelRaceDisplay";
			this.labelRaceDisplay.Size = new System.Drawing.Size(100, 15);
			this.labelRaceDisplay.TabIndex = 10;
			this.labelRaceDisplay.Text = "randomRace";
			this.labelRaceDisplay.MouseEnter += new System.EventHandler(this.labelRaceDisplay_MouseEnter);
			this.labelRaceDisplay.MouseLeave += new System.EventHandler(this.labelRaceDisplay_MouseLeave);
			// 
			// mainMenu
			// 
			this.mainMenu.BackColor = System.Drawing.Color.Transparent;
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.mainMenu.Size = new System.Drawing.Size(474, 24);
			this.mainMenu.TabIndex = 3;
			this.mainMenu.TabStop = true;
			this.mainMenu.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.generateCharacterToolStripMenuItem,
									this.copyToClipboardToolStripMenuItem,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// generateCharacterToolStripMenuItem
			// 
			this.generateCharacterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
			this.generateCharacterToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.generateCharacterToolStripMenuItem.Name = "generateCharacterToolStripMenuItem";
			this.generateCharacterToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.generateCharacterToolStripMenuItem.Text = "Generate Character";
			this.generateCharacterToolStripMenuItem.Click += new System.EventHandler(this.generateCharacterToolStripMenuItem_Click);
			// 
			// copyToClipboardToolStripMenuItem
			// 
			this.copyToClipboardToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
			this.copyToClipboardToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
			this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.copyToClipboardToolStripMenuItem.Text = "Copy to Clipboard";
			this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.CopyToClipboardToolStripMenuItemClick);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
			this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// groupInfo
			// 
			this.groupInfo.BackColor = System.Drawing.Color.Transparent;
			this.groupInfo.Controls.Add(this.labelHoverInfo);
			this.groupInfo.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.groupInfo.Location = new System.Drawing.Point(261, 27);
			this.groupInfo.Name = "groupInfo";
			this.groupInfo.Size = new System.Drawing.Size(200, 298);
			this.groupInfo.TabIndex = 12;
			this.groupInfo.TabStop = false;
			this.groupInfo.Text = "Info";
			// 
			// labelHoverInfo
			// 
			this.labelHoverInfo.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.labelHoverInfo.Location = new System.Drawing.Point(6, 16);
			this.labelHoverInfo.Name = "labelHoverInfo";
			this.labelHoverInfo.Size = new System.Drawing.Size(188, 232);
			this.labelHoverInfo.TabIndex = 0;
			this.labelHoverInfo.Text = "Hover Info goes here";
			this.labelHoverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// imageSkyrim
			// 
			this.imageSkyrim.BackColor = System.Drawing.Color.Transparent;
			this.imageSkyrim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageSkyrim.BackgroundImage")));
			this.imageSkyrim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.imageSkyrim.Location = new System.Drawing.Point(261, 373);
			this.imageSkyrim.Name = "imageSkyrim";
			this.imageSkyrim.Size = new System.Drawing.Size(200, 140);
			this.imageSkyrim.TabIndex = 13;
			this.imageSkyrim.MouseEnter += new System.EventHandler(this.imageSkyrim_MouseEnter);
			this.imageSkyrim.MouseLeave += new System.EventHandler(this.imageSkyrim_MouseLeave);
			// 
			// buttonCopyClipboard
			// 
			this.buttonCopyClipboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCopyClipboard.BackgroundImage")));
			this.buttonCopyClipboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonCopyClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCopyClipboard.Location = new System.Drawing.Point(404, 332);
			this.buttonCopyClipboard.Name = "buttonCopyClipboard";
			this.buttonCopyClipboard.Size = new System.Drawing.Size(44, 32);
			this.buttonCopyClipboard.TabIndex = 1;
			this.captionCopyButton.SetToolTip(this.buttonCopyClipboard, "Copy to clipboard. ");
			this.buttonCopyClipboard.UseVisualStyleBackColor = true;
			this.buttonCopyClipboard.Click += new System.EventHandler(this.ButtonCopyClipboardClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(474, 525);
			this.Controls.Add(this.buttonCopyClipboard);
			this.Controls.Add(this.groupInfo);
			this.Controls.Add(this.buttonGenerate);
			this.Controls.Add(this.groupChar);
			this.Controls.Add(this.mainMenu);
			this.Controls.Add(this.imageSkyrim);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mainMenu;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Radiant Character Generator";
			this.groupChar.ResumeLayout(false);
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.groupInfo.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.Label labelAffliction;
		private System.Windows.Forms.Label labelAfflictionDisplay;
		private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
		private System.Windows.Forms.ToolTip captionCopyButton;
		private System.Windows.Forms.Button buttonCopyClipboard;
		private System.Windows.Forms.Panel imageSkyrim;
		private System.Windows.Forms.Label labelHoverInfo;
        private System.Windows.Forms.GroupBox groupInfo;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.Label labelRaceDisplay;
        private System.Windows.Forms.Label labelStyleDisplay;
        private System.Windows.Forms.Label labelPrimarySkillDisplay;
		private System.Windows.Forms.GroupBox groupChar;
		private System.Windows.Forms.ListBox listSkills;
		private System.Windows.Forms.Label labelSkillList;
		private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelWeapon;
		private System.Windows.Forms.Label labelPrimarySkill;
		private System.Windows.Forms.Label labelArmorType;
		private System.Windows.Forms.Label labelStyle;
		private System.Windows.Forms.Label labelRace;
        private System.Windows.Forms.ListBox listArmorType;
        private System.Windows.Forms.ListBox listWeapons;
        private System.Windows.Forms.ToolStripMenuItem generateCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}
