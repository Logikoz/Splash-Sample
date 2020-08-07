using System.Windows;

namespace WPF
{
	public partial class LoginScreen : Window
	{
		public LoginScreen(SplashScreen splash)
		{
			InitializeComponent();
			splash.Close();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrEmpty(emailField.Text) || string.IsNullOrEmpty(passwordField.Password))
			{
				MessageBox.Show("Voce precisa preencher ambos os campos!");
				return;
			}

			MessageBox.Show($"{emailField.Text} voce logou com sucesso!");
		}
	}
}