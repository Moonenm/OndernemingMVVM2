namespace OndernemingMVVM2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Voorbeeld),typeof(Voorbeeld));
            Routing.RegisterRoute(nameof(WerknemerDetails),typeof(WerknemerDetails));
            Routing.RegisterRoute(nameof(DetailMoviePage),typeof(DetailMoviePage));
        }
    }
}
