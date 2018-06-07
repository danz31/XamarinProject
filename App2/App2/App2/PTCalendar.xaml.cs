using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.SfCalendar.XForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PtCalendar : ContentPage
	{
		public PtCalendar ()
		{
			InitializeComponent();

            DependencyService.Get<ICalendarDirection>().Forward();
            DependencyService.Get<ICalendarDirection>().Backward();

			SfCalendar ptCalendar = new SfCalendar();
		    List<DateTime> blackDates = new List<DateTime>();
		    for (int i = 0; i < 2; i++)
		    { DateTime date = new DateTime(2018, 6, 1 + i);
		     blackDates.Add(date); }
		    ptCalendar.BlackoutDates = blackDates;

            MonthLabelSettings labelSettings = new MonthLabelSettings();
		    labelSettings.DateFormat = "dd";
		    labelSettings.DayLabelSize = 20;
		    labelSettings.DayFormat = "EEE";
		    labelSettings.DateLabelSize = 12;
            MonthViewSettings monthViewSettings = new MonthViewSettings();
            monthViewSettings.CurrentMonthBackgroundColor = Color.AliceBlue;
            monthViewSettings.CurrentMonthTextColor = Color.Black;
            monthViewSettings.PreviousMonthBackgroundColor = Color.Aquamarine;
            monthViewSettings.PreviousMonthTextColor = Color.Black;
            monthViewSettings.DateSelectionColor = Color.Crimson;
            monthViewSettings.SelectedDayTextColor = Color.Black;
		    monthViewSettings.MonthLabelSettings = labelSettings;
		    ptCalendar.MonthViewSettings = monthViewSettings;

            this.Content = ptCalendar;
		}
	}
}