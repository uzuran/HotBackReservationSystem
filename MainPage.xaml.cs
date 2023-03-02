namespace HotBackReservationSystem;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();



    }

    private async void GoToReservationPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ReservationPage));

    }

}


