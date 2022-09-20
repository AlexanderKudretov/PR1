namespace MauiApp1;

public partial class DetailPage : ContentPage
{
	public DetailPage(DatailViewModel datailViewModel)
	{
		InitializeComponent();
		BindingContext = datailViewModel;
	}
}