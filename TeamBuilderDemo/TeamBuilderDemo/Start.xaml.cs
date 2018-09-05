using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeamBuilderDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Start : ContentPage
	{
		public Start ()
		{
			InitializeComponent ();
		}

        private void ProfessionalsOnClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfessionalPage());
        }

        private void SpacesOnClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpacePage());
        }
    }
}