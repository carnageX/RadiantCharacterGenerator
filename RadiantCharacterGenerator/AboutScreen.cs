using System;
using System.Drawing;
using System.Windows.Forms;

namespace RadiantCharacterGenerator
{
	/// <summary>
	/// Description of AboutScreen.
	/// </summary>
	public partial class AboutScreen : Form
	{
		public AboutScreen()
		{
			InitializeComponent();
			this.labelVersion.Text = "v" + typeof(Program).Assembly.GetName().Version.ToString();
		}
	}
}
