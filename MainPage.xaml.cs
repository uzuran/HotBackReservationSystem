namespace HotBackReservationSystem;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();



    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ReservationPage));

    }

}


