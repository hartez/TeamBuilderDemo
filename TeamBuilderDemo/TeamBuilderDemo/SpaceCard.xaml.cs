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
	public partial class SpaceCard : ContentView
	{
		public SpaceCard ()
		{
			InitializeComponent ();
		}
	}
}