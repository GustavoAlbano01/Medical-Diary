using MedicalDiary.Controllers;

namespace MedicalDiary.Views;

public partial class LoginPage : ContentPage
{
	UsuarioController controller = new UsuarioController();

	public LoginPage()
	{
		InitializeComponent();
	}

	private async void Entrar_Clicked(object sender, EventArgs e)
	{
		try
		{
			bool ok = controller.Login(
				txtEmail.Text,
				txtSenha.Text
			);

			if (ok)
			{
                await Navigation.PushAsync(new MenuPage());
			}
			else
			{
				lblErro.Text = "Usuário inválido";
			}
		}
		catch (Exception ex)
		{
			lblErro.Text = ex.Message;
		}
	}
}