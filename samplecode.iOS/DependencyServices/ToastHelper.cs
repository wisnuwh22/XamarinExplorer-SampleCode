using samplecode.Interfaces;
using samplecode.iOS.DependencyServices;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(ToastHelper))]
namespace samplecode.iOS.DependencyServices
{
    public class ToastHelper : IToast
    {
        public void Show(string message)
        {
            UIAlertView alert = new UIAlertView()
            {
                Message = message
            };
            alert.AddButton("OK");
            alert.Show();
        }
    }
}
