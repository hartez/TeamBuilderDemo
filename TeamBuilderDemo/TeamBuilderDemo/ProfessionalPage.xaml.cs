using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeamBuilderDemo
{
    public partial class ProfessionalPage : ContentPage
    {
        public ProfessionalPage()
        {
            InitializeComponent();

            var items = new List<ProfessionalViewModel>
            {
                new ProfessionalViewModel("Doug", "Graphic Designer", "Seattle, WA", "$35", "85%", "$330k+"),
                new ProfessionalViewModel("Robert", "Project Manager", "Palo Alto, CA", "$42", "98%", "$440k+"),
                new ProfessionalViewModel("Angela", "Android Developer", "Punxsutawney, PA", "$99", "101%", "$620k+"),

                new ProfessionalViewModel("Phil", "Graphic Designer", "Chula Vista, CA", "$35", "87%", "$560k+"),
                new ProfessionalViewModel("Lisa", "COBOL Guru", "Atlanta, GA", "$400", "100%", "$840k+"),
                new ProfessionalViewModel("Bart", "iOS Developer", "Corpus Christi, TX", "$99", "100%", "$620k+"),

                new ProfessionalViewModel("Hermes", "UWP Developer", "Santa Ana, CA", "$35", "89%", "$310k+"),
                new ProfessionalViewModel("Hubert", "WPF Developer", "Raleigh, NC", "$42", "98%", "$220k+"),
                new ProfessionalViewModel("Chuck", "Silverlight Developer", "Cleveland, OH", "$99", "101%", "$340k+"),

                new ProfessionalViewModel("Ansel", "WinForms Developer", "Laredo, TX", "$85", "83%", "$330k+"),
                new ProfessionalViewModel("Roberta", "Visual FoxPro Dev", "St. Petersburg, FL", "$42", "98%", "$420k+"),
                new ProfessionalViewModel("Napoleon", "GW-BASIC Dev", "Reno, NV", "$99", "98%", "$620k+"),

                new ProfessionalViewModel("Bill", "SQL Server DBA", "Oklahoma City, OK", "$35", "80%", "$230k+"),
                new ProfessionalViewModel("Sydney", "Serial Entrepreneur", "Arlington, VA", "$42", "98%", "$322k+"),
                new ProfessionalViewModel("Victor", "MUMPS Dev", "Scottsdale, AZ", "$99", "101%", "$985k+"),

                new ProfessionalViewModel("Melissa", "Haskell Evangelist", "Columbus, OH", "$35", "85%", "$320k+"),
                new ProfessionalViewModel("Caity", "Scheme Programmer", "Memphis, TN", "$42", "100%", "$125k+"),
                new ProfessionalViewModel("Harper", "FORTRAN Developer", "Anaheim, CA", "$99", "100%", "$764k+"),
            };

            CarouselView.ItemsSource = items;
            CarouselView.ItemTemplate = new DataTemplate(() => new Card());
        }
    }
}
