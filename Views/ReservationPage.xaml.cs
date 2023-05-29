namespace HotBackReservationSystem;
using Microsoft.Maui.Controls; // for Label


public partial class ReservationPage : ContentPage
{
    public MonthViewModel ViewModel { get; }
    public ReservationPage()
	{
		InitializeComponent();
        SetCurrentDate();
        ViewModel = new MonthViewModel();
        BindingContext = ViewModel;

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ViewModel.LoadDaysOfMonth();
    }

    private void DaySelectedCommandExecute(object parameter)
    {
        // Handle the button click event for a specific day
        // The selected day can be accessed through the 'parameter' parameter
    }

    private void SetCurrentDate()
    {
        DateTime currentDate = DateTime.Today;
        string formattedDate = currentDate.ToString("MMMM");
        DateLabel.Text = formattedDate;
    }






    private async void GoToTimeReservationPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TimeReservationPage));

    }

}

