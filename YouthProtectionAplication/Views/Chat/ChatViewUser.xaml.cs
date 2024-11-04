using CommunityToolkit.Maui.Views;
using YouthProtectionAplication.Services;
using YouthProtectionAplication.Services.Chat;
using YouthProtectionAplication.ViewModels.Chat;

namespace YouthProtectionAplication.Views.Chat;

public partial class ChatViewUser : ContentPage
{
	ChatUserViewModel chatViewModel;
	public ChatViewUser(Models.Postagem postagem)
	{
        chatViewModel = new ChatUserViewModel(postagem);
		BindingContext = chatViewModel;
        InitializeComponent();
    }


    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        
            if (await Application.Current.MainPage
                  .DisplayAlert("Confirma��o", "Deseja realmente sair? As altera��es n�o ser�o feitas", "Sim", "N�o"))
            {
                Application.Current.MainPage = new AppShell();
            }
    }
}