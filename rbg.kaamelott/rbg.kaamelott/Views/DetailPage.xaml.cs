using rbg.kaamelott.Models;
using rbg.kaamelott.ViewModels;
using Xamarin.Forms;

namespace rbg.kaamelott.Views
{
	public partial class DetailPage : ContentPage
	{
		public DetailPage (Sample sample)
		{
			InitializeComponent ();
            BindingContext = new DetailPageViewModel(Navigation, sample);
		}
	}
}