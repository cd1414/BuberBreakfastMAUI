using BuberBreakfast.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BuberBreakfast.ViewModel
{
    public partial class MyBreakfastViewModel
        : ObservableObject
    {
        [ObservableProperty]
        List<Breakfast> breakfasts;

        public MyBreakfastViewModel()
        {
            LoadBreakfasts();
        }

        private void LoadBreakfasts()
        {
            Breakfasts = new()
            {
                new Breakfast(
                    Name: "Vegan Sunshine",
                    Description: "Vegan everything",
                    StartDateTime: DateTime.Now.AddDays(1),
                    EndDataTime: DateTime.Now.AddDays(1).AddHours(2),
                    Image: new Uri(""),
                    Savory: new List<string> { "Oatmeal", "Avocado Toas"},
                    Sweet: new List<string> { "Cookie"}
                    ;
        }
    }
}

