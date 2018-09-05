using System.Reflection;
using Xamarin.Forms;

namespace TeamBuilderDemo
{
    public class ProfessionalViewModel 
    {
        public ProfessionalViewModel(string name, string title, string location, string rate, string successRate, string totalEarned)
        {
            Name = name;
            Title = title;
            Location = location;
            Rate = rate;
            SuccessRate = successRate;
            TotalEarned = totalEarned;
        }

        public string Name { get; }

        public string Title { get; }
        
        public string Location { get; }

        public string Rate { get; }

        public string SuccessRate { get; }

        public string TotalEarned { get; }

        public ImageSource ImageSource => Xamarin.Forms.ImageSource.FromResource($"TeamBuilderDemo.Images.{Name.ToLower()}.jpg",
            typeof(ProfessionalViewModel).GetTypeInfo().Assembly);
    }
}