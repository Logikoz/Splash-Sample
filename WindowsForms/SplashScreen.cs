using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsForms
{
	public partial class SplashScreen : Form
	{
		public SplashScreen()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			new Thread(() =>
			{
				LoginScreen login = new LoginScreen();
				login.ShowDialog();
			}).Start();
			Close();
		}
	}
}