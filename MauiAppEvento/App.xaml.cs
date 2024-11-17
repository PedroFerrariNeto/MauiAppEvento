using MauiAppEvento.Models;

namespace MauiAppEvento
{
    public partial class App : Application
    {
       /* public List<Evento> lista_evento = new List<Evento>
        {
            new Evento()
            {
                Descricao = "Festival de Churrasco",
                Local = "Recinto de exposição",
                ValorEvento = 100.0
            },
            new Evento()
            {
                Descricao = "Festival de Musicas",
                Local = "Bar do seu João",
                ValorEvento = 50.0
            },
            new Evento()
            {
                Descricao = "Rock in Rio",
                Local = "Cidade do Rock",
                ValorEvento = 500.0
            },
        };*/

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoEvento());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 650;

            return window;
        }
    }
}
