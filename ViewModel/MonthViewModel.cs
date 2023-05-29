using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class MonthViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    private ObservableCollection<DayModel> _daysOfMonth;
    public ObservableCollection<DayModel> DaysOfMonth
    {
        get { return _daysOfMonth; }
        set
        {
            if (_daysOfMonth != value)
            {
                _daysOfMonth = value;
                OnPropertyChanged();
            }
        }
    }

    public void LoadDaysOfMonth()
    {
        DateTime currentDate = DateTime.Now;
        int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

        DaysOfMonth = new ObservableCollection<DayModel>();

        for (int day = 1; day <= daysInMonth; day++)
        {
            DaysOfMonth.Add(new DayModel { Day = day });
        }
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
