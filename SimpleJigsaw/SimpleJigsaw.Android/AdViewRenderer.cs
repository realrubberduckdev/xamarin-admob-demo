using Android.Content;
using Android.Gms.Ads;
using SimpleJigsaw;
using SimpleJigsaw.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

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
                e.NewElement.HeightRequest = GetSmartBannerDpHeight();

                SetNativeControl(ad);
            }
        }

        private int GetSmartBannerDpHeight()
        {
            var dpHeight = Resources.DisplayMetrics.HeightPixels / Resources.DisplayMetrics.Density;

            if (dpHeight <= 400) return 32;
            if (dpHeight > 400 && dpHeight <= 720) return 50;
            return 90;
        }
    }
}