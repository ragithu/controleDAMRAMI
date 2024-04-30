namespace controleDAMRAMI;

public partial class bravoPage2 : ContentPage
{
	public bravoPage2()
	{
		InitializeComponent();
    }
	if (sisir.Text == "DAM2024") 
{
    this.Navigation.PushAsync(new BravoPage());
     }
 else { DisplayAlert("Error", "Try again...!", "OK"); }
}