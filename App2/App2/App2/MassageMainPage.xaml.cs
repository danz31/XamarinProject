using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Java.Nio.Channels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MassageMainPage : ContentPage
	{
		public MassageMainPage ()
		{
			InitializeComponent ();
		}

	    private async void NavigateToMassageCalander(object sender, EventArgs e)
	    {
            
	       await Navigation.PushAsync(new MassageCalendar());
	    }
	}
}