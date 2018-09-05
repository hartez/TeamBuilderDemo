using System.Reflection;
using Xamarin.Forms;

namespace TeamBuilderDemo
{
    public class SpaceViewModel
    {
        public SpaceViewModel(string name, string cost, string reviewCount, string rating, string imageName)
        {
            Name = name;
            Cost = cost;
            ReviewCount = reviewCount;
            Rating = rating;
            ImageName = imageName;
        }

        public string Name { get; }
        public string Cost { get; }
        public string ReviewCount { get; }
        public string Rating { get; }

        public string ImageName { get; }

        public ImageSource ImageSource => Xamarin.Forms.ImageSource.FromResource($"TeamBuilderDemo.Images.{ImageName.ToLower()}.jpg",
            typeof(ProfessionalViewModel).GetTypeInfo().Assembly);
    }
}