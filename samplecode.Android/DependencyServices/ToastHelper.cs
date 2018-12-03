using Android.Widget;
using samplecode.Droid.DependencyServices;
using samplecode.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(ToastHelper))]
namespace samplecode.Droid.DependencyServices
{
    public class ToastHelper : IToast
    {
        public void Show(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long).Show();
        }
    }
}
