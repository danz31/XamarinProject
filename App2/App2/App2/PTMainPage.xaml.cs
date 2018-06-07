using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PTMainPage : ContentPage
	{
		public PTMainPage ()
		{
			InitializeComponent ();
		}

	    private async void NavigateToPTCalander(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new PTCalendar());
	    }
	}
}