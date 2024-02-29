namespace OndernemingMVVM2.Views;

public partial class IpAdresPage : ContentPage
{
	public IpAdresPage(ApiViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;	
	}
}