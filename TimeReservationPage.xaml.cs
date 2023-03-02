namespace HotBackReservationSystem;

public partial class TimeReservationPage : ContentPage
{
	public TimeReservationPage()
	{
		InitializeComponent();
	}


    private async void GoToReservationSuccessPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ReservationSuccessPage));

    }


}
