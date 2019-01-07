using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using FFImageLoading.Forms.Platform;
using samplecode.GridMenu;
using System.Linq;
using Android.Content;

namespace samplecode.Droid
{
    [Activity(Label = "samplecode", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            CachedImageRenderer.Init(true);
            LoadApplication(new App());
        }

        private static MainActivity _this;

        public static View RootFindViewById<T>(int id) where T : View
        {
            return _this.FindViewById<T>(id);
        }

        public MainActivity()
        {
            _this = this;

        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            // check if the current item id 
            // is equals to the back button id
            if (item.ItemId == 16908332)
            {
                // retrieve the current xamarin forms page instance
                var currentpage =
                    (CoolContentPage)Xamarin.Forms.Application.Current.MainPage.Navigation.NavigationStack.LastOrDefault();

                // check if the page has subscribed to 
                // the custom back button event
                if (currentpage?.CustomBackButtonAction != null)
                {
                    // invoke the Custom back button action
                    currentpage?.CustomBackButtonAction.Invoke();
                    // and disable the default back button action
                    return false;
                }

                // if its not subscribed then go ahead 
                // with the default back button action
                return base.OnOptionsItemSelected(item);
            }
            else
            {
                // since its not the back button 
                //click, pass the event to the base
                return base.OnOptionsItemSelected(item);
            }
        }

        public override void OnBackPressed()
        {
            // this is not necessary, but in Android user 
            // has both Nav bar back button and
            // physical back button its safe 
            // to cover the both events

            try
            {
                // retrieve the current xamarin forms page instance
                var currentpage =
                       (CoolContentPage)Xamarin.Forms.Application.Current.MainPage.Navigation.NavigationStack.LastOrDefault();

                // check if the page has subscribed to 
                // the custom back button event
                if (currentpage?.CustomBackButtonAction != null)
                {
                    currentpage?.CustomBackButtonAction.Invoke();
                }
                else
                {
                    base.OnBackPressed();
                }
            }
            catch (Exception)
            {
                base.OnBackPressed();
            }

        }
    }
}

