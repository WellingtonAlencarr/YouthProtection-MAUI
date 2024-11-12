using YouthProtectionAplication.ViewModels.Diario;

namespace YouthProtectionAplication.Views.Diario;

public partial class DiarioEditPostUser : ContentPage
{

	DiarioEdicaoViewModel diarioEdicaoViewModel;
	public DiarioEditPostUser(Models.Postagem postagem)
	{
        diarioEdicaoViewModel = new DiarioEdicaoViewModel(postagem);
        InitializeComponent();
		BindingContext = diarioEdicaoViewModel;

    }

    private async void btnCancelar_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (await Application.Current.MainPage
                  .DisplayAlert("Confirma��o", "Deseja realmente sair? As altera��es n�o ser�o feitas", "Sim", "N�o"))
            {
                Application.Current.MainPage = new AppShell(Preferences.Get("UsuarioRole", 0));
            }
        }
        catch
        {

        }

    }
}
