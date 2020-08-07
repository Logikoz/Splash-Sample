using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
	public partial class LoginScreen : Form
	{
		public LoginScreen()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (string.IsNullOrEmpty(emailField.Text) || string.IsNullOrEmpty(passwordField.Text))
			{
				MessageBox.Show("Voce precisa preencher ambos os campos!");
				return;
			}

			MessageBox.Show($"{emailField.Text} voce logou com sucesso!");
		}
	}
}