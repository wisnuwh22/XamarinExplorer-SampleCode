using Android.Support.V7.Widget;
using samplecode.Droid.CustomRenderers;
using samplecode.GridMenu;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CoolContentPage), typeof(CoolContentPageRenderer))]
namespace samplecode.Droid.CustomRenderers
{
    public class CoolContentPageRenderer : PageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);

            if (((CoolContentPage)Element).EnableBackButtonOverride)
            {
                SetCustomBackButton();
            }
        }
        private void SetCustomBackButton()
        {
            //accessing toolbar from MainActivity
            var toolbar = (Toolbar)MainActivity.RootFindViewById<Toolbar>(Resource.Id.toolbar);

            // set Android Logo's image
            //toolbar.SetLogo(Resource.Drawable.AndroidBackButton);
            toolbar.SetLogo(Resource.Drawable.back);

            for (int i = 0; i < toolbar.ChildCount; i++)
            {
                var item = toolbar.GetChildAt(i);

                //if Android Logo
                if (item.GetType() == typeof(AppCompatImageView))
                {
                    AppCompatImageView image = (AppCompatImageView)item;

                    image.Click += (sender, e) =>
                    {
                        if (((CoolContentPage)Element)?.CustomBackButtonAction != null)
                        {
                            ((CoolContentPage)Element)?.CustomBackButtonAction.Invoke();
                        }
                    };
                }
            }
        }
    }
}
