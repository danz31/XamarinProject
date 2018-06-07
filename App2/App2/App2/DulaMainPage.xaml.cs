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
	public partial class DulaMainPage : ContentPage
	{
		public DulaMainPage ()
		{
			InitializeComponent ();
		}

	    private async void NavigateToDulaCalander(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new DulaCalendar());
	    }
	}
}