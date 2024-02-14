namespace AplicativoMAUI
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            string endereco = @"<iframe width=""560"" height=""315"" src=""https://www.youtube.com/embed/_QmyeFfiZaU?si=f0NRafxZ0QxO8r8Q"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"" allowfullscreen></iframe>";
            WVVideo.Source = new HtmlWebViewSource
            {
                Html = endereco
            };
        }
        private async void BTNOla_Clicked(object sender, EventArgs e)
        {
            string nomeUsuario = await DisplayPromptAsync("Nome", "Digite seu nome:", "Ok");
            string idadeUsuario = await DisplayPromptAsync("Sua Idade", "Digite sua idade: ", "Ok");
            await DisplayAlert("ALERTA", "Olá " + nomeUsuario + "!" +
                "\nVocê tem " + idadeUsuario + " anos e " +
                "está vendo essa notificação às: \n" + DateTime.Now.ToString(), "Fechar");
        }
    }
}
