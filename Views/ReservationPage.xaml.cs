namespace HotBackReservationSystem;
using Microsoft.Maui.Controls; // for Label
using Microsoft.Maui.Layouts;

public partial class ReservationPage : ContentPage
{
	public ReservationPage()
	{
		InitializeComponent();
        DataTNow();
        DisplayDaysOfMonth();

    }

    public void DataTNow()
    {

        DateTime currentDateTime = DateTime.Now;
        string formattedDateTime = currentDateTime.ToString(); 

        myLabel.Text = formattedDateTime;
    }

    public void DisplayDaysOfMonth()
    {
        DateTime currentDate = DateTime.Now;
        int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

        FlexLayout lineLayout = null; // Initialize a FlexLayout to hold the buttons for each line

        for (int day = 1; day <= daysInMonth; day++)
        {
            if (day % 7 == 1) // Start a new line after every 7 days
            {
                lineLayout = new FlexLayout
                {
                    Direction = FlexDirection.Row,
                    JustifyContent = (day <= daysInMonth - 3) ? FlexJustify.End : FlexJustify.Start,
                    Margin = new Thickness(0, 10, 0, 0) // Add margin for spacing after line creation
                };

                myCalednarLayout.Children.Add(lineLayout); // Add the lineLayout to myCalednarLayout
            }

            Button dayButton = new Button
            {
                Text = day.ToString(),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 80,
                HeightRequest = 80,
                CornerRadius = 40 // Set the corner radius to half the width/height
            };

            lineLayout.Children.Add(dayButton); // Add each dayButton to the lineLayout
        }
    }




    private async void GoToTimeReservationPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TimeReservationPage));

    }

}

