using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using SerieTaylor.Core.ViewModels;

namespace SerieTaylor.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class TipView : MvxActivity<SerieTaylorViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SerieTaylorPage);
        }
    }
}