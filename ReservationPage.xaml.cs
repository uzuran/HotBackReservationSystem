namespace HotBackReservationSystem;

public partial class ReservationPage : ContentPage
{
	public ReservationPage()
	{
		InitializeComponent();
	}

    private async void GoToTimeReservationPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TimeReservationPage));

    }
}