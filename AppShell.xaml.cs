namespace HotBackReservationSystem;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(ReservationPage), typeof(ReservationPage));
        Routing.RegisterRoute(nameof(TimeReservationPage), typeof(TimeReservationPage));
        Routing.RegisterRoute(nameof(ReservationSuccessPage), typeof(ReservationSuccessPage));
    }
}
