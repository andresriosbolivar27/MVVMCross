using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using SerieTaylorModified.Core.ViewModels;

namespace SerieTaylorModified.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class TipView : MvxActivity<SerieTaylorModifiedViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SerieTaylorModifiedPage);
        }
    }
}