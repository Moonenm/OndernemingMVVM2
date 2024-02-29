namespace OndernemingMVVM2.Views;

public partial class DetailMoviePage : ContentPage
{
	public DetailMoviePage(DetailMoviePageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}