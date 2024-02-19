namespace OndernemingMVVM2.Views;

public partial class Voorbeeld : ContentPage
{
	public Voorbeeld(VoorbeeldViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}