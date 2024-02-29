namespace OndernemingMVVM2.Views;

public partial class MoviePage : ContentPage
{
	public MoviePage(ApiViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}