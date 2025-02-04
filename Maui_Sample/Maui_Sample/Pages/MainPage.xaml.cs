using Maui_Sample.Models;
using Maui_Sample.PageModels;

namespace Maui_Sample.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}