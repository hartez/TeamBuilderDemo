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
	public partial class SpacePage : ContentPage
	{
		public SpacePage ()
		{
			InitializeComponent ();

            var items = new List<SpaceViewModel>
            {
                new SpaceViewModel("Regis Workspaces", "$339/mo", "187", "4.9", "space0"),
                new SpaceViewModel("Cowork Revolution", "$12,885/yr", "245", "3.5", "space1"),
                new SpaceViewModel("Spaces", "$125/mo", "88", "4.8", "space2"),
                new SpaceViewModel("MakerWorks", "$675/mo", "73", "4.3", "space3"),
                new SpaceViewModel("Cubes For Days", "$876/mo", "532", "4.3", "space4"),
                new SpaceViewModel("WorkSmart", "$224/mo", "4", "4.2", "space5"),
                new SpaceViewModel("Lofty Goals", "$345/mo", "234", "5.0", "space6"),
                new SpaceViewModel("Third Shift Office Rentals", "$675/mo", "97", "2.8", "space7"),
                new SpaceViewModel("Work In Progress", "$890/mo", "56", "3.9", "space8"),
                new SpaceViewModel("Desk & Outlet", "$1,200/mo", "87", "3.7", "space9"),
                new SpaceViewModel("Millennium Coworking", "$1,450/mo", "65", "2.8", "space10"),
                new SpaceViewModel("Bob's Discount Office Space", "$999/mo", "123", "1.6", "space11"),
                new SpaceViewModel("Le Studio", "$1,000/mo", "9", "5.0", "space12"),
                new SpaceViewModel("Maker Camp", "$1,850/mo", "45", "4.7", "space13"),
                new SpaceViewModel("The Forge", "$1,300/mo", "25", "5.0", "space14"),
                new SpaceViewModel("Digital ArtHub", "$2,000/mo", "125", "4.8", "space15"),
            };

            Spaces.ItemsLayout = new GridItemsLayout(2, ItemsLayoutOrientation.Vertical)
            {
                SnapPointsAlignment = SnapPointsAlignment.Start,
                SnapPointsType = SnapPointsType.Mandatory
            };
            

            Spaces.ItemTemplate = new DataTemplate(() => new SpaceCard());
            Spaces.ItemsSource = items;
        }
	}
}