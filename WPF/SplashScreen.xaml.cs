using System.Windows;

namespace WPF
{
	public partial class SplashScreen : Window
	{
		public SplashScreen()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			var login = new LoginScreen(this);
			login.Show();
		}
	}
}