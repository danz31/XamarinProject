using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml.Internals;
using Syncfusion.SfCalendar.XForms;

namespace App2
{
	public partial class MainPage : ContentPage
	{
        
		public MainPage()
		{
			InitializeComponent();
		}

		private async void ServiceButton_OnClicked(object sender, EventArgs e)
		{
		   string service = await DisplayActionSheet("Select a Service", "Cancel", null, "Personal Training", "Massage", "Dula", "Gift Certificates and Packages");


			switch (service)
			{
				case "Personal Training":
				    await Navigation.PushAsync(new PTMainPage());
					break;
				case "Massage":
				    await Navigation.PushAsync(new MassageMainPage());
					break;
				case "Dula":
				    await Navigation.PushAsync(new DulaMainPage());
					break;
				case "Gift Certificates":
				    await Navigation.PushAsync(new GiftCertificatesPage());
					break;

			}
		}
	}
}
