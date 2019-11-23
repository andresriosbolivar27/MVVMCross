using Android.App;
using Android.OS;
using QuadraticEquations.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace QuadraticEquations.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class QuadraticEcuationView : MvxActivity<QuadraticEcuationsViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.QuadraticEcuationsPage);
        }
    }
}