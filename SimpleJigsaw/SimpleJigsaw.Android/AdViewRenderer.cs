using Android.Widget;
using Android.Gms.Ads;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using SimpleJigsaw;
using SimpleJigsaw.Droid;
using Android.Content;

[assembly: ExportRenderer(typeof(AdControlView), typeof(AdViewRenderer))]
namespace SimpleJigsaw.Droid
{
    class AdViewRenderer : ViewRenderer
    {
        private Context _context;

        public AdViewRenderer(Context context) : base(context)
        {
            _context = context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                var ad = new AdView(_context);
                ad.AdSize = AdSize.SmartBanner;
                ad.AdUnitId = SimpleJigsawConstants.adMobBannerUnitId;
                var requestbuilder = new AdRequest.Builder();
                ad.LoadAd(requestbuilder.Build());

                SetNativeControl(ad);
            }
        }
    }
}