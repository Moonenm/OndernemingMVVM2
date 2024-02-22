namespace OndernemingMVVM2.Views;

public partial class WerknemerDetails : ContentPage
{
	public WerknemerDetails(WerknemerDetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}