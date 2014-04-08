/*
 * Created by SharpDevelop.
 * User: cbennet
 * Date: 5/6/2013
 * Time: 12:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RadiantCharacterGenerator
{
	partial class AboutScreen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutScreen));
			this.lableTitle = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.labelCopyright = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lableTitle
			// 
			this.lableTitle.BackColor = System.Drawing.Color.Transparent;
			this.lableTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.lableTitle.Location = new System.Drawing.Point(56, 30);
			this.lableTitle.Name = "lableTitle";
			this.lableTitle.Size = new System.Drawing.Size(177, 20);
			this.lableTitle.TabIndex = 1;
			this.lableTitle.Text = "Skyrim Radiant Character Generator";
			// 
			// labelVersion
			// 
			this.labelVersion.BackColor = System.Drawing.Color.Transparent;
			this.labelVersion.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.labelVersion.Location = new System.Drawing.Point(68, 50);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(163, 19);
			this.labelVersion.TabIndex = 2;
			this.labelVersion.Text = "v1.2.0";
			this.labelVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelCopyright
			// 
			this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
			this.labelCopyright.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.labelCopyright.Location = new System.Drawing.Point(68, 96);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(163, 18);
			this.labelCopyright.TabIndex = 3;
			this.labelCopyright.Text = "© 2013 Adam A. and Chase B.";
			// 
			// AboutScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(289, 136);
			this.Controls.Add(this.labelCopyright);
			this.Controls.Add(this.labelVersion);
			this.Controls.Add(this.lableTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label labelCopyright;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.Label lableTitle;
	}
}
