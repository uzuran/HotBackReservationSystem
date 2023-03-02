namespace HotBackReservationSystem;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(ReservationPage), typeof(ReservationPage));
    }
}
