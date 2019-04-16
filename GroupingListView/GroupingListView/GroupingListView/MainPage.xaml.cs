using GroupingListView.ViewModels;
using Xamarin.Forms;

namespace GroupingListView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ((MainPageViewModel)BindingContext).LoadPersonGroupsCommand.Execute(null);
        }
    }
}
